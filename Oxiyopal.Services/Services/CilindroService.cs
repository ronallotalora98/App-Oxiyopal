using Microsoft.EntityFrameworkCore;
using Oxiyopal.DataAccess.Repository;
using Oxiyopal.Models;
using Oxiyopal.Models.ViewModels;
using Oxiyopal.Services.IServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Oxiyopal.Services.Services
{
    public class CilindroService : ICilindroService
    {
        private readonly IRepository<Cilindro, int> _cilindroRepository;
        private readonly IRepository<HistorialCilindro, int> _hisCilindroRepository;
        private readonly IRepository<Ubicacion, int> _ubicacionRepository;
        private readonly IRepository<TipoDeProducto, int> _tipoRepo;
        private readonly IRepository<Estado, int> _estadoRepo;
        public CilindroService(IRepository<Cilindro, int> cilindroRepository,
                               IRepository<HistorialCilindro, int> hisCilindroRepository,
                               IRepository<Ubicacion, int> ubicacionRepository,
                               IRepository<TipoDeProducto, int> tipoRepo,
                               IRepository<Estado, int> estadoRepo)
        {
            this._cilindroRepository = cilindroRepository;
            this._hisCilindroRepository = hisCilindroRepository;
            this._ubicacionRepository = ubicacionRepository;
            this._tipoRepo = tipoRepo;
            this._estadoRepo = estadoRepo;
        }
        public async Task CreateCilinder(Cilindro cilindro)
        {
            try
            {
                this._cilindroRepository.Add(cilindro);
                await this._cilindroRepository.SaveChangeAsync();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public async Task<IList<Cilindro>> GetCilinderForType(int typeId)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<Estado>> GetEstados()
        {
            var status = await this._estadoRepo.Query().ToListAsync();
            return status;
        }

        public async Task<IList<TipoDeProducto>> GetTipoDeProductos()
        {
            var type = await this._tipoRepo.Query().ToListAsync();
            return type;
        }

        public async Task UpdateClindro(Cilindro cilindro)
        {
            try
            {
                var oldCilindro = await _cilindroRepository.Query()
                                           .FirstOrDefaultAsync(x => x.Id == cilindro.Id);
                oldCilindro.EstadoId = cilindro.EstadoId;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task UpdateUbicacion(Cilindro cilindro, bool estaEnBodega, int tipoDeUbicacionId)
        {
            try
            {
                if (estaEnBodega == true)
                {

                }
                else
                {

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
