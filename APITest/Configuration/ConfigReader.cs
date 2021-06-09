using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace APITest
{
    public static class ConfigReader
    {
        
        public static string BaseURL()
        {
            return ConfigurationManager.AppSettings["BaseURL"];
        }
        
    }
}
