namespace net_ef_videogame
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {


                /*  USATO PER CREARE 5 SOFTWARE HOUSE
                    var softwareHouses = new List<SoftwareHouse>
                     {
                     new SoftwareHouse { Name = "SoftwareHouse 1" },
                     new SoftwareHouse { Name = "SoftwareHouse 2" },
                     new SoftwareHouse { Name = "SoftwareHouse 3" },
                     new SoftwareHouse { Name = "SoftwareHouse 4" },
                     new SoftwareHouse { Name = "SoftwareHouse 5" }
                     };

                 db.SoftwareHouse.AddRange(softwareHouses);
                 db.SaveChanges(); */

                /* USATO PER CREARE 5 videogames
                var videogames = new List<Videogames>
                     {
                     new Videogames { Name = "Videogames 1" , Overview = "Bello", ReleaseDate="20/01/2021", SoftwareHouseId = 2},
                     new Videogames { Name = "Videogames 2" , Overview = "Bello", ReleaseDate="20/01/2021", SoftwareHouseId = 3},
                     new Videogames {Name = "Videogames 3", Overview = "Bello", ReleaseDate = "20/01/2021", SoftwareHouseId = 5},
                     new Videogames {Name = "Videogames 4", Overview = "Bello", ReleaseDate = "20/01/2021", SoftwareHouseId = 2},
                     new Videogames {Name = "Videogames 5", Overview = "Bello", ReleaseDate = "20/01/2021", SoftwareHouseId = 1}
                     };
                using VideogamesContext db = new VideogamesContext();


                db.Videogames.AddRange(videogames);
                 db.SaveChanges(); */

                bool continua = true;

                while (continua)
                {
                    Console.WriteLine("Menu:");
                    Console.WriteLine("1. Inserire un nuovo videogioco");
                    Console.WriteLine("2. Ricercare un videogioco per ID");
                    Console.WriteLine("3. Ricercare tutti i videogiochi aventi il nome contenente una determinata stringa");
                    Console.WriteLine("4. Cancellare un videogioco");
                    Console.WriteLine("5. Stampare tutti i videogiochi di una Software house");
                    Console.WriteLine("6. Chiudere il programma");

                    Console.Write("Scelta: ");
                    string scelta = Console.ReadLine();

                    switch (scelta)
                    {
                        case "1":
                            Console.WriteLine("Inserire un nome: ");
                            string name = Console.ReadLine();
                            Console.WriteLine("Inserire una descrizione (OPZIONALE): ");
                            string overview = Console.ReadLine();
                            Console.WriteLine("Inserire data di rilascio: (dd/MM/yyyy) ");
                            string releaseDate = Console.ReadLine();
                            Console.WriteLine("Inserire data di rilascio: (dd/MM/yyyy) ");
                            int softwareHouseId = Convert.ToInt32(Console.ReadLine());
                            DateTime createdAt = DateTime.Now;
                            DateTime updateAt = DateTime.Now;
                            Videogames nuovoGames = new Videogames(name, overview, releaseDate, createdAt, updateAt, softwareHouseId);
                            VideogameManager.InserisciVideogioco(nuovoGames);
                            Console.WriteLine("Creato con successo");
                            break;
                        case "2":
                            Console.WriteLine("Inserisci un ID");
                            int idInput = Convert.ToInt32(Console.ReadLine());
                            VideogameManager.RicercaVideogiocoId(idInput);
                            break;
                        case "3":
                            Console.WriteLine("Inserisci un nome");
                            string? nameInput = Console.ReadLine();
                            VideogameManager.RicercaVideogiocoNome(nameInput);
                            break;
                        case "4":
                            Console.WriteLine("Inserisci un ID da cancellare");
                            int idDelete = Convert.ToInt32(Console.ReadLine());
                            VideogameManager.EliminaVideogioco(idDelete);
                            break;
                        case "5":
                            {
                                using VideogamesContext db = new VideogamesContext();
                                var softwareHouse = db.SoftwareHouse.ToList();
                               SoftwareHouse.StampaDbSoftwareHouse(softwareHouse);
                            }
                            Console.WriteLine("Inserisci un ID della software house");


                            break;
                        case "6":
                            continua = false;
                            break;
                        default:
                            Console.WriteLine("Scelta non valida.");
                            break;
                    }

                    Console.WriteLine();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }
    }
}
