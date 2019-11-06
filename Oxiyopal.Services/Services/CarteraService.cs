using Oxiyopal.Models;
using Oxiyopal.Services.IServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Oxiyopal.Services.Services
{
    public class CarteraService : ICarteraService
    {
        public CarteraService()
        {
                
        }
        public Task<Cliente> CreateCliente()
        {
            throw new NotImplementedException();
        }

        public Task<IList<Cliente>> GetClientes()
        {
            throw new NotImplementedException();
        }

        public Task<Cliente> GetClienteSeleted(int clienteId)
        {
            throw new NotImplementedException();
        }
    }
}
