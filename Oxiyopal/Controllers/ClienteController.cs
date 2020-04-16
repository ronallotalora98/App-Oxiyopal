using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Oxiyopal.Models;
using Oxiyopal.Services.IServices;

namespace Oxiyopal.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly ICarteraService _carteraService;
        public ClienteController(ICarteraService carteraService)
        {
            this._carteraService = carteraService;
        }

        [HttpPost]
        [Route("createCliente")]
        [ProducesResponseType(typeof(Cliente), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> CreateNewClient([FromBody] Cliente cliente)
        {
            try
            {
                await this._carteraService.CreateCliente(cliente);
                return Ok();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}