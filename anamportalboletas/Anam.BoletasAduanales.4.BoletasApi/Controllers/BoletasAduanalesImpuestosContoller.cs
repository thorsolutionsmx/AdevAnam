using Anam.BoletasAduanales._2.Modelos.Modelos;
using Anam.BoletasAduanales._3.LogicaOperaciones;
using Microsoft.AspNetCore.Mvc;

namespace Anam.BoletasAduanales._4.BoletasApi.Controllers
{

    [ApiController]
    [Route("[controller]/[action]")]
    public class BoletasAduanalesImpuestosController : AnamContoladorBase
    {
        [HttpGet(Name = "GetImpuestoBoleta")]
        public decimal GetImpuestoBoleta()
        {
            BoletaAduanalClass _ba = new BoletaAduanalClass();
                decimal _res = _ba.CalcularIvaBoleta(0.08m, 100);
            return _res;
        }


        [HttpGet(Name = "GetBoletasAduanalesForma")]
        public List<BoletaAduanalForma> GetBoletasAduanalesForma()
        {
            BoletaAduanalClass _ba = new BoletaAduanalClass();
            List<BoletaAduanalForma> _res = _ba.GetBoletasAduanalesForma();
            return _res;
        }
    }
}
