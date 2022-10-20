namespace WebApiRest.Domain
{
  public class CalculatorIvaCo : ICalculatorIva
  {
    public double getTax1(double amountTotal)
    {
      if (amountTotal < 0)
        return 0;

      return amountTotal * 0.19;
    }

    public double getTax2(double amountTotal)
    {
      if (amountTotal < 0)
        return 0;

      return amountTotal * 0.23;
    }
  }
}