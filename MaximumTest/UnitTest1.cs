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
            int[] intArray = { 7, 4, 6 };
            Maximum.GenricMaximum<int> maxResult = new Maximum.GenricMaximum<int>(intArray);
            int actual = maxResult.MaxValue();
            Assert.AreEqual(7, actual);
        }

        /// <summary>
        /// Givens the maximum integer as second parameter should return maximim integer.
        /// </summary>
        [TestMethod]
        public void GivenMaximumInteger_AsSecondParameter_ShouldReturnMaximimInteger()
        {
            int[] intArray = {4,7,6};
            Maximum.GenricMaximum<int> maxResult = new Maximum.GenricMaximum<int>(intArray);
            int actual = maxResult.MaxValue();
            Assert.AreEqual(7, actual);
        }

        /// <summary>
        /// Givens the maximim result as third parameter should return maximum result.
        /// </summary>
        [TestMethod]
        public void GivenMaximimInteger_AsThirdParameter_ShouldReturnMaximumResult()
        {
            int[] intArray = { 4, 6, 7 };
            Maximum.GenricMaximum<int> maxResult = new Maximum.GenricMaximum<int>(intArray);
            int actual = maxResult.MaxValue();
            Assert.AreEqual(7, actual);
        }

        [TestMethod]
        public void GivenMoreThan3Elements_ShouldReturn_MaximumInteger()
        {
            int[] intArray = { 4, 6, 7, 8, 2 ,20};
            Maximum.GenricMaximum<int> maxResult = new Maximum.GenricMaximum<int>(intArray);
            int actual = maxResult.MaxValue();
            Assert.AreEqual(20, actual);
        }
        /// <summary>
        /// Givens the maximum float as first parameter should return maximim float.
        /// </summary>
        [TestMethod]
        public void GivenMaximumFloatAsFirstParameter_ShouldReturnMaximimFloat()
        {
            float[] floatarray = { 5.5f, 2.2f, 4.4f };
            Maximum.GenricMaximum<float> maxResult = new Maximum.GenricMaximum<float>(floatarray);
            float actual = maxResult.MaxValue();
            Assert.AreEqual(5.5, actual);
        }

        /// <summary>
        /// Givens the maximumfloat as second parameter should return maximumresult.
        /// </summary>
        [TestMethod]
        public void GivenMaximumfloat_AsSecondParameter_ShouldReturnMaximumFloat()
        {
            float[] floatArray = { 2.2f, 5.5f, 4.4f };
            Maximum.GenricMaximum<float> maxResult = new Maximum.GenricMaximum<float>(floatArray);
            float actual = maxResult.MaxValue();
            Assert.AreEqual(5.5, actual);

        }

        /// <summary>
        /// Givens the maximum float as third parameter should return maximum float.
        /// </summary>
        [TestMethod]
        public void GivenMaximumFloat_AsThirdParameter_ShouldReturnMaximumFloat()
        {
            float[] floatArray = { 2.2f, 4.4f, 5.5f };
            Maximum.GenricMaximum<float> maxResult = new Maximum.GenricMaximum<float>(floatArray);
            float actual = maxResult.MaxValue();
            Assert.AreEqual(5.5, actual);
        }

        [TestMethod]
        public void GivenFloatArrray_ShouldReturnMaximumFloat()
        {
            float[] floatArray = { 2.2f, 4.4f, 9.9f ,5.5f};
            Maximum.GenricMaximum<float> maxResult = new Maximum.GenricMaximum<float>(floatArray);
            float actual = maxResult.MaxValue();
            Assert.AreEqual(9.9f, actual);
        }

        /// <summary>
        /// Givens the maximum string as first parameter should return maximum string.
        /// </summary>
        [TestMethod]
        public void GivenMaximumString_AsFirstParameter_shouldReturnMaximumString()
        {
            string[]  stringArray = { "peach", "apple", "banana" };
            Maximum.GenricMaximum<string> maxResult = new Maximum.GenricMaximum<string>(stringArray);
            string actual = maxResult.MaxValue();
            Assert.AreEqual("peach", actual);
        }

        /// <summary>
        /// Givens the maximum string as secondparameter should return maximum string.
        /// </summary>
        [TestMethod]
        public void GivenMaximumString_AsSecondparameter_ShouldReturnMaximumString()
        {
            string[] stringArray = { "apple", "peach", "banana" };
            Maximum.GenricMaximum<string> maxResult = new Maximum.GenricMaximum<string>(stringArray);
            string actual = maxResult.MaxValue();
            Assert.AreEqual("peach", actual);
        }

        /// <summary>
        /// Givens the maximum string as THRD parameter should return maximum string.
        /// </summary>
        [TestMethod]
        public void GivenMaximumString_AsThrdParameter_ShouldReturnMaximumString()
        {
            string[] stringArray = { "banana", "apple", "peach" };
            Maximum.GenricMaximum<string> maxResult = new Maximum.GenricMaximum<string>(stringArray);
            string actual = maxResult.MaxValue();
            Assert.AreEqual("peach", actual);
        }

        [TestMethod]
        public void GivenStringArray_ShouldReturnMaximumString()
        {
            string[] stringArray = { "banana", "apple", "peach" ,"kiwi"};
            Maximum.GenricMaximum<string> maxResult = new Maximum.GenricMaximum<string>(stringArray);
            string actual = maxResult.MaxValue();
            Assert.AreEqual("peach", actual);
        }
    }
}
