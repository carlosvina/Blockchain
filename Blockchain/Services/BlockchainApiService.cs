using System;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using Blockchain.Models;

namespace Blockchain.Services {

    public class BlockchainApiService : IBlockchainApiService
    {        
        private HttpClient _client = new HttpClient();
        private Uri _baseUri = new Uri("https://blockchain.info/");

        public RawAddressResponse GetRawAddress(string address)
        {
            var uri = new Uri(_baseUri, $"rawaddr/{address}");
            var jsonResponse = _client.GetStringAsync(uri).Result;
    
            return JsonConvert.DeserializeObject<RawAddressResponse>(jsonResponse);
        }

        public UnspentOutputsResponse GetUnspentOutputs(string address)
        {
            var uri = new Uri(_baseUri, $"unspent?active={address}");
            var response = _client.GetAsync(uri).Result;
            
            string jsonResponse = null;
            if (response.StatusCode == HttpStatusCode.OK) {
                jsonResponse = response.Content.ReadAsStringAsync().Result;
            }
            else 
            {
                return new UnspentOutputsResponse();
            }
    
            return JsonConvert.DeserializeObject<UnspentOutputsResponse>(jsonResponse);
        }
    }

}