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
            _dto = new DTO();
        }

        public CallManager()
        {
            _client = new RestClient(ConfigReader.BaseURL);
            _dto = new DTO();
        }

        public async Task<Result> DeleteFilm(string request)
        {
            _newRequest = new RestRequest(Method.DELETE);
            _newRequest.Resource = $"Movies/{request}";
            var result = await _client.ExecuteAsync<string>(_newRequest);

            StatusDescription = result.StatusDescription;
            StatusCode = (int)result.StatusCode;
            Result expected = _dto.Deserialize<Result>(result.Content);
            return expected;
        }


        public async Task<IResult> Request<IResult>(string request)
        {
            _newRequest =
                request == "" ? new RestRequest(Method.GET) :
                throw new ArgumentException();

            var result = await _client.ExecuteAsync<string>(_newRequest);
            StatusDescription = result.StatusDescription;
            IResult expected = _dto.Deserialize<IResult>(result.Content);
            return expected;
        }

        public async Task<IResult> Request<IResult>(string request, JObject body)
        {
            
            _newRequest =
                request == "" ? new RestRequest(Method.GET) :
                request == "" ? new RestRequest(Method.POST) :
                request == "" ? new RestRequest(Method.PUT) :
                request == "" ? new RestRequest(Method.PATCH) :
                throw new ArgumentException();

            _newRequest.AddJsonBody(body.ToString());

            var result = await _client.ExecuteAsync<string>(_newRequest);
            StatusDescription = result.StatusDescription;
            IResult expected = _dto.Deserialize<IResult>(result.Content);
            return expected;
        }
    }
}
