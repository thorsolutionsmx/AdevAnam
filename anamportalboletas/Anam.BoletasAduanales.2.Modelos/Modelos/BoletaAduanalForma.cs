using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Anam.BoletasAduanales._2.Modelos.Modelos
{
    public class BoletaAduanalForma
    {
        public int boletaNumber { get; set; }
        public string aduanaId { get; set; }
        public string aduanaName { get; set; }
        public double monto { get; set; }
        public double iva { get; set; }
        public DateTime fecha { get; set; }
    }
}




