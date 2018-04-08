using Microsoft.VisualStudio.TestTools.UnitTesting;
using Blockchain.Services;

namespace Blockchain.Tests
{
    [TestClass]
    public class BlockchainApiServiceTests
    {
        [TestMethod]
        public void GetUnspentOutput_NoFreeOutputs() 
        {
            var blockchainApi = new BlockchainApiService();
            Assert.IsNull(blockchainApi.GetUnspentOutputs("1Aff4FgrtA1dZDwajmknWTwU2WtwUvfiXa").UnspentOutputs);
        }

        [TestMethod]
        public void GetUnspentOutput_HasFreeOutputs()
        {
            var blockchainApi = new BlockchainApiService();
            Assert.IsTrue(blockchainApi.GetUnspentOutputs("1M4VBwfLZ9BfeztkFNsvQgp2FuEY6PDnsC").UnspentOutputs.Count > 0);
        }
    }
}
