using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;

namespace UI.WebMatricula2C2024.Logica
{
    public class LnZona
    {
        LnConsumoAPI lnConsumoAPI;

        public LnZona()
        {
            lnConsumoAPI = new LnConsumoAPI();
        }

        public async Task<API.Dto.Zonas.Salida.VerTodosZonas> VerTodosZonas(API.Dto.Zonas.Entrada.VerTodosZonas pDatos, string token)
        {
            string encabezado = "Zonas/VerTodosZonas";
            string cuerpo = JsonConvert.SerializeObject(pDatos);

            string respuesta = await lnConsumoAPI.ConsumirAPI(encabezado, cuerpo, token);

            return JsonConvert.DeserializeObject<API.Dto.Zonas.Salida.VerTodosZonas>(respuesta);
        }


        public async Task<API.Dto.Zonas.Salida.VerDetalleZona> VerDetalleZona(API.Dto.Zonas.Entrada.VerDetalleZona pDatos, string token)
        {
            string encabezado = "Zonas/VerDetalleZona";
            string cuerpo = JsonConvert.SerializeObject(pDatos);

            string respuesta = await lnConsumoAPI.ConsumirAPI(encabezado, cuerpo, token);

            return JsonConvert.DeserializeObject<API.Dto.Zonas.Salida.VerDetalleZona>(respuesta);
        }

        public async Task<API.Dto.Zonas.Salida.AgregarZona> AgregarZona(API.Dto.Zonas.Entrada.AgregarZona pDatos, string token)
        {
            string encabezado = "Zonas/AgregarZona";
            string cuerpo = JsonConvert.SerializeObject(pDatos);

            string respuesta = await lnConsumoAPI.ConsumirAPI(encabezado, cuerpo, token);

            return JsonConvert.DeserializeObject<API.Dto.Zonas.Salida.AgregarZona>(respuesta);
        }

        public async Task<API.Dto.Zonas.Salida.EditarZona> EditarZona(API.Dto.Zonas.Entrada.EditarZona pDatos, string token)
        {
            string encabezado = "Zonas/EditarZona";
            string cuerpo = JsonConvert.SerializeObject(pDatos);

            string respuesta = await lnConsumoAPI.ConsumirAPI(encabezado, cuerpo, token);

            return JsonConvert.DeserializeObject<API.Dto.Zonas.Salida.EditarZona>(respuesta);
        }

        public async Task<API.Dto.Zonas.Salida.EliminarZona> EliminarZona(API.Dto.Zonas.Entrada.EliminarZona pDatos, string token)
        {
            string encabezado = "Zonas/EliminarZona";
            string cuerpo = JsonConvert.SerializeObject(pDatos);

            string respuesta = await lnConsumoAPI.ConsumirAPI(encabezado, cuerpo, token);

            return JsonConvert.DeserializeObject<API.Dto.Zonas.Salida.EliminarZona>(respuesta);
        }
    }
}
