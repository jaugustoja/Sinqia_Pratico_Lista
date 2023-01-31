using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EX_11.Models
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Cidade { get; set; }


        public Cliente(string nome, string cidade)
        {
            this.Nome = nome;
            this.Cidade = cidade;
        }
    }
}