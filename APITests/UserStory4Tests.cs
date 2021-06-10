using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using APITest;
using DataModel;
using Moq;

namespace UserStory4Tests
{
    [Ignore("Update method not fully built implemented yet")]
    public class WhenUpdateFilmCalledWithValidIDAndBody
    {
        
        public ICallable _filmService;
        [OneTimeSetUp]
        public async Task Setup()
        {
            Film film = new Film { actors = new string[] { "da", "asd" }, category = new string[] { "da", "asd" }, Company = " ", desc = " ", directors = "asd", releaseDate = "asdf", id = 8, languages = new string[] { "da", "asd" }, rating = "13", title = "sdfdf" };
            _filmService = new CallManager();

            await _filmService.UpdateFilm("Avengers: Endgame");
        }

        [Test]
        public void StatusIs_201()
        {
            Assert.That(_filmService.StatusCode, Is.EqualTo(201));
        }


        [Test]
        public void StatusDescriptionIsCreated()
        {
            Assert.That(_filmService.StatusDescription, Is.EqualTo("Created"));
        }
    }

    public class WhenUpdateFilmCalledWithInValidID
    {
        public ICallable _filmService;
        [OneTimeSetUp]
        public async Task Setup()
        {
            Film film = new Film { actors = new string[] { "da", "asd" }, category = new string[] { "da", "asd" }, Company = " ", desc = " ", directors = "asd", releaseDate = "asdf", id = 2, languages = new string[] { "da", "asd" }, rating = "5", title = "sdfdf" };
            _filmService = new CallManager();

            await _filmService.AddFilm(film);
        }

        [Test]
        public void StatusIs_500()
        {
            Assert.That(_filmService.StatusCode, Is.EqualTo(500));
        }


        [Test]
        public void StatusDescriptionIsInternalServiceerror()
        {
            Assert.That(_filmService.StatusDescription, Is.EqualTo("Internal Server Error"));
        }
    }
}

