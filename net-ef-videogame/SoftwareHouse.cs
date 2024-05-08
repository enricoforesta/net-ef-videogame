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
        List<Videogames>? Videogames { get; set; } // N-N
        public SoftwareHouse() { }
    }
}
