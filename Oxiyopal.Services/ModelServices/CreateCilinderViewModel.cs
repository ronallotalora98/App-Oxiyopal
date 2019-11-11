using Oxiyopal.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oxiyopal.Services.ModelServices
{
    public class CreateCilinderViewModel
    {
        public IList<TipoDeProducto> TipoDeProducto { get; set; }
        public IList<Estado> Estados { get; set; }
    }
}
