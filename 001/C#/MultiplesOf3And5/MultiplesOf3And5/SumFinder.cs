using System;
using System.Linq;

namespace MultiplesOf3And5
{
    public class SumFinder
    {
        public int Calculate(int max, Func<int, bool> filter)
        {
            return Enumerable.Range(0, max).Where(filter).Sum();
        }
    }
}
