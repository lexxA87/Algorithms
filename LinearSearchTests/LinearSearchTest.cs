using Algoritms;

namespace LinearSearchTests
{
    [TestClass]
    public class LinearSearchTest
    {
        static void Test(int[] array, int number, int result)
        {
            Assert.AreEqual(Program.LinearSearch(array, number), result);
        }

        [TestMethod]
        public void ExpectedTwo()
        {
            Test(new int[] { 1, 3, 5, 3, 0, 9 }, 5, 2);
        }
        [TestMethod]
        public void ExpectedFive()
        {
            Test(new int[] { 1, 3, 5, 3, 0, 9 }, 9, 5);
        }
        [TestMethod]
        public void ExpectedNotFound()
        {
            Test(new int[] { 1, 3, 5, 3, 0, 9 }, 7, -1);
        }
    }

    [TestClass]
    public class BetterLinearSearchTest
    {
        static void Test(int[] array, int number, int result)
        {
            Assert.AreEqual(Program.BetterLinearSearch(array, number), result);
        }

        [TestMethod]
        public void ExpectedTwo()
        {
            Test(new int[] { 1, 3, 5, 3, 0, 9 }, 5, 2);
        }
        [TestMethod]
        public void ExpectedFive()
        {
            Test(new int[] { 1, 3, 5, 3, 0, 9 }, 9, 5);
        }
        [TestMethod]
        public void ExpectedNotFound()
        {
            Test(new int[] { 1, 3, 5, 3, 0, 9 }, 7, -1);
        }
    }
    [TestClass]
    public class SentinelLinearSearchTest
    {
        static void Test(int[] array, int number, int result)
        {
            Assert.AreEqual(Program.SentinelLinearSearch(array, number), result);
        }

        [TestMethod]
        public void ExpectedTwo()
        {
            Test(new int[] { 1, 3, 5, 3, 0, 9 }, 5, 2);
        }
        [TestMethod]
        public void ExpectedFive()
        {
            Test(new int[] { 1, 3, 5, 3, 0, 9 }, 9, 5);
        }
        [TestMethod]
        public void ExpectedNotFound()
        {
            Test(new int[] { 1, 3, 5, 3, 0, 9 }, 7, -1);
        }
    }
    [TestClass]
    public class RecursiveLinearSearchTest
    {
        static void Test(int[] array, int number, int result)
        {
            Assert.AreEqual(Program.RecursiveLinearSearch(array, number), result);
        }

        [TestMethod]
        public void ExpectedTwo()
        {
            Test(new int[] { 1, 3, 5, 3, 0, 9 }, 5, 2);
        }
        [TestMethod]
        public void ExpectedFive()
        {
            Test(new int[] { 1, 3, 5, 3, 0, 9 }, 9, 5);
        }
        [TestMethod]
        public void ExpectedNotFound()
        {
            Test(new int[] { 1, 3, 5, 3, 0, 9 }, 7, -1);
        }
    }

    [TestClass]
    public class FactorialTest
    {
        static void Test(int n, int result)
        {
            Assert.AreEqual(Program.Factorial(n), result);
        }
        [TestMethod]
        public void ExpectedResult0()
        {
            Test(5, 120);
        }
        [TestMethod]
        public void ExpectedResult1()
        {
            Test(0, 1);
        }
    }
}