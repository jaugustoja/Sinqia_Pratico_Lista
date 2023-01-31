using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EX_10.Models
{
    public class Sorteio
    {
        public List<Pessoa> ListaPessoas = new List<Pessoa>();
        public string NomeSorteio { get; set; }

        public Sorteio(string nomeSorteio, List<Pessoa> listaPessoas)
        {
            this.NomeSorteio = nomeSorteio;
            this.ListaPessoas = listaPessoas;
        }

        public void SorteiaPremio()
        {
            Random random1 = new Random();
            int resultado = random1.Next(0, ListaPessoas.Count);

            Console.WriteLine($"O vencedor do premio é: \nNumero Inscrição: {this.ListaPessoas[resultado].NumeroInscricao}\nNome:{this.ListaPessoas[resultado].Nome}");
        }
    }
}