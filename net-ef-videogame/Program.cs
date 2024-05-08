namespace net_ef_videogame
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using VideogamesContext db = new VideogamesContext();

                bool continua = true;

                while (continua)
                {
                    Console.WriteLine("Menu:");
                    Console.WriteLine("1. Inserire un nuovo videogioco");
                    Console.WriteLine("2. Ricercare un videogioco per ID");
                    Console.WriteLine("3. Ricercare tutti i videogiochi aventi il nome contenente una determinata stringa");
                    Console.WriteLine("4. Cancellare un videogioco");
                    Console.WriteLine("5. Chiudere il programma");

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
                            DateTime createdAt = DateTime.Now;
                            DateTime updateAt = DateTime.Now;
                            Videogames nuovoGames = new Videogames(name, overview, releaseDate, createdAt, updateAt);
                            db.Add(nuovoGames);
                            db.SaveChanges();
                            Console.WriteLine("Creato con successo");
                            break;
                        case "2":
                            Console.WriteLine("Inserisci un ID");
                            int idInput = Convert.ToInt32(Console.ReadLine());
                            Videogames videogamesTarget = db.Videogames.Find(idInput);
                            if (videogamesTarget == null)
                            {
                                Console.WriteLine("Nessun Videogames trovato");
                                break;
                            }
                            Console.WriteLine(videogamesTarget.ToString());
                            break;
                        case "3":
                            Console.WriteLine("Inserisci un nome");
                            string? nameInput = Console.ReadLine();
                            List<Videogames> videogames = db.Videogames.Where(x => x.Name.Contains(nameInput)).ToList();
                            if (videogames.Count == 0)
                            {
                                Console.WriteLine("Nessun Videogames trovato");
                                break;
                            }
                            foreach (var videogame in videogames)
                            {
                                Console.WriteLine($"Nome: {videogame.Name} - Descrizione: {videogame.Overview} -  Data di rilascio: {videogame.ReleaseDate}");
                            }
                            break;
                        case "4":
                            Console.WriteLine("Inserisci un ID da cancellare");
                            int idDelete = Convert.ToInt32(Console.ReadLine());
                            var videogameToDelete = db.Videogames.Find(idDelete);
                            if (videogameToDelete == null)
                            {
                                Console.WriteLine("Nessun Videogames trovato con quell'ID");
                            }
                            else
                            {
                                db.Videogames.Remove(videogameToDelete); // Passa l'istanza dell'entità al metodo Remove
                                db.SaveChanges();
                                Console.WriteLine("Videogioco eliminato con successo.");
                            }
                            break;
                        case "5":
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
