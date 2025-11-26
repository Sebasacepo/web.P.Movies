using API.P.Movies.DAL.Models;
using System.ComponentModel.DataAnnotations;

public class Movie : AuditBase
{
  
    [Required] 
    [Display(Name = "Película")]
    public string duration { get; set; }
    public string? description { get; set; }
    public string clasification { get; set; }
    public string Name { get; internal set; }
}