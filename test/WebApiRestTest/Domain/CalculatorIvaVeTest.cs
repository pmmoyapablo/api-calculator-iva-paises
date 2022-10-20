using WebApiRest.Domain;
using Xunit;

namespace WebApiRestTest.Domain
{
      public class CalculatorIvaVeTest
      {

        [Fact]
        public void getTax1_AmountPositive_Value()
        {
            //Arrange
            var amount = 1200;
            var valueExpected = 144;

            //Act
            ICalculatorIva caliva = new CalculatorIvaVe();
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
            ICalculatorIva caliva = new CalculatorIvaVe();
            var valueResult = caliva.getTax1(amount);

            //Assert
            Assert.Equal(valueExpected, valueResult);
        }

        [Fact]
        public void getTax2_AmountPositive_Value()
        {
            //Arrange
            var amount = 1200;
            var valueExpected = 96;

            //Act
            ICalculatorIva caliva = new CalculatorIvaVe();
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
            ICalculatorIva caliva = new CalculatorIvaVe();
            var valueResult = caliva.getTax2(amount);

            //Assert
            Assert.Equal(valueExpected, valueResult);
        }
    }
}