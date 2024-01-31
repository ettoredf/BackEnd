using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int Eta { get; set; }

        public string GetNome () 
        { 
            return Nome; 
        }
        public string GetCognome ()
        {
            return Cognome;
        }
        public int GetEta ()
        {
            return Eta;
        }

        public string GetDettagli ()
        {
            return ($"Nome: {this.Nome},\nCognome: {this.Cognome},\nEtà: {this.Eta}");
        }
    }
}
