using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Configuration
    {
        private static Configuration configuration = null;
        private static object obj= new object();
        public string Property { get; set; }
        public int IntProperty { get; set; }

        private Configuration()
        {
        }

        public static Configuration GetConfiguration()
        {
            lock (obj)
            {
                if (configuration == null)
                {
                    configuration = new Configuration();
                }
            }

            return configuration;
        }
    }
}
