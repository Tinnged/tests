using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Dto.Configuracion.Entrada
{
    public class EditarConfiguracion : General.EntradaAPI
    {
        public int Config_id { get; set; }
        public string Clave { get; set; }
        public string Valor { get; set; }
        public string Descripcion { get; set; }
        public DateTime Ultima_modificacion { get; set; }
    }
}
