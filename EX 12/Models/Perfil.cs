using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EX_12.Models
{
    public class Perfil
    {
        public string Nome { get; set; }
        private string _avatar;
        public string Avatar
        {
            get { return _avatar; }
            set 
            {
                if (value.StartsWith("http") || value.StartsWith("https"))
                {
                    _avatar = value;
                }
                else
                {
                    throw new ArgumentException("URL inválida.");
                }
            }
        }
        private string _tema;
        public string Tema 
        {
            get { return _tema; }
            set 
            {
                switch (value)
                {
                    case "light":
                        _tema = "Claro";
                        break;

                    case "dark":
                        _tema = "Escuro";
                        break;

                    default:
                        throw new ArgumentException("O tema deve ser Claro (light) ou Escuro (dark)");
                }
            }
        }
        public Perfil(string nome, string avatar, string tema)
        {
            this.Nome = nome;
            Avatar = avatar;
            Tema = tema;
        }
    }
}