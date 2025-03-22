using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UI.WebMatricula2C2024.Logica;

namespace UI.WebMatricula2C2024.Controllers
{
    [AllowAnonymous]
    public class UsuariosController : Controller
    {
        LnUsuario lnUsuario = new LnUsuario();

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public async Task<IActionResult> Index()
        {
            API.Dto.Usuarios.Entrada.VerTodosUsuarios parametros =
                new API.Dto.Usuarios.Entrada.VerTodosUsuarios();

            //var usuarioActual = HttpContext.Session.GetObjectFromJson<Models.Users.User>("UsuarioActual");

            var listaUsuarios = await lnUsuario.VerTodosUsuarios(parametros, "");


            return View(listaUsuarios.ListaUsuarios);
        }

        [HttpPost]
        public async Task<JsonResult> AgregarUsuario(API.Dto.Usuarios.Entrada.AgregarUsuario agregarUsuario)
        {
            //var usuarioActual = HttpContext.Session.GetObjectFromJson<Models.Users.User>("UsuarioActual");
            var codigo = await lnUsuario.AgregarUsuario(agregarUsuario, "");

            if (codigo != null)
                return Json(String.Format("El Usuario: {0} ha sido ingresado con éxito.", agregarUsuario.NombreCompleto));
            else
                return Json(String.Format("El Usuario: {0} no fue ingresado.", agregarUsuario.NombreCompleto));
        }

        [HttpPost]
        public async Task<JsonResult> EditarUsuario(API.Dto.Usuarios.Entrada.EditarUsuario editarUsuario)
        {
            //var usuarioActual = HttpContext.Session.GetObjectFromJson<Models.Users.User>("UsuarioActual");
            var codigo = await lnUsuario.EditarUsuario(editarUsuario, "");

            if (codigo != null)
                return Json(String.Format("El Usuario: {0} ha sido modificado con éxito.", editarUsuario.NombreCompleto));
            else
                return Json(String.Format("El Usuario: {0} no fue modificado.", editarUsuario.NombreCompleto));
        }

        [HttpPost]
        public async Task<JsonResult> EliminarUsuario(API.Dto.Usuarios.Entrada.EliminarUsuario eliminarUsuario)
        {
            //var usuarioActual = HttpContext.Session.GetObjectFromJson<Models.Users.User>("UsuarioActual");
            var codigo = await lnUsuario.EliminarUsuario(eliminarUsuario, "");

            if (codigo != null)
                return Json(String.Format("El Usuario: {0} ha sido eliminado con éxito.", eliminarUsuario.UsuarioID));
            else
                return Json(String.Format("El Usuario: {0} no fue eliminado.", eliminarUsuario.UsuarioID));
        }

        [HttpPost]
        public async Task<JsonResult> VerDetalleUsuario(API.Dto.Usuarios.Entrada.VerDetalleUsuario verDetalleUsuario)
        {
            //var usuarioActual = HttpContext.Session.GetObjectFromJson<Models.Users.User>("UsuarioActual");
            var respuesta = await lnUsuario.VerDetalleUsuario(verDetalleUsuario, "");

            return Json(respuesta);
        }


        [HttpPost]
        public async Task<IActionResult> VerTodosUsuarios()
        {
            API.Dto.Usuarios.Entrada.VerTodosUsuarios parametros =
                new API.Dto.Usuarios.Entrada.VerTodosUsuarios();

            //var usuarioActual = HttpContext.Session.GetObjectFromJson<Models.Users.User>("UsuarioActual");

            var listaUsuarios = await lnUsuario.VerTodosUsuarios(parametros, "");


            return Json(listaUsuarios.ListaUsuarios);
        }

    }
}
