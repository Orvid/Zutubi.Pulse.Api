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
using System.ComponentModel;
using System.Collections;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CookComputing.XmlRpc
{
    /// <summary>
    /// 
    /// </summary>
  public interface IXmlRpcProxy
  {
      /// <summary>
      /// 
      /// </summary>
    bool AllowAutoRedirect { get; set; }

#if (!COMPACT_FRAMEWORK && !SILVERLIGHT && !SILVERLIGHT)
      /// <summary>
      /// 
      /// </summary>
    X509CertificateCollection ClientCertificates { get; }
#endif

#if (!COMPACT_FRAMEWORK && !SILVERLIGHT)
      /// <summary>
      /// 
      /// </summary>
    string ConnectionGroupName { get; set; }
#endif

#if (!COMPACT_FRAMEWORK && !SILVERLIGHT)
      /// <summary>
      /// 
      /// </summary>
    CookieContainer CookieContainer { get; }
#endif
      /// <summary>
      /// 
      /// </summary>
    [Browsable(false)]
    ICredentials Credentials { get; set; }

#if (!COMPACT_FRAMEWORK && !FX1_0 && !SILVERLIGHT)
      /// <summary>
      /// 
      /// </summary>
    bool EnableCompression { get; set;}
      /// <summary>
      /// 
      /// </summary>
    bool Expect100Continue { get; set; }
      /// <summary>
      /// 
      /// </summary>
    bool UseNagleAlgorithm { get; set; }
#endif
      /// <summary>
      /// 
      /// </summary>
    [Browsable(false)]
    WebHeaderCollection Headers { get; }
      /// <summary>
      /// 
      /// </summary>
    Guid Id { get; }
      /// <summary>
      /// 
      /// </summary>
    int Indentation { get; set; }
      /// <summary>
      /// 
      /// </summary>
    bool KeepAlive { get; set; }
      /// <summary>
      /// 
      /// </summary>
    XmlRpcNonStandard NonStandard { get; set; }
      /// <summary>
      /// 
      /// </summary>
    bool PreAuthenticate { get; set; }

#if (!SILVERLIGHT)
      /// <summary>
      /// 
      /// </summary>
    [Browsable(false)]
    System.Version ProtocolVersion { get; set; }
#endif

#if (!SILVERLIGHT)
      /// <summary>
      /// 
      /// </summary>
    [Browsable(false)]
    IWebProxy Proxy { get; set; }
#endif

#if (!COMPACT_FRAMEWORK && !SILVERLIGHT)
      /// <summary>
      /// 
      /// </summary>
    [Browsable(false)]
    CookieCollection ResponseCookies { get; }
      /// <summary>
      /// 
      /// </summary>
    [Browsable(false)]
    WebHeaderCollection ResponseHeaders { get; }
#endif
      /// <summary>
      /// 
      /// </summary>
    int Timeout { get; set; }
      /// <summary>
      /// 
      /// </summary>
    string Url { get; set; }
      /// <summary>
      /// 
      /// </summary>
    bool UseEmptyElementTags { get; set; }
      /// <summary>
      /// 
      /// </summary>
    bool UseEmptyParamsTag { get; set; }
      /// <summary>
      /// 
      /// </summary>
    bool UseIndentation { get; set; }
      /// <summary>
      /// 
      /// </summary>
    bool UseIntTag { get; set; }
      /// <summary>
      /// 
      /// </summary>
    bool UseStringTag { get; set; }
      /// <summary>
      /// 
      /// </summary>
    string UserAgent { get; set; }
      /// <summary>
      /// 
      /// </summary>
    [Browsable(false)]
    Encoding XmlEncoding { get; set; }
      /// <summary>
      /// 
      /// </summary>
    string XmlRpcMethod { get; set; }

    // introspecton methods
      /// <summary>
      /// 
      /// </summary>
      /// <returns></returns>
    string[] SystemListMethods(); 
      /// <summary>
      /// 
      /// </summary>
      /// <param name="MethodName"></param>
      /// <returns></returns>
    object[] SystemMethodSignature(string MethodName);
      /// <summary>
      /// 
      /// </summary>
      /// <param name="MethodName"></param>
      /// <returns></returns>
    string SystemMethodHelp(string MethodName);

    // events
      /// <summary>
      /// 
      /// </summary>
    event XmlRpcRequestEventHandler RequestEvent;
      /// <summary>
      /// 
      /// </summary>
    event XmlRpcResponseEventHandler ResponseEvent;

  }
}
