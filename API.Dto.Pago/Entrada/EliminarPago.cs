﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Dto.Pago.Entrada
{
    public class EliminarPago : General.EntradaAPI
    {
        public int PagoID { get; set; }
    }
}
