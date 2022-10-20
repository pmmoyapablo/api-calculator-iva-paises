namespace WebApiRest.Domain
{
  public class CalculatorIvaPa : ICalculatorIva
  {
    public double getTax1(double amountTotal)
    {
      if(amountTotal < 0)
        return 0;

      return amountTotal * 0.10;
    }

    public double getTax2(double amountTotal)
    {
      if (amountTotal < 0)
        return 0;

      return amountTotal * 0.15;
    }
  }
}