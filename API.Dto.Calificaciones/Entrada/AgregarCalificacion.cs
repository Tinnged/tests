using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Dto.Calificaciones.Entrada
{
    public class AgregarCalificacion : General.EntradaAPI
    {
        public int Entrega_id { get; set; }
        public int Puntuacion { get; set; }
        public string Comentario { get; set; }
        public DateTime Fecha_calificacion { get; set; }
    }
}
