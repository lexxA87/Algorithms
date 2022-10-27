
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestLinearSearch
{
    [TestClass]
    public class UnitTest1
    {
        void Test(int[] array, int number)
        {
            Assert.AreEqual(array.Length, number);
        }

        [TestMethod]
        public void TestMethod1()
        {
            Test(new int[] { 1, 2 }, 1);
        }
    }
}
