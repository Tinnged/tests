using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;

namespace UI.WebMatricula2C2024.Logica
{
    public class LnDireccion
    {
        LnConsumoAPI lnConsumoAPI;

        public LnDireccion()
        {
            lnConsumoAPI = new LnConsumoAPI();
        }

        public async Task<API.Dto.Direcciones.Salida.VerTodosDirecciones> VerTodosDirecciones(API.Dto.Direcciones.Entrada.VerTodosDirecciones pDatos, string token)
        {
            string encabezado = "Direcciones/VerTodosDirecciones";
            string cuerpo = JsonConvert.SerializeObject(pDatos);

            string respuesta = await lnConsumoAPI.ConsumirAPI(encabezado, cuerpo, token);

            return JsonConvert.DeserializeObject<API.Dto.Direcciones.Salida.VerTodosDirecciones>(respuesta);
        }


        public async Task<API.Dto.Direcciones.Salida.VerDetalleDireccion> VerDetalleDireccion(API.Dto.Direcciones.Entrada.VerDetalleDireccion pDatos, string token)
        {
            string encabezado = "Direcciones/VerDetalleDireccion";
            string cuerpo = JsonConvert.SerializeObject(pDatos);

            string respuesta = await lnConsumoAPI.ConsumirAPI(encabezado, cuerpo, token);

            return JsonConvert.DeserializeObject<API.Dto.Direcciones.Salida.VerDetalleDireccion>(respuesta);
        }

        public async Task<API.Dto.Direcciones.Salida.AgregarDireccion> AgregarDireccion(API.Dto.Direcciones.Entrada.AgregarDireccion pDatos, string token)
        {
            string encabezado = "Direcciones/AgregarDireccion";
            string cuerpo = JsonConvert.SerializeObject(pDatos);

            string respuesta = await lnConsumoAPI.ConsumirAPI(encabezado, cuerpo, token);

            return JsonConvert.DeserializeObject<API.Dto.Direcciones.Salida.AgregarDireccion>(respuesta);
        }

        public async Task<API.Dto.Direcciones.Salida.EditarDireccion> EditarDireccion(API.Dto.Direcciones.Entrada.EditarDireccion pDatos, string token)
        {
            string encabezado = "Direcciones/EditarDireccion";
            string cuerpo = JsonConvert.SerializeObject(pDatos);

            string respuesta = await lnConsumoAPI.ConsumirAPI(encabezado, cuerpo, token);

            return JsonConvert.DeserializeObject<API.Dto.Direcciones.Salida.EditarDireccion>(respuesta);
        }

        public async Task<API.Dto.Direcciones.Salida.EliminarDireccion> EliminarDireccion(API.Dto.Direcciones.Entrada.EliminarDireccion pDatos, string token)
        {
            string encabezado = "Direcciones/EliminarDireccion";
            string cuerpo = JsonConvert.SerializeObject(pDatos);

            string respuesta = await lnConsumoAPI.ConsumirAPI(encabezado, cuerpo, token);

            return JsonConvert.DeserializeObject<API.Dto.Direcciones.Salida.EliminarDireccion>(respuesta);
        }
    }
}
