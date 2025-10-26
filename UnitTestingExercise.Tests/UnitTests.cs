using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(1, 2, 3, 6)] //My test data contributions
        [InlineData(2, 4, 6, 12)]
        [InlineData(2, 2, 2, 6)]
        
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            // Start Step 3 here:
            // Arrange
            var Calculator = new Calculator();
            
            // Act
            var actual = Calculator.Add(num1, num2, num3);

            // Assert
            Assert.Equal(expected, actual);

            // create a Calculator object


            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual

            //Assert
            //Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1,2,-1)]//Add test data <-------
        [InlineData(3,2,1)]
        [InlineData(4,4,0)]
        [InlineData(6,5,1)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var Calculator = new Calculator();

            //Act
            var actual = Calculator.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(1,1,1)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var Calculator = new Calculator();

            //Act
            var actual = Calculator.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(1,1,1)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var Calculator = new Calculator();

            //Act
            var actual = Calculator.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

    }
}
