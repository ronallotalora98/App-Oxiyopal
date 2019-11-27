using Oxiyopal.Models.Base;
using Oxiyopal.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Oxiyopal.Models
{
    public class Cilindro : EntityBase<int>
    {
        public string Serial { get; set; }
        public string Tamaño { get; set; }

        public int TipoDeProductoId { get; set; }
        public TipoDeProducto TipoDeProducto { get; set; }

        public int EstadoId { get; set; }
        public Estado Estado { get; set; }


        public virtual IList<HistorialCilindro> HistorialCilindros { get; set; }
        public IList<HistorialDeFactura> HistorialDeFacturas { get; set; }
    }
}
