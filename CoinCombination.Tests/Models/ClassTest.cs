using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoinCombination.Models;
using System;

namespace CoinCombination.Tests
{
    [TestClass]
    public class CoinSlideTest
    {
        [TestMethod]
        public void CoinSlide_GetNumberOfQuarters_3()
        {
            CoinSlide.GetCoins(75);
            Assert.AreEqual(3, CoinSlide.numQuarters);
        }
        [TestMethod]
        public void CoinSlide_GetNumberOfDimes_2()
        {
            CoinSlide.GetCoins(20);
            Assert.AreEqual(2, CoinSlide.numDimes);
        }
        [TestMethod]
        public void CoinSlide_GetNumberOfNickels_1()
        {
            CoinSlide.GetCoins(5);
            Assert.AreEqual(1, CoinSlide.numNickels);
        }
        [TestMethod]
        public void CoinSlide_GetNumberOfPennies_3()
        {
            CoinSlide.GetCoins(3);
            Assert.AreEqual(3, CoinSlide.numPennies);
        }
        [TestMethod]
        public void CoinSlide_GetNumberOfCoins_1Quarter2Dimes2Pennies()
        {
            CoinSlide.GetCoins(47);

            Assert.AreEqual(1, CoinSlide.numQuarters);
            Assert.AreEqual(2, CoinSlide.numDimes);
            Assert.AreEqual(2, CoinSlide.numPennies);
        }
    }
}
