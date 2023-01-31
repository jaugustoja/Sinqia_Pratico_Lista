using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EX_16.Models
{
    public class Seriado : Programa
    {
        public string NomeSerie { get; set; }
        public int NumeroDeEpisódios { get; set; }
        public int AnoInicio { get; set; }
        public int AnoFim { get; set; }

        public Seriado(string nome, int numeroEps, int anoInicio, int anoFim )
        {
            this.NomeSerie = nome;
            this.NumeroDeEpisódios = numeroEps;
            this.AnoInicio = anoInicio;
            this.AnoFim = anoFim;
        }
    }
}