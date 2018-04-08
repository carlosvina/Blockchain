using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Blockchain.Models 
{
    public class UnspentOutputsResponse 
    {
        [JsonProperty("unspent_outputs")]
        public List<Utxo> UnspentOutputs { get; set; } 
    }
}