using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariEdenV2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Animale> Animali = new List<Animale>{
                    new Camaleonte("Midori", DateTime.Now, 3, "Media", "Verde"),
                    new Camaleonte("Gurin", DateTime.Now, 3, "Grande", "Blu"),
                    new Camaleonte("Broccoletto", DateTime.Now, 1, "Piccola", "Verde Scuro"),

                    new Canguro("Kanga", DateTime.Now.AddDays(-10), 3, "Grande", "Emilia"),
                    new Canguro("Roo", DateTime.Now.AddDays(-5), 1, "Piccola", "Kanga"),

                    new Pinguino("Tibo", DateTime.Now, 3, "Piccola", "Skipper"),
                    new Pinguino("Lulu", DateTime.Now.AddDays(-2), 1, "Piccola", "Soldato"),
                    new Pinguino("Silver", DateTime.Now.AddDays(-5), 3, "Piccola", "Kowalski"),
                    new Pinguino("Icy", DateTime.Now.AddDays(-10), 4, "Piccola", "Rico"),

                    new Orso("Grizzly", DateTime.Now, 4, "Grande", "Miele"),
                    new Orso("Panda", DateTime.Now.AddDays(-3), 3, "Grande", "Bambù"),
                    new Orso("Bianco", DateTime.Now.AddDays(-7), 5, "Grande", "Pesce"),

                    new Coccodrillo("Denti", DateTime.Now, 5, "Media", "Cauto"),
                    new Coccodrillo("Squama", DateTime.Now.AddDays(-2), 4, "Grande", "Aggressiva")
                };

            
            MainMenu(Animali);
        }

        static void MainMenu(List<Animale> Animali)
        {
            Console.Clear();
            Console.WriteLine("Buongiorno Safari Eden!");
            Console.WriteLine("Cosa vuoi fare?");
            Console.WriteLine("1: Aggiungi animale");
            Console.WriteLine("2: Visualizza per categorie");
            Console.WriteLine("3: Verifica dell'ultimo pasto");
            Console.WriteLine("4: Dai da mangiare ad un animale");
            Console.WriteLine("q: Esci");

            Console.WriteLine("");
            string Input = Console.ReadLine();

            switch (Input)
            {
                case "1":
                    AggiuntaAnimale(Animali);
                    break;

                case "2":
                    VisualizzaCategorie(Animali);
                    break;

                case "3":
                    VerificaUltimoPasto(Animali);
                    break;

                case "4":
                    DaiDaMangiare(Animali, true);
                    break;

                case "q":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Comando errato");
                    MainMenu(Animali);
                    break;
            }
        }

        static void AggiuntaAnimale(List<Animale> Animali)
        {
            Console.Clear();
            Console.WriteLine("Aggiunta animale");
            Console.WriteLine("Che animale vuoi aggingere?");
            Console.WriteLine("1: Camaleonte");
            Console.WriteLine("2: Canguro");
            Console.WriteLine("3: Pinguino");
            Console.WriteLine("4: Orso");
            Console.WriteLine("5: Coccodrillo");
            Console.WriteLine("e: Indetro");

            Console.WriteLine("");
            string Input = Console.ReadLine();

            void Aggiunta(Animale animale, string stringa, string caratteristica)
            {
                Console.Clear();
                Console.WriteLine($"Aggiunta {stringa}:");


                string InputNome;
                do {
                    Console.WriteLine("Nome: ");
                    InputNome = Console.ReadLine();
                } while (string.IsNullOrWhiteSpace(InputNome));

                int InputEtà = -1;
                do
                {
                    Console.WriteLine("Età: ");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out InputEtà))
                    {
                        InputEtà = int.Parse(input);
                    }
                } while (InputEtà < 0);

                string InputDimensioni;
                do
                {
                    Console.WriteLine("Dimensioni: ");
                    InputDimensioni = Console.ReadLine();
                } while (string.IsNullOrWhiteSpace(InputDimensioni));

                string InputSpeciale;
                do
                {
                    Console.WriteLine($"{caratteristica}: ");
                    InputSpeciale = Console.ReadLine();
                } while (string.IsNullOrWhiteSpace(InputSpeciale));

                
                switch (stringa) {
                    case "Camaleonte":
                        Animali.Add(new Camaleonte(InputNome, DateTime.Now, InputEtà, InputDimensioni, InputSpeciale));
                        break;

                    case "Canguro":
                        Animali.Add(new Canguro(InputNome, DateTime.Now, InputEtà, InputDimensioni, InputSpeciale));
                        break;

                    case "Pinguino":
                        Animali.Add(new Pinguino(InputNome, DateTime.Now, InputEtà, InputDimensioni, InputSpeciale));
                        break;

                    case "Orso":
                        Animali.Add(new Orso(InputNome, DateTime.Now, InputEtà, InputDimensioni, InputSpeciale));
                        break;

                    case "Coccodrillo":
                        Animali.Add(new Coccodrillo(InputNome, DateTime.Now, InputEtà, InputDimensioni, InputSpeciale));
                        break;
                    
                    default:
                        Console.WriteLine($"Errore");
                        return;
                }

                Console.WriteLine($"{stringa} aggiunto con successo:");
                return;
            };

            switch (Input)
            {
                case "1":
                    Aggiunta(new Camaleonte(), "Camaleonte", "Colore");
                    break;

                case "2":
                    Aggiunta(new Canguro(), "Canguro", "Madre");
                    break;

                case "3":
                    Aggiunta(new Pinguino(), "Pinguino", "Nome in codice");
                    break;

                case "4":
                    Aggiunta(new Orso(), "Orso", "Cibo preferito");
                    break;

                case "5":
                    Aggiunta(new Coccodrillo(), "Coccodrillo", "Temperamento");
                    break;

                case "e":
                    MainMenu(Animali);
                    break;

                default:
                    Console.WriteLine("Comando errato");
                    AggiuntaAnimale(Animali);
                    break;
            }

            Console.WriteLine("\nPremi un tasto per tornare indietro");
            Console.ReadKey();
            AggiuntaAnimale(Animali);
        }
        static void VisualizzaCategorie(List<Animale> Animali)
        {
            Console.Clear();
            Console.WriteLine("Visualizza categorie");
            Console.WriteLine("Che categoria vuoi visualizzare?");
            Console.WriteLine("1: Camaleonti");
            Console.WriteLine("2: Canguri");
            Console.WriteLine("3: Pinguini");
            Console.WriteLine("4: Orsi");
            Console.WriteLine("5: Coccodrilli");
            Console.WriteLine("e: Indetro");

            Console.WriteLine("");
            string Input = Console.ReadLine();

            switch (Input)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Camaleonti: ");

                    foreach (var i in Animali)
                    {
                        if(i.GetType() == typeof(Camaleonte))
                        {
                            Console.WriteLine(i.GetToString());
                        }
                    }
                    break;

                case "2":
                    Console.Clear();
                    Console.WriteLine("Canguri: ");

                    foreach (var i in Animali)
                    {
                        if (i.GetType() == typeof(Canguro))
                        {
                            Console.WriteLine(i.GetToString());
                        }
                    }

                    break;

                case "3":
                    Console.Clear();
                    Console.WriteLine("Pinguini: ");

                    foreach (var i in Animali)
                    {
                        if (i.GetType() == typeof(Pinguino))
                        {
                            Console.WriteLine(i.GetToString());
                        }
                    }

                    break;

                case "4":
                    Console.Clear();
                    Console.WriteLine("Orsi: ");

                    foreach (var i in Animali)
                    {
                        if (i.GetType() == typeof(Orso))
                        {
                            Console.WriteLine(i.GetToString());
                        }
                    }

                    break;

                case "5":
                    Console.Clear();
                    Console.WriteLine("Coccodrilli: ");

                    foreach (var i in Animali)
                    {
                        if (i.GetType() == typeof(Coccodrillo))
                        {
                            Console.WriteLine(i.GetToString());
                        }
                    }

                    break;

                case "e":
                    MainMenu(Animali);
                    break;

                default:
                    Console.WriteLine("Comando errato");
                    VisualizzaCategorie(Animali);
                    break;
            }

            Console.WriteLine("\nPremi un tasto per tornare indietro");
            Console.ReadKey();
            VisualizzaCategorie(Animali);
        }

        static void VerificaUltimoPasto(List<Animale> Animali)
        {
            Console.Clear();
            Console.WriteLine("Verifica ultimo pasto: ");
            foreach (var Animale in Animali)
            {
                    Console.WriteLine(Animale.LastFeed());
            }

            Console.WriteLine("\nPremi un tasto per tornare indietro");
            Console.ReadKey();
            MainMenu(Animali);
        }

        static void DaiDaMangiare(List<Animale> Animali, bool Clear)
        {
            bool AnimalFound = false;
            if (Clear)
            {
                Console.Clear();
                Console.WriteLine("Dai da mangiare");
            }
            
            Console.WriteLine("Scrivi il nome dell'animale che deve mangiare");
            Console.WriteLine("l: Lista nomi");
            Console.WriteLine("e: Indietro");

            Console.WriteLine("");
            string Input = Console.ReadLine();
            if(Input == "e")
            {
                MainMenu(Animali);
            }
            if (Input == "l")
            {
                foreach (var Animale in Animali)
                {
                    Console.WriteLine("Lista Nomi");
                        Console.WriteLine($"{Animale.Name}");
                }
                Console.WriteLine("");
                DaiDaMangiare(Animali, false);
            }
            else
            {
                foreach (var Animale in Animali)
                {
                    if (Animale.Name == Input)
                    {
                        Animale.FeedAnimal();
                        Console.Clear();
                        Console.WriteLine($"{Animale.Name} ha mangiato");
                        AnimalFound = true;
                        break;
                    }
                }

                if (!AnimalFound)
                {
                    Console.WriteLine("Animale non trovato");
                    Console.WriteLine("\nPremi un tasto per tornare indietro");
                    Console.ReadKey();
                    DaiDaMangiare(Animali, true);
                }

                Console.WriteLine("\nPremi un tasto per tornare indietro");
                Console.ReadKey();
                DaiDaMangiare(Animali, true);
            }

            
        }
    }
}
