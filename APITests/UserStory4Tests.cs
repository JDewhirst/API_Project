﻿using System;
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
    public class WhenUpdateFilmCalledWithValidIDAndBody
    {
        Film result;
        public ICallable _filmService;
        [OneTimeSetUp]
        public async Task Setup()
        {
            Film upDatedFilm = new Film {title = "testupdate",actors = new string[] { "da", "asd" }, category = new string[] { "da", "asd" }, Company = " ", desc = " ", directors = "asd", releaseDate = "asdf", rating = "13", languages = new string[] {"Cantonese", "English" } };
            _filmService = new CallManager();

           result = await _filmService.UpdateFilm(4.ToString(), upDatedFilm);
        }

        [Test]
        public void StatusIs_201()
        {
            Assert.That(_filmService.StatusCode, Is.EqualTo(200));
        }


        [Test]
        public void StatusDescriptionIsCreated()
        {
            Assert.That(_filmService.StatusDescription, Is.EqualTo("OK"));
        }

        [Test]
        public void ResponseGivesCorrectUpdates()
        {
            Assert.That(result.title, Is.EqualTo("testupdate"));
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

