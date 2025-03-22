using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Dto.Vehiculos.Entrada
{
    public class AgregarVehiculo : General.EntradaAPI
    {
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public string Tipo { get; set; }
        public decimal Capacidad_kg { get; set; }
        public string Estado { get; set; }
        public DateTime Ultimo_mantenimiento { get; set; }
        public DateTime Fecha_adquisicion { get; set; }
        public int Kilometraje { get; set; }
    }
}

