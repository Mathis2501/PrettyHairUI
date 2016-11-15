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
       
        ProductType _chair = new ProductType(14.99, 15, "This Chair Is Bad!");

        [TestMethod]
        public void CanReadDescription()
        {
            Assert.AreEqual("This Chair Is Bad!", _chair.Description);
        }

        [TestMethod]
        public void CanReadAmount()
        {
            Assert.AreEqual(15, _chair.Amount);
        }
        
        [TestMethod]
        public void CanReadPrice()
        {
            Assert.AreEqual(14.99, _chair.Price);
        }

        [TestMethod]
        public void CanAdjustPrice()
        {
            ProductTypeRepository.AdjustPrice(_chair, 149.99);

            Assert.AreEqual(149.99, _chair.Price);
        }

        [TestMethod]
        public void CanAdjustAmount()
        {
            ProductTypeRepository.AdjustAmount(_chair, 150);

            Assert.AreEqual(150, _chair.Amount);
        }

        [TestMethod]
        public void CanAdjustDesription()
        {
            ProductTypeRepository.AdjustDescription(_chair, "This Chair Is Really Fucking Bad!");

            Assert.AreEqual("This Chair Is Really Fucking Bad!", _chair.Description);
        }

        [TestMethod]
        public void GetsConfirmation()
        {
            Assert.AreEqual("ChangeConfirmed:\n Changed To: 149\n", ProductTypeRepository.AdjustAmount(_chair, 149));
            Assert.AreEqual("ChangeConfirmed:\n Changed To: this doesn't matter\n", ProductTypeRepository.AdjustDescription(_chair, "this doesn't matter"));
            Assert.AreEqual("ChangeConfirmed:\n Changed To: 6\n", ProductTypeRepository.AdjustPrice(_chair, 6));
        }

    }

}
