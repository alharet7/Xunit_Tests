using SimpleCalculatorApp;

namespace SimpleCalculatorAppTests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_ShouldReturnCorrectSum()
        {
            // Arrange
            var calculator = new Calculator();
            int a = 5;
            int b = 3;

            // Act
            int result = calculator.Add(a, b);

            // Assert
            Assert.Equal(8, result);
        }

        [Fact]
        public void Subtract_Test()
        {
            //Arrange
            var calculator = new Calculator();
            int a = 10;
            int b = 5;

            //Act
            int result = calculator.Subtract(a, b);

            //Assert
            Assert.Equal(5,result);
        }

        [Fact]
        public void Divide_Test()
        { 
            //Arrange
            var calculator = new Calculator();
            int a = 10;
            int b = 0;
            //Act & Assert
            Assert.Throws<ArgumentException>(() => calculator.Divide(a,b));
        }
    }
}