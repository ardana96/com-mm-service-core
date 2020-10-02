using Microsoft.AspNetCore.Mvc;
using Com.MM.Service.Core.Lib;
using Com.MM.Service.Core.Lib.Models;
using Com.MM.Service.Core.Lib.Services;
using Com.MM.Service.Core.Lib.ViewModels;
using Com.MM.Service.Core.WebApi.Helpers;


namespace Com.MM.Service.Core.WebApi.Controllers.v1.BasicControllers
{
    [Produces("application/json")]
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/articles/subCounters")]
    public class ArticleSubCountersController : BasicController<ArticleSubCounterService, ArticleSubCounter, ArticleSubCounterViewModel, CoreDbContext>
    {
        private new static readonly string ApiVersion = "1.0";
        public ArticleSubCountersController(ArticleSubCounterService service) : base(service, ApiVersion)
        {
        }
    }
}
