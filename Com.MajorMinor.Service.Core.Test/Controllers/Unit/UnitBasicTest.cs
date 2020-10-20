using Com.MM.Service.Core.Lib.Models;
using Com.MM.Service.Core.Lib.Services;
using Com.MM.Service.Core.Lib.ViewModels;
using Com.MM.Service.Core.Test.DataUtils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Com.MM.Service.Core.Test.Controllers.UnitTest
{
    [Collection("TestFixture Collection")]
    public class UnitBasicTest
    {
        private const string URI = "v1/master/units";

        protected TestServerFixture TestFixture { get; set; }

        protected HttpClient Client
        {
            get { return this.TestFixture.Client; }
        }

        public UnitBasicTest(TestServerFixture fixture)
        {
            TestFixture = fixture;
        }

        protected UnitDataUtil DataUtil
        {
            get { return (UnitDataUtil)this.TestFixture.Service.GetService(typeof(UnitDataUtil)); }
        }

        protected UnitService Service
        {
            get { return (UnitService)this.TestFixture.Service.GetService(typeof(UnitService)); }
        }


        public UnitViewModel GenerateTestModel()
        {
            string guid = Guid.NewGuid().ToString();

            return new UnitViewModel()
            {
                code = string.Format("TEST {0}", guid),
                name = string.Format("Unit {0}", guid),
                description = "Description",
                division = new DivisionViewModel
                {
                    name = "DivisionName",
                    code= "DivisionCode",
                    _id=1
                },
            };
        }

        [Fact]
        public async Task Post()
        {
            UnitViewModel VM = GenerateTestModel();
            var response = await this.Client.PostAsync(URI, new StringContent(JsonConvert.SerializeObject(VM).ToString(), Encoding.UTF8, "application/json"));

            Assert.Equal(HttpStatusCode.Created, response.StatusCode);
        }

        [Fact]
        public async Task Post_Failed_Internal_Server_Error()
        {

            UnitViewModel VM = null;
            var response = await this.Client.PostAsync(URI, new StringContent(JsonConvert.SerializeObject(VM).ToString(), Encoding.UTF8, "application/json"));

            Assert.Equal(HttpStatusCode.InternalServerError, response.StatusCode);
        }

        [Fact]
        public async Task Post_Failed_Bad_Request()
        {
            UnitViewModel VM = GenerateTestModel();
            VM.code = null;
            var response = await this.Client.PostAsync(URI, new StringContent(JsonConvert.SerializeObject(VM).ToString(), Encoding.UTF8, "application/json"));

            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
        }

        [Fact]
        public async Task Get()
        {
            var response = await this.Client.GetAsync(URI);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task GetById()
        {
            var response = await this.Client.GetAsync(string.Concat(URI, "/"));
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task Delete()
        {
            Unit Unit = await DataUtil.GetTestDataAsync();
            UnitViewModel VM = Service.MapToViewModel(Unit);
            var response = await this.Client.DeleteAsync(string.Concat(URI, "/", VM._id));

            Assert.Equal(HttpStatusCode.NoContent, response.StatusCode);
        }

        [Fact]
        public async Task Update()
        {
            Unit Unit = await DataUtil.GetTestDataAsync();
            UnitViewModel VM = Service.MapToViewModel(Unit);
            var response = await this.Client.PutAsync(string.Concat(URI, "/", VM._id), new StringContent(JsonConvert.SerializeObject(VM).ToString(), Encoding.UTF8, "application/json"));

            Assert.Equal(HttpStatusCode.NoContent, response.StatusCode);
        }

        [Fact]
        public async Task NotFound()
        {
            var response = await this.Client.GetAsync(string.Concat(URI, "/", 0));
            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }

        [Fact]
        public async Task GetSimple()
        {
            var response = await this.Client.GetAsync(string.Concat(URI, "/simple"));
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

    }
}
