using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UI.WebMatricula2C2024.Logica;

namespace UI.WebMatricula2C2024.Controllers
{
    [AllowAnonymous]
    public class ConfiguracionController : Controller
    {
        LnConfiguracion lnConfiguracion = new LnConfiguracion();

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public async Task<IActionResult> Index()
        {
            API.Dto.Configuracion.Entrada.VerTodosConfiguraciones parametros = 
                new API.Dto.Configuracion.Entrada.VerTodosConfiguraciones();

            //var usuarioActual = HttpContext.Session.GetObjectFromJson<Models.Users.User>("UsuarioActual");

            var listaConfiguracion = await lnConfiguracion.VerTodosConfiguracion(parametros, "");


            return View(listaConfiguracion.ListaConfiguraciones);
        }

        [HttpPost]
        public async Task<JsonResult> AgregarConfiguracion(API.Dto.Configuracion.Entrada.AgregarConfiguracion agregarConfiguracion)
        {
            //var usuarioActual = HttpContext.Session.GetObjectFromJson<Models.Users.User>("UsuarioActual");
            var codigo = await lnConfiguracion.AgregarConfiguracion(agregarConfiguracion, "");

            if (codigo != null)
                return Json(String.Format("El Configuracion: {0} ha sido ingresado con éxito.",agregarConfiguracion.Descripcion));
            else
                return Json(String.Format("El Configuracion: {0} no fue ingresado.", agregarConfiguracion.Descripcion));
        }

        [HttpPost]
        public async Task<JsonResult> EditarConfiguracion(API.Dto.Configuracion.Entrada.EditarConfiguracion editarConfiguracion)
        {
            //var usuarioActual = HttpContext.Session.GetObjectFromJson<Models.Users.User>("UsuarioActual");
            var codigo = await lnConfiguracion.EditarConfiguracion(editarConfiguracion, "");

            if (codigo != null)
                return Json(String.Format("El Configuracion: {0} ha sido modificado con éxito.", editarConfiguracion.Descripcion));
            else
                return Json(String.Format("El Configuracion: {0} no fue modificado.", editarConfiguracion.Descripcion));
        }

        [HttpPost]
        public async Task<JsonResult> EliminarConfiguracion(API.Dto.Configuracion.Entrada.EliminarConfiguracion eliminarConfiguracion)
        {
            //var usuarioActual = HttpContext.Session.GetObjectFromJson<Models.Users.User>("UsuarioActual");
            var codigo = await lnConfiguracion.EliminarConfiguracion(eliminarConfiguracion, "");

            if (codigo != null)
                return Json(String.Format("El Configuracion: {0} ha sido eliminado con éxito.", eliminarConfiguracion.ConfigID));
            else
                return Json(String.Format("El Configuracion: {0} no fue eliminado.", eliminarConfiguracion.ConfigID));
        }

        [HttpPost]
        public async Task<JsonResult> VerDetalleConfiguracion(API.Dto.Configuracion.Entrada.VerDetalleConfiguracion verDetalleConfiguracion)
        {
            //var usuarioActual = HttpContext.Session.GetObjectFromJson<Models.Users.User>("UsuarioActual");
            var respuesta = await lnConfiguracion.VerDetalleConfiguracion(verDetalleConfiguracion, "");
            
            return Json(respuesta);
        }

    }
}
