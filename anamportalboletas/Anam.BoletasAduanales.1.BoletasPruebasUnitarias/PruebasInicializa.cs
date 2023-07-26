using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anam.BoletasAduanales._1.BoletasPruebasUnitarias
{
    [TestClass]
    public class PruebasInicializa
    {
        [AssemblyInitialize]
        public static void IniciaAmbiente(TestContext? TestContext)
        {
            //traer archivo xml con catalogos
            //Borrar registros de la tabla op_pagos
        }

        [AssemblyCleanup]
        public static void FinalizaAmbiente()
        {
            //traer archivo xml con catalogos
            //Borrar registros de la tabla op_pagos
        }
    }
}
