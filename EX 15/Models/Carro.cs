using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EX_15.Models
{
    public class Carro : Veiculo
    {
        public string TipoCombustivel { get; set; }
        public Carro(int rodas, string tipoDeCombustivel)
        {
            this.Rodas = rodas;
            this.UsaCombustivel = true;
            tipoDeCombustivel.ToLower();
            if (tipoDeCombustivel == "gasolina" || tipoDeCombustivel == "flex" || tipoDeCombustivel == "alcool")
            {
                this.TipoCombustivel = tipoDeCombustivel;
            }
            else
            {
                throw new Exception("Tipo de combustivel inválido.");
            }
        }
    }
}