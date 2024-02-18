using System.Net;
using Test.Test;

namespace Test.Header
{
    [TestClass]
    public class TestHeader : TestInitialize
    {
        private const string Host = "api/Header";
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
            var requestUri = $"{Host}";
            _httpClient.DefaultRequestHeaders.Add("Api-Version", "1.0");
            var response = await _httpClient.GetAsync(requestUri);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            await DisplayHttpResponseMessage(response);
        }
        [TestMethod("Version 2.0")]
        public async Task RunV2()
        {
            var requestUri = $"{Host}";
            _httpClient.DefaultRequestHeaders.Add("Api-Version", "2.0");
            var response = await _httpClient.GetAsync(requestUri);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            await DisplayHttpResponseMessage(response);
        }
        [TestMethod("Version 3.0")]
        public async Task RunV3()
        {
            var requestUri = $"{Host}";
            _httpClient.DefaultRequestHeaders.Add("Api-Version", "3.0");
            var response = await _httpClient.GetAsync(requestUri);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            await DisplayHttpResponseMessage(response);
        }
    }
}
