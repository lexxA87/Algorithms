namespace Algoritms
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Yooo!");
            var arr = new int[] { 1, 3, 5, 3, 0, 9 };
            var arr2 = new int[] { 1, 3, 5, 6, 10, 15 };
            //Console.WriteLine(LinearSearch.SimpleLinearSearch(arr, 5));
            //Console.WriteLine(LinearSearch.BetterLinearSearch(arr, 7));
            //Console.WriteLine(LinearSearch.SentinelLinearSearch(arr, 3));
            //Console.WriteLine(LinearSearch.Factorial(10));
            //Console.WriteLine(LinearSearch.RecursiveLinearSearch(arr, 7));
            Console.WriteLine(BinarySearchs.BinarySearch(arr2, 1));
            Console.WriteLine(BinarySearchs.RecursiveBinarySearch(arr2, 42, 0, arr2.Length - 1));
        }
    }
}
