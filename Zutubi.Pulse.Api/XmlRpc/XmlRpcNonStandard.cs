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

using System;
using System.Text;

namespace CookComputing.XmlRpc
{
    /// <summary>
    /// 
    /// </summary>
    [Flags]
    public enum XmlRpcNonStandard
    {
        /// <summary>
        /// 
        /// </summary>
        None = 0x00,
        /// <summary>
        /// 
        /// </summary>
        AllowStringFaultCode = 0x01,
        /// <summary>
        /// 
        /// </summary>
        AllowNonStandardDateTime = 0x02,
        /// <summary>
        /// 
        /// </summary>
        IgnoreDuplicateMembers = 0x4,
        /// <summary>
        /// 
        /// </summary>
        MapZerosDateTimeToMinValue = 0x8,
        /// <summary>
        /// 
        /// </summary>
        MapEmptyDateTimeToMinValue = 0x10,
        /// <summary>
        /// 
        /// </summary>
        AllowInvalidHTTPContent = 0x20,
        /// <summary>
        /// 
        /// </summary>
        All = 0x7fff,
    }
}
