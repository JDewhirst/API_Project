using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Configuration;
namespace APITest
{
    public class ConfigReader
    {

        public static readonly string BaseURL = ConfigurationManager.AppSettings["baseUrl"];//"https://my-json-server.typicode.com/Bongiboy777/APITesting";
    }
}
