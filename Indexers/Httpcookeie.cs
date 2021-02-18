using System.Collections.Generic;

namespace Indexers
{
    public class Httpcookie
    {
        private readonly Dictionary<string, string> dictonary = new Dictionary<string, string>();

        public string this[string key]
        {
            get { return dictonary[key]; }
            set { dictonary[key] = value; }
        }
    }
}
