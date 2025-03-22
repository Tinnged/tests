using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;

namespace UI.WebMatricula2C2024.Logica
{
    public class LnIncidencia
    {
        LnConsumoAPI lnConsumoAPI;

        public LnIncidencia()
        {
            lnConsumoAPI = new LnConsumoAPI();
        }

        public async Task<API.Dto.Incidencias.Salida.VerTodosIncidencias> VerTodosIncidencias(API.Dto.Incidencias.Entrada.VerTodosIncidencias pDatos, string token)
        {
            string encabezado = "Incidencias/VerTodosIncidencias";
            string cuerpo = JsonConvert.SerializeObject(pDatos);

            string respuesta = await lnConsumoAPI.ConsumirAPI(encabezado, cuerpo, token);

            return JsonConvert.DeserializeObject<API.Dto.Incidencias.Salida.VerTodosIncidencias>(respuesta);
        }


        public async Task<API.Dto.Incidencias.Salida.VerDetalleIncidencia> VerDetalleIncidencia(API.Dto.Incidencias.Entrada.VerDetalleIncidencia pDatos, string token)
        {
            string encabezado = "Incidencias/VerDetalleIncidencia";
            string cuerpo = JsonConvert.SerializeObject(pDatos);

            string respuesta = await lnConsumoAPI.ConsumirAPI(encabezado, cuerpo, token);

            return JsonConvert.DeserializeObject<API.Dto.Incidencias.Salida.VerDetalleIncidencia>(respuesta);
        }

        public async Task<API.Dto.Incidencias.Salida.AgregarIncidencia> AgregarIncidencia(API.Dto.Incidencias.Entrada.AgregarIncidencia pDatos, string token)
        {
            string encabezado = "Incidencias/AgregarIncidencia";
            string cuerpo = JsonConvert.SerializeObject(pDatos);

            string respuesta = await lnConsumoAPI.ConsumirAPI(encabezado, cuerpo, token);

            return JsonConvert.DeserializeObject<API.Dto.Incidencias.Salida.AgregarIncidencia>(respuesta);
        }

        public async Task<API.Dto.Incidencias.Salida.EditarIncidencia> EditarIncidencia(API.Dto.Incidencias.Entrada.EditarIncidencia pDatos, string token)
        {
            string encabezado = "Incidencias/EditarIncidencia";
            string cuerpo = JsonConvert.SerializeObject(pDatos);

            string respuesta = await lnConsumoAPI.ConsumirAPI(encabezado, cuerpo, token);

            return JsonConvert.DeserializeObject<API.Dto.Incidencias.Salida.EditarIncidencia>(respuesta);
        }

        public async Task<API.Dto.Incidencias.Salida.EliminarIncidencia> EliminarIncidencia(API.Dto.Incidencias.Entrada.EliminarIncidencia pDatos, string token)
        {
            string encabezado = "Incidencias/EliminarIncidencia";
            string cuerpo = JsonConvert.SerializeObject(pDatos);

            string respuesta = await lnConsumoAPI.ConsumirAPI(encabezado, cuerpo, token);

            return JsonConvert.DeserializeObject<API.Dto.Incidencias.Salida.EliminarIncidencia>(respuesta);
        }
    }
}
