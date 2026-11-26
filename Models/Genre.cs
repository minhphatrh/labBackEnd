
using System.ComponentModel.DataAnnotations;

namespace _31241022342_TrinhMinhPhat.Models;

public class Genre
{
    [Key]
    public int ID { get; set; }

    [Display(Name = "Tên")]
    [Required]
    [StringLength(200)]
    public string Name { get; set; }

    public virtual IList<Movie> Movies { get; set; }
}
