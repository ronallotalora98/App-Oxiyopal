using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Oxiyopal.Models;
using Oxiyopal.Services.IServices;
using Oxiyopal.Services.ModelServices;

namespace Oxiyopal.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CilindroController : ControllerBase
    {
        private readonly ICilindroService _cilindroService;
        public CilindroController(ICilindroService cilindroService)
        {
            this._cilindroService = cilindroService;
        }
        [Route("formCreate")]
        [ProducesResponseType(typeof(CreateCilinderViewModel), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetStatusAndTypeProduc()
        {
            var model = new CreateCilinderViewModel
            {
                TipoDeProducto = await this._cilindroService.GetTipoDeProductos(),
                Estados = await this._cilindroService.GetEstados()
            };
            return Ok(model);

        }

        [Route("createCilinder")]
        [ProducesResponseType(typeof(Cilindro), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> CreateNewCilinder([FromBody] Cilindro cilindro)
        {
            try
            {
                await this._cilindroService.CreateCilinder(cilindro);
                return Ok();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [Route("getCilinder/{type}")]
        [ProducesResponseType(typeof(CilindroSearhResultViewModel), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetCilindersForType( string type)
        {
            try
            {
               var result = await this._cilindroService.GetCilinderForType(type);
                return Ok(result);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [Route("updateCilinder")]
        [ProducesResponseType(typeof(Cilindro), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> UpdateNewCilinder([FromBody] Cilindro cilindro)
        {
            try
            {
                // await this._cilindroService.CreateCilinder(cilindro);
                return Ok();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}