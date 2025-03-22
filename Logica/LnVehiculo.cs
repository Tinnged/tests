using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;

namespace UI.WebMatricula2C2024.Logica
{
    public class LnVehiculo
    {
        LnConsumoAPI lnConsumoAPI;

        public LnVehiculo()
        {
            lnConsumoAPI = new LnConsumoAPI();
        }

        public async Task<API.Dto.Vehiculos.Salida.VerTodosVehiculos> VerTodosVehiculos(API.Dto.Vehiculos.Entrada.VerTodosVehiculos pDatos, string token)
        {
            string encabezado = "Vehiculos/VerTodosVehiculos";
            string cuerpo = JsonConvert.SerializeObject(pDatos);

            string respuesta = await lnConsumoAPI.ConsumirAPI(encabezado, cuerpo, token);

            return JsonConvert.DeserializeObject<API.Dto.Vehiculos.Salida.VerTodosVehiculos>(respuesta);
        }


        public async Task<API.Dto.Vehiculos.Salida.VerDetalleVehiculo> VerDetalleVehiculo(API.Dto.Vehiculos.Entrada.VerDetalleVehiculo pDatos, string token)
        {
            string encabezado = "Vehiculos/VerDetalleVehiculo";
            string cuerpo = JsonConvert.SerializeObject(pDatos);

            string respuesta = await lnConsumoAPI.ConsumirAPI(encabezado, cuerpo, token);

            return JsonConvert.DeserializeObject<API.Dto.Vehiculos.Salida.VerDetalleVehiculo>(respuesta);
        }

        public async Task<API.Dto.Vehiculos.Salida.AgregarVehiculo> AgregarVehiculo(API.Dto.Vehiculos.Entrada.AgregarVehiculo pDatos, string token)
        {
            string encabezado = "Vehiculos/AgregarVehiculo";
            string cuerpo = JsonConvert.SerializeObject(pDatos);

            string respuesta = await lnConsumoAPI.ConsumirAPI(encabezado, cuerpo, token);

            return JsonConvert.DeserializeObject<API.Dto.Vehiculos.Salida.AgregarVehiculo>(respuesta);
        }

        public async Task<API.Dto.Vehiculos.Salida.EditarVehiculo> EditarVehiculo(API.Dto.Vehiculos.Entrada.EditarVehiculo pDatos, string token)
        {
            string encabezado = "Vehiculos/EditarVehiculo";
            string cuerpo = JsonConvert.SerializeObject(pDatos);

            string respuesta = await lnConsumoAPI.ConsumirAPI(encabezado, cuerpo, token);

            return JsonConvert.DeserializeObject<API.Dto.Vehiculos.Salida.EditarVehiculo>(respuesta);
        }

        public async Task<API.Dto.Vehiculos.Salida.EliminarVehiculo> EliminarVehiculo(API.Dto.Vehiculos.Entrada.EliminarVehiculo pDatos, string token)
        {
            string encabezado = "Vehiculos/EliminarVehiculo";
            string cuerpo = JsonConvert.SerializeObject(pDatos);

            string respuesta = await lnConsumoAPI.ConsumirAPI(encabezado, cuerpo, token);

            return JsonConvert.DeserializeObject<API.Dto.Vehiculos.Salida.EliminarVehiculo>(respuesta);
        }
    }
}
