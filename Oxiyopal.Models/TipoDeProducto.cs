using Oxiyopal.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oxiyopal.Models
{
    public class TipoDeProducto : EntityBase<int>
    {
        public string NombreTipoProducto { get; set; }
        public string Color { get; set; }

        public IList<Cilindro> Cilindros { get; set; }
    }
}
