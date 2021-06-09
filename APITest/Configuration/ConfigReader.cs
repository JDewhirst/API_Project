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
       
        public static string BaseURL()
        {
            string ans =  ConfigurationManager.AppSettings["baseUrl"];
            NameValueCollection nsv = ConfigurationManager.AppSettings;
            return ans;
        }
        
    }
}
