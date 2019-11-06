using Oxiyopal.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Oxiyopal.Services.IServices
{
    public interface ICilindroService
    {
        Task CreateCilinder(Cilindro cilindro);
        Task<IList<Cilindro>> GetCilinderForType(int typeId);

        Task UpdateClindro(Cilindro cilindro);

        Task UpdateUbicacion(Cilindro cilindro, Ubicacion ubicacion);
    }
}
