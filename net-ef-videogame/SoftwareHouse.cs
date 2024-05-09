using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace net_ef_videogame
{
    [Table("software_house")]
    [Index(nameof(SoftwareHouseId), IsUnique = true)]
    public class SoftwareHouse
    {
        [Key] public int SoftwareHouseId { get; set; }
        public string? Name { get; set; }
        public int VideogamesId { get; set; }
        public List<Videogames>? Videogames { get; set; } // N-N
        public SoftwareHouse() { }

        public SoftwareHouse(int softwareHouseId, string? name, int videogamesId)
        {
            this.SoftwareHouseId = softwareHouseId;
            this.Name = name;
            this.VideogamesId = videogamesId;
        }

        public static void StampaDbSoftwareHouse(List<SoftwareHouse> lista)
        {
            if (lista.Count > 0)
            {
                Console.WriteLine("Software House presenti nel database:");

                foreach (var sh in lista)
                {
                    Console.WriteLine($"ID: {sh.SoftwareHouseId}, Nome: {sh.Name},");
                }
            }
        }
    }
}
