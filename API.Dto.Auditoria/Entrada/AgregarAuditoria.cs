using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Dto.Auditoria.Entrada
{
    public class AgregarAuditoria : General.EntradaAPI
    {
        public string Tabla { get; set; }
        public string Operacion { get; set; }
        public int Usuario_id { get; set; }
        public DateTime Fecha_operacion { get; set; }
        public string Registro_anterior { get; set; }
        public string Registro_nuevo { get; set; }
    }
}
