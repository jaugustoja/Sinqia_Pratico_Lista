using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EX_10.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Sexo { get; set; }
        public int NumeroInscricao { get; set; }

        public Pessoa(string nome, int idade, string sexo, int inscricao)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Sexo = sexo;
            this.NumeroInscricao = inscricao;
        }
    }
}