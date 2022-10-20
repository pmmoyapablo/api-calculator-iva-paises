using WebApiRest.Application;
using Xunit;

namespace WebApiRestTest.Application
{
    public class ManagerMainTest
    {
        private ManagerMain managerMain;

        [Fact]
        public void GetInfoIvaCoiuntry_codeInvalid_ErrorCounty()
        {
            //Arrange
            managerMain = new ManagerMain();
            var messageExpected = "Pais no disponible";

            //Act
            var response = managerMain.GetInfoIvaCoiuntry("XX", 2, 100);

            //Assert
            AssemblyTraitAttribute.Equals(messageExpected, response.Message);

        }

        [Fact]
        public void GetInfoIvaCoiuntry_codeValid_Procesado()
        {
            //Arrange
            managerMain = new ManagerMain();
            var messageExpected = "Procesado";

            //Act
            var response = managerMain.GetInfoIvaCoiuntry("PA", 1, 100);

            //Assert
            AssemblyTraitAttribute.Equals(messageExpected, response.Message);

        }

        [Fact]
        public void GetInfoIvaCoiuntry_taxTypeNoFound_TaxInvalid()
        {
            //Arrange
            managerMain = new ManagerMain();
            var messageExpected = "Tipo de tasa no permitida";

            //Act
            var response = managerMain.GetInfoIvaCoiuntry("VE", 7, 100);

            //Assert
            AssemblyTraitAttribute.Equals(messageExpected, response.Message);

        }
    }
}