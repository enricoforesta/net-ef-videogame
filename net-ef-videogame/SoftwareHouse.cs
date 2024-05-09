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
        public List<Videogames>? Videogames { get; set; } // N-N
        public SoftwareHouse() { }

        public SoftwareHouse(int softwareHouseId, string? name, List<Videogames>? videogames)
        {
            this.SoftwareHouseId = softwareHouseId;
            this.Name = name;
            this.Videogames = videogames;
        }
    }
}
