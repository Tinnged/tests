using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UI.WebMatricula2C2024.Logica;

namespace UI.WebMatricula2C2024.Controllers
{
    [AllowAnonymous]
    public class VehiculosController : Controller
    {
        LnVehiculo lnVehiculo = new LnVehiculo();

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public async Task<IActionResult> Index()
        {
            API.Dto.Vehiculos.Entrada.VerTodosVehiculos parametros = 
                new API.Dto.Vehiculos.Entrada.VerTodosVehiculos();

            //var usuarioActual = HttpContext.Session.GetObjectFromJson<Models.Users.User>("UsuarioActual");

            var listaVehiculos = await lnVehiculo.VerTodosVehiculos(parametros, "");


            return View(listaVehiculos.ListaVehiculos);
        }

        [HttpPost]
        public async Task<JsonResult> AgregarVehiculo(API.Dto.Vehiculos.Entrada.AgregarVehiculo agregarVehiculo)
        {
            //var usuarioActual = HttpContext.Session.GetObjectFromJson<Models.Users.User>("UsuarioActual");
            var codigo = await lnVehiculo.AgregarVehiculo(agregarVehiculo, "");

            if (codigo != null)
                return Json(String.Format("El Vehiculo: {0} ha sido ingresado con éxito.",agregarVehiculo.Placa));
            else
                return Json(String.Format("El Vehiculo: {0} no fue ingresado.", agregarVehiculo.Placa));
        }

        [HttpPost]
        public async Task<JsonResult> EditarVehiculo(API.Dto.Vehiculos.Entrada.EditarVehiculo editarVehiculo)
        {
            //var usuarioActual = HttpContext.Session.GetObjectFromJson<Models.Users.User>("UsuarioActual");
            var codigo = await lnVehiculo.EditarVehiculo(editarVehiculo, "");

            if (codigo != null)
                return Json(String.Format("El Vehiculo: {0} ha sido modificado con éxito.", editarVehiculo.Placa));
            else
                return Json(String.Format("El Vehiculo: {0} no fue modificado.", editarVehiculo.Placa));
        }

        [HttpPost]
        public async Task<JsonResult> EliminarVehiculo(API.Dto.Vehiculos.Entrada.EliminarVehiculo eliminarVehiculo)
        {
            //var usuarioActual = HttpContext.Session.GetObjectFromJson<Models.Users.User>("UsuarioActual");
            var codigo = await lnVehiculo.EliminarVehiculo(eliminarVehiculo, "");

            if (codigo != null)
                return Json(String.Format("El Vehiculo: {0} ha sido eliminado con éxito.", eliminarVehiculo.VehiculoID));
            else
                return Json(String.Format("El Vehiculo: {0} no fue eliminado.", eliminarVehiculo.VehiculoID));
        }

        [HttpPost]
        public async Task<JsonResult> VerDetalleVehiculo(API.Dto.Vehiculos.Entrada.VerDetalleVehiculo verDetalleVehiculo)
        {
            //var usuarioActual = HttpContext.Session.GetObjectFromJson<Models.Users.User>("UsuarioActual");
            var respuesta = await lnVehiculo.VerDetalleVehiculo(verDetalleVehiculo, "");
            
            return Json(respuesta);
        }

        [HttpPost]
        public async Task<IActionResult> VerTodosVehiculos()
        {
            API.Dto.Vehiculos.Entrada.VerTodosVehiculos parametros =
                new API.Dto.Vehiculos.Entrada.VerTodosVehiculos();

            //var usuarioActual = HttpContext.Session.GetObjectFromJson<Models.Users.User>("UsuarioActual");

            var listaVehiculos = await lnVehiculo.VerTodosVehiculos(parametros, "");


            return Json(listaVehiculos.ListaVehiculos);
        }
    }
}
