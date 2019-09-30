using Oxiyopal.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Oxiyopal.Models.ViewModels
{
    public class HistorialCilindro : EntityBase<int>
    {
        public int CilindroId { get; set; }
        public Cilindro Cilindro { get; set; }

        public int UbicacionId { get; set; }
        public Ubicacion Ubicacion { get; set; }

        public bool EsUbucacionActual { get; set; }
    }
}
