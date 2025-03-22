using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UI.WebMatricula2C2024.Logica;

namespace UI.WebMatricula2C2024.Controllers
{
    [AllowAnonymous]
    public class ZonasController : Controller
    {
        LnZona lnZona = new LnZona();

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public async Task<IActionResult> Index()
        {
            API.Dto.Zonas.Entrada.VerTodosZonas parametros = 
                new API.Dto.Zonas.Entrada.VerTodosZonas();

            //var usuarioActual = HttpContext.Session.GetObjectFromJson<Models.Users.User>("UsuarioActual");

            var listaZonas = await lnZona.VerTodosZonas(parametros, "");


            return View(listaZonas.ListaZonas);
        }

        [HttpPost]
        public async Task<JsonResult> AgregarZona(API.Dto.Zonas.Entrada.AgregarZona agregarZona)
        {
            //var usuarioActual = HttpContext.Session.GetObjectFromJson<Models.Users.User>("UsuarioActual");
            var codigo = await lnZona.AgregarZona(agregarZona, "");

            if (codigo != null)
                return Json(String.Format("El Zona: {0} ha sido ingresado con éxito.",agregarZona.Descripcion));
            else
                return Json(String.Format("El Zona: {0} no fue ingresado.", agregarZona.Descripcion));
        }

        [HttpPost]
        public async Task<JsonResult> EditarZona(API.Dto.Zonas.Entrada.EditarZona editarZona)
        {
            //var usuarioActual = HttpContext.Session.GetObjectFromJson<Models.Users.User>("UsuarioActual");
            var codigo = await lnZona.EditarZona(editarZona, "");

            if (codigo != null)
                return Json(String.Format("El Zona: {0} ha sido modificado con éxito.", editarZona.Descripcion));
            else
                return Json(String.Format("El Zona: {0} no fue modificado.", editarZona.Descripcion));
        }

        [HttpPost]
        public async Task<JsonResult> EliminarZona(API.Dto.Zonas.Entrada.EliminarZona eliminarZona)
        {
            //var usuarioActual = HttpContext.Session.GetObjectFromJson<Models.Users.User>("UsuarioActual");
            var codigo = await lnZona.EliminarZona(eliminarZona, "");

            if (codigo != null)
                return Json(String.Format("El Zona: {0} ha sido eliminado con éxito.", eliminarZona.ZonaID));
            else
                return Json(String.Format("El Zona: {0} no fue eliminado.", eliminarZona.ZonaID));
        }

        [HttpPost]
        public async Task<JsonResult> VerDetalleZona(API.Dto.Zonas.Entrada.VerDetalleZona verDetalleZona)
        {
            //var usuarioActual = HttpContext.Session.GetObjectFromJson<Models.Users.User>("UsuarioActual");
            var respuesta = await lnZona.VerDetalleZona(verDetalleZona, "");
            
            return Json(respuesta);
        }

        [HttpPost]
        public async Task<IActionResult> VerTodosZonas()
        {
            API.Dto.Zonas.Entrada.VerTodosZonas parametros =
                new API.Dto.Zonas.Entrada.VerTodosZonas();

            //var usuarioActual = HttpContext.Session.GetObjectFromJson<Models.Users.User>("UsuarioActual");

            var listaZonas = await lnZona.VerTodosZonas(parametros, "");


            return Json(listaZonas.ListaZonas);
        }
    }
}
