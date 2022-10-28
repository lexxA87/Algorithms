using Algoritms;


namespace BinarySearchTests
{
    [TestClass]

    public class BinarySearchTest
    {
        static void Test(int number, int result)
        {
            int[] array = new int[] { 1, 3, 5, 6, 10, 15 };
            Assert.AreEqual(BinarySearchs.BinarySearch(array, number), result);
        }

        [TestMethod]
        public void ExpectedNotFound()
        {
            Test(7, -1);
            Test(-100, -1);
            Test(42, -1);
        }

        [TestMethod]
        public void ExpectedZero()
        {
            Test(1, 0);
        }

        [TestMethod]
        public void ExpectedSix()
        {
            Test(15, 5);
        }

        [TestMethod]
        public void ExpectedThree()
        {
            Test(6, 3);
        }

    }
}
