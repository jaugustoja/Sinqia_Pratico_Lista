using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EX_16.Models
{
    public class Programa
    {
        public int Duracao { get; set; }
        public List<string> Generos = new List<string> { "ação", "comédia", "suspense", "drama", "terror" };
    }
    
}