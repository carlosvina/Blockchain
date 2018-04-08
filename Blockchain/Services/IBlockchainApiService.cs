using Blockchain.Models;

namespace Blockchain.Services
{
    public interface IBlockchainApiService
    {
         RawAddressResponse GetRawAddress(string address);
         UnspentOutputsResponse GetUnspentOutputs(string address);
    }
}