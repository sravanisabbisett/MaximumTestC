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
        public void GivenMaximimInteger_AsThirdParameter_ShouldReturnMaximumResult()
        {
            int maxResult = maximum.maximumInteger(4, 6, 7);
            Assert.AreEqual(7, maxResult);
        }

        /// <summary>
        /// Givens the maximum float as first parameter should return maximim float.
        /// </summary>
        [TestMethod]
        public void GivenMaximumFloatAsFirstParameter_ShouldReturnMaximimFloat()
        {
            float maxResult = maximum.MaximumFloat(5.5f, 2.2f, 4.4f);
            Assert.AreEqual(5.5, maxResult);
        }

        /// <summary>
        /// Givens the maximumfloat as second parameter should return maximumresult.
        /// </summary>
        [TestMethod]
        public void GivenMaximumfloat_AsSecondParameter_ShouldReturnMaximumFloat()
        {
            float maxResult = maximum.MaximumFloat(2.2f, 5.5f, 4.4f);
            Assert.AreEqual(5.5, maxResult);

        }

        /// <summary>
        /// Givens the maximum float as third parameter should return maximum float.
        /// </summary>
        [TestMethod]
        public void GivenMaximumFloat_AsThirdParameter_ShouldReturnMaximumFloat()
        {
            float maxResult = maximum.MaximumFloat(2.2f, 4.4f, 5.5f);
            Assert.AreEqual(5.5, maxResult);
        }

    }
}
