/* 
XML-RPC.NET library
Copyright (c) 2001-2006, Charles Cook <charlescook@cookcomputing.com>

Permission is hereby granted, free of charge, to any person 
obtaining a copy of this software and associated documentation 
files (the "Software"), to deal in the Software without restriction, 
including without limitation the rights to use, copy, modify, merge, 
publish, distribute, sublicense, and/or sell copies of the Software, 
and to permit persons to whom the Software is furnished to do so, 
subject to the following conditions:

The above copyright notice and this permission notice shall be 
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, 
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES 
OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND 
NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT 
HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, 
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, 
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
DEALINGS IN THE SOFTWARE.
*/

namespace CookComputing.XmlRpc
{
    using System;
    /// <summary>
    /// 
    /// </summary>
    public class XmlRpcException :
#if (!SILVERLIGHT)
 ApplicationException
#else
    Exception
#endif
    {
        /// <summary>
        /// 
        /// </summary>
        public XmlRpcException() { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg"></param>
        public XmlRpcException(string msg)
            : base(msg) { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="innerEx"></param>
        public XmlRpcException(string msg, Exception innerEx)
            : base(msg, innerEx) { }
    }
    /// <summary>
    /// 
    /// </summary>
    public class XmlRpcUnsupportedTypeException : XmlRpcException
    {
        Type _unsupportedType;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="t"></param>
        public XmlRpcUnsupportedTypeException(Type t)
            : base(string.Format("Unable to map type {0} onto XML-RPC type", t))
        {
            _unsupportedType = t;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="t"></param>
        /// <param name="msg"></param>
        public XmlRpcUnsupportedTypeException(Type t, string msg)
            : base(msg)
        {
            _unsupportedType = t;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="t"></param>
        /// <param name="msg"></param>
        /// <param name="innerEx"></param>
        public XmlRpcUnsupportedTypeException(Type t, string msg, Exception innerEx)
            : base(msg, innerEx)
        {
            _unsupportedType = t;
        }
        /// <summary>
        /// 
        /// </summary>
        public Type UnsupportedType { get { return _unsupportedType; } }
    }
    /// <summary>
    /// 
    /// </summary>
    public class XmlRpcUnexpectedTypeException : XmlRpcException
    {
        /// <summary>
        /// 
        /// </summary>
        public XmlRpcUnexpectedTypeException() { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg"></param>
        public XmlRpcUnexpectedTypeException(string msg)
            : base(msg) { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="innerEx"></param>
        public XmlRpcUnexpectedTypeException(string msg, Exception innerEx)
            : base(msg, innerEx) { }
    }
    /// <summary>
    /// 
    /// </summary>
    public class XmlRpcIllFormedXmlException : XmlRpcException
    {
        /// <summary>
        /// 
        /// </summary>
        public XmlRpcIllFormedXmlException() { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg"></param>
        public XmlRpcIllFormedXmlException(string msg)
            : base(msg) { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="innerEx"></param>
        public XmlRpcIllFormedXmlException(string msg, Exception innerEx)
            : base(msg, innerEx) { }
    }
    /// <summary>
    /// 
    /// </summary>
    public class XmlRpcUnsupportedMethodException : XmlRpcException
    {
        /// <summary>
        /// 
        /// </summary>
        public XmlRpcUnsupportedMethodException() { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg"></param>
        public XmlRpcUnsupportedMethodException(string msg)
            : base(msg) { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="innerEx"></param>
        public XmlRpcUnsupportedMethodException(string msg, Exception innerEx)
            : base(msg, innerEx) { }
    }
    /// <summary>
    /// 
    /// </summary>
    public class XmlRpcInvalidParametersException : XmlRpcException
    {
        /// <summary>
        /// 
        /// </summary>
        public XmlRpcInvalidParametersException() { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg"></param>
        public XmlRpcInvalidParametersException(string msg)
            : base(msg) { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="innerEx"></param>
        public XmlRpcInvalidParametersException(string msg, Exception innerEx)
            : base(msg, innerEx) { }
    }
    /// <summary>
    /// 
    /// </summary>
    public class XmlRpcNonRegularArrayException : XmlRpcException
    {
        /// <summary>
        /// 
        /// </summary>
        public XmlRpcNonRegularArrayException() { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg"></param>
        public XmlRpcNonRegularArrayException(string msg)
            : base(msg) { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="innerEx"></param>
        public XmlRpcNonRegularArrayException(string msg, Exception innerEx)
            : base(msg, innerEx) { }
    }
    /// <summary>
    /// 
    /// </summary>
    public class XmlRpcInvalidXmlRpcException : XmlRpcException
    {
        /// <summary>
        /// 
        /// </summary>
        public XmlRpcInvalidXmlRpcException() { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg"></param>
        public XmlRpcInvalidXmlRpcException(string msg)
            : base(msg) { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="innerEx"></param>
        public XmlRpcInvalidXmlRpcException(string msg, Exception innerEx)
            : base(msg, innerEx) { }
    }
    /// <summary>
    /// 
    /// </summary>
    public class XmlRpcMethodAttributeException : XmlRpcException
    {
        /// <summary>
        /// 
        /// </summary>
        public XmlRpcMethodAttributeException() { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg"></param>
        public XmlRpcMethodAttributeException(string msg)
            : base(msg) { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="innerEx"></param>
        public XmlRpcMethodAttributeException(string msg, Exception innerEx)
            : base(msg, innerEx) { }
    }
    /// <summary>
    /// 
    /// </summary>
    public class XmlRpcTypeMismatchException : XmlRpcException
    {
        /// <summary>
        /// 
        /// </summary>
        public XmlRpcTypeMismatchException() { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg"></param>
        public XmlRpcTypeMismatchException(string msg)
            : base(msg) { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="innerEx"></param>
        public XmlRpcTypeMismatchException(string msg, Exception innerEx)
            : base(msg, innerEx) { }
    }
    /// <summary>
    /// 
    /// </summary>
    public class XmlRpcNullReferenceException : XmlRpcException
    {
        /// <summary>
        /// 
        /// </summary>
        public XmlRpcNullReferenceException() { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg"></param>
        public XmlRpcNullReferenceException(string msg)
            : base(msg) { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="innerEx"></param>
        public XmlRpcNullReferenceException(string msg, Exception innerEx)
            : base(msg, innerEx) { }
    }
    /// <summary>
    /// 
    /// </summary>
    public class XmlRpcServerException : XmlRpcException
    {
        /// <summary>
        /// 
        /// </summary>
        public XmlRpcServerException() { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg"></param>
        public XmlRpcServerException(string msg)
            : base(msg) { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="innerEx"></param>
        public XmlRpcServerException(string msg, Exception innerEx)
            : base(msg, innerEx) { }
    }
    /// <summary>
    /// 
    /// </summary>
    public class XmlRpcInvalidReturnType : XmlRpcException
    {
        /// <summary>
        /// 
        /// </summary>
        public XmlRpcInvalidReturnType() { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg"></param>
        public XmlRpcInvalidReturnType(string msg)
            : base(msg) { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="innerEx"></param>
        public XmlRpcInvalidReturnType(string msg, Exception innerEx)
            : base(msg, innerEx) { }
    }
    /// <summary>
    /// 
    /// </summary>
    public class XmlRpcMappingSerializeException : XmlRpcException
    {
        /// <summary>
        /// 
        /// </summary>
        public XmlRpcMappingSerializeException() { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg"></param>
        public XmlRpcMappingSerializeException(string msg)
            : base(msg) { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="innerEx"></param>
        public XmlRpcMappingSerializeException(string msg, Exception innerEx)
            : base(msg, innerEx) { }
    }
    /// <summary>
    /// 
    /// </summary>
    public class XmlRpcNullParameterException : XmlRpcException
    {
        /// <summary>
        /// 
        /// </summary>
        public XmlRpcNullParameterException() { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg"></param>
        public XmlRpcNullParameterException(string msg)
            : base(msg) { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="innerEx"></param>
        public XmlRpcNullParameterException(string msg, Exception innerEx)
            : base(msg, innerEx) { }
    }
    /// <summary>
    /// 
    /// </summary>
    public class XmlRpcMissingUrl : XmlRpcException
    {
        /// <summary>
        /// 
        /// </summary>
        public XmlRpcMissingUrl() { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg"></param>
        public XmlRpcMissingUrl(string msg)
            : base(msg) { }
    }
    /// <summary>
    /// 
    /// </summary>
    public class XmlRpcDupXmlRpcMethodNames : XmlRpcException
    {
        /// <summary>
        /// 
        /// </summary>
        public XmlRpcDupXmlRpcMethodNames() { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg"></param>
        public XmlRpcDupXmlRpcMethodNames(string msg)
            : base(msg) { }
    }
    /// <summary>
    /// 
    /// </summary>
    public class XmlRpcNonSerializedMember : XmlRpcException
    {
        /// <summary>
        /// 
        /// </summary>
        public XmlRpcNonSerializedMember() { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg"></param>
        public XmlRpcNonSerializedMember(string msg)
            : base(msg) { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="innerEx"></param>
        public XmlRpcNonSerializedMember(string msg, Exception innerEx)
            : base(msg, innerEx) { }
    }
    /// <summary>
    /// 
    /// </summary>
    public class XmlRpcInvalidEnumValue : XmlRpcException
    {
        /// <summary>
        /// 
        /// </summary>
        public XmlRpcInvalidEnumValue() { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg"></param>
        public XmlRpcInvalidEnumValue(string msg)
            : base(msg) { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="innerEx"></param>
        public XmlRpcInvalidEnumValue(string msg, Exception innerEx)
            : base(msg, innerEx) { }
    }
}
