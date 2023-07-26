using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anam.BoletasAduanales._2.Modelos.Modelos
{
    public class AnamConstantes
    {
        public class Comunes
        {
            public const string CadenaConexion = "CadenaConexion";
            public const string RutaPlantillas = "RutaPlantillas";
            public const string IvaBoletas = "IvaBoletas";
        }

        public class ApiBoletas
        {
            public const string RutaImagenes = "RutaImagenes";
            public class Acciones
            {
                public const string GetBoletasAduanalesForma = "BoletasAduanalesImpuestos/GetBoletasAduanalesForma";
            }
        }
        public class SitioBoletas
        {
            public const string ApiProtegida = "ApiProtegida";
        }
    }
}
