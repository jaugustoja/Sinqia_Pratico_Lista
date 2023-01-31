using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EX_02.Models
{

    public class CNH
    {
        public string País { get; private set; }
        public int Idade { get; private set; }
        public string Categoria { get; private set; }

        public CNH() : this("sem país", 18)
        {

        }
        public CNH(string país, int idade)
        {
            switch(país)
            {
                case "US":

                    this.País = país;
                    if(idade >= 16)
                    {
                        this.Idade = idade;
                    }
                    else
                    {
                        Console.WriteLine("Idade menor que o permitido. Idade determinada como padrão de 16 anos");
                        this.Idade = 16;
                    }
                    break;
                
                case "CA":

                    this.País = país;
                    if(idade >= 16)
                    {
                        this.Idade = idade;
                    }
                    else
                    {
                        Console.WriteLine("Idade menor que o permitido. Idade determinada como padrão de 16 anos");
                        this.Idade = 16;
                    }
                    break;
                
                case "CH":
                    
                    this.País = país;
                    if(idade >= 21)
                    {
                        this.Idade = idade;
                    }
                    else
                    {
                        Console.WriteLine("Idade menor que o permitido. Idade determinada como padrão de 21 anos");
                        this.Idade = 21;
                    }
                    break;
                
                case "RU":

                    this.País = país;
                    if(idade >= 21)
                    {
                        this.Idade = idade;
                    }
                    else
                    {
                        Console.WriteLine("Idade menor que o permitido. Idade determinada como padrão de 21 anos");
                        this.Idade = 21;
                    }
                    break;
                
                case "BR":

                    this.País = país;
                    List<string> listaCategorias = new List<string>() {"A", "B", "C", "D", "E", "AB", "AC", "AD", "AE"};
                    Random random = new Random();

                    int randomizaCategoria = random.Next(0, 9);
                    this.Categoria = listaCategorias[randomizaCategoria];
                    if(idade >= 18)
                    {
                        this.Idade = idade;
                    }
                    else
                    {
                        Console.WriteLine("Idade menor que o permitido. Idade determinada como padrão de 18 anos");
                        this.Idade = 18;
                    }
                    break;

            }
        }


    }
}