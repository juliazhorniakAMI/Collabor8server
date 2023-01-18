using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.DLL.Models;
using app.DTOs;
using app.ModelsDTO.User;

namespace app.Sevices.Abstract
{
    public interface IUserService
    {
        Task<ServiceResponse<List<UserDTO>>> GetAllUsers();
        Task<bool> CheckIfUserExists(string email, string password);
        Task<ServiceResponse<UserDTO>> Login(string email, string password);
        Task<ServiceResponse<bool>> Register(UserDTO user);
        Task<ServiceResponse<UserDashboardDTO>> GetUser(int id);
        Task<bool> UpdateUser(UserDTO user);
        Task<bool> DeleteUser(int id);


    }
}