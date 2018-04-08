using Blockchain.Models;

namespace Blockchain.Wrappers
{
    public interface IBlockchainApiWrapper
    {
         RawAddressResponse GetRawAddress(string address);
         UnspentOutputsResponse GetUnspentOutputs(string address);
    }
}