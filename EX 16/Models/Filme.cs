using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EX_16.Models
{
    
    public class Filme : Programa
    {
        public string NomeFilme { get; set; }
        public Filme (string nome, int duracao)  
        {
            this.NomeFilme = nome;
            this.Duracao = duracao;
        } 
    }
}