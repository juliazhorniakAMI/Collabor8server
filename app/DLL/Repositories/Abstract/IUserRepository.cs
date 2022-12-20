using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.DLL.Models;
using app.DTOs;
namespace app.DLL.Repositories.Abstract
{
    public interface IUserRepository
    {
        Task<ServiceResponse<List<UserDTO>>> GetAllUsers();
        Task<bool> AddUser(UserDTO user);
        Task<bool> UpdateUser(UserDTO user);
        Task<bool> DeleteUser(int id);

    }
}