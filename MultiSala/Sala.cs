using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiSala
{
    internal class Sala
    {
        private string Nome { get; set; }
        private string Cognome { get; set; } 

        public bool TicketRidotto = false;

        public Sala() { }

        public Sala(string nome, string cognome)
        {
            this.Nome = nome;
            this.Cognome = cognome;
        }
    }
}
