using Newtonsoft.Json;
using Oxiyopal.Models;
using Oxiyopal.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Oxiyopal.Services.ModelServices
{
    public class CilindroSearhResultViewModel
    {

        [JsonIgnore]
        private readonly IList<HistorialCilindro> _historial;

        public IList<CilindroResult> cilindros =>
                _historial.Select(x =>
                new CilindroResult
                {
                    CilindroId = x.CilindroId,
                    Serial = x.Cilindro.Serial,
                    ubicacion = 
                        new UbicacionResult
                        {
                            EstaEnBodega = x.Ubicacion.estaEnBodega,
                            FechaDeTraslado = x.Ubicacion.FechaDeTraslado,
                            NombreUbicacion = (x.Ubicacion.estaEnBodega == true) ? x.Ubicacion.Bodega.NombreBodega: 
                            x.Ubicacion.Cliente.Nombre + ' ' + x.Ubicacion.Cliente.Apellido
                        }
                    
                }).ToList();

        public CilindroSearhResultViewModel( IList<HistorialCilindro> historials)
        {
            // this._cilindros = cilindros;
            this._historial = historials;
        }
    }

    public class CilindroResult
    {
        public int CilindroId { get; set; }
        public string Serial { get; set; }
        public UbicacionResult ubicacion { get; set; }

    }

    public class UbicacionResult
    {
        public bool EstaEnBodega { get; set; }
        public string NombreUbicacion { get; set; }
        public DateTime FechaDeTraslado { get; set; }
    }
}
