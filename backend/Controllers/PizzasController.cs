using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using backend.Data;
using backend.Model;
using backend.Services;
using Microsoft.AspNetCore.Cors;

namespace backend.Controllers
{
    [Route("pizzas")]
    [ApiController]
    public class PizzasController : ControllerBase
    {
        private readonly PizzaService _pizzaService;

        public PizzasController(PizzaService pizzaService)
        {
            _pizzaService = pizzaService;
        }

        [HttpGet]
        [EnableCors("AllowOrigin")]
        public async Task<IActionResult> Pizzas()
        {
            var list = await _pizzaService.FindAllAsync();
            return Ok(list);
        }

        [HttpGet("{id}")]
        [EnableCors("AllowOrigin")]
        public async Task<IActionResult> Pizzas(int id)
        {
            var obj = await _pizzaService.FindByIdAsync(id);
            return Ok(obj);
        }
    }

}
