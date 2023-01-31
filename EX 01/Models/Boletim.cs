using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EX_01.Models
{
    public class Boletim
    {
        //Propriedades
        public string NomeDoAluno { get; private set; }
        public int Ano {get; private set; }
        public int Semestre { get; private set; }
        public List<string> Media { get; private set; }

        //Construtor com validações
        public Boletim (string nome,int anoBoletim, int semestre)
        {
            this.NomeDoAluno = nome;

            do
            {
                if (anoBoletim >= 1964)
                {
                    this.Ano = anoBoletim;
                }
                else
                {
                    Console.WriteLine("Ano inferior há 1964, insira um novo ano.");
                    anoBoletim = int.Parse(Console.ReadLine());
                    this.Ano = anoBoletim;
                }
            } while (anoBoletim < 1964);

            do
            {
                if (semestre >= 1 && semestre <= 14)
                {
                    this.Semestre = semestre;
                }
                else
                {
                    Console.WriteLine("Semestre informado deve ser entre 1 e 14, insira um novo semestre.");
                    semestre = int.Parse(Console.ReadLine());
                    this.Semestre = semestre;
                }
            } while (!(semestre >= 1 && semestre <= 14));
        }

        //Métodos
        public void DefinirNotas(double matematica, double portugues, double historia, double geografia, double artes, double ingles)
        {
            List<string> media = new List<string>();
            media.Add("Média em matematica = nota " + Convert.ToString(matematica));
            media.Add("Média em português = nota " + Convert.ToString(portugues));
            media.Add("Média em historia = nota " + Convert.ToString(historia));
            media.Add("Média em geografia = nota " + Convert.ToString(geografia));
            media.Add("Média em artes = nota " + Convert.ToString(artes));
            media.Add("Média em inglês = nota " + Convert.ToString(ingles));

            this.Media = media;
            Console.WriteLine($"Médias adicionadas ao {this.Semestre}° semestre do boletim de {this.Ano} de {this.NomeDoAluno}");

        }

        public void VerBoletim()
        {
            
            Console.WriteLine($"\nBOLETIM: {this.Semestre}° semestre de {this.NomeDoAluno} em {this.Ano}: \n");
            foreach(string nota in Media)
            {
                Console.WriteLine(nota);
            };
        }

    }
}