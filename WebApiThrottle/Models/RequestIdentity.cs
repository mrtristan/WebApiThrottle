﻿using System;
using System.Net.Http;

namespace WebApiThrottle
{
    /// <summary>
    /// Stores the client IP, key and endpoint
    /// </summary>
    [Serializable]
    public class RequestIdentity
    {
        public string ClientIp { get; set; }

        public string ClientKey { get; set; }

        public string Endpoint { get; set; }

        public HttpMethod Method { get; set; }

        public bool ForceWhiteList { get; set; }
    }
}
