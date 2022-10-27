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
        public void TestMethod1()
        {
            Test(new int[] { 1, 3, 5, 3, 0, 9 }, 5, 2);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Test(new int[] { 1, 3, 5, 3, 0, 9 }, 9, 5);
        }
        [TestMethod]
        public void TestMethod3()
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
        public void TestMethod1()
        {
            Test(new int[] { 1, 3, 5, 3, 0, 9 }, 5, 2);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Test(new int[] { 1, 3, 5, 3, 0, 9 }, 9, 5);
        }
        [TestMethod]
        public void TestMethod3()
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
        public void TestMethod1()
        {
            Test(new int[] { 1, 3, 5, 3, 0, 9 }, 5, 2);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Test(new int[] { 1, 3, 5, 3, 0, 9 }, 9, 5);
        }
        [TestMethod]
        public void TestMethod3()
        {
            Test(new int[] { 1, 3, 5, 3, 0, 9 }, 7, -1);
        }
    }
}