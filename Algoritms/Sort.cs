namespace Algoritms
{
    public class Sort
    {
        public static int[] SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int smallest = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[smallest]) smallest = j;
                }
                (array[smallest], array[i]) = (array[i], array[smallest]);
            }
            return array;
        }

        public static int[] InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int key = array[i];
                int j = i - 1;
                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = key;
            }
            return array;
        }




        public static void MergeSort(int[] array, int start, int end)
        {
            if (start >= end) return;
            else
            {
                double d = (start + end) / 2;
                int middle = (int)Math.Round(d, MidpointRounding.ToZero);
                MergeSort(array, start, middle);
                MergeSort(array, middle + 1, end);
                Merge(array, start, middle, end);
            }

        }

        private static void Merge(int[] array, int start, int middle, int end)
        {
            int n1 = middle - start + 1;
            int n2 = end - middle;
            var arrayB = new int[n1 + 1];
            var arrayC = new int[n2 + 1];
            for (int i = 0; i <= arrayB.Length - 2; i++)
            {
                arrayB[i] = array[start + i];
            }
            for (int i = 0; i <= arrayC.Length - 2; i++)
            {
                arrayC[i] = array[middle + 1 + i];
            }

            arrayB[^1] = Int32.MaxValue;
            arrayC[^1] = Int32.MaxValue;
            int s = 0;
            int t = 0;

            for (int i = start; i <= end; i++)
            {
                if (arrayB[s] <= arrayC[t])
                {
                    array[i] = arrayB[s];
                    s++;
                }
                else
                {
                    array[i] = arrayC[t];
                    t++;
                }
            }
        }
    }
}
