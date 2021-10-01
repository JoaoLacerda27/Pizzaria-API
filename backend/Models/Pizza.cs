using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Sabor { get; set; }
        public string Descricao { get; set; }
        public int Preco { get; set; }

        public Pizza()
        {
        }

        public Pizza(int id, string sabor, string descricao, int preco)
        {
            Id = id;
            Sabor = sabor;
            Descricao = descricao;
            Preco = preco;
        }
    }
}
