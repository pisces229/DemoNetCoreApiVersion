using System.Net;
using Test.Test;

namespace Test.QueryString
{
    [TestClass]
    public class TestQueryString : TestInitialize
    {
        private const string Host = "api/QueryString";
        [TestMethod("Version")]
        public async Task Run()
        {
            var requestUri = $"{Host}";
            var response = await _httpClient.GetAsync(requestUri);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            await DisplayHttpResponseMessage(response);
        }
        [TestMethod("Version 1.0")]
        public async Task RunV1()
        {
            var requestUri = $"{Host}?api-version=1.0";
            //var requestUri = $"{Host}?x-version=1.0";
            var response = await _httpClient.GetAsync(requestUri);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            await DisplayHttpResponseMessage(response);
        }
        [TestMethod("Version 2.0")]
        public async Task RunV2()
        {
            var requestUri = $"{Host}?api-version=2.0";
            //var requestUri = $"{Host}?x-version=2.0";
            var response = await _httpClient.GetAsync(requestUri);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            await DisplayHttpResponseMessage(response);
        }
        [TestMethod("Version 3.0")]
        public async Task RunV3()
        {
            var requestUri = $"{Host}?api-version=3.0";
            //var requestUri = $"{Host}?x-version=3.0";
            var response = await _httpClient.GetAsync(requestUri);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            await DisplayHttpResponseMessage(response);
        }
    }
}
