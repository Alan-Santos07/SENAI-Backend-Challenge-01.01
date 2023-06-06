using src.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.Interfaces
{
    public interface IUsuarioInterface
    {
        void Listar();
        void Cadastrar(string nome, int idade, string cpf);
        void Remover(Usuario id);
    }
}