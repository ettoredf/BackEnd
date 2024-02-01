using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona();

            persona1.Nome = "Ettore";
            persona1.Cognome = "Di Francesco";
            persona1.Eta = 22;

            // Console.WriteLine($"Nome: {persona1.GetNome()}");
            // Console.WriteLine($"Cognome: {persona1.GetCognome()}");
            // Console.WriteLine($"Età: {persona1.GetEta()}");
            Console.WriteLine($"Dettagli:\n{persona1.GetDettagli()}");
        }
    }
}
