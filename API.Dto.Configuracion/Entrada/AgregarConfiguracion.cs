using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Dto.Configuracion.Entrada
{
    public class AgregarConfiguracion : General.EntradaAPI
    {
        public string Clave { get; set; }
        public string Valor { get; set; }
        public string Descripcion { get; set; }
        public DateTime Ultima_modificacion { get; set; }
    }
}
