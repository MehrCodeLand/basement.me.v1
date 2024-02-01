using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Leyer.Entities;

public class Article
{
    [Key]
    public int ArticleId { get; set; }
    [Required]
    [MaxLength(100 , ErrorMessage = "Max is 100")]
    [MinLength(2 , ErrorMessage = "Min is 2")]
    public string Title { get; set; }
    [Required]
    public string body { get; set; }
    public string Description { get; set; }

    [Required]
    public int ArtistId { get; set; }
    public Artist Artist { get; set; }
}
