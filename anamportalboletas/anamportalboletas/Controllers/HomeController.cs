using Anam.BoletasAduanales._2.Modelos.Modelos;
using anamportalboletas.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.Json;

namespace anamportalboletas.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IHttpClientFactory _http;

        public HomeController(ILogger<HomeController> logger, IHttpClientFactory http)
        {
            _logger = logger;
            _http = http;
        }



        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Boletas()
        {
            //mis cambios se deben reflejar en el repositorio
            return View();
        }

        public IActionResult BoletasImprime()
        {
            //mis cambios se deben reflejar en el repositorio
            return View();
        }


        //create function to validate an email

        public IActionResult Formulario()
        {
            // mis cambios ya van firmados
            return View();
        }

        public async Task<IActionResult> LlamarApi(string txtNombre)
        {
            IEnumerable<BoletaAduanalForma> ListaElementos;
            var httpClient = _http.CreateClient(AnamConstantes.SitioBoletas.ApiProtegida);
            var httpResponseMessage = await httpClient.GetAsync(AnamConstantes.ApiBoletas.Acciones.GetBoletasAduanalesForma);
            string _Respuesta = "No fue exitosa la llamada";
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                var contentStream =
                    await httpResponseMessage.Content.ReadAsStringAsync();
                ListaElementos = JsonSerializer.Deserialize<IEnumerable<BoletaAduanalForma>>(contentStream);
                _Respuesta = "<table class='table'><tHead><td>Fecha</td><td>Aduana</td><td>Monto</td><td>Iva</td></tHead><tBody>";
                if (ListaElementos != null)
                    foreach (BoletaAduanalForma _ba in ListaElementos)
                    {
                        _Respuesta += "<tr>";
                        _Respuesta += "<td>" + _ba.fecha.ToString("dd/MM/yyyy") + "</td>";
                        _Respuesta += "<td>" + _ba.aduanaName + "</td>";
                        _Respuesta += "<td align='right'>" + _ba.monto.ToString("c") + "</td>";
                        _Respuesta += "<td align='right'>" + _ba.iva.ToString("c") + "</td>";
                        _Respuesta += "</tr>";
                    }
                _Respuesta += "</tBody></table>";
            }



            ViewBag.Respuesta = _Respuesta;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}