using System;
using Xunit;

namespace LabFBW.FBWTest
{
    public class FBWTest
    {
        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        [InlineData(12)]
        public void AThreeSaysFizz(int num)
        {
            // Arrange
            // var num = 3;

            // Act
            var sut = new FizzBuzzWoof(); // system under test
            var test = sut.Convert(num);

            // Assert
            Assert.Contains("Fizz", test);
        }
        [Fact]
        public void AFiveSaysBuzz()
        {
            // Arrange
            var num = 5;

            // Act
            var sut = new FizzBuzzWoof();
            var test = sut.Convert(num);

            // Assert
            Assert.Contains("Buzz", test);
        }
        [Fact]
        public void ASevenSaysWoof()
        {
            // Arrange
            var num = 7;

            // Act
            var sut = new FizzBuzzWoof();
            var test = sut.Convert(num);

            // Assert
            Assert.Contains("Woof", test);
        }
        [Fact]
        public void ContainsThreeSaysFizz()
        {
            // Arrange
            var num = 31;

            // Act
            var sut = new FizzBuzzWoof();
            var test = sut.Convert(num);

            // Assert
            Assert.Contains("Fizz", test);
        }
        [Fact]
        public void ContainsFiveSaysBuzz()
        {
            // Arrange
            var num = 51;

            // Act
            var sut = new FizzBuzzWoof();
            var test = sut.Convert(num);

            // Assert
            Assert.Contains("Buzz", test);
        }
        [Fact]
        public void ContainsSevenSaysWoof()
        {
            // Arrange
            var num = 71;

            // Act
            var sut = new FizzBuzzWoof();
            var test = sut.Convert(num);

            // Assert
            Assert.Contains("Woof", test);
        }
        [Fact]
        public void MultipleThreeSaysFizz()
        {
            // Arrange
            var num = 9;

            // Act
            var sut = new FizzBuzzWoof();
            var test = sut.Convert(num);

            // Assert
            Assert.Contains("Fizz", test);
        }
        [Fact]
        public void MultipleFiveSaysBuzz()
        {
            // Arrange
            var num = 20;

            // Act
            var sut = new FizzBuzzWoof();
            var test = sut.Convert(num);

            // Assert
            Assert.Contains("Buzz", test);
        }
        [Fact]
        public void MultipleSevenSaysWoof()
        {
            // Arrange
            var num = 14;

            // Act
            var sut = new FizzBuzzWoof();
            var test = sut.Convert(num);

            // Assert
            Assert.Contains("Woof", test);
        }
        [Fact]
        public void MultipleThreeAndFiveSaysFizzBuzz()
        {
            // Arrange
            var num = 60;

            // Act
            var sut = new FizzBuzzWoof();
            var test = sut.Convert(num);

            // Assert
            Assert.Contains("Fizz", test);
            Assert.Contains("Buzz", test);
        }
        [Fact]
        public void MultipleFiveAndSevenSaysBuzzWoof()
        {
            // Arrange
            var num = 140;

            // Act
            var sut = new FizzBuzzWoof();
            var test = sut.Convert(num);

            // Assert
            Assert.Contains("Buzz", test);
            Assert.Contains("Woof", test);
        }
        [Fact]
        public void MultipleThreeAndSevenSaysFizzWoof()
        {
            // Arrange
            var num = 21;

            // Act
            var sut = new FizzBuzzWoof();
            var test = sut.Convert(num);

            // Assert
            Assert.Contains("Fizz", test);
            Assert.Contains("Woof", test);
        }
    }
}
