using Microsoft.EntityFrameworkCore;
using Oxiyopal.DataAccess.Repository;
using Oxiyopal.Models;
using Oxiyopal.Models.ViewModels;
using Oxiyopal.Services.IServices;
using Oxiyopal.Services.ModelServices;
using System;
using System.Collections.Generic;
using System.Linq;
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
        private readonly IRepository<Bodega, int> _bodegaRepo;
        private readonly IRepository<Cliente, int> _clienteRepo;
        public CilindroService(IRepository<Cilindro, int> cilindroRepository,
                               IRepository<HistorialCilindro, int> hisCilindroRepository,
                               IRepository<Ubicacion, int> ubicacionRepository,
                               IRepository<TipoDeProducto, int> tipoRepo,
                               IRepository<Estado, int> estadoRepo,
                               IRepository<Bodega, int> bodegaRepo,
                               IRepository<Cliente, int> clienteRepo)
        {
            this._cilindroRepository = cilindroRepository;
            this._hisCilindroRepository = hisCilindroRepository;
            this._ubicacionRepository = ubicacionRepository;
            this._tipoRepo = tipoRepo;
            this._estadoRepo = estadoRepo;
            this._bodegaRepo = bodegaRepo;
            this._clienteRepo = clienteRepo;
        }
        public async Task CreateCilinder(Cilindro cilindro)
        {
            try
            {
                this._cilindroRepository.Add(cilindro);
                await this._cilindroRepository.SaveChangeAsync();

                Ubicacion ubicacion = new Ubicacion
                {
                    estaEnBodega = true,
                    BodegaId = 1,
                    FechaDeTraslado = DateTime.Now
                };
                this._ubicacionRepository.Add(ubicacion);
                await this._ubicacionRepository.SaveChangeAsync();

                HistorialCilindro historial = new HistorialCilindro
                {
                    EsUbucacionActual = true,
                    CilindroId = cilindro.Id,
                    UbicacionId = ubicacion.Id
                };
                this._hisCilindroRepository.Add(historial);
                await this._hisCilindroRepository.SaveChangeAsync();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public async Task<Cilindro> GetCilinder(int cilindroId)
        {
            var cilindro = await this._cilindroRepository.Query()
                                     .Include(x => x.TipoDeProducto)
                                     .Include(x => x.Estado)
                                     // .Include(x => x.HistorialCilindros).ThenInclude(x => x.Ubicacion).ThenInclude(x => x.Cliente)
                                     // .Include(x => x.HistorialCilindros).ThenInclude(x => x.Ubicacion).ThenInclude(x => x.Cliente)
                                     .Where(x => x.Id == cilindroId)
                                     .FirstOrDefaultAsync();
            return cilindro;
        }
        public async Task<IList<HistorialCilindro>> getHistorial(int cilindroId)
        {
            var historial = await this._hisCilindroRepository.Query()
                                .Include(x => x.Ubicacion).ThenInclude(x => x.Bodega)
                                .Include(x => x.Ubicacion).ThenInclude(x => x.Cliente)
                                .Where(x => x.CilindroId == cilindroId)
                                .ToListAsync();
            return historial;
        }
        public async Task<CilindroSearhResultViewModel> GetCilinderForType(string type)
        {
            var Cilindros = await this._hisCilindroRepository.Query()
                                       .Include(x => x.Ubicacion).ThenInclude(x => x.Bodega)
                                       .Include(x => x.Ubicacion.Cliente)
                                       .Include(x => x.Cilindro).ThenInclude(x => x.TipoDeProducto)
                                       .Where(x => x.EsUbucacionActual == true && x.Cilindro.TipoDeProducto.NombreTipoProducto.Contains(type))
                                       .ToListAsync();

            return new CilindroSearhResultViewModel(Cilindros);
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

        public async Task<LocationsResult> getLocations(bool isBodega)
        {
            List<Bodega> bodegas = new List<Bodega>();
            List<Cliente> clientes = new List<Cliente>();
            if (isBodega == true)
            {
                /// clientes = new List<Cliente>();
                bodegas = await this._bodegaRepo.Query().ToListAsync();

            }
            else
            {
                // bodegas = new List<Bodega>();
                clientes = await this._clienteRepo.Query().ToListAsync();
            }

            return new LocationsResult(isBodega, bodegas, clientes);

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
