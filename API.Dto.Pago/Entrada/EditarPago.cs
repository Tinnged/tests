using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Dto.Pago.Entrada
{
    public class EditarPago : General.EntradaAPI
    {
        public int PagoID { get; set; }
        public int EntregaID { get; set; }
        public decimal Monto{ get; set; }
        public string MetodoPago { get; set; }
        public DateTime FechaPago { get; set; }
        public string Estado { get; set; }
        public string Referencia { get; set; }
        public string ComprobanteUrl { get; set; }
    }
}
