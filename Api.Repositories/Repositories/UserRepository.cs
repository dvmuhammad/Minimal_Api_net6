using Api.Models.Models;

namespace Api.Repositories.Repositories
{
    public class UserRepository
    {
        public static List<User> Users = new()
        {
            new() { Username = "luke_admin", EmailAddress = "luke.admin@email.com", Password = "MyPass_w0rd",Role = "Administrator" },
            new() { Username = "lydia_standard", EmailAddress = "lydia.standard@email.com", Password = "MyPass_w0rd",Role = "Standard" },
        };
    }
}