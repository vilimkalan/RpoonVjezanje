using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Strategy.Classes
{
    abstract class SearchStrategy
    {
        public abstract int Search(double[] array, double value);
    }
}
