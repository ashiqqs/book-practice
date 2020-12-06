using System;
using Xunit;
using CalculatorLib;

namespace CalculatorLibUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test4()
        {
            //Arrange
            int a = 4;
            string expected = "2x2";
            var calc = new Calculator();

            //Act
            string actual = calc.PrimeFactor(a);

            //Assert
            Assert.Equal(expected,actual);

        }
        [Fact]
        public void Tes7()
        {
            //Arrange
            int a = 7;
            string expected = "7";
            var calc = new Calculator();

            //Act
            string actual = calc.PrimeFactor(a);

            //Assert
            Assert.Equal(expected,actual);

        }
        [Fact]
        public void Tes30()
        {
            //Arrange
            int a = 30;
            string expected = "5x3x2";
            var calc = new Calculator();

            //Act
            string actual = calc.PrimeFactor(a);

            //Assert
            Assert.Equal(expected,actual);

        }
        [Fact]
        public void Tes40()
        {
            //Arrange
            int a = 40;
            string expected = "5x2x2x2";
            var calc = new Calculator();

            //Act
            string actual = calc.PrimeFactor(a);

            //Assert
            Assert.Equal(expected,actual);

        }
        [Fact]
        public void Tes50()
        {
            //Arrange
            int a = 50;
            string expected = "5x5x2";
            var calc = new Calculator();

            //Act
            string actual = calc.PrimeFactor(a);

            //Assert
            Assert.Equal(expected,actual);

        }
    }
}
