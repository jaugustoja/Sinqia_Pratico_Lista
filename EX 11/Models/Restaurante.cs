using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EX_11.Models
{
    public class Restaurante
    {
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public bool Delivery { get; set; }
        public int PedidoPendente { get; set; }
        public int TempoDeEntregaEstimado { get; set; }

        public Restaurante(string nome, string cidade, int pendencia)
        {
            this.Nome = nome;
            this.Cidade = cidade;
            this.PedidoPendente = pendencia;
        }

        public void EntregaPedido(Cliente cliente)
        {
            if(cliente.Cidade == this.Cidade)
            {
                this.Delivery = true;
                this.TempoDeEntregaEstimado = 10 + 2 * PedidoPendente;

                Console.WriteLine($"Entrega será realizada para o cliente {cliente.Nome} em {this.TempoDeEntregaEstimado} minutos.");
            }
            else
            {
                Console.WriteLine($"Cliente não reside em {this.Cidade}, entrega cancelada.");
            }
        }
    }
}