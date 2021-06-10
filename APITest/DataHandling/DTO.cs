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
            string transform = ojectContent.Insert(0, "{\"result\":");
            transform += '}';

            

           var newType = JsonConvert.DeserializeObject<T>(transform);
            return newType;
        }

        public string Serialize(Film film)
        {
            return JsonConvert.SerializeObject(new Result { result = new Film[] { film} });
        }
    }
}
