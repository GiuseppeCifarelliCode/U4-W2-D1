using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MultiSala
{
    internal class MultiSala
    {
        private static List<Sala> SalaNord = new List<Sala>();
        private static List<Sala> SalaEst = new List<Sala>();
        private static List<Sala> SalaSud = new List<Sala>();
        public static int PostiRimastiNord = 120;
        public static int PostiRimastiEst = 120;
        public static int PostiRimastiSud = 120;

        public static void Menu()
        {
            Console.WriteLine("============MENU============");
            Console.WriteLine("1. Inserisci prenotazione");
            Console.WriteLine("2. Mostra posti liberi");
            Console.WriteLine("3. ESCI");
            Console.WriteLine("============MENU============");
            try
            {
              int option = Convert.ToInt16(Console.ReadLine());
              switch(option)
                {
                    case 1:
                        InserisciPrenotazione();
                        Menu();
                        break;

                    case 2:
                        MostraPostiDisponibili();
                        Menu();
                        break;

                    case 3:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("L'opzione inserita non esiste");
                        Menu();
                        break;
                }
            }
            catch {
                Console.WriteLine("L'opzione inserita non esiste");
                Menu() ;
            }
        }

        public static void InserisciPrenotazione()
        {
            Console.WriteLine("Inserisci Nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Inserisci Cognome");
            string cognome = Console.ReadLine();
            Console.WriteLine("A quale sala vuoi inserirlo?");
            Console.WriteLine("1. SALA NORD");
            Console.WriteLine("2. SALA EST");
            Console.WriteLine("3. SALA SUD");
            try
            {
                int option = Convert.ToInt16(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        Sala nuovaPrenotazione = new Sala(nome, cognome);
                        Console.WriteLine("Il biglietto è ridotto? y/n");
                        string risposta = Console.ReadLine().ToLower();
                        if (risposta == "y")
                        {
                            nuovaPrenotazione.TicketRidotto = true;
                            Console.WriteLine("Hai preso il biglietto ridotto");
                        }
                        else {
                            nuovaPrenotazione.TicketRidotto = false;
                            Console.WriteLine("Hai preso il biglietto intero");
                        }
                        PostiRimastiNord -= 1;
                        SalaNord.Add(nuovaPrenotazione);
                        Console.WriteLine($"Sono rimasti {PostiRimastiNord} posti nella sala NORD");                       
                        break;

                    case 2:
                        Sala nuovaPrenotazione2 = new Sala(nome, cognome);
                        Console.WriteLine("Il biglietto è ridotto? y/n");
                        string risposta2 = Console.ReadLine().ToLower();
                        if (risposta2 == "y")
                        {
                            nuovaPrenotazione2.TicketRidotto = true;
                            Console.WriteLine("Hai preso il biglietto ridotto");
                        }
                        else
                        {
                            nuovaPrenotazione2.TicketRidotto = false;
                            Console.WriteLine("Hai preso il biglietto intero");
                        }
                        PostiRimastiEst -= 1;
                        SalaEst.Add(nuovaPrenotazione2);
                        Console.WriteLine($"Sono rimasti {PostiRimastiEst} posti nella sala EST");
                        break;

                    case 3:
                        Sala nuovaPrenotazione3 = new Sala(nome, cognome);
                        Console.WriteLine("Il biglietto è ridotto? y/n");
                        string risposta3 = Console.ReadLine().ToLower();
                        if (risposta3 == "y")
                        {
                            nuovaPrenotazione3.TicketRidotto = true;
                            Console.WriteLine("Hai preso il biglietto ridotto");
                         }
                        else
                        {
                            nuovaPrenotazione3.TicketRidotto = false;
                            Console.WriteLine("Hai preso il biglietto intero");
                        }
                        PostiRimastiSud -= 1;
                        SalaSud.Add(nuovaPrenotazione3);
                        Console.WriteLine($"Sono rimasti {PostiRimastiSud} posti nella sala SUD");
                        break;

                    default:
                        Console.WriteLine("L'opzione inserita non esiste");
                        Menu();
                        break;
                }
            }
            catch { 
                Console.WriteLine("L'opzione inserita non esiste");
                Menu();
            }
            
        }

        public static void MostraPostiDisponibili()
        {
            Console.WriteLine($"Sono rimasti {PostiRimastiNord} posti nella sala NORD");
            Console.WriteLine($"Sono rimasti {PostiRimastiEst} posti nella sala EST");
            Console.WriteLine($"Sono rimasti {PostiRimastiSud} post nella sala SUD");
        }
    }
}
