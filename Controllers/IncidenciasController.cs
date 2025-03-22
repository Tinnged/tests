using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UI.WebMatricula2C2024.Logica;

namespace UI.WebMatricula2C2024.Controllers
{
    [AllowAnonymous]
    public class IncidenciasController : Controller
    {
        LnIncidencia lnIncidencia = new LnIncidencia();

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public async Task<IActionResult> Index()
        {
            API.Dto.Incidencias.Entrada.VerTodosIncidencias parametros =
                new API.Dto.Incidencias.Entrada.VerTodosIncidencias();

            //var usuarioActual = HttpContext.Session.GetObjectFromJson<Models.Users.User>("UsuarioActual");

            var listaIncidencias = await lnIncidencia.VerTodosIncidencias(parametros, "");


            return View(listaIncidencias.ListaIncidencias);
        }

        [HttpPost]
        public async Task<JsonResult> AgregarIncidencia(API.Dto.Incidencias.Entrada.AgregarIncidencia agregarIncidencia)
        {
            //var usuarioActual = HttpContext.Session.GetObjectFromJson<Models.Users.User>("UsuarioActual");
            var codigo = await lnIncidencia.AgregarIncidencia(agregarIncidencia, "");

            if (codigo != null)
                return Json(String.Format("El Incidencia: {0} ha sido ingresado con éxito.", agregarIncidencia.Descripcion));
            else
                return Json(String.Format("El Incidencia: {0} no fue ingresado.", agregarIncidencia.Descripcion));
        }

        [HttpPost]
        public async Task<JsonResult> EditarIncidencia(API.Dto.Incidencias.Entrada.EditarIncidencia editarIncidencia)
        {
            //var usuarioActual = HttpContext.Session.GetObjectFromJson<Models.Users.User>("UsuarioActual");
            var codigo = await lnIncidencia.EditarIncidencia(editarIncidencia, "");

            if (codigo != null)
                return Json(String.Format("El Incidencia: {0} ha sido modificado con éxito.", editarIncidencia.Descripcion));
            else
                return Json(String.Format("El Incidencia: {0} no fue modificado.", editarIncidencia.Descripcion));
        }

        [HttpPost]
        public async Task<JsonResult> EliminarIncidencia(API.Dto.Incidencias.Entrada.EliminarIncidencia eliminarIncidencia)
        {
            //var usuarioActual = HttpContext.Session.GetObjectFromJson<Models.Users.User>("UsuarioActual");
            var codigo = await lnIncidencia.EliminarIncidencia(eliminarIncidencia, "");

            if (codigo != null)
                return Json(String.Format("El Incidencia: {0} ha sido eliminado con éxito.", eliminarIncidencia.IncidenciaID));
            else
                return Json(String.Format("El Incidencia: {0} no fue eliminado.", eliminarIncidencia.IncidenciaID));
        }

        [HttpPost]
        public async Task<JsonResult> VerDetalleIncidencia(API.Dto.Incidencias.Entrada.VerDetalleIncidencia verDetalleIncidencia)
        {
            //var usuarioActual = HttpContext.Session.GetObjectFromJson<Models.Users.User>("UsuarioActual");
            var respuesta = await lnIncidencia.VerDetalleIncidencia(verDetalleIncidencia, "");

            return Json(respuesta);
        }


    }
}
