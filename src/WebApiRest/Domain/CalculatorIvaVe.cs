namespace WebApiRest.Domain
{
  public class CalculatorIvaVe : ICalculatorIva
  {
    public double getTax1(double amountTotal)
    {
      if(amountTotal < 0)
        return 0;

      return amountTotal * 0.12;
    }

    public double getTax2(double amountTotal)
    {
      if (amountTotal < 0)
        return 0;

      return amountTotal * 0.08;
    }
  }
}