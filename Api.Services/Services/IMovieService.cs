using Api.Models.Models;

namespace Api.Services.Services
{
    public interface IMovieService
    {
        public Movie Create(Movie movie);
        public Movie Get(int id);
        public List<Movie> List();
        public Movie Update(Movie movie);
        public bool Delete(int id);
    }
}