using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace WebApiUnitTest
{
    public class UnitTest1
    {
        //private readonly WebApplicationFactory<RazorPagesProject.Startup> _factory;

        //public BasicTests(WebApplicationFactory<RazorPagesProject.Startup> factory)
        //{
        //    _factory = factory;
        //}
        public HttpClient _client;
        public UnitTest1()
        {
            var server = new TestServer(new WebHostBuilder().UseStartup<IStartup>());
            _client = server.CreateClient();
        }

        [Fact]
        public async Task Test()
        {
            var response = await _client.GetAsync("/api/People/5");
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            Assert.Equal("{\"author\":\"haha\",\"title\":\"Kimak\"}", responseString);
            //Welcome pc = new Welcome();
            //Book cpd = pc.Test("lol");
            //Assert.Equal("lol", cpd.Author);
        }
    }
}
