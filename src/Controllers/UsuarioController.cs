using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using src.Classes;
using src.Interfaces;

namespace src.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : IUsuarioInterface
    {
        private List<Usuario> usuarios;

        public void Usuarios()
        {
            usuarios = new List<Usuario>();
        }

        [HttpGet]
        public void Listar()
        {
            Console.WriteLine("Usuários na lista:");
            foreach (var usuario in usuarios)
            {
                Console.WriteLine($"Nome: {usuario.Nome}, Idade: {usuario.Idade}");
            }
        }

        [HttpPost]
        public void Cadastrar(string nome, int idade, string cpf)
        {
            Usuario usuario = new Usuario(nome, idade, cpf);
            usuarios.Add(usuario);
            Console.WriteLine("Usuário cadastrado: " + usuario.Nome);
        }

        [HttpDelete]
        public void Remover(Usuario id)
        {
            usuarios.Remove(id);
            Console.WriteLine("Usuario Removido");
        }
    }
}