using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    internal class Mergesort
    {
        public static int[] MergeSort(int[] array)
        {
            var lenght = array.Length;
            if (lenght == 1)
            {
                return array;
            }
            else
            {
                var middlepoint = lenght / 2;

                int[] left = array[0..middlepoint];
                int[] right = array[middlepoint..];

                left = MergeSort(left);
                right = MergeSort(right);

                return Sorting(left, right);

            }
            
        }

        private static int[] Sorting(int[] left, int[]right)
        {
            int[] sorted = new int[left.Length + right.Length];
            int i = 0;
            int j = 0;
            int s = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                {
                    sorted[s++] = left[i++];
                }
                else
                {
                    sorted[s++] = right[j++];
                }
            }

            while (i < left.Length)
            {
                sorted[s++] = left[i++];
            }

            while (j < right.Length)
            {
                sorted[s++] = right[j++];
            }

            return sorted;
        }

    }
}
