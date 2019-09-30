using Oxiyopal.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oxiyopal.Models.ViewModels
{
    public class HistorialDeFactura : EntityBase<int>
    {
        public int CilindroId { get; set; }
        public Cilindro Cilindro { get; set; }

        public int FacturaId { get; set; }
        public Factura Factura { get; set; }
    }
}
