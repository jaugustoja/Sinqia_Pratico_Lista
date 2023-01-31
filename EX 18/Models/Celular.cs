using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EX_18.Models
{
    public class Celular
    {
        public int EspacoDisponivel { get; set; }
        public int CameraFrontal { get; set; }
        public int CameraTraseira { get; set; }

        public Celular()
        {
            EspacoDisponivel = 100;
        }

        public void TirarEspaco(int qtdFotos) 
        {
            EspacoDisponivel -= qtdFotos;
        }
    }
}