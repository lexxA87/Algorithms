using Algoritms;

namespace SortTests
{

    [TestClass]
    public class SelectionSortTest
    {

        static void Test(int result, int[] array, int index = 0)
        {
            var sortArr = Sort.SelectionSort(array);
            Assert.AreEqual(result, sortArr[index]);
        }

        [TestMethod]
        public void ExpectedElementOfSortAray()
        {
            int[] array = new int[] { 56, 1, 3, 5, 3, 0, 9, 10, 2, 4, 42 };
            Test(0, array);
            Test(56, array, 10);
            Test(1, array, 1);
        }
    }

    [TestClass]
    public class InsertionSortTest
    {
        static void Test(int result, int[] array, int index = 0)
        {
            var sortArr = Sort.InsertionSort(array);
            Assert.AreEqual(result, sortArr[index]);
        }
        [TestMethod]
        public void ExpectedElementOfSortAray()
        {
            int[] array = new int[] { 56, 1, 3, 5, 3, 0, 9, 10, 2, 4, 42 };
            Test(0, array);
            Test(56, array, 10);
            Test(1, array, 1);
        }
    }

}
