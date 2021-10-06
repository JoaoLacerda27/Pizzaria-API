using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Data;
using backend.Model;

namespace backend.Data
{
    public class SeedingService
    {
        private PizzariaContext _context;

        public SeedingService(PizzariaContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Pizza.Any())
            {
                return; // DB já foi populado
            }

            Pizza p1 = new Pizza(1, "Calabresa", " Calabresa, cebola e azeitona.", 49.90);
            Pizza p2 = new Pizza(2, "Marguerita", "Tomates cerejas, parmesão e manjericão.", 49.90);
            Pizza p3 = new Pizza(3, "Peperoni", "Mussarella, peperoni da Sadia e catupiry.", 59.90);
            Pizza p4 = new Pizza(4, "Do Regime", "Abobrinha refogada, alho coberta com queijo Minas padrão.", 59.90);
            Pizza p5 = new Pizza(5, "Tropical", " Palmito, presunto e champignon.", 39.90);
            Pizza p6 = new Pizza(6, "Atum", "Mussarella,cebola, atum azeitonas pretas.", 34.90);
            Pizza p7 = new Pizza(7, "Quatro Queijos", "Catupiry, gorgonzola, provolone e parmesão.", 49.90);
            Pizza p8 = new Pizza(8, "Mussarella", "Mussarella azeitonas pretas.", 34.90);
            Pizza p9 = new Pizza(9, "Vegana", "Berinjela italiana, tomate em cubos e cebelo roxa.", 59.90);


            _context.Pizza.AddRange(p1, p2, p3, p4, p5, p6, p7, p8, p9); //Passando o objeto e populando a tabela de Pizzas

            _context.SaveChanges();
        }
    }
}
