using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContoCorrente
{
    public class ContoCorrente
    {
        public string NomeCliente
        {
            get { return _nomeCliente; }
            set { _nomeCliente = value; }
        }

        private string _cognomeCliente;
        public string CognomeCliente
        {
            get { return _cognomeCliente; }
            set { _cognomeCliente = value; }
        }

        private string _nomeCliente;

        private decimal _saldo = 0;
        public decimal Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }

        private bool _contoAperto = false;

        public bool ContoAperto
        {
            get { return _contoAperto; }
            set { _contoAperto = value; }
        }

        public ContoCorrente()
        {

        }

        public void MenuIniziale()
        {

            Console.WriteLine("\n Scegli l'operazione da effettuare:");
            Console.WriteLine("1. Apri Nuovo Conto Corrente");
            Console.WriteLine("2. Effettua un versamento");
            Console.WriteLine("3. Effettua un prelievo");
            Console.WriteLine("4. Chiudi programma");

            int scelta = int.Parse(Console.ReadLine());

            if (scelta == 1)
            {
                ApriNuovoContoCorrente();
            }
            else if (scelta == 2)
            {
                EffettuaVersamento();
            }
            else if (scelta == 3)
            {
                EffettuaPrelievo();
            }
            else if (scelta == 4)
            {
                Console.WriteLine("Chiusura programma in corso");
            }
            else
            {
                Console.WriteLine("Hai selezionato una voce non valida.");
                MenuIniziale();
            }

        }

        private void ApriNuovoContoCorrente()
        {
            Console.WriteLine("Nome Cliente: ");
            string Nome = Console.ReadLine();

            Console.WriteLine("Cognome Cliente: ");
            string Cognome = Console.ReadLine();

            ContoCorrente c = new ContoCorrente();
            _nomeCliente = Nome;
            _cognomeCliente = Cognome;
            _saldo = 0;
            _contoAperto = true;
            Console.WriteLine($"Conto corrente nr. 0123456 intestato a: {_cognomeCliente} {_nomeCliente} aperto correttamente");
            MenuIniziale();
        }

        private void EffettuaPrelievo()
        {
            if (_contoAperto == false)
            {
                Console.WriteLine("E' necessario aprire un conto prima di effettuare un prelievo");
            }
            else
            {
                Console.WriteLine("Inserisci l'importo del prelievo da effettuare: ");
                decimal importoPrelevato = Decimal.Parse(Console.ReadLine());

                if (importoPrelevato > _saldo)
                {
                    Console.WriteLine("Prelievo non consentito");
                }
                else
                {
                    Console.WriteLine("Prelievo effettuato");
                    _saldo -= importoPrelevato;
                    Console.WriteLine($"Nuovo saldo disponibile: {_saldo.ToString("N")}");
                }
            }
            MenuIniziale();
        }

        private void EffettuaVersamento()
        {
            if (_contoAperto == false)
            {
                Console.WriteLine("E' necessario aprire un conto prima di effettuare un versamento");
            }
            else
            {
                Console.WriteLine("Inserisci l'importo da versare: ");
                decimal importoVersato = Decimal.Parse(Console.ReadLine());

                Console.WriteLine("Versamento effettuato");
                _saldo += importoVersato;
                Console.WriteLine($"Nuovo saldo disponibile: {_saldo.ToString("N")}");
            }
            MenuIniziale();
        }


    }
}
