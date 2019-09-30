using Oxiyopal.Models.Base;
using Oxiyopal.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oxiyopal.Models
{
    public class Ubicacion : EntityBase<int>
    {
        public bool estaEnBodega { get; set; }


        public int? ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public int? BodegaId { get; set; }
        public Bodega Bodega { get; set; }
        public IList<HistorialCilindro> HistorialCilindros { get; set; }

       
    }
}
