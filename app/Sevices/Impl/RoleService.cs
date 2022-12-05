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
    public class RoleService : IRoleService
    {
         private readonly IRoleRepository _Repository;
        public RoleService(IRoleRepository Repository)
        {
            _Repository=Repository;       
        }
        public Task<bool> AddRole(RoleDTO role)
        {
          return _Repository.AddRole(role);
        }

        public Task<bool> DeleteRole(int id)
        {
            return _Repository.DeleteRole(id);
        }

        public Task<ServiceResponse<List<RoleDTO>>> GetAllRoles()
        {
             return _Repository.GetAllRoles();
        }

        public Task<ServiceResponse<RoleDTO>> GetRoleById(int id)
        {
             return _Repository.GetRoleById(id);
        }

        public Task<bool> UpdateRole(RoleDTO role)
        {
            return _Repository.UpdateRole(role);
        }
    }
}