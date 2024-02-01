using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Leyer.Entities;

public class Artist
{
    [Key]
    public int ArtistId { get; set; }
    [Required]
    public string ArtistName { get; set; }
    [Required]
    public string Password { get; set; }
    public DateTime Created { get; set; } = DateTime.Now;
    public bool IsBanned { get; set; } = false;

    public ICollection<Article> Articles { get; set; }
}
