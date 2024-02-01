using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Be_W1_L4
{
    public static class Utente
    {
        public static string username;
        public static string password;
        public static bool IsLogged;
        public static DateTime DataLog;

        public static void Login()
        {
            Console.WriteLine("Inserisci username:");
            Utente.username = Console.ReadLine();

            Console.WriteLine("Inserisci password:");
            Utente.password = Console.ReadLine();

            Console.WriteLine("Conferma password:");
            string conferma = Console.ReadLine();

            if ((Utente.password == conferma) && (Utente.username != ""))
            {
                IsLogged = true;
                DataLog = DateTime.Now;
                Console.WriteLine($"Utente correttamente loggato alle ore {DataOraLog}");
            }
            else
            {
                Console.WriteLine("Non è possibile effettuare il login");
            }
        }

        public static void Logout()
        {
            username = "";
            password = "";
            IsLogged = false;
            Console.WriteLine("Nessun utente loggato al sistema");
        }

        public static void StampaDataEOraLogin()
        {
            if (Utente.IsLogged == true)
            {
                Console.WriteLine($"L'utente {Utente.username} ha effettuato l'accesso il {Utente.DataOraLog}");
            }
            else
            {
                Console.WriteLine("Non risultano utenti loggati a sistema");
            }
        }
    }
}

    