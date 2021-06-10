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
        public Film[] Deserialize(string ojectContent)
        {
            string transform = ojectContent.Insert(0, "{\"result\":");
            transform += '}';

            Tests.ForEach(x =>
            {
                int len = ojectContent.Length;
                try
                {
                    JObject attempt = JObject.Parse(x);
                }
                catch(JsonSerializationException e)
                {
                    Debug.WriteLine("Serialization error");
                }

                catch (JsonReaderException ex)
                {
                    Debug.WriteLine("Read error");
                }
            });

           var newType = JsonConvert.DeserializeObject<T>(transform);
            return newType;
        }
    }
}
