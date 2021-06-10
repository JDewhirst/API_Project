# Typicode API Testing Framework

The aim of the project is deliver a test framework for a REST API, testing all the data in the responses

It makes use of [typicode](https://my-json-server.typicode.com/) placeholder REST API of our design, a library for storing information about films and their directors, for example IMDB. With the ability to get, update and delete them information. The API is stored in a github repo [here](https://github.com/Bongiboy777/APITesting).

## Project Setup

To set up this project requires Visual Studio 2019 and the .NET Framework 4.7.2 developer tools. The solution is split into two projects, APITest and APITEsts. APITest requires the NuGet packages Newtonsoft.JSon, RestSharp, and System.Configuration.ConfigurationManager, APITests requires Microsoft.NET.Test.Sdk, Moq, Newtonsoft.Json, NUnit, NUNit3TestAdapter, RestSharp, and System.Configuration.ConfigurationManger.

### Credits

Bongani Luwemba, Hossain Ghazal, Jack Dewhirst