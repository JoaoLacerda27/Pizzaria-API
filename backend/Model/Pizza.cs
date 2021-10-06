using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Model
{
    public class Pizza
    {
        [Key]
        public int Id { get; set; }
        public string Sabor { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }

        public Pizza()
        {
        }

        public Pizza(int id, string sabor, string descricao, double preco)
        {
            Id = id;
            Sabor = sabor;
            Descricao = descricao;
            Preco = preco;
        }
    }

}
