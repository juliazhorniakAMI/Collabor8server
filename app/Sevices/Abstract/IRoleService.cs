using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.DLL.Models;
using app.DTOs;
namespace app.Sevices.Abstract
{
    public interface IRoleService
    {
        Task<ServiceResponse<List<RoleDTO>>> GetAllRoles();
        Task<ServiceResponse<RoleDTO>> GetRoleById(int id);
        Task<bool> AddRole(RoleDTO role);
        Task<bool> UpdateRole(RoleDTO role);
        Task<bool> DeleteRole(int id);

    }
}