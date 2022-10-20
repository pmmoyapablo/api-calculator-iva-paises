namespace WebApiRest.Domain
{
    public class CalculatorIvaNull : ICalculatorIva
    {
        public double getTax1(double amountTotal)
        {
            return 0;
        }

        public double getTax2(double amountTotal)
        {
            return 0;
        }
    }
}