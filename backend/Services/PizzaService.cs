using backend.Data;
using backend.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Services
{
    public class PizzaService
    {
        private readonly PizzariaContext _context;

        public PizzaService(PizzariaContext context)
        {
            _context = context;
        }

        public async Task<List<Pizza>> FindAllAsync()
        {
            return await _context.Pizza.ToListAsync();
        }

        public async Task<Pizza> FindByIdAsync(int id)
        {
            return await _context.Pizza.FirstOrDefaultAsync(obj => obj.Id == id);

        }

    }
}
