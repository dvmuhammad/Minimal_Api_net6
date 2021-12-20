using Api.Models.Models;

namespace Api.Repositories.Repositories
{
    public class MovieRepository
    {
        public static List<Movie> Movies = new()
        {
            new() { Id = 1, Title = "Spider-Man: No Way Home", Description = "With Spider-Man's identity now revealed, Peter asks Doctor Strange for help. When a spell goes wrong, dangerous foes from other worlds start to appear, forcing Peter to discover what it truly means to be Spider-Man", Rating = 10 },
            new() { Id = 2, Title = "Matrixa 4", Description = "A return to The Matrix is fast approaching. It was confirmed back in August 2021 that the fourth movie is officially called The Matrix Resurrections (as an earlier leak had claimed), and the first trailer arrived on September 9", Rating = 9 },
        };
    }
}