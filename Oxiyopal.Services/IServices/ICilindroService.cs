using Oxiyopal.Models;
using Oxiyopal.Models.ViewModels;
using Oxiyopal.Services.ModelServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Oxiyopal.Services.IServices
{
    public interface ICilindroService
    {
        /// <summary>
        /// Permite agrega un nuevo cilindro
        /// </summary>
        /// <param name="cilindro"></param>
        /// <returns></returns>
        Task CreateCilinder(Cilindro cilindro);

        /// <summary>
        /// Obtiene el listado de los cilidros dependiento el tipo selecionado
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        Task<CilindroSearhResultViewModel> GetCilinderForType(string type);

        /// <summary>
        /// Actualiza la informacion del cilindro
        /// </summary>
        /// <param name="cilindro"></param>
        /// <returns></returns>
        Task UpdateClindro(Cilindro cilindro);

        /// <summary>
        /// Aptualiza la ubicacion del Cilindro
        /// </summary>
        /// <param name="cilindro"></param>
        /// <param name="estaEnBodega"></param>
        /// <param name="tipoDeUbicacionId"></param>
        /// <returns></returns>
        Task UpdateUbicacion(Cilindro cilindro, bool estaEnBodega, int tipoDeUbicacionId);

        /// <summary>
        /// Obtiene todos los tipos de producto que puede tener un cilindro
        /// </summary>
        /// <returns></returns>
        Task<IList<TipoDeProducto>> GetTipoDeProductos();

        /// <summary>
        /// Obtiene todos los estados que puede tener un cilindro
        /// </summary>
        /// <returns></returns>
        Task<IList<Estado>> GetEstados();

        /// <summary>
        /// Obtiene los datos de un cilindro
        /// </summary>
        /// <param name="cilindroId"></param>
        /// <returns></returns>
        Task<Cilindro> GetCilinder(int cilindroId);

        /// <summary>
        /// Optiene el Historial de movimientos que ha tenido un cilindro
        /// </summary>
        /// <param name="cilindroId"></param>
        /// <returns></returns>
        Task<IList<HistorialCilindro>> getHistorial(int cilindroId);

        /// <summary>
        /// Obtiene el listado de las bodega o lo clientes
        /// </summary>
        /// <param name="isBodega"></param>
        /// <returns></returns>
        Task<LocationsResult> getLocations(bool isBodega);
    }
}
