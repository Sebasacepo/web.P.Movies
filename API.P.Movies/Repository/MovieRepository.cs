using API.P.Movies.DAL;
using API.P.Movies.DAL.Models;
using API.P.Movies.DAL.Models.Dtos;
using API.P.Movies.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

public class MovieRepository : IMovieRepository
{
    private readonly ApplicationDbContext _context;
    public MovieRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    public Task<MovieDto> CreateCategoryAsync(MovieCreateUpdateDto categoryCreateDto)
    {
        throw new NotImplementedException();
    }    
       

    public async Task<bool> CreateMovieAsync(Movie movie)
    {
        movie.CreatedDate = DateTime.UtcNow;

        _context.Movies.Add(movie);
        return await SaveAsync();
    }

    public Task<bool> CreateMovieAsync(string name)
    {
        throw new NotImplementedException();
    }

    public Task DeleteMovieAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<MovieDto> GetMovieAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<MovieDto>> GetMoviesAsync()
    {
        throw new NotImplementedException();
    }

    public Task<MovieDto> UpdateCategoryAsync(MovieCreateUpdateDto dto, int id)
    {
        throw new NotImplementedException();
    }

    private async Task<bool> SaveAsync()
    {
        return await _context.SaveChangesAsync() >= 0 ? true : false;
    }
}