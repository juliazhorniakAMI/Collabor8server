using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.DLL.Models;
using app.DLL.Repositories.Abstract;
using app.DTOs;
using app.Sevices.Abstract;
namespace app.Sevices.Impl
{
    public class UserService : IUserService
    {
         private readonly IUserRepository _Repository;
        public UserService(IUserRepository Repository)
        {
            _Repository=Repository;       
        }
        public Task<ServiceResponse<bool>> Register(UserDTO user)
        {
          return _Repository.Register(user);
        }
        public Task<bool> CheckIfUserExists(string email, string password)
        {
             return _Repository.CheckIfUserExists(email,password);
        }
        public Task<bool> DeleteUser(int id)
        {
            return _Repository.DeleteUser(id);
        }
        public Task<ServiceResponse<UserDTO>> Login(string email, string password)
        {
            return _Repository.Login(email,password);
        }
        public Task<ServiceResponse<List<UserDTO>>> GetAllUsers()
        {
             return _Repository.GetAllUsers();
        }
        public Task<bool> UpdateUser(UserDTO user)
        {
            return _Repository.UpdateUser(user);
        }
    }
}