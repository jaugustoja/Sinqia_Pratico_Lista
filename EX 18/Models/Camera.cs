using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EX_18.Models
{
    public class Camera
    {
        public double ResolucaoMaxima { get; set; }
        public int FotosTiradas { get; set; }

        public Camera()
        {
            FotosTiradas = 0;
        }

        public void TirarFoto(int qtdFotos)
        {
            FotosTiradas += qtdFotos;
            
        }
    }
}
