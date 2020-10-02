using Com.MM.Service.Core.Lib;
using Com.MM.Service.Core.Lib.Models.Module;
using Com.MM.Service.Core.Lib.Services;
using Com.MM.Service.Core.Lib.ViewModels.Module;
using Com.MM.Service.Core.WebApi.Helpers;
using Microsoft.AspNetCore.Mvc;


namespace Com.MM.Service.Core.WebApi.Controllers.v1.BasicControllers
{

    [Produces("application/json")]
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/modules")]
    public class ModulesController : BasicController<ModuleService, Module, ModuleViewModel, CoreDbContext>
    {
        private new static readonly string ApiVersion = "1.0";
        public ModulesController(ModuleService service) : base(service, ApiVersion)
        {
        }
    }
}
