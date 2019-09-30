using Oxiyopal.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oxiyopal.Models
{
    public class Estado : EntityBase<int>
    {
        public string NombreDeEstado { get; set; }
        public string ColorDeEstado { get; set; }
        public IList<Cilindro> Cilindros { get; set; }
    }
}
