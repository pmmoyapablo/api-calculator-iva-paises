namespace WebApiRest.Domain
{
  public class CalculatorIvaEc : ICalculatorIva
  {
    public double getTax1(double amountTotal)
    {
      if (amountTotal < 0)
        return 0;

      return amountTotal * 0.1;
    }

    public double getTax2(double amountTotal)
    {
      if (amountTotal < 0)
        return 0;

      return amountTotal * 0.5;
    }
  }
}