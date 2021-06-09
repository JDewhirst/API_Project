using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;
using System.Configuration;
using DataModel;
namespace APITest
{
    public class DTO
    {
        public Film[] Deserialize(string ojectContent)
        {
            return JsonConvert.DeserializeObject<Result>(ojectContent).films;
        }
    }
}
