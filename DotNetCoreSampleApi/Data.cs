using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreSampleApi
{
    public class Data
    {
        public List<KeyValuePair<string, string>> DataList = new List<KeyValuePair<string, string>>();

        private static Data instance;

        public static Data Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Data();
                }

                return instance;
            }
        }
    }
}
