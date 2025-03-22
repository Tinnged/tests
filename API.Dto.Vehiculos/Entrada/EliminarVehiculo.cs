using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Dto.Vehiculos.Entrada
{
    public class EliminarVehiculo : General.EntradaAPI
    {
        public int Vehiculo_id { get; set; }
    }
}
