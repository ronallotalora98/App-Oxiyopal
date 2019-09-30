using Oxiyopal.Models.Base;
using Oxiyopal.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oxiyopal.Models
{
    public class Factura: EntityBase<int>
    {
        public int Valor { get; set; }
        public int Serial { get; set; }
        public DateTime FechaDeVenta { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public IList<HistorialDeFactura> HistorialDeFacturas { get; set; }
    }
}
