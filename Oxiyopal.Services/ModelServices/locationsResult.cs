using Oxiyopal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Oxiyopal.Services.ModelServices
{
    public class LocationsResult
    {

        public IList<Location> locations;

        public LocationsResult(bool isBodega, IList<Bodega> bodegas, IList<Cliente> clientes)
        {
            if (isBodega == true)
            {
                this.locations = bodegas.Select(x =>
                new Location
                {
                    IdLocation = x.Id,
                    NameLocation = x.NombreBodega
                }).ToList();
            }else
            {
                this.locations = clientes.Select(x =>
                new Location
                {
                    IdLocation = x.Id,
                    NameLocation = x.Nombre
                }).ToList();
            }
        }
    }

    public class Location
    {
        public int IdLocation { get; set; }
        public string NameLocation { get; set; }
    }
}
