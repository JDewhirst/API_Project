using NUnit.Framework;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using APITest;
using DataModel;
using System.Configuration;

namespace UserStory6Tests
{
    [TestFixture]
    public class WhenAdminIsUpdatngUserOnDataBase
    {
        ICallable _callManager;
        [OneTimeSetUp]
        public async Task OneTimeSetup()
        {
            _callManager = new CallManager();
            await _callManager.Request("j");
        }
        [Category("Happy Path")]
        [Test]
        public void StatusIs200WhenValid6_1()
        {
            Assert.That(_callManager.StatusDescription, Is.Not.Null);
        }

        //[Test]
        //public void StatusIs200WhenValidalt6_1()
        //{
        //    Assert.That(singlePostcodeService.callManager.StatusDescription, Is.EqualTo("OK"));
        //}

        //[Test]
        //public void StatusIs200WhenValidalt26_1()
        //{
        //    Assert.That(singlePostcodeService.StatusCode, Is.EqualTo(200));
        //}

        //[Test]
        //public void StatusIs200WhenValidalt36_1()
        //{
        //    Assert.That(singlePostcodeService.ResponseObject["status"].ToObject<int>(), Is.EqualTo(200));
        //}

        //[Test]
        //public void DetailsCorrect()
        //{
        //    Assert.That(singlePostcodeService.singlePostCodeDTO.DeserializedResponse.result.postcode, Is.EqualTo("PE7 8NL"));
        //}

        //[Test]
        //public void OutCodeCorrect()
        //{
        //    Assert.That(singlePostcodeService.singlePostCodeDTO.DeserializedResponse.result.outcode, Is.EqualTo("PE7"));
        //}

        //[Test]
        //public void inCodeCorrect()
        //{
        //    Assert.That(singlePostcodeService.singlePostCodeDTO.DeserializedResponse.result.incode, Is.EqualTo("8NL"));
        //}
    }

    //public class BulkPostCodeTests
    //{
    //    BulkPostCodeService _bulkPostService = new BulkPostCodeService();
    //    List<string> _postCodes = new List<string>() { "ec2y 5as", "pe78af", "SW1W 0NY", "SW1W 0NY" };
    //    [OneTimeSetUp]
    //    public async Task Setup()
    //    {
    //        await _bulkPostService.MakeRequest(_postCodes);
    //    }

    //    [Test]
    //    public void StatusIs200WhenValid()
    //    {
    //        Assert.That(_bulkPostService._bulkPostCodeDTO.DeserializedResponse.status, Is.EqualTo(200));
    //    }

    //    [Test]
    //    public void StatusIs200WhenValidalt()
    //    {
    //        Assert.That(_bulkPostService.callManager.StatusDescription, Is.EqualTo("OK"));
    //    }

    //    [Test]
    //    public void StatusIs200WhenValidalt2()
    //    {
    //        Assert.That(_bulkPostService.StatusCode, Is.EqualTo(200));
    //    }

    //    [Test]
    //    public void StatusIs200WhenValidalt3()
    //    {
    //        Assert.That(_bulkPostService.ResponseObject["status"].ToObject<int>(), Is.EqualTo(200));
    //    }

    //    [Test]
    //    public void DetailsCorrect()
    //    {
    //        Assert.That(_bulkPostService._bulkPostCodeDTO.DeserializedResponse.result[2].result.postcode, Is.EqualTo("SW1W 0NY"));
    //    }

    //}



}