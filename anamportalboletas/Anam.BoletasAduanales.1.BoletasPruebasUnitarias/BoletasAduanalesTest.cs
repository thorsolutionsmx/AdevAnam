using Anam.BoletasAduanales._2.Modelos.Interfaces;
using Anam.BoletasAduanales._2.Modelos.Modelos;
using Anam.BoletasAduanales._3.LogicaOperaciones;
using Anam.BoletasAduanales._4.BoletasApi.Controllers;
using Microsoft.VisualStudio.TestPlatform.Common.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using System.Reflection.Emit;


namespace Anam.BoletasAduanales._1.BoletasPruebasUnitarias
{
    [TestClass]
    public class BoletasAduanalesTest : BoletasAduanalesBaseTest
    {

        #region "Controles de la prueba"

        [ClassInitialize]
        public static void IniciaPrueba(TestContext? TestContext)
        {
            //traer archivo xml con catalogos
            //Borrar registros de la tabla op_pagos

            //       string _miruta =     TestContext?.Properties["miruta"].ToString();

        }

        [TestInitialize]
        public  void IniciaPruebaCatalogos()
        {
            //traer archivo xml con catalogos
            //Borrar registros de la tabla op_pagos
            if (TestContext?.TestName== "GetCatalogoIvaSuccessTest")
            {
            }
            else if (TestContext?.TestName == "CalcularIvaBoletaTimeTest")
            {
            }
        }



        [TestCleanup]
        public void FinalizaPruebaCatalogos()
        {
            //traer archivo xml con catalogos
            //Borrar registros de la tabla op_pagos

            if (TestContext?.TestName == "GetCatalogoIvaSuccessTest")
            {
                //Limpio el catalogo
            }
            else if (TestContext?.TestName == "CalcularIvaBoletaTimeTest")
            {
            }
        }


        [ClassCleanup]
        public static void FinalizaPrueba()
        {
            //traer archivo xml con catalogos
            //Borrar registros de la tabla op_pagos

            //       string _miruta =     TestContext?.Properties["miruta"].ToString();
        }


        #endregion


        #region "Impuestos"
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
        [TestCategory("Impuestos")]
        [DataRow(2000.00, 150.00)]
        [DataRow(1.10, 0.088)]
//        [DataRow(10001, 1000.1)]
        public void CalcularIvaBoletaSuccessTest(double MontoBoleta, double IvaEsperado)
        {
            //arrange
            decimal _MontoBoleta = (decimal)MontoBoleta;
            decimal _IvaEsperado = (decimal)IvaEsperado;
            BoletaAduanalClass _ba = new BoletaAduanalClass();
            //act
            TestContext?.WriteLine($"{DateTime.Now.ToString("yyyyMMddHHmmss")} Comienza la ejecución de la función {TestContext?.TestName}");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            decimal _Resultado = _ba.CalcularIvaBoleta(_Iva, _MontoBoleta);
            stopwatch.Stop();
            TestContext?.WriteLine($"{DateTime.Now.ToString("yyyyMMddHHmmss")} Termina la ejecución de la función {TestContext?.TestName} tiempo {stopwatch.Elapsed.TotalMilliseconds.ToString()}");


            //assert
            Assert.AreEqual(_IvaEsperado, _Resultado);
            Assert.IsTrue(_IvaEsperado == _Resultado);
        }

        [TestMethod]
        [Priority(1)]
        [ExpectedException(typeof(ArgumentException))]
        public void CalcularIvaBoletaFailTest()
        {
            //arrange
            decimal _MontoBoleta = 0.00m;
           // decimal _IvaEsperado = 160.00m;
            BoletaAduanalClass _ba = new BoletaAduanalClass();
            //act
            decimal _Resultado = _ba.CalcularIvaBoleta(_Iva, _MontoBoleta);
            //assert
        }

        [TestMethod]
        [Owner("Raúl Cisneros")]
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

        #endregion

        #region "Catalogos"

        [TestMethod]
        [TestCategory("Catalogos")]
        public void GetCatalogoIvaSuccessTest()
        {
            //arrange
            BoletaAduanalClass _ba = new BoletaAduanalClass();
            //act
                List<CatalogoIva> _res = _ba.GetCatalogoIva();
            //assert
            Assert.IsTrue(_res.Count > 0);
            CollectionAssert.AllItemsAreNotNull(_res);
            CollectionAssert.AllItemsAreInstancesOfType(_res, typeof(CatalogoIva) );
            Assert.IsTrue(((CatalogoIva)_res[0]).IvaPorcentaje >= 0);
        }





        #endregion






    }
}