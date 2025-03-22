using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UI.WebMatricula2C2024.Logica;

namespace UI.WebMatricula2C2024.Controllers
{
    [AllowAnonymous]
    public class EntregasController : Controller
    {
        LnEntrega lnEntrega = new LnEntrega();

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public async Task<IActionResult> Index()
        {
            API.Dto.Entregas.Entrada.VerTodosEntregas parametros = 
                new API.Dto.Entregas.Entrada.VerTodosEntregas();

            //var usuarioActual = HttpContext.Session.GetObjectFromJson<Models.Users.User>("UsuarioActual");

            var listaEntregas = await lnEntrega.VerTodosEntregas(parametros, "");


            return View(listaEntregas.ListaEntregas);
        }

        [HttpPost]
        public async Task<JsonResult> AgregarEntrega(API.Dto.Entregas.Entrada.AgregarEntrega agregarEntrega)
        {
            //var usuarioActual = HttpContext.Session.GetObjectFromJson<Models.Users.User>("UsuarioActual");
            var codigo = await lnEntrega.AgregarEntrega(agregarEntrega, "");

            if (codigo != null)
                return Json("La Entrega ha sido ingresado con éxito.");
            else
                return Json("La Entrega no fue ingresado.");
        }

        [HttpPost]
        public async Task<JsonResult> EditarEntrega(API.Dto.Entregas.Entrada.EditarEntrega editarEntrega)
        {
            //var usuarioActual = HttpContext.Session.GetObjectFromJson<Models.Users.User>("UsuarioActual");
            var codigo = await lnEntrega.EditarEntrega(editarEntrega, "");

            if (codigo != null)
                return Json("La Entrega ha sido modificado con éxito.");
            else
                return Json("La Entrega no fue modificado.");
        }

        [HttpPost]
        public async Task<JsonResult> EliminarEntrega(API.Dto.Entregas.Entrada.EliminarEntrega eliminarEntrega)
        {
            //var usuarioActual = HttpContext.Session.GetObjectFromJson<Models.Users.User>("UsuarioActual");
            var codigo = await lnEntrega.EliminarEntrega(eliminarEntrega, "");

            if (codigo != null)
                return Json(String.Format("El Entrega: {0} ha sido eliminado con éxito.", eliminarEntrega.EntregaID));
            else
                return Json(String.Format("El Entrega: {0} no fue eliminado.", eliminarEntrega.EntregaID));
        }

        [HttpPost]
        public async Task<JsonResult> VerDetalleEntrega(API.Dto.Entregas.Entrada.VerDetalleEntrega verDetalleEntrega)
        {
            //var usuarioActual = HttpContext.Session.GetObjectFromJson<Models.Users.User>("UsuarioActual");
            var respuesta = await lnEntrega.VerDetalleEntrega(verDetalleEntrega, "");
            
            return Json(respuesta);
        }


    }
}
