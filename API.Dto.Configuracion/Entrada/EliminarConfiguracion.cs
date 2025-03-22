using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Dto.Configuracion.Entrada
{
    public class EliminarConfiguracion : General.EntradaAPI
    {
        public int Config_id { get; set; }
    }
}
