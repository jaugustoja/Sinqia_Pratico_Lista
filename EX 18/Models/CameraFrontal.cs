using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EX_18.Models
{
    public class CameraFrontal : Camera
    {
        public double ResolucaoAtual { get; set; }

        public CameraFrontal()
        {
            Random r = new Random();

            ResolucaoMaxima = 8;
            ResolucaoAtual = r.Next(5, 9);
        }
    }
}