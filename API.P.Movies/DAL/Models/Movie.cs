using API.P.Movies.DAL.Models;
using System.ComponentModel.DataAnnotations;

public class Movie : AuditBase
{
  
    [Required]
    public string duration { get; set; }

    public string? description { get; set; }

    [Required]
    [MaxLength(10)]
    public string clasification { get; set; }
}