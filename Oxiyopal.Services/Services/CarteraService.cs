using Oxiyopal.DataAccess.Repository;
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
        private readonly IRepository<Cliente, int> _clienteRepo;
        public CarteraService(IRepository<Cliente, int> clienteRepo)
        {
            this._clienteRepo = clienteRepo;
        }
        public async Task CreateCliente(Cliente cliente)
        {
            try
            {
                 this._clienteRepo.Add(cliente);
                await this._clienteRepo.SaveChangeAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
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
