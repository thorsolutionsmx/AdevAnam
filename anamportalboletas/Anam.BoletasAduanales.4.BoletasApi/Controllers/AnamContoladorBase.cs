using Anam.BoletasAduanales._2.Modelos.Modelos;
using Microsoft.AspNetCore.Mvc;

namespace Anam.BoletasAduanales._4.BoletasApi.Controllers
{
    public class AnamContoladorBase : ControllerBase
    {

        protected  ConfiguracionTotal _configuracion;


        public AnamContoladorBase()
        {
                
        }

        public AnamContoladorBase(IConfiguration _config)
        {
            ConfiguracionTotal _configuracion = new ConfiguracionTotal();
            _configuracion.CadenaConexion = _config.GetValue<string>(AnamConstantes.Comunes.CadenaConexion);
            _configuracion.RutaPlantillas = _config.GetValue<string>(AnamConstantes.Comunes.RutaPlantillas);
            //            _config.Bind<ConfiguracionTotal>(_config.GetSection(AnamConstantes.Comunes.CadenaConexion), _configuracion);


        }

    }
}
