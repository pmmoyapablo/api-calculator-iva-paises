using System;
using WebApiRest.Domain;

namespace WebApiRest.Application
{
    public class ManagerMain
    {
        ICalculatorIva calculatorIva;
        public Response GetInfoIvaCoiuntry(string code, int tax, double amonut)
        {
            Response response = new Response();
            code = code.ToUpper();
            response.Country = code;
            response.Message = "Procesado";
            response.Tax = "Tasa " + tax;

            switch (code)
            {
                case "VE":
                    calculatorIva = new CalculatorIvaVe();
                    break;

                case "CO":
                    calculatorIva = new CalculatorIvaCo();
                    break;
                
                case "EC":
                    calculatorIva = new CalculatorIvaEc();
                    break;

                case "PA":
                    calculatorIva = new CalculatorIvaPa();                 
                    break;


                default:
                    calculatorIva = new CalculatorIvaNull();
                    response.Message = "Pais no disponible";
                    break;
            }

            if(tax == 1)
                response.AmounIva = calculatorIva.getTax1(amonut);
            else if (tax == 2)
                response.AmounIva = calculatorIva.getTax2(amonut);
            else
                response.Message = "Tipo de tasa no permitida";

            return response;
        }
    }
}