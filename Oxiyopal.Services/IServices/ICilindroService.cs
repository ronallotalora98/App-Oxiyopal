using Oxiyopal.Models;
using Oxiyopal.Services.ModelServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Oxiyopal.Services.IServices
{
    public interface ICilindroService
    {
        Task CreateCilinder(Cilindro cilindro);
        Task<CilindroSearhResultViewModel> GetCilinderForType(string type);

        Task UpdateClindro(Cilindro cilindro);

        Task UpdateUbicacion(Cilindro cilindro, bool estaEnBodega, int tipoDeUbicacionId);


        Task<IList<TipoDeProducto>> GetTipoDeProductos();
        Task<IList<Estado>> GetEstados();
    }
}
