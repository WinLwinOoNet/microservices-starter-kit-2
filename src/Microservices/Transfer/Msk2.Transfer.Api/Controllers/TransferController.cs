using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Msk2.Transfer.Application.Interfaces;
using Msk2.Transfer.Domain.Models;

namespace Msk2.Transfer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransferController : ControllerBase
    {
        private readonly ITransferService _service;

        public TransferController(ITransferService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<TransferLog>> Get()
            => Ok(_service.GetTransferLogs());
    }
}
