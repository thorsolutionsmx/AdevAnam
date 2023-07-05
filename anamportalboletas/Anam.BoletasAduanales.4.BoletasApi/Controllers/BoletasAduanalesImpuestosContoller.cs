using Anam.BoletasAduanales._3.LogicaOperaciones;
using Microsoft.AspNetCore.Mvc;

namespace Anam.BoletasAduanales._4.BoletasApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class BoletasAduanalesImpuestosContoller : AnamContoladorBase
    {
        [HttpGet(Name = "GetImpuestoBoleta")]
        public decimal GetImpuestoBoleta()
        {
            BoletaAduanalClass _ba = new BoletaAduanalClass();
                decimal _res = _ba.CalcularIvaBoleta(0.08m, 100);
            return _res;
        }
    }
}
