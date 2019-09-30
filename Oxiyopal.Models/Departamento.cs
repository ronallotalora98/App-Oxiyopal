using Oxiyopal.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oxiyopal.Models
{
    public class Departamento : EntityBase<int>
    {
        public string NombreDepartamento { get; set; }
        public IList<Ciudad> Ciudades { get; set; }
    }
}
