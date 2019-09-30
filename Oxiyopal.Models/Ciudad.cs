using Oxiyopal.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oxiyopal.Models
{
    public class Ciudad : EntityBase<int>
    {
        public string NombreCiudad { get; set; }

        public int DepartamentoId { get; set; }
        public Departamento Departamento { get; set; }
        public IList<Bodega> Bodegas { get; set; }
        public IList<Cliente> Clientes { get; set; }
    }
}
