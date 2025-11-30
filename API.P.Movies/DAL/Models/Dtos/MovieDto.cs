using System.ComponentModel.DataAnnotations;

namespace API.P.Movies.DAL.Models.Dtos
{
    public class MovieDto
    {      
            public int Id { get; set; }

            [Required(ErrorMessage = "El nombre de la película es obligatorio.")]
            [MaxLength(50, ErrorMessage = "El número máximo de caracteres es de 50.")]
            public string Name { get; set; }
            public DateTime CreatedDate { get; set; }
            public DateTime? UpdatedDate { get; set; }
        }
    }

