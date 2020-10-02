using Com.MM.Service.Core.Lib;
using Com.MM.Service.Core.Lib.Models;
using Com.MM.Service.Core.Lib.Services;
using Com.MM.Service.Core.Lib.ViewModels;
using Com.MM.Service.Core.WebApi.Helpers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Com.MM.Service.Core.WebApi.Controllers.v1.BasicControllers
{
    [Produces("application/json")]
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/articles/materials")]
    public class ArticleMaterialsController : BasicController<ArticleMaterialService, ArticleMaterial, ArticleMaterialViewModel, CoreDbContext>
    {
        private new static readonly string ApiVersion = "1.0";
        public ArticleMaterialsController(ArticleMaterialService service) : base(service, ApiVersion)
        {
        }
    }
}
