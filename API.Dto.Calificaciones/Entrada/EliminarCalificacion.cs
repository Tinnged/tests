using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Dto.Calificaciones.Entrada
{
    public class EliminarCalificacion : General.EntradaAPI
    {
        public int calificacion_id { get; set; }
    }
}
