using WebApiRest.Domain;
using Xunit;

namespace WebApiRestTest.Domain
{
public class CalculatorIvaEcTest
    {
        [Fact]
        public void getTax1_AmountPositive_Value()
        {
            //Arrange
            var amount = 1200;
            var valueExpected = 120;

            //Act
            ICalculatorIva caliva = new CalculatorIvaEc();
            var valueResult = caliva.getTax1(amount);

            //Assert
            Assert.Equal(valueExpected, valueResult);
        }

        [Fact]
        public void getTax1_AmountNegative_Xero()
        {
            //Arrange
            var amount = -950;
            var valueExpected = 0;

            //Act
            ICalculatorIva caliva = new CalculatorIvaEc();
            var valueResult = caliva.getTax1(amount);

            //Assert
            Assert.Equal(valueExpected, valueResult);
        }

        [Fact]
        public void getTax2_AmountPositive_Value()
        {
            //Arrange
            var amount = 1200;
            var valueExpected = 600;

            //Act
            ICalculatorIva caliva = new CalculatorIvaEc();
            var valueResult = caliva.getTax2(amount);

            //Assert
            Assert.Equal(valueExpected, valueResult);
        }

        [Fact]
        public void getTax2_AmountNegative_Xero()
        {
            //Arrange
            var amount = -10;
            var valueExpected = 0;

            //Act
            ICalculatorIva caliva = new CalculatorIvaEc();
            var valueResult = caliva.getTax2(amount);

            //Assert
            Assert.Equal(valueExpected, valueResult);
        }
    }
}