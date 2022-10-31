namespace Algoritms
{
    public class CountingSort
    {
        static int[] CountKeysEqual(int[] array, int arrayLength, int range)
        {
            int[] equal = new int[range + 1];
            for (int i = 0; i < arrayLength; i++)
            {
                int key = array[i];
                equal[key]++;
            }
            return equal;
        }

        static int[] CountKeysLess(int[] equal, int range)
        {
            var less = new int[range + 1];
            for (int i = 1; i <= range; i++)
            {
                less[i] = less[i - 1] + equal[i - 1];
            }
            return less;
        }

        static int[] Rearrange(int[] array, int[] less, int arrayLength, int range)
        {
            var arrayB = new int[arrayLength];
            var next = new int[range + 1];

            for (int i = 0; i <= range; i++)
            {
                next[i] = less[i];
            }

            for (int i = 0; i < arrayLength; i++)
            {
                int key = array[i];
                int index = next[key];
                arrayB[index] = array[i];
                next[key]++;
            }

            return arrayB;
        }

        public static int[] Sort(int[] array, int arrayLength, int range)
        {
            var equal = CountKeysEqual(array, arrayLength, range);
            var less = CountKeysLess(equal, range);
            var resultArray = Rearrange(array, less, arrayLength, range);
            return resultArray;
        }
    }
}
