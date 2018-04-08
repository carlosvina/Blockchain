using System.Collections.Generic;
using Newtonsoft.Json;

namespace Blockchain.Models
{
    public class RawAddressResponse
    {
        public string Hash160 { get; set; }
        public string Address { get; set; }
        [JsonProperty("n_tx")]
        public int TransactionCount { get; set; }
        [JsonProperty("total_received")]
        public long TotalReceived { get; set; }
        [JsonProperty("total_sent")]
        public long TotalSent { get; set; }
        [JsonProperty("final_balance")]
        public long FinalBalance { get; set; }
        [JsonProperty("txs")]
        public List<Transaction> Transactions { get; set; }
    }
}