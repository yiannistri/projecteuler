using Xunit;

namespace EvenFibonacciNumbers
{
    public class SumFinderTests
    {
        [Fact]
        public void When_values_less_than_100_result_is_44()
        {
            Assert.Equal(44, new SumFinder().Calculate(100, x => x % 2 == 0));
        }

        [Fact]
        public void When_values_less_than_4000000_result_is_4613732()
        {
            Assert.Equal(4613732, new SumFinder().Calculate(4000000, x => x % 2 == 0));
        }
    }
}
