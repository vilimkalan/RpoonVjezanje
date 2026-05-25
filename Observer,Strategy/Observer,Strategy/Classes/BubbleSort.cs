using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Strategy.Classes
{
    internal class BubbleSort: SortStrategy
    {
        public override void Sort(double[] array)
        {
            int arraySize = array.Length;
            bool swapped;

            for (int i = 0; i < arraySize - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < arraySize - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                        swapped = true;
                    }
                }
                // Ako u unutarnjoj petlji nismo napravili nijednu zamjenu, polje je već sortirano
                if (!swapped)
                {
                    break;
                }
            }
        }

    }
}
