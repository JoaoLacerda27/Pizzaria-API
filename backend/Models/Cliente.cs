using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Usuario { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public int Cep { get; set; }
        public int Quantidade { get; set; }
        public int Total { get; set; }
        public Pizza Pizza { get; set; }

        public Cliente()
        {

        }

        public Cliente(int id, string firstName, string lastName, string usuario, string cidade, string estado, int cep, int quantidade, int total, Pizza pizza)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Usuario = usuario;
            Cidade = cidade;
            Estado = estado;
            Cep = cep;
            Quantidade = quantidade;
            Total = total;
            Pizza = pizza;
        }
    }
}
