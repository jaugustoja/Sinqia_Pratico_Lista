using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EX_15.Models
{
    public class Bicicleta : Veiculo
    {
        public bool Infantil { get; set; }
        public Bicicleta(bool infantil, int rodas)
        {
            if (rodas >= 2)
            {
                this.Rodas = rodas;
            }
            else
            {
                throw new Exception("Não possui rodas suficientes. < 2");
            }

            this.Infantil = infantil;
            this.UsaCombustivel = false;
        }
    }
}