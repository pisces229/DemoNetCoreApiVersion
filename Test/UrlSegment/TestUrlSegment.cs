using System.Net;
using Test.Test;

namespace Test.UrlSegment
{
    [TestClass]
    public class TestUrlSegment : TestInitialize
    {
        private const string Host = "api/{0}/UrlSegment";
        [TestMethod("Version")]
        public async Task Run()
        {
            var requestUri = string.Format($"{Host}", "");
            var response = await _httpClient.GetAsync(requestUri);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            await DisplayHttpResponseMessage(response);
        }
        [TestMethod("Version 1.0")]
        public async Task RunV1()
        {
            var requestUri = string.Format($"{Host}", "v1.0");
            var response = await _httpClient.GetAsync(requestUri);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            await DisplayHttpResponseMessage(response);
        }
        [TestMethod("Version 2.0")]
        public async Task RunV2()
        {
            var requestUri = string.Format($"{Host}", "v2.0");
            var response = await _httpClient.GetAsync(requestUri);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            await DisplayHttpResponseMessage(response);
        }
        [TestMethod("Version 3.0")]
        public async Task RunV3()
        {
            var requestUri = string.Format($"{Host}", "v3.0");
            var response = await _httpClient.GetAsync(requestUri);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            await DisplayHttpResponseMessage(response);
        }
    }
}
