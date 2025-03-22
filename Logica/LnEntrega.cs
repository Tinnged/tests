using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;

namespace UI.WebMatricula2C2024.Logica
{
    public class LnEntrega
    {
        LnConsumoAPI lnConsumoAPI;

        public LnEntrega()
        {
            lnConsumoAPI = new LnConsumoAPI();
        }

        public async Task<API.Dto.Entregas.Salida.VerTodosEntregas> VerTodosEntregas(API.Dto.Entregas.Entrada.VerTodosEntregas pDatos, string token)
        {
            string encabezado = "Entregas/VerTodosEntregas";
            string cuerpo = JsonConvert.SerializeObject(pDatos);

            string respuesta = await lnConsumoAPI.ConsumirAPI(encabezado, cuerpo, token);

            return JsonConvert.DeserializeObject<API.Dto.Entregas.Salida.VerTodosEntregas>(respuesta);
        }


        public async Task<API.Dto.Entregas.Salida.VerDetalleEntrega> VerDetalleEntrega(API.Dto.Entregas.Entrada.VerDetalleEntrega pDatos, string token)
        {
            string encabezado = "Entregas/VerDetalleEntrega";
            string cuerpo = JsonConvert.SerializeObject(pDatos);

            string respuesta = await lnConsumoAPI.ConsumirAPI(encabezado, cuerpo, token);

            return JsonConvert.DeserializeObject<API.Dto.Entregas.Salida.VerDetalleEntrega>(respuesta);
        }

        public async Task<API.Dto.Entregas.Salida.AgregarEntrega> AgregarEntrega(API.Dto.Entregas.Entrada.AgregarEntrega pDatos, string token)
        {
            string encabezado = "Entregas/AgregarEntrega";
            string cuerpo = JsonConvert.SerializeObject(pDatos);

            string respuesta = await lnConsumoAPI.ConsumirAPI(encabezado, cuerpo, token);

            return JsonConvert.DeserializeObject<API.Dto.Entregas.Salida.AgregarEntrega>(respuesta);
        }

        public async Task<API.Dto.Entregas.Salida.EditarEntrega> EditarEntrega(API.Dto.Entregas.Entrada.EditarEntrega pDatos, string token)
        {
            string encabezado = "Entregas/EditarEntrega";
            string cuerpo = JsonConvert.SerializeObject(pDatos);

            string respuesta = await lnConsumoAPI.ConsumirAPI(encabezado, cuerpo, token);

            return JsonConvert.DeserializeObject<API.Dto.Entregas.Salida.EditarEntrega>(respuesta);
        }

        public async Task<API.Dto.Entregas.Salida.EliminarEntrega> EliminarEntrega(API.Dto.Entregas.Entrada.EliminarEntrega pDatos, string token)
        {
            string encabezado = "Entregas/EliminarEntrega";
            string cuerpo = JsonConvert.SerializeObject(pDatos);

            string respuesta = await lnConsumoAPI.ConsumirAPI(encabezado, cuerpo, token);

            return JsonConvert.DeserializeObject<API.Dto.Entregas.Salida.EliminarEntrega>(respuesta);
        }
    }
}
