using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.Classes
{
    public class Usuario
    {
        public int IdUsuario { get; set; }

        public string Nome { get; set; }

        public int Idade { get; set; }

        private string CPF { get; set; }

        public Usuario(string nome, int idade, string cpf)
        {
            Nome = nome;
            Idade = idade;
            CPF = cpf;
        }
    }
}