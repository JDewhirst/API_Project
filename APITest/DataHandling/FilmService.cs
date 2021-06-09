﻿using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using DataModel;

namespace APITest
{
    public class FilmService
    {
        public ICallable CallManager { get; set; }
        public JObject JSON_Response { get; set; }
        public string FilmSelected { get; set; }
        public IResult FilmResult { get; set; }
        public DTO DTO { get; set; }


        public FilmService(ICallable callManager)
        {
            CallManager = callManager;
            DTO = new DTO();
        }

        public async Task MakeRequestAsync(string filmId)
        {

            FilmSelected = filmId;

            // Make request
            FilmResult = await CallManager.DeleteFilm(filmId);
            

            
            //// Parse JSON response content
            //JSON_Response = JObject.Parse(FilmResult);

            //// Use DTO to convert JSON string to an object
            //FilmResult.Deserialize<Film>()
            ////.DeserialiseResponse(PostcodeResponse);
        }

    }
}
