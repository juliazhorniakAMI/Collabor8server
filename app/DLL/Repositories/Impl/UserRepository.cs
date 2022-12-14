using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.Context;
using app.DLL.Models;
using app.DLL.Repositories.Abstract;
using app.DTOs;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
namespace app.DLL.Repositories.Impl
{
    public class UserRepository :  GenericKeyRepository<int, User, DataContext>,IUserRepository
    {
         private readonly IMapper _mapper;
        public UserRepository(DataContext context, IMapper mapper) : base(context)
        {
           _mapper = mapper  ;
        }
        public async Task<bool> AddUser(UserDTO user)
        {
            User r= _mapper.Map<UserDTO, User>(user);
            return await Add(r);         
        }
        public async Task<bool> DeleteUser(int id)
        {
           var user = await GetById(id);
            return await Delete(user);
        }
        public async Task<ServiceResponse<List<UserDTO>>> GetAllUsers()
        {
            return  new ServiceResponse<List<UserDTO>>
            {
                Data = await Context.Users.Select(c => _mapper.Map<UserDTO>(c)).ToListAsync()
            };
        }
        // public async Task<ServiceResponse<RoleDTO>> GetRoleById(int id)
        // {
        //     var role = await Context.Roles.FirstOrDefaultAsync(c => c.Id == id);
        //     return new ServiceResponse<RoleDTO>
        //     {
        //         Data = _mapper.Map<RoleDTO>(role)
        //     };
        // }
        public async Task<bool> UpdateUser(UserDTO user)
        {
            var existingUser = Context.Users.First(x => x.Id == user.Id);

            if (existingUser == null) return false;

            existingUser.Name = user.Name;

            return await Update(existingUser);
        }
    }
}