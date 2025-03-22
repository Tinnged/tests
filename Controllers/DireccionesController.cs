using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UI.WebMatricula2C2024.Logica;

namespace UI.WebMatricula2C2024.Controllers
{
    [AllowAnonymous]
    public class DireccionesController : Controller
    {
        LnDireccion lnDireccion = new LnDireccion();

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public async Task<IActionResult> Index()
        {
            API.Dto.Direcciones.Entrada.VerTodosDirecciones parametros =
                new API.Dto.Direcciones.Entrada.VerTodosDirecciones();

            //var usuarioActual = HttpContext.Session.GetObjectFromJson<Models.Users.User>("UsuarioActual");

            var listaDirecciones = await lnDireccion.VerTodosDirecciones(parametros, "");


            return View(listaDirecciones.ListaDirecciones);
        }

        [HttpPost]
        public async Task<JsonResult> AgregarDireccion(API.Dto.Direcciones.Entrada.AgregarDireccion agregarDireccion)
        {
            //var usuarioActual = HttpContext.Session.GetObjectFromJson<Models.Users.User>("UsuarioActual");
            var codigo = await lnDireccion.AgregarDireccion(agregarDireccion, "");

            if (codigo != null)
                return Json(String.Format("El Direccion: {0} ha sido ingresado con éxito.", agregarDireccion.Numero));
            else
                return Json(String.Format("El Direccion: {0} no fue ingresado.", agregarDireccion.Numero));
        }

        [HttpPost]
        public async Task<JsonResult> EditarDireccion(API.Dto.Direcciones.Entrada.EditarDireccion editarDireccion)
        {
            //var usuarioActual = HttpContext.Session.GetObjectFromJson<Models.Users.User>("UsuarioActual");
            var codigo = await lnDireccion.EditarDireccion(editarDireccion, "");

            if (codigo != null)
                return Json(String.Format("El Direccion: {0} ha sido modificado con éxito.", editarDireccion.Numero));
            else
                return Json(String.Format("El Direccion: {0} no fue modificado.", editarDireccion.Numero));
        }

        [HttpPost]
        public async Task<JsonResult> EliminarDireccion(API.Dto.Direcciones.Entrada.EliminarDireccion eliminarDireccion)
        {
            //var usuarioActual = HttpContext.Session.GetObjectFromJson<Models.Users.User>("UsuarioActual");
            var codigo = await lnDireccion.EliminarDireccion(eliminarDireccion, "");

            if (codigo != null)
                return Json(String.Format("El Direccion: {0} ha sido eliminado con éxito.", eliminarDireccion.DireccionID));
            else
                return Json(String.Format("El Direccion: {0} no fue eliminado.", eliminarDireccion.DireccionID));
        }

        [HttpPost]
        public async Task<JsonResult> VerDetalleDireccion(API.Dto.Direcciones.Entrada.VerDetalleDireccion verDetalleDireccion)
        {
            //var usuarioActual = HttpContext.Session.GetObjectFromJson<Models.Users.User>("UsuarioActual");
            var respuesta = await lnDireccion.VerDetalleDireccion(verDetalleDireccion, "");

            return Json(respuesta);
        }


    }
}
