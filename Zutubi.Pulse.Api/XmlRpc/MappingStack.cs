using System;
using System.Collections.Generic;
using System.Text;

namespace CookComputing.XmlRpc
{
    /// <summary>
    /// 
    /// </summary>
    public class MappingStack : Stack<string>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="parseType"></param>
      public MappingStack(string parseType)
      {
        m_parseType = parseType;
      }

      new void Push(string str)
      {
        base.Push(str);
      }
        /// <summary>
        /// 
        /// </summary>
      public string MappingType
      {
        get { return m_parseType; }
      }
        /// <summary>
        /// 
        /// </summary>
      public string m_parseType = "";
    }
  }
