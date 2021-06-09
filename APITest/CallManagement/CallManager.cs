using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using DataModel;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
namespace APITest
{
    public class CallManager : ICallable
    {
        IRestClient _client;
        IRestRequest _newRequest;
        DTO _dto;
        public int StatusCode {get; private set;}
        public string StatusDescription { get; private set; }


        public CallManager(IRestClient client)
        {
            _client = client;
        }

        public CallManager()
        {
            _client = new RestClient(ConfigReader.BaseURL());
        }


        public async Task<Film[]> Request(string request)
        {
            _newRequest = new RestRequest(Method.GET);

            _newRequest.Timeout = -1;
            _newRequest.AddHeader("Content-Type", "application/json");
            _newRequest.Resource = ("Films");

            var result = await _client.ExecuteAsync<string>(_newRequest);
            StatusDescription = result.StatusDescription;
            Film[] output = _dto.Deserialize(result.Content);
            return output;
        }

        
    }
}
