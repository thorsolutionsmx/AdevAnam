using Anam.BoletasAduanales._2.Modelos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anam.BoletasAduanales._2.Modelos.Modelos
{
    public class CatalogoIva : ICatalogo
    {
        public int  Id { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public decimal IvaPorcentaje { get; set; }

        public bool EsExento { get; set; }

    }
}
