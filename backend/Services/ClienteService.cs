using backend.Data;
using backend.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace backend.Services
{
    public class ClienteService
    {
        private readonly PizzariaContext _context;

        public ClienteService(PizzariaContext context)
        {
            _context = context;
        }

        public async Task<List<Cliente>> FindAllAsync()
        {
            return await _context.Cliente.ToListAsync();
        }

        public async Task<Pizza> FindByIdAsync(int id)
        {
            return await _context.Pizza.FirstOrDefaultAsync(obj => obj.Id == id);
        }
    }
}
