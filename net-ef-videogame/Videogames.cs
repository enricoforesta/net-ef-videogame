using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace net_ef_videogame
{

    [Table("videogames")]
    [Index(nameof(VideogamesId), IsUnique = true)]
    public class Videogames
    {
        [Key]
        public int VideogamesId { get; set; }
        public string Name { get; set; }
        public string? Overview { get; set; }
        [Column("release_date")]
        public string ReleaseDate { get; set; }
        [Column("created_at")]
        public DateTime CreatedAt { get; set; }
        [Column("update_at")]
        public DateTime UpdatedAt { get; set; }
        public int SoftwareHouseId { get; set; }
        public List<SoftwareHouse>? SoftwareHouseList { get; set; } // N-N
        public Videogames() { }
        public Videogames(string name, string overview, string releaseDate, DateTime createdAt, DateTime updateAt, int softwareHouseId)
        {
            this.Name = name;
            this.Overview = overview;
            this.ReleaseDate = releaseDate;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updateAt;
            this.SoftwareHouseId = softwareHouseId;
        }

        public override string ToString()
        {
            return $"ID: {VideogamesId} - Nome: {Name} - Descrizione: {Overview} - Data di rilascio {ReleaseDate}";
        }
    }
}
