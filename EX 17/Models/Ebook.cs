using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EX_17.Models
{
    public class Ebook : Livro
    {
        public int NumeroPaginas { get; set; }
        public int NumeroCapitulos { get; set; }
    }
}