using Oxiyopal.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Oxiyopal.Services.IServices
{
    public interface ICarteraService
    {
        Task<Cliente> CreateCliente();
        Task<IList<Cliente>> GetClientes();

        Task<Cliente> GetClienteSeleted(int clienteId);

    }
}
