using Oxiyopal.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oxiyopal.Models
{
    public class Bodega: EntityBase<int>
    {
        public string NombreBodega { get; set; }
        public string Direccion { get; set; }

        public int CiudadId { get; set; }
        public Ciudad Ciudad { get; set; }

       
        public IList<Ubicacion> Ubicaciones { get; set; }
    }
}
