using API.P.Movies.DAL.Models;
using API.P.Movies.DAL.Models.Dtos;
using API.P.Movies.Repository;
using API.P.Movies.Repository.IRepository;
using API.P.Movies.Services.IServices;
using AutoMapper;

namespace API.P.Movies.Services
{
    public class MovieService: IMovieService
    {

        private readonly IMovieRepository _movieRepository;
        private readonly IMapper _mapper;

        public MovieService(IMovieRepository movieRepository, IMapper mapper)
        {
            _movieRepository = movieRepository;
            _mapper = mapper;
        }

        public async Task<MovieDto> CreateMovieAsync(MovieCreateUpdateDto movieCreateDto)
        {
            var movieExists = await _movieRepository.CreateMovieAsync(movieCreateDto.Name);

            if (movieExists)
            {
                throw new InvalidOperationException($"Ya existe una películas con el nombre '{movieCreateDto.Name}'");
            }

            //Mappear de DTO a la entidad/modelo Category
            var movie = _mapper.Map<Movie>(movieCreateDto);

            //Crear la películas en la base de datos
            var movieCreated = await _movieRepository.CreateMovieAsync(movie);

            if (!movieCreated)
            {
                throw new InvalidOperationException("Ocurrió un error al crear la películas");
            }

            var movieDto = _mapper.Map<MovieDto>(movie);
            return movieDto;
        }

        public Task<bool> DeleteMovieAsync(int id)
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

        public Task<MovieDto> UpdateMovieAsync(MovieCreateUpdateDto dto, int id)
        {
            throw new NotImplementedException();
        }
    }
}
