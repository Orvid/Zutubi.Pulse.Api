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
    [AttributeUsage(AttributeTargets.Method)]
    public class XmlRpcMethodAttribute : Attribute
    {
        /// <summary>
        /// 
        /// </summary>
        public XmlRpcMethodAttribute()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="method"></param>
        public XmlRpcMethodAttribute(string method)
        {
            this.method = method;
        }
        /// <summary>
        /// 
        /// </summary>
        public string Method
        {
            get
            { return method; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool IntrospectionMethod
        {
            get { return introspectionMethod; }
            set { introspectionMethod = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool StructParams
        {
            get { return structParams; }
            set { structParams = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string value = "Method : " + method;
            return value;
        }
        /// <summary>
        /// 
        /// </summary>
        public string Description = "";
        /// <summary>
        /// 
        /// </summary>
        public bool Hidden = false;
        private string method = "";
        private bool introspectionMethod = false;
        private bool structParams = false;
    }
}