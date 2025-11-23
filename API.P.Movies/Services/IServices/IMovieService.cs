using API.P.Movies.DAL.Models.Dtos;
using API.P.Movies.Repository.IRepository;

namespace API.P.Movies.Services.IServices
{
    public interface IMovieService
    {
        Task<ICollection<MovieDto>> GetMoviesAsync(); //Vamos aquí

        Task<CategoryDto> GetMovieAsync(int id);
        Task<CategoryDto> CreateMovieAsync(CategoryCreateUpdateDto categoryCreateDto);
        Task<CategoryDto> UpdateMovieAsync(CategoryCreateUpdateDto dto, int id);
        Task<bool> DeleteMovieAsync(int id);
    }
}
