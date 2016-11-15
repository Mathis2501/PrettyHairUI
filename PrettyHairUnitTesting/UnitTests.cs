using System;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrettyHair;

namespace PrettyHairUnitTesting
{
    [TestClass]
    public class UnitTests
    {
       
        ProductType Chair = new ProductType(14.99, 15, "This Chair Is Bad!");

        [TestMethod]
        public void CanReadDescription()
        {
            Assert.AreEqual("This Chair Is Bad!", Chair.Description);
        }

        [TestMethod]
        public void CanReadAmount()
        {
            Assert.AreEqual(15, Chair.Amount);
        }
        
        [TestMethod]
        public void CanReadPrice()
        {
            Assert.AreEqual(14.99, Chair.Price);
        }

        [TestMethod]
        public void CanAdjustPrice()
        {
            ProductTypeRepository.AdjustPrice(Chair, 149.99);

            Assert.AreEqual(149.99, Chair.Price);
        }

        [TestMethod]
        public void CanAdjustAmount()
        {
            ProductTypeRepository.AdjustAmount(Chair, 150);

            Assert.AreEqual(150, Chair.Amount);
        }

        [TestMethod]
        public void CanAdjustDesription()
        {
            ProductTypeRepository.AdjustDescription(Chair, "This Chair Is Really Fucking Bad!");

            Assert.AreEqual("This Chair Is Really Fucking Bad!", Chair.Description);
        }

        [TestMethod]
        public void GetsConfirmation()
        {
            Assert.AreEqual("ChangeConfirmed:\n Changed To: 149\n", ProductTypeRepository.AdjustAmount(Chair, 149));
            Assert.AreEqual("ChangeConfirmed:\n Changed To: this doesn't matter\n", ProductTypeRepository.AdjustDescription(Chair, "this doesn't matter"));
            Assert.AreEqual("ChangeConfirmed:\n Changed To: 6\n", ProductTypeRepository.AdjustPrice(Chair, 6));
        }

    }

}
