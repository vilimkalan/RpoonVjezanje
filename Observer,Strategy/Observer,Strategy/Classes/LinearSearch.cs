using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Strategy.Classes
{
    internal class LinearSearch : SearchStrategy
    {
        public override int Search(double[] array, double value)
        {
            for (int i = 0; i < array.Length; i++)
            {
               
                if (array[i] == value)
                {
                    return i; 
                }
            }
            return -1; 
        }
    }
}
