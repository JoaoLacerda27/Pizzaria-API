using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using backend.Model;

namespace backend.Data
{
    public class PizzariaContext : DbContext
    {
        public PizzariaContext (DbContextOptions<PizzariaContext> options)
            : base(options)
        {
        }

        public DbSet<Pizza> Pizza { get; set; }
        public DbSet <Cliente> Cliente { get; set; }
    }
}
