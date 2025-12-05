using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgo
{
    internal class Bubblesort
    {
        private IList<int> listToSort;
        public Bubblesort(IList<int> listToSort)
        {
            this.listToSort = listToSort;

        }

        public IList<int> Sorti() {
            var swapped = true;
            var length = listToSort.Count;

            while(swapped) 
            {
                swapped = false;
                for (var i = 0; i < listToSort.Count - 1; i++)
                {
                    if (listToSort[i] > listToSort[i + 1])
                    {
                        var temp = listToSort[i + 1];
                        listToSort[i + 1] = listToSort[i];
                        listToSort[i] = temp;
                        swapped = true;

                       
                    }
                }
                length--; // optimalizujeme aby sme mali kratsiu dobu vykonu - od konca su stale zosortovane - takze o ten krok skracujeme cyklus
            }
            return listToSort;

            }
    } 
}
