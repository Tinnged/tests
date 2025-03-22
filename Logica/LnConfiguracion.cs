using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;

namespace UI.WebMatricula2C2024.Logica
{
    public class LnConfiguracion
    {
        LnConsumoAPI lnConsumoAPI;

        public LnConfiguracion()
        {
            lnConsumoAPI = new LnConsumoAPI();
        }

        public async Task<API.Dto.Configuracion.Salida.VerTodosConfiguraciones> VerTodosConfiguracion(API.Dto.Configuracion.Entrada.VerTodosConfiguraciones pDatos, string token)
        {
            string encabezado = "Configuracion/VerTodosConfiguraciones";
            string cuerpo = JsonConvert.SerializeObject(pDatos);

            string respuesta = await lnConsumoAPI.ConsumirAPI(encabezado, cuerpo, token);

            return JsonConvert.DeserializeObject<API.Dto.Configuracion.Salida.VerTodosConfiguraciones>(respuesta);
        }


        public async Task<API.Dto.Configuracion.Salida.VerDetalleConfiguracion> VerDetalleConfiguracion(API.Dto.Configuracion.Entrada.VerDetalleConfiguracion pDatos, string token)
        {
            string encabezado = "Configuracion/VerDetalleConfiguracion";
            string cuerpo = JsonConvert.SerializeObject(pDatos);

            string respuesta = await lnConsumoAPI.ConsumirAPI(encabezado, cuerpo, token);

            return JsonConvert.DeserializeObject<API.Dto.Configuracion.Salida.VerDetalleConfiguracion>(respuesta);
        }

        public async Task<API.Dto.Configuracion.Salida.AgregarConfiguracion> AgregarConfiguracion(API.Dto.Configuracion.Entrada.AgregarConfiguracion pDatos, string token)
        {
            string encabezado = "Configuracion/AgregarConfiguracion";
            string cuerpo = JsonConvert.SerializeObject(pDatos);

            string respuesta = await lnConsumoAPI.ConsumirAPI(encabezado, cuerpo, token);

            return JsonConvert.DeserializeObject<API.Dto.Configuracion.Salida.AgregarConfiguracion>(respuesta);
        }

        public async Task<API.Dto.Configuracion.Salida.EditarConfiguracion> EditarConfiguracion(API.Dto.Configuracion.Entrada.EditarConfiguracion pDatos, string token)
        {
            string encabezado = "Configuracion/EditarConfiguracion";
            string cuerpo = JsonConvert.SerializeObject(pDatos);

            string respuesta = await lnConsumoAPI.ConsumirAPI(encabezado, cuerpo, token);

            return JsonConvert.DeserializeObject<API.Dto.Configuracion.Salida.EditarConfiguracion>(respuesta);
        }

        public async Task<API.Dto.Configuracion.Salida.EliminarConfiguracion> EliminarConfiguracion(API.Dto.Configuracion.Entrada.EliminarConfiguracion pDatos, string token)
        {
            string encabezado = "Configuracion/EliminarConfiguracion";
            string cuerpo = JsonConvert.SerializeObject(pDatos);

            string respuesta = await lnConsumoAPI.ConsumirAPI(encabezado, cuerpo, token);

            return JsonConvert.DeserializeObject<API.Dto.Configuracion.Salida.EliminarConfiguracion>(respuesta);
        }
    }
}
