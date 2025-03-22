using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Dto.Seguimientos.Entrada
{
    public class AgregarSeguimiento : General.RespuestaAPI
    {
        public int EntregaID { get; set; }
        public DateTime FechaEstado { get; set; }
        public string estado { get; set; }
        public string Descripcion { get; set; }
        public string Ubicacion { get; set; }
        public decimal Latitud { get; set; }
        public decimal Longitud { get; set; }
    }
}
