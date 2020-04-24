using Newtonsoft.Json;
using Oxiyopal.Models;
using Oxiyopal.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Oxiyopal.Services.ModelServices
{
    public class CilindroSearchResult
    {
        [JsonIgnore]
        private readonly Cilindro _cilindro;

        [JsonIgnore]
        private readonly IList<HistorialCilindro> _historial;

        public Cilindro cilindro => _cilindro;
        public IList<HistorialCilindro> historial => _historial.Select(x =>
            new HistorialCilindro
            {
                CilindroId = x.CilindroId,
                UbicacionId = x.UbicacionId,
                Ubicacion = new Ubicacion
                {
                    BodegaId = x.Ubicacion?.BodegaId,
                    Bodega = new Bodega
                    {
                        //Id = x.Ubicacion.Bodega.Id,
                        NombreBodega = x.Ubicacion?.Bodega?.NombreBodega
                    },
                    ClienteId = x.Ubicacion?.ClienteId,
                    Cliente = new Cliente
                    {
                       // Id = x.Ubicacion.Cliente.Id,
                        Nombre = x.Ubicacion?.Cliente?.Nombre
                    },
                    Id = x.Ubicacion.Id,
                    FechaDeTraslado = x.Ubicacion.FechaDeTraslado,
                    estaEnBodega = x.Ubicacion.estaEnBodega
                }
            }
        ).ToList();

        public CurrentUbicacion ubicacion;

        public CilindroSearchResult(Cilindro cilindro, IList<HistorialCilindro> historials)
        {
            this._cilindro = new Cilindro {
                Id = cilindro.Id,
                Serial = cilindro.Serial,
                Cantidad = cilindro.Cantidad,
                TipoDeProductoId = cilindro.TipoDeProductoId,
                TipoDeProducto = new TipoDeProducto
                {
                    Id = cilindro.TipoDeProducto.Id,
                    NombreTipoProducto = cilindro.TipoDeProducto.NombreTipoProducto,
                    Color = cilindro.TipoDeProducto.Color
                },
                EstadoId = cilindro.EstadoId,
                Estado = new Estado
                {
                    Id = cilindro.Estado.Id,
                    NombreDeEstado = cilindro.Estado.NombreDeEstado,
                    ColorDeEstado = cilindro.Estado.ColorDeEstado
                },
            };

            this._historial = historials;

            foreach (var item in historials)
            {
                if (item.EsUbucacionActual == true)
                {
                    if (item.Ubicacion.estaEnBodega == true)
                    {
                        this.ubicacion = new CurrentUbicacion
                        {
                            IdClienBodeg = item.Ubicacion.Bodega.Id,
                            NombreUbicacion = item.Ubicacion.Bodega.NombreBodega,
                            IdUbicacion = item.Id,
                            IsBodega = item.Ubicacion.estaEnBodega

                        };
                    }else
                    {
                        this.ubicacion = new CurrentUbicacion
                        {
                            IdClienBodeg = item.Ubicacion.Cliente.Id,
                            NombreUbicacion = item.Ubicacion.Cliente.Nombre,
                            IdUbicacion = item.Id,
                            IsBodega = item.Ubicacion.estaEnBodega

                        };
                    }
                }
            }
        }
    }

    public class CurrentUbicacion
    {
        public int IdUbicacion { get; set; }
        public string NombreUbicacion { get; set; }
        public int IdClienBodeg { get; set; }
        public bool IsBodega { get; set; }
    }
}
