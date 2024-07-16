using SimpleCalculatorApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculatorAppTests
{
    public class FizzBuzzTests
    {
        [Theory]
        [InlineData(15, "FizzBuzz")]
        [InlineData(3, "Fizz")]
        [InlineData(5, "Buzz")]
        [InlineData(4, "4")]
        public void FizzBuzzTest(int number, string expected)
        {
            //Arrange
            var fizzBuzz = new FizzBuzz();

            //Act
            var result = fizzBuzz.Generate(number);

            //Assert
            Assert.Equal(expected, result);
        }

    }
}
