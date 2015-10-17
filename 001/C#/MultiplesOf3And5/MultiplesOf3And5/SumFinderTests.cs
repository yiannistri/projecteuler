using Xunit;

namespace MultiplesOf3And5
{
    public class SumFinderTests
    {
        [Fact]
        public void When_max_is_10_result_is_23()
        {
            Assert.Equal(23, new SumFinder().Calculate(10, x => x % 3 == 0 || x % 5 == 0));
        }

        [Fact]
        public void When_max_is_1000_result_is_233168()
        {
            Assert.Equal(233168, new SumFinder().Calculate(1000, x => x % 3 == 0 || x % 5 == 0));
        }
    }
}
