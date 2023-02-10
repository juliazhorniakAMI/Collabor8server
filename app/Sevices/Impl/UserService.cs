using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using app.DLL.Models;
using app.DLL.Repositories.Abstract;
using app.DTOs;
using app.ModelsDTO.User;
using app.Sevices.Abstract;
namespace app.Sevices.Impl
{
    public class UserService : IUserService
    {
         private readonly IUserRepository _Repository;
         private readonly IHttpContextAccessor _httpContextAccessor;
        public UserService(IUserRepository Repository,IHttpContextAccessor httpContextAccessor)
        {
            _Repository=Repository;    
            _httpContextAccessor= httpContextAccessor;
        }

        public Task<ServiceResponse<bool>> Register(UserDTO user)
        {
          return _Repository.Register(user);
        }
        public Task<bool> CheckIfUserExists(string email)
        {
             return _Repository.CheckIfUserExists(email);
        }
        public Task<bool> DeleteUser()
        {
            return _Repository.DeleteUser();
        }
        public Task<ServiceResponse<List<UserDTO>>> GetAllUsers()
        {
             return _Repository.GetAllUsers();
        }
        public Task<bool> UpdateUser(UserDTO user)
        {
            return _Repository.UpdateUser(user);
        }
        public Task<ServiceResponse<UserDashboardDTO>> GetUser()
        {
             return _Repository.GetUser();
        }

        Task<ServiceResponse<string>> IUserService.Login(string email, string password)
        {
              return _Repository.Login(email,password);
        }
    }
}