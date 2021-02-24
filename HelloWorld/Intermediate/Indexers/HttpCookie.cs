using System;
using System.Collections.Generic;

namespace HelloWorld.Intermediate.Indexers
{
    class HttpCookie
    {
        private readonly Dictionary<string, string> _dictionary;
        public DateTime Expiring { get; set; }

        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>();
        }

        // Indexer
        public string this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }
    }
}