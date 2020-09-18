using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Msk2.Banking.Application.Interfaces;
using Msk2.Banking.Application.Models;
using Msk2.Banking.Domain.Models;

namespace Msk2.Banking.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankingController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public BankingController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Account>> Get()
            => Ok(_accountService.GetAccounts());

        [HttpPost]
        public ActionResult Post([FromBody]AccountTransfer accountTransfer)
        {
            _accountService.Transfer(accountTransfer); ;
            return Ok(accountTransfer);
        }
    }
}
