using src.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.Interfaces
{
    public interface IEventoInterface
    {
        void Listar();
        void Cadastrar(string nomeDoEvento, int participantes, DateTime dataDoEvento, int duracaoDoEvento, Usuario criadoPor);
        void Detalhar(Evento IdEvento);
        void Editar(Evento IdEvento);
        void Remover(Evento IdEvento);

    }
}