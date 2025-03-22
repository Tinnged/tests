using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;

namespace UI.WebMatricula2C2024.Logica
{
    public class LnUsuario
    {
        LnConsumoAPI lnConsumoAPI;

        public LnUsuario()
        {
            lnConsumoAPI = new LnConsumoAPI();
        }

        public async Task<API.Dto.Usuarios.Salida.VerTodosUsuarios> VerTodosUsuarios(API.Dto.Usuarios.Entrada.VerTodosUsuarios pDatos, string token)
        {
            string encabezado = "Usuarios/VerTodosUsuarios";
            string cuerpo = JsonConvert.SerializeObject(pDatos);

            string respuesta = await lnConsumoAPI.ConsumirAPI(encabezado, cuerpo, token);

            return JsonConvert.DeserializeObject<API.Dto.Usuarios.Salida.VerTodosUsuarios>(respuesta);
        }


        public async Task<API.Dto.Usuarios.Salida.VerDetalleUsuario> VerDetalleUsuario(API.Dto.Usuarios.Entrada.VerDetalleUsuario pDatos, string token)
        {
            string encabezado = "Usuarios/VerDetalleUsuario";
            string cuerpo = JsonConvert.SerializeObject(pDatos);

            string respuesta = await lnConsumoAPI.ConsumirAPI(encabezado, cuerpo, token);

            return JsonConvert.DeserializeObject<API.Dto.Usuarios.Salida.VerDetalleUsuario>(respuesta);
        }

        public async Task<API.Dto.Usuarios.Salida.AgregarUsuario> AgregarUsuario(API.Dto.Usuarios.Entrada.AgregarUsuario pDatos, string token)
        {
            string encabezado = "Usuarios/AgregarUsuario";
            string cuerpo = JsonConvert.SerializeObject(pDatos);

            string respuesta = await lnConsumoAPI.ConsumirAPI(encabezado, cuerpo, token);

            return JsonConvert.DeserializeObject<API.Dto.Usuarios.Salida.AgregarUsuario>(respuesta);
        }

        public async Task<API.Dto.Usuarios.Salida.EditarUsuario> EditarUsuario(API.Dto.Usuarios.Entrada.EditarUsuario pDatos, string token)
        {
            string encabezado = "Usuarios/EditarUsuario";
            string cuerpo = JsonConvert.SerializeObject(pDatos);

            string respuesta = await lnConsumoAPI.ConsumirAPI(encabezado, cuerpo, token);

            return JsonConvert.DeserializeObject<API.Dto.Usuarios.Salida.EditarUsuario>(respuesta);
        }

        public async Task<API.Dto.Usuarios.Salida.EliminarUsuario> EliminarUsuario(API.Dto.Usuarios.Entrada.EliminarUsuario pDatos, string token)
        {
            string encabezado = "Usuarios/EliminarUsuario";
            string cuerpo = JsonConvert.SerializeObject(pDatos);

            string respuesta = await lnConsumoAPI.ConsumirAPI(encabezado, cuerpo, token);

            return JsonConvert.DeserializeObject<API.Dto.Usuarios.Salida.EliminarUsuario>(respuesta);
        }
    }
}
