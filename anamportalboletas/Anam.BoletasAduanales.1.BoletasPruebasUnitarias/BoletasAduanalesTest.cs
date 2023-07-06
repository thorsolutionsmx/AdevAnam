using Anam.BoletasAduanales._3.LogicaOperaciones;
using Anam.BoletasAduanales._4.BoletasApi.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Anam.BoletasAduanales._1.BoletasPruebasUnitarias
{
    [TestClass]
    public class BoletasAduanalesTest : BoletasAduanalesBaseTest
    {



        [TestMethod]
        [Timeout(3000)]
        public void CalcularIvaBoletaTimeTest()
        {
            //arrange
            decimal _MontoBoleta = 2000.00m;
            decimal _IvaEsperado = 160.00m;
            BoletaAduanalClass _ba = new BoletaAduanalClass();
            //act
            decimal _Resultado = _ba.CalcularIvaBoleta(_Iva, _MontoBoleta);
            //assert
            Assert.AreEqual(_IvaEsperado, _Resultado);
            Assert.IsTrue(_IvaEsperado == _Resultado);
        }


        [TestMethod]
        [Description("Prueba de calculo de IVA de una boleta aduanal caso correcto")]
        [DataRow(2000.00, 160.00)]
        public void CalcularIvaBoletaSuccessTest(double MontoBoleta, double IvaEsperado)
        {
            //arrange
            decimal _MontoBoleta = (decimal)MontoBoleta;
            decimal _IvaEsperado = (decimal)IvaEsperado;
            TestContext?.WriteLine($"Aquí empieza la prueba de {TestContext?.TestName}");
            BoletaAduanalClass _ba = new BoletaAduanalClass();
            //act
            decimal _Resultado = _ba.CalcularIvaBoleta(_Iva, _MontoBoleta);
            //assert
            Assert.AreEqual(_IvaEsperado, _Resultado);
            Assert.IsTrue(_IvaEsperado == _Resultado);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalcularIvaBoletaFailTest()
        {
            //arrange
            decimal _MontoBoleta = 0.00m;
            decimal _IvaEsperado = 160.00m;
            BoletaAduanalClass _ba = new BoletaAduanalClass();
            //act
            decimal _Resultado = _ba.CalcularIvaBoleta(_Iva, _MontoBoleta);
            //assert
        }

        [TestMethod]
        public void CalcularIvaBoletaEndsTest()
        {
            //arrange
            decimal _MontoBoleta = 1.10m;
            decimal _IvaEsperado = 0.088m;
            BoletaAduanalClass _ba = new BoletaAduanalClass();
            //act
            decimal _Resultado = _ba.CalcularIvaBoleta(_Iva, _MontoBoleta);
            //assert
            Assert.AreEqual(_IvaEsperado, _Resultado);
            Assert.IsTrue(_IvaEsperado == _Resultado);
        }

        [TestMethod]
        [Description("Prueba de calculo de IVA de una boleta aduanal en la api caso correcto")]
        public void CalcularIvaBoletaApiSuccessTest()
        {
            //arrange
            decimal _IvaEsperado = 8.00m;
            BoletasAduanalesImpuestosContoller _ba = new BoletasAduanalesImpuestosContoller();
            //act
            decimal _Resultado = _ba.GetImpuestoBoleta();
            //assert
            Assert.AreEqual(_IvaEsperado, _Resultado);
            Assert.IsTrue(_IvaEsperado == _Resultado);
        }



    }
}