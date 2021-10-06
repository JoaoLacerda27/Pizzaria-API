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
        public IActionResult Pizzas()
        {
            var list = _pizzaService.FindAll();
            return Ok(list);
        }

    }
}
