namespace SortAlgo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = [4, 2, 7, 10, 6, 1, 5, 2];

            var sorter = new Bubblesort(arr);
            var sortedArr = sorter.Sorti();
            Console.WriteLine(sortedArr);
        }
    }
}
