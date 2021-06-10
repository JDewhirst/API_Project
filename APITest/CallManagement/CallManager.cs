using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using DataModel;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
namespace APITest
{
    public class CallManager : ICallable
    {
        IRestClient _client;
        IRestRequest _newRequest;
        DTO _dto;
        public int StatusCode { get; private set; }
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

        public async Task DeleteFilm(string request)
        {
            _newRequest = new RestRequest(Method.DELETE);
            _newRequest.Resource = $"Films/{request}";
            var result = await _client.ExecuteAsync<string>(_newRequest);

            StatusDescription = result.StatusDescription;
            StatusCode = (int)result.StatusCode;
            //Result expected = _dto.Deserialize<Result>(result.Content);

        }

        public async Task AddFilm(Film film)
        {
            _newRequest = new RestRequest(Method.POST);
            _newRequest.Resource = $"Films";
            _newRequest.AddJsonBody(film);
            _newRequest.AddHeader("Content-Type", "application/Json");


            var result = await _client.ExecuteAsync<string>(_newRequest);

            StatusDescription = result.StatusDescription;
            StatusCode = (int)result.StatusCode;
        }

        public async Task<Result> UpdateFilm(string filmName)
        {
            _newRequest = new RestRequest(Method.PATCH);
            _newRequest.Resource = $"Films/?title={filmName.Replace(" ", "%20")}";
            var result = await _client.ExecuteAsync<string>(_newRequest);


            StatusDescription = result.StatusDescription;
            StatusCode = (int)result.StatusCode;
            //Result expected = _dto.Deserialize<Result>(result.Content);
            return null;
        }


        public async Task<Result> Request(string request)
        {

            _newRequest =
                request != "" ? new RestRequest(Method.GET) :
                throw new ArgumentException();
            _newRequest.AddHeader("Content-Type", "application/Json");


            //_newRequest.AddJsonBody(new JObject { new JProperty("postcodes", new JArray { "OX49 5NU", "M32 0JG", "NE30 1DP" })}.ToString());
            _newRequest.Resource = $"Films?title={request}";
            //_newRequest.Resource = $"postcodes";// Films/1";//?title={request.Replace(" ","%20")}";

            var result = await _client.ExecuteAsync<string>(_newRequest);
            StatusCode = (int)result.StatusCode;

            StatusDescription = result.StatusDescription;
            Result expected = _dto.Deserialize<Result>($"{result.Data}");
            return expected;
        }

        public async Task<Result> RequestAll()
        {

            _newRequest = new RestRequest(Method.GET);

            _newRequest.AddHeader("Content-Type", "application/Json");

            _newRequest.Resource = $"Films";


            var result = await _client.ExecuteAsync<string>(_newRequest);


            StatusDescription = result.StatusDescription;
            Result expected = _dto.Deserialize<Result>($"{result.Data}");
            return null;
        }

    }
}
