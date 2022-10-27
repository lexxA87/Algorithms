namespace Algoritms
{
    public class Program
    {

        public static int LinearSearch(int[] array, int number)
        {
            int index = -1;
            for (var i = 0; i < array.Length; i++)
            {
                if (array[i] == number) index = i;
            }
            return index;
        }

        public static int BetterLinearSearch(int[] array, int number)
        {
            int index = -1;
            for (var i = 0; i < array.Length; i++)
            {
                if (array[i] == number) return i;
            }
            return index;
        }

        public static int SentinelLinearSearch(int[] array, int number)
        {
            int i = 0;
            int last = array[^1];
            array[^1] = number;
            while (array[i] != number) i++;
            array[^1] = last;
            if (i < array.Length - 1 || array[^1] == number) return i;
            else return -1;
        }

        public static void Main()
        {
            Console.WriteLine("Yooo!");
            var arr = new int[] { 1, 3, 5, 3, 0, 9 };
            Console.WriteLine(LinearSearch(arr, 5));
            Console.WriteLine(BetterLinearSearch(arr, 7));
            Console.WriteLine(SentinelLinearSearch(arr, 3));
        }
    }
}
