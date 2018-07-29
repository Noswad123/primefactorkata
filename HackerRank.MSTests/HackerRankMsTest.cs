using System;
using HackerRankAlgorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.MSTests
{
    [TestClass]
    public class HackerRankMsTest
    {
        public int[] s = { 1, 2, 3, 4, 5 };
        [TestMethod]
        public void PrimeFactorsReturnsContentOfListIsInteger()
        {
            //arrange
            PrimeFactors primeFactors = new PrimeFactors();
            List<int> expectedList = new List<int>();
            //act
            expectedList.Add(5);
            var expected = expectedList;
            var actual = primeFactors.GeneratePrimeFactors(6).GetType();
            
            //compare expected and actual type
            Assert.IsTrue(actual==expected.GetType(),"an integer is not returned");
        }
        [TestMethod]
        public void PrimeFactorsReturnsListOfIntegers()
        {
            PrimeFactors primeFactors = new PrimeFactors();
            List<int> expectedList = new List<int>();
            expectedList.Add(5);
            var actual = primeFactors.GeneratePrimeFactors(11);
            Assert.IsTrue(actual.GetType() == expectedList.GetType(), "an integer is not returned");
        }
        [TestMethod]
        public void PrimeFactorsReturns3WhenInputIs3()
        {
            PrimeFactors primeFactors = new PrimeFactors();
            List<int> expectedList = new List<int>();
            var expected = 3;
            var actual = primeFactors.GeneratePrimeFactors(3)[0];
            Assert.AreEqual(actual , expected);
        }
        [TestMethod]
        public void PrimeFactorsReturns2and3WhenInputIs6()
        {
            PrimeFactors primeFactors = new PrimeFactors();
            List<int> expectedList = new List<int>();
            expectedList.Add(2);
            expectedList.Add(3);
            var expected = expectedList;
            var actual = primeFactors.GeneratePrimeFactors(6);
            Assert.IsTrue(expected.All(actual.Contains) && expected.Count == actual.Count);
        }
        [TestMethod]
        public void CheckPrimeReturnsTrueWhenInputIs2()
        {
            PrimeFactors primeFactors = new PrimeFactors();
            var expected = true;
            var actual = primeFactors.isPrime(2);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckPrimeReturnsFalseWhenInputIs6()
        {
            PrimeFactors primeFactors = new PrimeFactors();
           
            var actual = primeFactors.isPrime(4);
            Assert.IsFalse( actual);
        }
        [TestMethod]
        public void GetAllFactorsReturns2and3WhenInputIs6()
        {
            PrimeFactors primeFactors = new PrimeFactors();
            var expectedList = new List<int>();
            expectedList.Add(2);
            expectedList.Add(3);
            
            var actual = primeFactors.GetAllFactors(6);
            Assert.IsTrue(expectedList.All(actual.Contains) && expectedList.Count == actual.Count);
        }
        [TestMethod]
        public void GetAllFactorsReturns2and3and6and9WhenInputIs18()
        {
            PrimeFactors primeFactors = new PrimeFactors();
            var expectedList = new List<int> {9,6,3,2};
          
            var actual = primeFactors.GetAllFactors(18);
            Assert.IsTrue(expectedList.All(actual.Contains) && expectedList.Count == actual.Count);
        }
        [TestMethod]
        public void SolveReturns2and3WhenInputIs18()
        {
            PrimeFactors primeFactors = new PrimeFactors();
            var expectedList = new List<int> { 3, 2 };

            var actual = primeFactors.GeneratePrimeFactors(18);
            Assert.IsTrue(expectedList.All(actual.Contains) && expectedList.Count == actual.Count);
        }
        [TestMethod]
        public void SolveReturns11and3WhenInputIs297()
        {
            PrimeFactors primeFactors = new PrimeFactors();
            var expectedList = new List<int> { 3,11 };

            var actual = primeFactors.GeneratePrimeFactors(297);
            Assert.IsTrue(expectedList.All(actual.Contains) && expectedList.Count == actual.Count);
        }
    }
}
