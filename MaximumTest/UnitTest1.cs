using FindMaximum;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MaximumTest
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Givens the maximum integer as first parameter should return maximum.
        /// </summary>
        [TestMethod]
        public void GivenMaximumInteger_AsFirstParameterShouldReturnMaximum()
        {
            int maxResult = new Maximum.GenricMaximum<int>(7, 4, 6).MaxMethod();
            Assert.AreEqual(7, maxResult);
        }

        /// <summary>
        /// Givens the maximum integer as second parameter should return maximim integer.
        /// </summary>
        [TestMethod]
        public void GivenMaximumInteger_AsSecondParameter_ShouldReturnMaximimInteger()
        {
            int maxResult = new Maximum.GenricMaximum<int>(4, 7, 6).MaxMethod();
            Assert.AreEqual(7, maxResult);
        }

        /// <summary>
        /// Givens the maximim result as third parameter should return maximum result.
        /// </summary>
        [TestMethod]
        public void GivenMaximimInteger_AsThirdParameter_ShouldReturnMaximumResult()
        {
            int maxResult = new Maximum.GenricMaximum<int>(4, 6, 7).MaxMethod();
            Assert.AreEqual(7, maxResult);
        }

        /// <summary>
        /// Givens the maximum float as first parameter should return maximim float.
        /// </summary>
        [TestMethod]
        public void GivenMaximumFloatAsFirstParameter_ShouldReturnMaximimFloat()
        {
            float maxResult = new Maximum.GenricMaximum<float>(5.5f, 2.2f, 4.4f).MaxMethod();
            Assert.AreEqual(5.5, maxResult);
        }

        /// <summary>
        /// Givens the maximumfloat as second parameter should return maximumresult.
        /// </summary>
        [TestMethod]
        public void GivenMaximumfloat_AsSecondParameter_ShouldReturnMaximumFloat()
        {
            float maxResult = new Maximum.GenricMaximum<float>(2.2f, 5.5f, 4.4f).MaxMethod();
            Assert.AreEqual(5.5, maxResult);
            
        }

        /// <summary>
        /// Givens the maximum float as third parameter should return maximum float.
        /// </summary>
        [TestMethod]
        public void GivenMaximumFloat_AsThirdParameter_ShouldReturnMaximumFloat()
        {
            float maxResult = new Maximum.GenricMaximum<float>(2.2f, 4.4f, 5.5f).MaxMethod();
            Assert.AreEqual(5.5, maxResult);
        }

        /// <summary>
        /// Givens the maximum string as first parameter should return maximum string.
        /// </summary>
        [TestMethod]
        public void GivenMaximumString_AsFirstParameter_shouldReturnMaximumString()
        {
            string maxResult = new Maximum.GenricMaximum<string>("peach", "apple", "banana").MaxMethod();
            Assert.AreEqual("peach", maxResult);
        }

        /// <summary>
        /// Givens the maximum string as secondparameter should return maximum string.
        /// </summary>
        [TestMethod]
        public void GivenMaximumString_AsSecondparameter_ShouldReturnMaximumString()
        {
            string maxResult =new Maximum.GenricMaximum<string>("apple", "peach", "banana").MaxMethod();
            Assert.AreEqual("peach", maxResult);
        }

        /// <summary>
        /// Givens the maximum string as THRD parameter should return maximum string.
        /// </summary>
        [TestMethod]
        public void GivenMaximumString_AsThrdParameter_ShouldReturnMaximumString()
        {
            string maxResult =new Maximum.GenricMaximum<string>("banana", "apple", "peach").MaxMethod();
            Assert.AreEqual("peach", maxResult);
        }
    }
}
