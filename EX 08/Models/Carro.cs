using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EX_08.Models
{
    public class Carro
    {
        public string Cor { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public double CapacidadeDoTanque { get; set; }
        public double Tanque { get; set; }
        public string TipoDeCombustivel { get; set; }

        public Carro(string cor, string marca, string modelo, double capacidadeTanque, string tipoCombustivel)
        {
            this.Cor = cor;
            this.Marca = marca;

            modelo = modelo.ToLower();
            do
            {
                if (modelo == "sedan" || modelo == "hatch")
                {
                    this.Modelo = modelo;
                }
                else
                {
                    Console.WriteLine("Modelo incopatível. Escolha entre hatch ou sedan.");
                    modelo = Console.ReadLine().ToLower();
                }
            } while (modelo != "hatch" && modelo != "sedan");


            this.CapacidadeDoTanque = capacidadeTanque;

            tipoCombustivel = tipoCombustivel.ToLower();
            do
            {
                if (tipoCombustivel == "alcool" || tipoCombustivel == "gasolina" || tipoCombustivel == "flex")
                {
                    this.TipoDeCombustivel = tipoCombustivel;
                }
                else
                {
                    Console.WriteLine("Combustivel incopatível. Escolha entre gasolina, alcool ou flex.");
                    tipoCombustivel = Console.ReadLine().ToLower();
                }
            } while (tipoCombustivel != "alcool" && tipoCombustivel != "gasolina" && tipoCombustivel != "flex");

        }

        public double Abastecer(double litragem, string tipoDoCombustivel)
        {
            //Console.WriteLine("Qual tipo de combustivel gostaria de abastecer? (gasolina/álcool/flex");
            if((tipoDoCombustivel == "gasolina" || tipoDoCombustivel == "alcool") && tipoDoCombustivel != "flex")
            {
                double tanqueVazio = CapacidadeDoTanque - Tanque;
                if (litragem <= tanqueVazio)
                {
                    Console.WriteLine($"Abastecendo {this.Modelo} com {tipoDoCombustivel}...");
                    this.Tanque = litragem;
                    Thread.Sleep(3000);
                    Console.WriteLine($"Tanque abastecido com {litragem} litros, capacidade máxima do tanque é de {this.CapacidadeDoTanque} litros.");
                    Console.WriteLine("Volte sempre!");

                    switch (tipoDoCombustivel)
                    {
                        case "gasolina":
                            double preco = litragem * 5.62;
                            return preco;

                        case "alcool":
                            preco = litragem * 4.16;
                            return preco;
                    }
                    
                }
                Console.WriteLine("Valor ultrapassa a quantidade máxima de capacidade do tanque.");
                return 0;

            }
            
            else
            {
                Console.WriteLine($"Tipo de combustivel incopativel, o modelo utiliza {this.TipoDeCombustivel}.");
                return 0;
            }


        }



    }
}