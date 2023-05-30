using DAUinfo.Model;
using DAUinfo.Model.DTO;

namespace DAUinfo.Services.Interfaces
{
    public interface IUser
    {
        Task<User> AddUser (User user);
        Task<List<User>> GetAllUser();
    }
}
