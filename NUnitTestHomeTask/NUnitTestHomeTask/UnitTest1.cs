using NUnit.Framework;
using Newtonsoft.Json;
using RestSharp;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;

namespace NUnitTestHomeTask
{
    public class Tests
    {
        Response1 deserializedProduct;
        Response2 deserializedProduct2;


        [OneTimeSetUp]
        public void Setup()
        {
            var client = new RestClient("https://api.thevirustracker.com/free-api?countryTotal=RU");
            var request = new RestRequest();
            request.Method = Method.GET;
            request.AddHeader("Accept", "application/json");
            var d = client.Execute(request);
            deserializedProduct = JsonConvert.DeserializeObject<Response1>(d.Content);
            var client2 = new RestClient("https://disease.sh/v2/countries/russian%20federation?yesterday=false&strict=true");
            var request2 = new RestRequest();
            request.Method = Method.GET;
            request.AddHeader("Accept", "application/json");
            var d2 = client2.Execute(request2);
            deserializedProduct2 = JsonConvert.DeserializeObject<Response2>(d2.Content);
            Assert.True(d.StatusCode == System.Net.HttpStatusCode.OK, "не прошёл запрос по адресу https://api.thevirustracker.com/free-api?countryTotal=RU");
            Assert.True(d2.StatusCode == System.Net.HttpStatusCode.OK, "не прошёл запрос по адресу https://disease.sh/v2/countries/russian%20federation?yesterday=false&strict=true");


        }
        [Test]
        public void Test1()
        {
            Assert.True(deserializedProduct.countrydata[0].info.title == deserializedProduct2.Country);

        }
        [Test]
        public void Test2()
        {
            Assert.True(deserializedProduct.countrydata[0].total_cases == deserializedProduct2.cases);

        }
    }

}