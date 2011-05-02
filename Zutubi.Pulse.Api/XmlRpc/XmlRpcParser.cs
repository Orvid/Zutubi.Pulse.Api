using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace CookComputing.XmlRpc
{
    /// <summary>
    /// 
    /// </summary>
    public class XmlRpcParser
    {
        static List<string> _xmlRpcMembers = new List<string>();

        static XmlRpcParser()
        {
            _xmlRpcMembers.AddRange(new string[]
        {
          "name",          
          "value",          

        });
        }

        private int _depth = 0;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="rdr"></param>
        /// <returns></returns>
        public IEnumerable<Node> ParseRequest(XmlReader rdr)
        {
            rdr.MoveToContent();
            if (rdr.Name != "methodCall")
                throw new XmlRpcInvalidXmlRpcException(
                  "Request XML not valid XML-RPC - root element not methodCall.");
            int mcDepth = rdr.Depth;
            MoveToChild(rdr, "methodName", true);
            int mnDepth = rdr.Depth;
            string methodName = rdr.ReadElementContentAsString();
            if (methodName == "")
                throw new XmlRpcInvalidXmlRpcException(
                  "Request XML not valid XML-RPC - empty methodName.");
            yield return CreateMethodName(methodName);
            if (MovetoSibling(rdr, "params", false))
            {
                yield return new ParamsNode(_depth);
                int psDepth = rdr.Depth;
                bool gotP = MoveToChild(rdr, "param", false);
                while (gotP)
                {
                    foreach (Node node in ParseParam(rdr))
                        yield return node;
                    gotP = MovetoSibling(rdr, "param");
                }
                MoveToEndElement(rdr, psDepth);
            }
            MoveToEndElement(rdr, mcDepth);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="rdr"></param>
        /// <returns></returns>
        public IEnumerable<Node> ParseResponse(XmlReader rdr)
        {
            rdr.MoveToContent();
            if (rdr.Name != "methodResponse")
                throw new XmlRpcInvalidXmlRpcException(
                  "Response XML not valid XML-RPC - root element not methodResponse.");
            int mrDepth = rdr.Depth;
            MoveToChild(rdr, "params", "fault");
            if (rdr.Name == "params")
            {
                yield return new ResponseNode(_depth);
                int psDepth = rdr.Depth;
                bool gotP = MoveToChild(rdr, "param");
                if (gotP)
                {
                    foreach (Node node in ParseParam(rdr))
                        yield return node;
                }
                MoveToEndElement(rdr, psDepth);
            }
            else
            {
                int fltDepth = rdr.Depth;
                foreach (Node node in ParseFault(rdr))
                    yield return node;
                MoveToEndElement(rdr, fltDepth);
            }
            MoveToEndElement(rdr, mrDepth);
        }

        private IEnumerable<Node> ParseFault(XmlReader rdr)
        {
            int fDepth = rdr.Depth;
            yield return new FaultNode(_depth);
            MoveToChild(rdr, "value", true);
            foreach (Node node in ParseValue(rdr))
                yield return node;
            MoveToEndElement(rdr, fDepth);
        }

        private IEnumerable<Node> ParseParam(XmlReader rdr)
        {
            int pDepth = rdr.Depth;
            //yield return new ParamNode();
            MoveToChild(rdr, "value", true);
            foreach (Node node in ParseValue(rdr))
                yield return node;
            MoveToEndElement(rdr, pDepth);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="rdr"></param>
        /// <returns></returns>
        public IEnumerable<Node> ParseValue(XmlReader rdr)
        {
            int vDepth = rdr.Depth;
            if (rdr.IsEmptyElement)
            {
                yield return CreateStringValue("", true);
            }
            else
            {
                rdr.Read(); // TODO: check all return values from rdr.Read()
                if (rdr.NodeType == XmlNodeType.Text)
                {
                    yield return CreateStringValue(rdr.Value, true);
                }
                else
                {
                    string strValue = "";
                    if (rdr.NodeType == XmlNodeType.Whitespace)
                    {
                        strValue = rdr.Value;
                        rdr.Read();
                    }
                    if (rdr.NodeType == XmlNodeType.EndElement)
                    {
                        yield return CreateStringValue(strValue, true);
                    }
                    else if (rdr.NodeType == XmlNodeType.Element)
                    {
                        switch (rdr.Name)
                        {
                            case "string":
                                yield return CreateStringValue(rdr.ReadElementContentAsString(), false);
                                break;
                            case "int":
                            case "i4":
                                yield return CreateIntValue(rdr.ReadElementContentAsString());
                                break;
                            case "i8":
                                yield return CreateLongValue(rdr.ReadElementContentAsString());
                                break;
                            case "double":
                                yield return CreateDoubleValue(rdr.ReadElementContentAsString());
                                break;
                            case "dateTime.iso8601":
                                yield return CreateDateTimeValue(rdr.ReadElementContentAsString());
                                break;
                            case "boolean":
                                yield return CreateBooleanValue(rdr.ReadElementContentAsString());
                                break;
                            case "base64":
                                yield return CreateBase64Value(rdr.ReadElementContentAsString());
                                break;
                            case "struct":
                                foreach (var node in ParseStruct(rdr))
                                    yield return node;
                                break;
                            case "array":
                                foreach (var node in ParseArray(rdr))
                                    yield return node;
                                break;
                            case "nil":
                                yield return CreateNilValue();
                                break;
                        }
                    }
                }
            }
            MoveToEndElement(rdr, vDepth);
        }

        private IEnumerable<Node> ParseArray(XmlReader rdr)
        {
            yield return CreateArrayValue();
            int aDepth = rdr.Depth;
            MoveToChild(rdr, "data");
            bool gotV = MoveToChild(rdr, "value");
            int vDepth = rdr.Depth;
            while (gotV)
            {
                foreach (Node node in ParseValue(rdr))
                    yield return node;
                gotV = MovetoSibling(rdr, "value");
            }
            yield return CreateEndArrayValue();
        }

        private IEnumerable<Node> ParseStruct(XmlReader rdr)
        {
            yield return CreateStructValue();
            int sDepth = rdr.Depth;
            bool gotM = MoveToChild(rdr, "member");
            int mDepth = rdr.Depth;
            while (gotM)
            {
                MoveToChild(rdr, "name", true);
                string name = rdr.ReadElementContentAsString();
                if (name == "")
                    throw new XmlRpcInvalidXmlRpcException("Struct contains member with empty name element.");
                yield return CreateStructMember(name);
                MoveOverWhiteSpace(rdr);
                if (!(rdr.NodeType == XmlNodeType.Element && rdr.Name == "value"))
                    throw new Exception();
                foreach (Node node in ParseValue(rdr))
                    yield return node;
                MoveToEndElement(rdr, mDepth);
                gotM = MovetoSibling(rdr, "member");
            }
            MoveToEndElement(rdr, sDepth);
            yield return CreateEndStructValue();
        }

        private bool MovetoSibling(XmlReader rdr, string p)
        {
            return MovetoSibling(rdr, p, false);
        }

        private bool MovetoSibling(XmlReader rdr, string p, bool required)
        {
            if (!rdr.IsEmptyElement && rdr.NodeType == XmlNodeType.Element && rdr.Name == p)
                return true;
            int depth = rdr.Depth;
            rdr.Read();
            while (rdr.Depth >= depth)
            {
                if (rdr.Depth == (depth) && rdr.NodeType == XmlNodeType.Element
                    && rdr.Name == p)
                    return true;
                if (!rdr.Read())
                    break;
            }
            if (required)
                throw new XmlRpcInvalidXmlRpcException(string.Format("Missing element {0}", p));
            return false;
        }

        private bool MoveToEndElement(XmlReader rdr, int mcDepth)
        {
            // TODO: better error reporting required, i.e. include end element node type expected
            if (rdr.Depth == mcDepth && rdr.IsEmptyElement)
                return true;
            if (rdr.Depth == mcDepth && rdr.NodeType == XmlNodeType.EndElement)
                return true;
            while (rdr.Depth >= mcDepth)
            {
                rdr.Read();
                if (rdr.NodeType == XmlNodeType.Element && IsXmlRpcElement(rdr.Name))
                    throw new XmlRpcInvalidXmlRpcException(string.Format("Unexpected element {0}",
                      rdr.Name));
                if (rdr.Depth == mcDepth && rdr.NodeType == XmlNodeType.EndElement)
                    return true;
            }
            return false;
        }

        private bool IsXmlRpcElement(string elementName)
        {
            return _xmlRpcMembers.Contains(elementName);
        }

        private bool MoveToChild(XmlReader rdr, string nodeName)
        {
            return MoveToChild(rdr, nodeName, false);
        }

        private bool MoveToChild(XmlReader rdr, string nodeName1, string nodeName2)
        {
            return MoveToChild(rdr, nodeName1, nodeName2, false);
        }

        private bool MoveToChild(XmlReader rdr, string nodeName, bool required)
        {
            return MoveToChild(rdr, nodeName, null, required);
        }

        private bool MoveToChild(XmlReader rdr, string nodeName1, string nodeName2,
          bool required)
        {
            int depth = rdr.Depth;
            if (rdr.IsEmptyElement)
            {
                if (required)
                    throw new XmlRpcInvalidXmlRpcException(MakeMissingChildMessage(nodeName1, nodeName2));
                return false;
            }
            rdr.Read();
            while (rdr.Depth > depth)
            {
                if (rdr.Depth == (depth + 1) && rdr.NodeType == XmlNodeType.Element
                    && (rdr.Name == nodeName1 || (nodeName2 != null && rdr.Name == nodeName2)))
                    return true;
                rdr.Read();
            }
            if (required)
                throw new XmlRpcInvalidXmlRpcException(MakeMissingChildMessage(nodeName1, nodeName2));
            return false;
        }

        string MakeMissingChildMessage(string nodeName1, string nodeName2)
        {
            return nodeName2 == null
              ? string.Format("Missing element:  {0}", nodeName1)
              : string.Format("Missing element: {0} or {1}", nodeName1, nodeName2);
        }

        private void MoveOverWhiteSpace(XmlReader rdr)
        {
            while (rdr.NodeType == XmlNodeType.Whitespace
              || rdr.NodeType == XmlNodeType.SignificantWhitespace)
                rdr.Read();
        }


        private MethodName CreateMethodName(string name)
        {
            return new MethodName(_depth, name);
        }

        private StringValue CreateStringValue(string value, bool implicitValue)
        {
            return new StringValue(_depth, value, implicitValue);
        }

        private IntValue CreateIntValue(string value)
        {
            return new IntValue(_depth, value);
        }

        private LongValue CreateLongValue(string value)
        {
            return new LongValue(_depth, value);
        }

        private DoubleValue CreateDoubleValue(string value)
        {
            return new DoubleValue(_depth, value);
        }

        private BooleanValue CreateBooleanValue(string value)
        {
            return new BooleanValue(_depth, value);
        }

        private DateTimeValue CreateDateTimeValue(string value)
        {
            return new DateTimeValue(_depth, value);
        }

        private Base64Value CreateBase64Value(string value)
        {
            return new Base64Value(_depth, value);
        }

        private NilValue CreateNilValue()
        {
            return new NilValue(_depth);
        }

        private StructValue CreateStructValue()
        {
            return new StructValue(_depth++);
        }

        private StructMember CreateStructMember(string name)
        {
            return new StructMember(_depth, name);
        }

        private EndStructValue CreateEndStructValue()
        {
            return new EndStructValue(--_depth);
        }

        private ArrayValue CreateArrayValue()
        {
            return new ArrayValue(_depth++);
        }

        private EndArrayValue CreateEndArrayValue()
        {
            return new EndArrayValue(--_depth);
        }
    }
    /// <summary>
    /// 
    /// </summary>
    public class Node
    {
        /// <summary>
        /// 
        /// </summary>
        public int Depth { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="depth"></param>
        public Node(int depth)
        {
            Depth = depth;
        }
    }
    /// <summary>
    /// 
    /// </summary>
    public class ValueNode : Node
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="depth"></param>
        public ValueNode(int depth) : base(depth) { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="depth"></param>
        /// <param name="value"></param>
        public ValueNode(int depth, string value)
            : base(depth)
        {
            Value = value;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="depth"></param>
        /// <param name="value"></param>
        /// <param name="implicitValue"></param>
        public ValueNode(int depth, string value, bool implicitValue)
            : base(depth)
        {
            Value = value;
            ImplicitValue = implicitValue;
        }
        /// <summary>
        /// 
        /// </summary>
        public string Value { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool ImplicitValue { get; private set; }
    }
    /// <summary>
    /// 
    /// </summary>
    public class SimpleValueNode : ValueNode
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="depth"></param>
        public SimpleValueNode(int depth) : base(depth) { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="depth"></param>
        /// <param name="value"></param>
        public SimpleValueNode(int depth, string value)
            : base(depth, value) { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="depth"></param>
        /// <param name="value"></param>
        /// <param name="implicitValue"></param>
        public SimpleValueNode(int depth, string value, bool implicitValue)
            : base(depth, value, implicitValue) { }
    }
    /// <summary>
    /// 
    /// </summary>
    public class ComplexValueNode : ValueNode
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="depth"></param>
        public ComplexValueNode(int depth) : base(depth) { }
    }
    /// <summary>
    /// 
    /// </summary>
    public class EndComplexValueNode : Node
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="depth"></param>
        public EndComplexValueNode(int depth) : base(depth) { }
    }
    /// <summary>
    /// 
    /// </summary>
    public class StringValue : SimpleValueNode
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="depth"></param>
        /// <param name="value"></param>
        /// <param name="implicitValue"></param>
        public StringValue(int depth, string value, bool implicitValue)
            : base(depth, value, implicitValue) { }
    }
    /// <summary>
    /// 
    /// </summary>
    public class IntValue : SimpleValueNode
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="depth"></param>
        /// <param name="value"></param>
        public IntValue(int depth, string value) : base(depth, value) { }
    }
    /// <summary>
    /// 
    /// </summary>
    public class LongValue : SimpleValueNode
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="depth"></param>
        /// <param name="value"></param>
        public LongValue(int depth, string value) : base(depth, value) { }
    }
    /// <summary>
    /// 
    /// </summary>
    public class DoubleValue : SimpleValueNode
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="depth"></param>
        /// <param name="value"></param>
        public DoubleValue(int depth, string value) : base(depth, value) { }
    }
    /// <summary>
    /// 
    /// </summary>
    public class BooleanValue : SimpleValueNode
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="depth"></param>
        /// <param name="value"></param>
        public BooleanValue(int depth, string value) : base(depth, value) { }
    }
    /// <summary>
    /// 
    /// </summary>
    public class DateTimeValue : SimpleValueNode
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="depth"></param>
        /// <param name="value"></param>
        public DateTimeValue(int depth, string value) : base(depth, value) { }
    }
    /// <summary>
    /// 
    /// </summary>
    public class Base64Value : SimpleValueNode
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="depth"></param>
        /// <param name="value"></param>
        public Base64Value(int depth, string value) : base(depth, value) { }
    }
    /// <summary>
    /// 
    /// </summary>
    public class NilValue : SimpleValueNode
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="depth"></param>
        public NilValue(int depth) : base(depth) { }
    }
    /// <summary>
    /// 
    /// </summary>
    public class StructMember : ValueNode
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="depth"></param>
        /// <param name="name"></param>
        public StructMember(int depth, string name) : base(depth, name) { }
    }
    /// <summary>
    /// 
    /// </summary>
    public class EndStructValue : EndComplexValueNode
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="depth"></param>
        public EndStructValue(int depth) : base(depth) { }
    }
    /// <summary>
    /// 
    /// </summary>
    public class ArrayValue : ComplexValueNode
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="depth"></param>
        public ArrayValue(int depth) : base(depth) { }
    }
    /// <summary>
    /// 
    /// </summary>
    public class EndArrayValue : EndComplexValueNode
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="depth"></param>
        public EndArrayValue(int depth) : base(depth) { }
    }
    /// <summary>
    /// 
    /// </summary>
    public class MethodName : Node
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="depth"></param>
        /// <param name="name"></param>
        public MethodName(int depth, string name)
            : base(depth)
        {
            Name = name;
        }
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }
    }
    /// <summary>
    /// 
    /// </summary>
    public class FaultNode : Node
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="depth"></param>
        public FaultNode(int depth) : base(depth) { }
    }
    /// <summary>
    /// 
    /// </summary>
    public class ResponseNode : Node
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="depth"></param>
        public ResponseNode(int depth) : base(depth) { }
    }
    /// <summary>
    /// 
    /// </summary>
    public class ParamsNode : Node
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="depth"></param>
        public ParamsNode(int depth) : base(depth) { }
    }
    /// <summary>
    /// 
    /// </summary>
    public class ParamNode : Node
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="depth"></param>
        public ParamNode(int depth) : base(depth) { }
    }
    /// <summary>
    /// 
    /// </summary>
    public class StructValue : ComplexValueNode
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="depth"></param>
        public StructValue(int depth) : base(depth) { }
    }
}
