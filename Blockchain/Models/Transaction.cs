using System.Collections.Generic;
using Newtonsoft.Json;

namespace Blockchain.Models
{
    public class Transaction
    {
        [JsonProperty("ver")]
        public int Version { get; set; }
        public List<Input> Inputs { get; set; }
        public int Weight { get; set; }
        [JsonProperty("block_height")]
        public int BlockHeight { get; set; }
        [JsonProperty("relayed_by")]
        public string RelayedBy { get; set; }
        [JsonProperty("out")]
        public List<Output> Outputs { get; set; }
        [JsonProperty("lock_time")]
        public long LockTime { get; set; }
        public long Result { get; set; }
        public int Size { get; set; }
        public int Time { get; set; }
        [JsonProperty("tx_index")]
        public long TransactionIndex { get; set; }
        [JsonProperty("vin_sz")]
        public int VinSize { get; set; }
        public string Hash { get; set; }
        [JsonProperty("vout_sz")]
        public int VoutSize { get; set; }
    }

    public class Input
    {
        public long Sequence { get; set; }
        public string Witness { get; set; }
        [JsonProperty("prev_out")]
        public PreviousOutput PrevOut { get; set; }
        public string Script { get; set; }
    }

    public class PreviousOutput 
    {
        public bool Spent { get; set; }
        [JsonProperty("tx_index")]
        public long TransactionIndex { get; set; }
        public int Type { get; set; }
        [JsonProperty("addr")]
        public string Address { get; set; }
        public long Value { get; set; }
        public int N { get; set; }
        public string Script { get; set; }
    }

    public class Output
    {
        [JsonProperty("address_tag_link")]
        public string AddressTagLink { get; set; }
        [JsonProperty("address_tag")]
        public string AddressTag { get; set; }
        public bool Spent { get; set; }
        [JsonProperty("tx_index")]
        public long TransactionIndex { get; set; }
        public int Type { get; set; }
        [JsonProperty("addr")]
        public string Address { get; set; }
        public long Value { get; set; }
        public int N { get; set; }
        public string Script { get; set;}
    }

}