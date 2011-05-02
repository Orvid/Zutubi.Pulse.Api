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
    public class XmlRpcParameterInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public XmlRpcParameterInfo()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        public String Doc
        {
            get { return doc; }
            set { doc = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool IsParams
        {
            get { return isparams; }
            set { isparams = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String Name
        {
            get { return name; }
            set
            {
                name = value;
                if (xmlRpcName == "")
                    xmlRpcName = name;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public String XmlRpcName
        {
            get { return xmlRpcName; }
            set { xmlRpcName = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Type Type
        {
            get { return type; }
            set { type = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string XmlRpcType
        {
            get { return xmlRpcType; }
            set { xmlRpcType = value; }
        }

        string doc;
        string name;
        Type type;
        string xmlRpcName;
        string xmlRpcType;
        bool isparams;
    }
}