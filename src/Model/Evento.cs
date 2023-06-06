using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace src.Classes
{
    public class Evento
    {
        public int IdEvento { get; set; }
        
        public string NomeDoEvento { get; set; }

        public int Participantes { get; set; }

        public DateTime DataDoEvento { get; set; }

        public float DuracaoDoEvento { get; set; }

        private Usuario CriadoPor { get; set; }

        public Evento(string nome, int participantes, DateTime data, float duracao, Usuario criadoPor)
        {
            NomeDoEvento = nome;
            Participantes = participantes;
            DataDoEvento = data;    
            DuracaoDoEvento = duracao;
            CriadoPor = criadoPor;
        }
    }
}