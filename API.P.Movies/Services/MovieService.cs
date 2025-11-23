using API.P.Movies.DAL.Models.Dtos;
using API.P.Movies.Services.IServices;

namespace API.P.Movies.Services
{
    public class MovieService: IMovieService
    {

        public MovieService() { }

        public Task<CategoryDto> CreateMovieAsync(CategoryCreateUpdateDto categoryCreateDto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteMovieAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CategoryDto> GetMovieAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<MovieDto>> GetMoviesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CategoryDto> UpdateMovieAsync(CategoryCreateUpdateDto dto, int id)
        {
            throw new NotImplementedException();
        }
    }
}
