using System;
using Microsoft.AspNetCore.Mvc;
using Blockchain.Wrappers;
using Blockchain.Models;
using Newtonsoft.Json;

namespace Blockchain.Controllers
{
    [Route("[controller]")]
    public class AddressController : Controller
    {
        private IBlockchainApiWrapper _blockChainApi = new BlockchainApiWrapper();

        // GET /address
        [HttpGet("{address}")]
        public string Get(string address)
        {
            UnspentOutputsResponse unspentOutputsResponse;
            string response;
            try 
            {
                unspentOutputsResponse = _blockChainApi.GetUnspentOutputs(address);
                if (unspentOutputsResponse.UnspentOutputs != null)
                {
                    response = JsonConvert.SerializeObject(unspentOutputsResponse, Formatting.Indented);
                }
                else 
                {
                    response = "Address has no outputs to spend or is invalid.\n";
                }
            }
            catch (Exception ex)
            {
                response = $"There has been a problem trying to connect to Blockchain.info API.\n{ex.InnerException}";
            }
            
            return response;
            
        }
    }
}
