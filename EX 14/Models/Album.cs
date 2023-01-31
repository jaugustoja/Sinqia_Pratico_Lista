using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EX_14.Models
{
    public class Album
    {
        public int QtdeFigurinhas { get; set; }
        public int[] ArrayFigurinhasColadas;
        public int FigurasColadas { get; set; }

        public Album(int quantidaeFigurinha)
        {
            this.QtdeFigurinhas = quantidaeFigurinha;
            ArrayFigurinhasColadas = new int[quantidaeFigurinha];
            this.FigurasColadas = 0;
        }
    

        public void ColarFigurinhas(int numeroFigurinha)
        {
            ArrayFigurinhasColadas[this.FigurasColadas] = numeroFigurinha;
            this.FigurasColadas++;
        }
    }
    
}