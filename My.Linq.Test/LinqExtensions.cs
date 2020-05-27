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

        [Fact(DisplayName = "Take two items from array of numbers")]
        public void TakeTwoFromArrayOfNumbers()
        {
            var myListOfNumbers = new[] { 1, 2, 3, 4, 5, 6, 7 };

            var myResult = myListOfNumbers.Take(2);

            var myListOfExpectNumbers = new[] { 1, 2 };
            Assert.Equal(myListOfExpectNumbers, myResult);
        }

        [Fact(DisplayName = "Take zero items from array of numbers")]
        public void TakeZeroFromArrayOfNumbers()
        {
            var myListOfNumbers = new[] { 1, 2, 3, 4, 5, 6, 7 };

            var myResult = myListOfNumbers.Take(0);

            Assert.Empty(myResult);
        }

        [Fact(DisplayName = "Take three items from array of strings")]
        public void TakeThreeFromArrayOfStrings()
        {
            var myListOfStrings = new[] { "A", "B", "C", "D", "E" };

            var myResult = myListOfStrings.Take(3);

            var myListOfExpectStrings = new[] { "A", "B", "C" };
            Assert.Equal(myListOfExpectStrings, myResult);
        }
    }
}
