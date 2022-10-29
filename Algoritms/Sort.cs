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
    }
}
