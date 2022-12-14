using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.DLL.Models;
using app.ModelsDTO;
using app.DTOs;
namespace app.Sevices.Abstract
{
    public interface ISkillService
    {
      Task<ServiceResponse<List<SkillDTO>>> GetAllSkills();
    }
}