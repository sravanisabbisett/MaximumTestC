using FindMaximum;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MaximumTest
{
    [TestClass]
    public class UnitTest1
    {
        Maximum maximum;

        public UnitTest1()
        {
            maximum = new Maximum();
        }

        /// <summary>
        /// Givens the maximum integer as first parameter should return maximum.
        /// </summary>
        [TestMethod]
        public void GivenMaximumInteger_AsFirstParameterShouldReturnMaximum()
        {
            int maxResult = maximum.maximumInteger(7, 4, 6);
            Assert.AreEqual(7, maxResult);
        }

        /// <summary>
        /// Givens the maximum integer as second parameter should return maximim integer.
        /// </summary>
        [TestMethod]
        public void GivenMaximumInteger_AsSecondParameter_ShouldReturnMaximimInteger()
        {
            int maxResult = maximum.maximumInteger(4, 7, 6);
            Assert.AreEqual(7, maxResult);
        }

        /// <summary>
        /// Givens the maximim result as third parameter should return maximum result.
        /// </summary>
        [TestMethod]
        public void GivenMaximimResult_AsThirdParameter_ShouldReturnMaximumResult()
        {
            int maxResult = maximum.maximumInteger(4, 6, 7);
            Assert.AreEqual(7, maxResult);
        }

    }
}
