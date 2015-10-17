using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenFibonacciNumbers
{
    public class SumFinder
    {
        public int Calculate(int max, Func<int, bool> filter)
        {
            return Fibonacci(max).Where(filter).Sum();
        }

        private IEnumerable<int> Fibonacci(int max)
        {
            int previous = 1;
            int current = 2;
            var list = new List<int> { previous, current };
            int sum = previous + current;
            while (sum <= max)
            {
                list.Add(sum);
                previous = current;
                current = sum;
                sum = previous + current;
            }
            return list.AsEnumerable();
        }
    }
}
