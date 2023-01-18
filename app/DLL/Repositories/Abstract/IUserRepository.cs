using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.DLL.Models;
using app.DTOs;
using app.ModelsDTO.User;

namespace app.DLL.Repositories.Abstract
{
    public interface IUserRepository
    {
        Task<ServiceResponse<List<UserDTO>>> GetAllUsers();
        Task<bool> CheckIfUserExists(string email, string password);
        Task<ServiceResponse<UserDTO>> Login(string email, string password);
        Task<ServiceResponse<bool>> Register(UserDTO user);
        Task<bool> UpdateUser(UserDTO user);
        Task<ServiceResponse<UserDashboardDTO>> GetUser(int id);
        Task<bool> DeleteUser(int id);

    }
}