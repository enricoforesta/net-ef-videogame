namespace net_ef_videogame
{
    public static class VideogameManager
    {
        public static void InserisciVideogioco(Videogames Videogame)
        {
            using VideogamesContext db = new VideogamesContext();
            db.Add(Videogame);
            db.SaveChanges();
        }

        public static void RicercaVideogiocoId(int idInput)
        {
            using VideogamesContext db = new VideogamesContext();
            Videogames videogamesTarget = db.Videogames.Find(idInput);
            if (videogamesTarget == null)
            {
                Console.WriteLine("Nessun Videogames trovato");

            }
            else
            {
                Console.WriteLine(videogamesTarget.ToString());
            }
        }

        public static void RicercaVideogiocoNome(string nameInput)
        {
            using VideogamesContext db = new VideogamesContext();
            List<Videogames> videogames = db.Videogames.Where(x => x.Name.Contains(nameInput)).ToList();
            if (videogames.Count == 0)
            {
                Console.WriteLine("Nessun Videogames trovato");
            }
            else
            {
                foreach (var videogame in videogames)
                {
                    Console.WriteLine($"Nome: {videogame.Name} - Descrizione: {videogame.Overview} -  Data di rilascio: {videogame.ReleaseDate}");
                }

            }

        }

        public static void EliminaVideogioco(int idDelete)
        {
            using VideogamesContext db = new VideogamesContext();
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
        }
    }
}
