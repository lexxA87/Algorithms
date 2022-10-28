namespace Algoritms
{
    public class LinearSearch
    {
        public static int SimpleLinearSearch(int[] array, int number)
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

        public static int RecursiveLinearSearch(int[] array, int number, int i = 0)
        {

            if (i > array.Length - 1) return -1;
            else if (array[i] == number) return i;
            else return RecursiveLinearSearch(array, number, i + 1);
        }

        public static int Factorial(int n)
        {
            if (n == 0) return 1;
            else return n * Factorial(n - 1);
        }
    }
}
