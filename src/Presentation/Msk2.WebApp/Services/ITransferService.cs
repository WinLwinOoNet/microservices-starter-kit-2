using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Msk2.WebApp.Dtos;

namespace Msk2.WebApp.Services
{
    public interface ITransferService
    {
        Task Transfer(TransferDto transferDto);
    }
}
