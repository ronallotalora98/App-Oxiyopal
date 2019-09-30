using Oxiyopal.Models.Base;
using Oxiyopal.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oxiyopal.Models
{
    public class Cliente : EntityBase<int>
    {
        #region Cliente Natural
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Documento { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Descripcion { get; set; }
        #endregion
        public bool EsEmpresa { get; set; }

        public int CiudadId { get; set; }
        public Ciudad Ciudad { get; set; }
        public IList<Ubicacion> Ubicaciones { get; set; }
        public IList<Factura> Facturas { get; set; }
    }
}
        