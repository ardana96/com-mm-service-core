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

namespace Com.MajorMinor.Service.Core.WebApi.Controllers.v1.BasicControllers
{
    [Produces("application/json")]
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/master/banks")]
    public class BankController : BasicController<BankService, Bank, BankViewModel, CoreDbContext>
    {
        private new static readonly string ApiVersion = "1.0";

        public BankController(BankService service) : base(service, ApiVersion)
        {
        }
    }
}
