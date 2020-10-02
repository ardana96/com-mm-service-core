using Microsoft.AspNetCore.Mvc;
using Com.MM.Service.Core.Lib;
using Com.MM.Service.Core.Lib.Services;
using Com.MM.Service.Core.WebApi.Helpers;
using Com.MM.Service.Core.Lib.Models;
using Com.MM.Service.Core.Lib.ViewModels;

namespace Com.MM.Service.Core.WebApi.Controllers.v1.UploadControllers
{
    [Produces("application/json")]
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/master/upload-categories")]
    public class CategoriesUploadController : BasicUploadController<ArticleCategoryService, ArticleCategory, ArticleCategoryViewModel, ArticleCategoryService.CategoryMap, CoreDbContext>
    {
        private static readonly string ApiVersion = "1.0";

        public CategoriesUploadController(ArticleCategoryService service) : base(service, ApiVersion)
        {
        }
    }
}