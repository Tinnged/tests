using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Dto.Auditoria.Entrada
{
    public class VerDetalleAuditoria : General.EntradaAPI
    {
        public int auditoria_id { get; set; }
    }
}
