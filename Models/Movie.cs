using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models;

public class Movie
{
    public int Id { get; set; }
    [StringLength(60, MinimumLength = 3)]
    [Required]
    public string? Title { get; set; }
    
    [Display(Name = "Release Date")]
    [DataType(DataType.Date)]
    [Required]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTime ReleaseDate { get; set; }

    [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), Required, StringLength(30)]
    public string? Genre { get; set; }

    [Range(1, 100)]
    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }


    //[RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
    //[StringLength(5)]
    [Column(TypeName = "decimal(3, 1)")]
    [Range(0, 10, ErrorMessage = "Rating must be between 0 and 10")]
    [Required]
    public decimal Rating { get; set; }
}