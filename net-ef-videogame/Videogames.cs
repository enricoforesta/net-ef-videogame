using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_ef_videogame
{

    [Table("videogames")]
    [Index(nameof(VideogamsId), IsUnique = true)]
    public class Videogames
    {
        [Key] public int VideogamsId { get; set; }
        public string Name { get; set; }
        public string? Overview { get; set; }
        [Column("release_date")]
        public DateOnly ReleaseDate { get; set; }
        [Column("created_at")]
        public DateTime CreatedAt { get; set; }
        [Column("update_at")]
        public DateTime UpdatedAt { get;set; }

        List<SoftwareHouse>? SoftwareHouseList { get; set;} // N-N
    }
}
