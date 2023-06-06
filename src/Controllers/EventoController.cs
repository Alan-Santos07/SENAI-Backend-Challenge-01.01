using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using src.Classes;
using src.Interfaces;
using static System.Net.Mime.MediaTypeNames;

namespace src.Controller
{
    [ApiController]
    [Route("api/eventos")]
    public class EventoController : IEventoInterface
    {
        private List<Evento> eventos;

        public void EventosController()
        {
            eventos = new List<Evento>();
        }

        [HttpPost]
        public void Cadastrar(string nomeDoEvento, int participantes, DateTime dataDoEvento, int duracaoDoEvento, Usuario criadoPor)
        {
            Evento evento = new Evento(nomeDoEvento, participantes, dataDoEvento, duracaoDoEvento, criadoPor);
            evento.IdEvento = eventos.Count + 1;
            eventos.Add(evento);
            Console.WriteLine("Evento cadastrado: " + evento.NomeDoEvento);
        }

        [HttpGet("{id}")]
        public void Detalhar(Evento IdEvento)
        {
            throw new NotImplementedException();
        }

        public void Editar(Evento IdEvento)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public void Listar()
        {
            Console.WriteLine("Eventos na lista:");
            foreach (var evento in eventos)
            {
                Console.WriteLine($"Nome: {evento.NomeDoEvento}, Data: {evento.DataDoEvento}");
            }
        }

        public void Remover(Evento IdEvento)
        {
            throw new NotImplementedException();
        }
    }
}