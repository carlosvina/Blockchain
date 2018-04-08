using Microsoft.VisualStudio.TestTools.UnitTesting;
using Blockchain.Controllers;

namespace Blockchain.Tests
{
    [TestClass]
    public class AddressControllerTests
    {
        [TestMethod]
        public void Get_InvalidAddress_ReturnsError()
        {
            var addressController = new AddressController();
            var expectedResult = "Address has no outputs to spend or is invalid.\n";

            var result = addressController.Get("1Aff4FgrtA1dZDwajmknWTwU2WtwUvfiXa");

            Assert.AreEqual(result, expectedResult);
        }
    }
}
