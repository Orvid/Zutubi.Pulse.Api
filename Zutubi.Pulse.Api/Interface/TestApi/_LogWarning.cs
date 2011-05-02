﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Zutubi.Pulse.Api
{
    public static partial class Interface
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static bool LogWarning(string message)
        {
            CheckAuth(AuthType.Admin);
            return Client.LogWarning(authToken, message);
        }
    }
}