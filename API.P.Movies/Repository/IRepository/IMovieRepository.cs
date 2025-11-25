using API.P.Movies.DAL.Models;
using API.P.Movies.DAL.Models.Dtos;

namespace API.P.Movies.Repository.IRepository
{
    public interface IMovieRepository
    {
        Task<ICollection<MovieDto>> GetMoviesAsync();
        Task<MovieDto?> GetMovieAsync(int id);
        Task<MovieDto> CreateCategoryAsync(MovieCreateUpdateDto categoryCreateDto);
        Task<MovieDto> UpdateCategoryAsync(MovieCreateUpdateDto dto, int id);
        Task DeleteMovieAsync(int id);
        Task<bool> CreateMovieAsync(string name);
    }
}
