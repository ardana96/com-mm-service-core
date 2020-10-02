using Com.Danliris.Service.Core.Test.Helpers;
using Com.MM.Service.Core.Lib;
using Com.MM.Service.Core.Lib.Models;
using Com.MM.Service.Core.Lib.Services;
using System;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Com.MM.Service.Core.Test.Services.CategoryTest
{
    [Collection("ServiceProviderFixture Collection")]
    public class CategoryBasicTest : BasicServiceTest<CoreDbContext, ArticleCategoryService, ArticleCategory>
    {
        private static readonly string[] createAttrAssertions = { "Name", "Code" };
        private static readonly string[] updateAttrAssertions = { "Name", "Code" };
        private static readonly string[] existAttrCriteria = { "Code" };

        public CategoryBasicTest(ServiceProviderFixture fixture) : base(fixture, createAttrAssertions, updateAttrAssertions, existAttrCriteria)
        {
        }

        public override void EmptyCreateModel(ArticleCategory model)
        {
            model.Code = string.Empty;
            model.Name = string.Empty;
        }

        public override void EmptyUpdateModel(ArticleCategory model)
        {
            model.Code = string.Empty;
            model.Name = string.Empty;
        }

        public override ArticleCategory GenerateTestModel()
        {
            string guid = Guid.NewGuid().ToString();

            return new ArticleCategory
            {
                Code = string.Format("CategoryName {0}", guid),
                Name = string.Format("CategoryName {0}", guid),
            };
        }

        //[Fact]
        //public async Task TestJoinDivision()
        //{
        //    CategoryService service = this.Service;
        //    DivisionService divisionService = ServiceProvider.GetService<DivisionService>();
        //    string guid = Guid.NewGuid().ToString();

        //    var division = new Lib.Models.Division()
        //    {
        //        Name = String.Concat("TEST DIVISION ", guid),
        //    };
        //    ArticleCategories createdData = await this.GetCreatedTestData(service);
        //    var createdDivision = await divisionService.CreateModel(division);

        //    var data = service.JoinDivision();
        //    Assert.NotNull(data);
        //}
    }
}
