using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using app.Context;
using app.DLL.Models;
using app.DLL.Repositories.Abstract;
using app.DTOs;
using app.ModelsDTO.User;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace app.DLL.Repositories.Impl
{
    public class UserRepository : GenericKeyRepository<int, User, DataContext>, IUserRepository
    {
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public UserRepository(DataContext context, IMapper mapper,IConfiguration configuration,IHttpContextAccessor httpContextAccessor) : base(context)
        {
            _mapper = mapper;
            _configuration = configuration;
            _httpContextAccessor= httpContextAccessor;
        }
        private int GetUserId() => int.Parse(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));
        public async Task<bool> DeleteUser(int userId)
        {
            //for auth
           // var user = await GetById(GetUserId());
           var user = await GetById(userId);
            return await Delete(user);
         
        }  
        public async Task<ServiceResponse<List<UserDTO>>> GetAllUsers()
        {
            return new ServiceResponse<List<UserDTO>>
            {
                Data = await Context.Users.Select(c => _mapper.Map<UserDTO>(c)).ToListAsync()
            };
        }
        public async Task<bool> CheckIfUserExists(string email)
        {
            return await Context.Users.AnyAsync(x => x.Email == email);
        }
        public async Task<bool> UpdateUser(UserDTO user)
        {
            //for auth
           // var existingUser = Context.Users.First(x => x.Id == GetUserId());
           var existingUser = Context.Users.First(x => x.Id == user.Id);

            if (existingUser == null) return false;
            existingUser.Name = user.Name;
            existingUser.Email = user.Email;
           // existingUser.Pass = user.Pass;
            return await Update(existingUser);
        }
        public async Task<ServiceResponse<UserDashboardDTO>> GetUser(int userId)
        {
            var User = await Context.Users.
            Include(x => x.Collabor8ors).ThenInclude(x => x.C8orsProjects).ThenInclude(x => x.Project)
            .Include(x => x.Collabor8ors).ThenInclude(x => x.C8orSkill)
            .Include(x => x.Founders).ThenInclude(x => x.Project).FirstAsync(x => x.Id ==userId);
            //for auth
            // .Include(x => x.Founders).ThenInclude(x => x.Project).FirstAsync(x => x.Id ==GetUserId());
            return new ServiceResponse<UserDashboardDTO>
            {
                Data = _mapper.Map<UserDashboardDTO>(User)
            };
        }

       public async Task<ServiceResponse<string>> Login(string email, string password)
        {
            
             var response = new ServiceResponse<string>();
             User user = await Context.Users.FirstOrDefaultAsync(c => c.Email == email);
            if (user is null)
            {
                response.Success = false;
                response.Message = "User not found";
            }
            else if(!VerifyPasswordHash(password,user.PasswordHash,user.PasswordSalt))
            {
                response.Success = false;
                response.Message = "Wrong password";
            }
            else{
            // wch - the following code is needed for authorization  
            // ------------------------------------------------------
               response.Data = CreateToken(user);
            //    response.Data =user.Id.ToString();
            // wch - the previous code is needed for authorization  
            // ------------------------------------------------------

            }
            return response;
        }

        public async Task<ServiceResponse<bool>> Register(UserDTO user)
        { 
            var response = new ServiceResponse<bool>();

            if(await CheckIfUserExists(user.Email)){
                response.Success = false;
                response.Message = "User already exists";
                return response;
            }
            response.Success = true;

            CreatePasswordHash(user.Pass,out byte[] passwordHash,out byte[] passwordSalt);    

            User r = _mapper.Map<UserDTO, User>(user);
            r.PasswordHash=passwordHash;
            r.PasswordSalt=passwordSalt;  
            return await Add(r);
        }
        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {

            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {

                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return computedHash.SequenceEqual(passwordHash);

            }
        }
        private void CreatePasswordHash(string password,out byte[] passwordHash,out byte[] passwordSalt){

            using(var hmac = new System.Security.Cryptography.HMACSHA512()){

                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
        private string CreateToken(User user){

            var claims = new List<Claim>{

                new Claim(ClaimTypes.NameIdentifier,user.Id.ToString()),
                new Claim(ClaimTypes.Name,user.Email)
            };
            
            var appSettingsToken = _configuration.GetSection("AppSettings:Token").Value;
            if(appSettingsToken is null)
            throw new Exception("AppSettings Token is null");
            SymmetricSecurityKey key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(appSettingsToken));
            
            SigningCredentials creds = new SigningCredentials(key,SecurityAlgorithms.HmacSha256Signature);

            var tokenDescriptor = new SecurityTokenDescriptor{
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = creds
            };
            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            SecurityToken token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);

        }
    }
}