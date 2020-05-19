using System;
using Xunit;

namespace My.Linq.Test
{
    public class LinqExtensions
    {
        [Fact(DisplayName = "Where of array of numbers, with the filter: item < 5")]
        public void WhereOfArrayOfNumbers()
        {
            var myListOfNumbers = new[] { 1, 2, 3, 4 ,5 , 6, 7, 8, 9 };

            var myResultAfterFilter = myListOfNumbers.Where(i => i <= 5);

            var myListOfExpectNumbers = new[] { 1, 2, 3, 4, 5 };
            Assert.Equal(myListOfExpectNumbers, myResultAfterFilter);
        }

        [Fact(DisplayName = "Any of empty array, with no filter")]
        public void AnyOfEmptyArray()
        {
            var myListOfNumbers = new int[] {};

            var myResult = myListOfNumbers.Any();

            Assert.False(myResult);
        }

        [Fact(DisplayName = "Any of array of numbers, with no filter")]
        public void AnyOfArrayOfNumbers()
        {
            var myListOfNumbers = new[] { 1 };

            var myResult = myListOfNumbers.Any();

            Assert.True(myResult);
        }

        [Fact(DisplayName = "Any of array of numbers, with filter: item < 5")]
        public void AnyOfArrayOfNumbersWithFilterLessThenFive()
        {
            var myListOfNumbers = new[] { 5, 6, 7 };

            var myResult = myListOfNumbers.Any(i => i < 5);

            Assert.False(myResult);
        }

        [Fact(DisplayName = "Any of array of numbers, with filter: item < 5")]
        public void AnyOfArrayOfNumbersWithFilterMoreThenFive()
        {
            var myListOfNumbers = new[] { 5, 6, 7 };

            var myResult = myListOfNumbers.Any(i => i > 5);

            Assert.True(myResult);
        }
    }
}
