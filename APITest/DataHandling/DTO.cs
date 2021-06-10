using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Configuration;
using System.Diagnostics;
using DataModel;

namespace APITest
{
    public class DTO
    {
        public T Deserialize<T>(string ojectContent)
        {
            
           var newType = JsonConvert.DeserializeObject<T>(ojectContent);
            return newType;
        }

        public string Serialize(Film film)
        {
            string ans =  JsonConvert.SerializeObject(film);
            return ans;
        }
    }
}
