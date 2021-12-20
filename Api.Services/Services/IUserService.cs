using Api.Models.Models;
using Api.Models.DTO;

namespace Api.Services.Services
{
    public interface IUserService
    {
        public User Get(UserLogin userLogin);
    }
}