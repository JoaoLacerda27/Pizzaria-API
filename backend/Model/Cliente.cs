using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Model
{
    public class Cliente
    {
        [Key]
        public int PedidoId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Usuario { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public int Cep { get; set; }
        public int Quantidade { get; set; }
        public double Total { get; set; }
        public int PizzaId { get; set; }

        public Cliente()
        {

        }
        public Cliente(int pedidoId, string firstName, string lastName, string usuario, string cidade, string estado, int cep, int quantidade, int total, int pizzaId)
        {
            PedidoId = pedidoId;
            FirstName = firstName;
            LastName = lastName;
            Usuario = usuario;
            Cidade = cidade;
            Estado = estado;
            Cep = cep;
            Quantidade = quantidade;
            Total = total;
            PizzaId = pizzaId;
        }
    }
}
