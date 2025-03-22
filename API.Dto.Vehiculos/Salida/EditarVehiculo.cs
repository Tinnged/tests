﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Dto.Vehiculos.Salida
{
    public class EditarVehiculo : General.RespuestaAPI
    {
        public int VehiculoID { get; set; }
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public string Tipo { get; set; }
        public decimal CapacidadKG { get; set; }
        public string Estado { get; set; }
        public DateTime UltimoMantenimiento { get; set; }
        public DateTime FechaAdquisicion { get; set; }
        public int Kilometraje { get; set; }
    }
}
