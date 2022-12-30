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
        public async Task<bool> CheckIfUserExists(string email, string password)
        {
            return await Context.Users.AnyAsync(x => x.Email == email && x.Pass == password);
        }
        public async Task<ServiceResponse<UserDTO>> FindUser(string email, string password)
        {
             User user = await Context.Users.FirstAsync(c => c.Email == email && c.Pass==password);
            return new ServiceResponse<UserDTO>
            {
                Data = _mapper.Map<UserDTO>(user)
            };     
        }
        public async Task<bool> UpdateUser(UserDTO user)
        {
            var existingUser = Context.Users.First(x => x.Id == user.Id);

            if (existingUser == null) return false;

            existingUser.Name = user.Name;
            existingUser.Email = user.Email;
            existingUser.Pass = user.Pass;

            return await Update(existingUser);
        }
    }
}