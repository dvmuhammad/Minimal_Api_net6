using Api.Models.Models;

namespace Api.Repositories.Repositories
{
    public class UserRepository
    {
        public static List<User> Users = new()
        {
            new() { Username = "Admin", EmailAddress = "admin@email.com", Password = "Admin_1234",Role = "Administrator" },
            new() { Username = "Muhammad", EmailAddress = "Muhammad@email.com", Password = "Muhammad_111",Role = "user" },
        };
    }
}