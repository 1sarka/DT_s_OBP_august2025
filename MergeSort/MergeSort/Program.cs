namespace MergeSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello welcome to pogram which is portfolio example of merdge-sort algorithem");

            int[] array1 = { 14, 3, 27, 9, 1, 18, 22, 5, 11, 30, 7, 16 };
            int[] array2 = { 25, 4, 18, 7, 12, 29, 1, 15, 9, 22 };
            int[] array3 = { 8, 15, 2, 29, 6, 17, 4, 23, 12, 19, 1, 27, 9, 5, 30, 11, 22, 7, 13, 16 };
            int[] array4 = { 21, 7, 14, 2, 30, 11, 5, 19, 27, 3, 9, 22, 16, 8, 1, 25, 12, 29 };

            Console.WriteLine("unsorted array: ");
            Console.WriteLine(string.Join(" ", array3));
            int[] sorted = Mergesort.MergeSort(array3);
            Console.WriteLine("sorted array:");
            Console.WriteLine(string.Join(" ", sorted));


        }
    }
}
