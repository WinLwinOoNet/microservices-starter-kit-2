using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Msk2.WebApp.Dtos;
using Newtonsoft.Json;

namespace Msk2.WebApp.Services
{
    public class TransferService : ITransferService
    {
        private readonly HttpClient _apiClient;

        public TransferService(HttpClient apiClient)
        {
            _apiClient = apiClient;
        }

        public async Task Transfer(TransferDto transferDto)
        {
            var uri = "https://localhost:44378/api/banking";
            var transferContent = new StringContent(JsonConvert.SerializeObject(transferDto),
                Encoding.UTF8, "application/json");

            var response = await _apiClient.PostAsync(uri, transferContent);
            response.EnsureSuccessStatusCode();
        }
    }
}
