// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using app.Context;
// using app.DLL.Models;
// using app.DLL.Repositories.Abstract;
// using app.DTOs;
// using AutoMapper;
// using Microsoft.EntityFrameworkCore;
// namespace app.DLL.Repositories.Impl
// {
//     public class RoleRepository :  GenericKeyRepository<int, Role, DataContext>,IRoleRepository
//     {
//          private readonly IMapper _mapper;
//         public RoleRepository(DataContext context, IMapper mapper) : base(context)
//         {
//            _mapper = mapper  ;
//         }
//         public async Task<bool> AddRole(RoleDTO role)
//         {
//             Role r= _mapper.Map<RoleDTO, Role>(role);
//             return Add(r);         
//         }
//         public async Task<bool> DeleteRole(int id)
//         {
//            var role = GetById(id);
//             return Delete(role);
//         }
//         public async Task<ServiceResponse<List<RoleDTO>>> GetAllRoles()
//         {
//             return  new ServiceResponse<List<RoleDTO>>
//             {
//                 Data = await Context.Roles.Select(c => _mapper.Map<RoleDTO>(c)).ToListAsync()
//             };
//         }
//         public async Task<ServiceResponse<RoleDTO>> GetRoleById(int id)
//         {
//             var role = await Context.Roles.FirstOrDefaultAsync(c => c.Id == id);
//             return new ServiceResponse<RoleDTO>
//             {
//                 Data = _mapper.Map<RoleDTO>(role)
//             };
//         }
//         public async Task<bool> UpdateRole(RoleDTO role)
//         {
//             var existingRole = Context.Roles.First(x => x.Id == role.Id);

//             if (existingRole == null) return false;

//             existingRole.FullName = role.FullName;

//             return Update(existingRole);
//         }
//     }
// }