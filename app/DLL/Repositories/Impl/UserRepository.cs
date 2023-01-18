using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.Context;
using app.DLL.Models;
using app.DLL.Repositories.Abstract;
using app.DTOs;
using app.ModelsDTO.User;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
namespace app.DLL.Repositories.Impl
{
    public class UserRepository : GenericKeyRepository<int, User, DataContext>, IUserRepository
    {
        private readonly IMapper _mapper;
        public UserRepository(DataContext context, IMapper mapper) : base(context)
        {
            _mapper = mapper;
        }
        public async Task<ServiceResponse<bool>> Register(UserDTO user)
        {
            var response = new ServiceResponse<bool>();
            User r = _mapper.Map<UserDTO, User>(user);
            if (await CheckIfUserExists(r.Email, r.Pass))
            {
                response.Success = false;
                response.Message = "User already exists";
                return response;
            }
            return await Add(r);
        }
        public async Task<bool> DeleteUser(int id)
        {
            var user = await GetById(id);
            return await Delete(user);
        }
        public async Task<ServiceResponse<List<UserDTO>>> GetAllUsers()
        {
            return new ServiceResponse<List<UserDTO>>
            {
                Data = await Context.Users.Select(c => _mapper.Map<UserDTO>(c)).ToListAsync()
            };
        }
        public async Task<bool> CheckIfUserExists(string email, string password)
        {
            return await Context.Users.AnyAsync(x => x.Email == email && x.Pass == password);
        }
        public async Task<ServiceResponse<UserDTO>> Login(string email, string password)
        {
            var response = new ServiceResponse<UserDTO>();
            User user = await Context.Users.FirstOrDefaultAsync(c => c.Email == email && c.Pass == password);
            if (user is null)
            {
                response.Success = false;
                response.Message = "User not found";
            }
            else
            {
                response.Data = _mapper.Map<UserDTO>(user);
            }
            return response;
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
        public async Task<ServiceResponse<UserDashboardDTO>> GetUser(int id)
        {
            var User = await Context.Users.
            Include(x => x.Collabor8ors).ThenInclude(x => x.C8orsProjects).ThenInclude(x => x.Project)
            .Include(x => x.Collabor8ors).ThenInclude(x => x.C8orSkill)
            .Include(x => x.Founders).ThenInclude(x => x.Project).FirstAsync(x => x.Id == id);
            return new ServiceResponse<UserDashboardDTO>
            {
                Data = _mapper.Map<UserDashboardDTO>(User)
            };
        }
    }
}