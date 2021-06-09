using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;
using System.Configuration;
namespace APITest
{
    public class DTO
    {
        public T Deserialize<T>(string ojectContent)
        {
            return JsonConvert.DeserializeObject<T>(ojectContent);
        }
    }
}
