using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anam.BoletasAduanales._3.LogicaOperaciones
{
    public class BoletaAduanalClass
    {
        // DONE: Implementar la logica de la operacion CalcularIvaBoleta
        public decimal CalcularIvaBoleta(decimal _Iva, decimal _MontoBoleta)
        {
            if (_MontoBoleta <= 1)
            {
                throw new ArgumentException("El monto de la boleta no puede ser menor o igual a 1 peso");
            }
//            System.Threading.Thread.Sleep(4000);
decimal _res = _Iva * _MontoBoleta;
            return _res;
        }
    }
}
