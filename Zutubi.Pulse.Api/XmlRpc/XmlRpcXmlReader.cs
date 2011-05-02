using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace CookComputing.XmlRpc
{
    /// <summary>
    /// 
    /// </summary>
  public static class XmlRpcXmlReader
  {
      /// <summary>
      /// 
      /// </summary>
      /// <param name="stm"></param>
      /// <returns></returns>
    public static XmlReader Create(Stream stm)
    {
      XmlTextReader xmlRdr = new XmlTextReader(stm);
      ConfigureXmlTextReader(xmlRdr);
      return xmlRdr;
    }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="textReader"></param>
      /// <returns></returns>
    public static XmlReader Create(TextReader textReader)
    {
      XmlTextReader xmlRdr = new XmlTextReader(textReader);
      ConfigureXmlTextReader(xmlRdr);
      return xmlRdr;
    }

    private static void ConfigureXmlTextReader(XmlTextReader xmlRdr)
    {
      xmlRdr.Normalization = false;
      xmlRdr.ProhibitDtd = true;
      xmlRdr.WhitespaceHandling = WhitespaceHandling.All;
    }
  }
}
