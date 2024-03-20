class QuickSortProgram
{
    static void Main()
    {
        int[] array = { 5, 4, 10, 7, 16, 20, 4, 0, 0, 9 };
        Sort(ref array);
        Console.WriteLine(string.Join(", ", array));
    }
    public static void QuickSort(int[] array, int left, int right)
    {
        if (left < right)
        {
            int pivotIndex = Partition(array, left, right);
            QuickSort(array, left, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, right);
        }
    }

    private static int Partition(int[] array, int left, int right)
    {
        int pivot = array[right];
        int i = left - 1;
        for (int j = left; j < right; j++)
        {
            if (array[j] <= pivot)
            {
                i++;
                Swap(ref array[i], ref array[j]);
            }
        }
        Swap(ref array[i + 1], ref array[right]);
        return i + 1;
    }

    private static void Swap(ref int first, ref int second)
    {
        int temp = first;
        first = second;
        second = temp;
    }

    public static void Sort(ref int[] array) => QuickSort(array, 0, array.Length - 1);
}