namespace Algoritms
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Yooo!");
            //var arr = new int[] { 56, 1, 3, 5, 3, 0, 9, 10, 2, 4, 42 };
            //var arr2 = new int[] { 23, 7, 1, 3, 5, 6, 10, 15 };
            //var arr3 = new int[] { 1, 1, 0, 0, 0, 1, 1, 0, 1, 1, 0, 0, 1 };

            //int[][] graph = new int[14][] {
            //    new[] {2},
            //    new[] {3},
            //    new[] {3,4},
            //    new[] {5},
            //    new[] {5},
            //    new[] {6,10},
            //    new[] {7},
            //    new[] {12},
            //    new[] {9},
            //    new[] {10},
            //    new[] {11},
            //    new[] {12},
            //    new[] {13},
            //    Array.Empty<int>()
            //};
            //var list = TopologicalSort.Sort(graph);
            //foreach (var item in list) Console.Write(item + " ");

            //Console.WriteLine(LinearSearch.SimpleLinearSearch(arr, 5));
            //Console.WriteLine(LinearSearch.BetterLinearSearch(arr, 7));
            //Console.WriteLine(LinearSearch.SentinelLinearSearch(arr, 3));
            //Console.WriteLine(LinearSearch.Factorial(10));
            //Console.WriteLine(LinearSearch.RecursiveLinearSearch(arr, 7));
            //Console.WriteLine(BinarySearchs.BinarySearch(arr2, 1));
            //Console.WriteLine(BinarySearchs.RecursiveBinarySearch(arr2, 42, 0, arr2.Length - 1));
            //var arr3 = Sort.SelectionSort(arr);
            //var arr5 = Sort.InsertionSort(arr);
            //var arr4 = Sort.SelectionSort(Array.Empty<int>());
            //foreach (int i in arr3) Console.Write(i + " ");
            //foreach (int i in arr4) Console.Write(i + " ");
            //Sort.MergeSort(arr2, 0, arr2.Length - 1);
            //Sort.QuickSort(arr, 0, arr.Length - 1);
            //Sort.QuickSort(arr2, 0, arr2.Length - 1);
            //foreach (int i in arr) Console.Write(i + " ");
            //Console.WriteLine();
            //foreach (int i in arr2) Console.Write(i + " ");
            //Sort.ReallySimpleSort(arr3, arr3.Length - 1);
            //foreach (int i in arr3) Console.Write(i + " ");
            //var arrRes = CountingSort.Sort(arr, arr.Length, 56);
            //foreach (int i in arrRes) Console.Write(i + " ");
            //Console.WriteLine();

            var arrLCS = LongestCommonSubsequence.ComputeLCSTable("ABCDEFG", "EFG");
            string str = LongestCommonSubsequence.AssembleLCS("ABCDEFG", "EFG", arrLCS, 7, 3);
            Console.WriteLine(str);

            var arrCostTransform = AssembleTransformation.ComputeTransformTableCost("ACAAGC", "CCGT", -1, 1, 2, 2);
            var arrOperTransform = AssembleTransformation.ComputeTransformTableOperation("ACAAGC", "CCGT", -1, 1, 2, 2);
            var operations = AssembleTransformation.Transform(arrOperTransform, 6, 4);
            Console.WriteLine(operations);
        }
    }
}
