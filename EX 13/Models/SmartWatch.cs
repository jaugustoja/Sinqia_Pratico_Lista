using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EX_13.Models
{
    public class SmartWatch
    {
        public string Marca { get; set; }
        public int Pedometro { get; set; }

        public SmartWatch(string marca)
        {
            this.Marca = marca;
        }

   

        public void Caminhar()
        {
            this.Pedometro++;
        }

        public void ResetOnMidnight()
        {
            this.Pedometro = 0;
        }

    }
 }
