using backend.Data;
using backend.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Controllers
{
    [Route("clientes")]
    [ApiController]
    public class ClientesController : Controller
    {
        private readonly ClienteService _clienteService;

        public ClientesController(ClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpGet("id={id}")]
        public async Task<IActionResult> Cliente (int id)
        {
            var obj = await _clienteService.FindByIdAsync(id);
            return Ok(obj);
        }
    }
}
