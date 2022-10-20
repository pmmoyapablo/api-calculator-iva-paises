namespace WebApiRest.Domain
{
  public interface ICalculatorIva
  {
    double getTax1(double amountTotal);
    double getTax2(double amountTotal);
  }
}