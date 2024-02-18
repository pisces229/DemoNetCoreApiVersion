using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Test.Test
{
    [TestClass]
    public class TestInitialize
    {
        protected readonly HttpClient _httpClient;
        public TestInitialize()
        {
            Environment.SetEnvironmentVariable("ASPNETCORE_ENVIRONMENT", "Development");
            var application = new WebApplicationFactory<Program>()
                .WithWebHostBuilder(builder =>
                {
                    //builder.UseEnvironment("Developement");
                });
            _httpClient = application.CreateClient();
        }
        protected async Task DisplayHttpResponseMessage(HttpResponseMessage response)
        {
            Console.WriteLine();
            Console.WriteLine("----- Headers -----");
            Console.WriteLine();
            foreach (var header in response.Headers)
            {
                Console.WriteLine("{0}:{1}", header.Key, string.Join(",", header.Value));
            }
            Console.WriteLine();
            Console.WriteLine("----- Content -----");
            Console.WriteLine();
            foreach (var header in response.Content.Headers)
            {
                Console.WriteLine("{0}:{1}", header.Key, string.Join(",", header.Value));
            }
            Console.WriteLine();
            Console.WriteLine(await response.Content.ReadAsStringAsync());
        }
    }
}
