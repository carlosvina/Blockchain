using System;
using Newtonsoft.Json;

namespace Blockchain.Models
{
    public class Utxo
    {
        [JsonProperty("tx_hash")]
        public string TxHash { get; set; }
        [JsonProperty("tx_index")]
        public long TxIndex { get; set; }
        public long Value { get; set; }
    }
}