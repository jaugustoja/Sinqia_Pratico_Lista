using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EX_09.Models
{
    public class Time
    {
        public string País { get; set; }
        public string Esporte { get; set; }
        public int Pontuacao { get; set; }
        public string NomeTime { get; set; }

        public Time(string pais, string esporte, string nome)
        {
            this.País = pais;
            this.Esporte = esporte;
            this.NomeTime = nome;
        }

        public void Pontua(string status)
        {
            status = status.ToUpper();
            switch(status)
            {
                case "W":

                    Console.WriteLine($"{this.NomeTime} venceu a partida de {this.Esporte}, +3 pontos.");
                    this.Pontuacao += 3;
                    Console.WriteLine($"{this.Pontuacao} pontos no campeonato.");
                    break;

                case "L":

                    Console.WriteLine($"{this.NomeTime} perdeu a partida de {this.Esporte}, +0 pontos.");
                    Console.WriteLine($"{this.Pontuacao} pontos no campeonato.");
                    break;

                case "D":

                    Console.WriteLine($"{this.NomeTime} empatou a partida de {this.Esporte}, +1 ponto.");
                    this.Pontuacao += 1;
                    Console.WriteLine($"{this.Pontuacao} pontos no campeonato.");
                    break;
                
                default:
                    Console.WriteLine("Entrada inválida. Entre com W em caso de vitória, L em caso de derrota e D em caso de empate.");
                    break;
            }
        }

    }
}