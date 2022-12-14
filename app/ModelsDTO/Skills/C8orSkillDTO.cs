using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.Controllers.SkillController;
using app.DLL.Models;
namespace app.ModelsDTO.Skills
{
    public class C8orSkillDTO
    {
        public int Id { get; set; }
        public int SkillId { get; set; }
        public int C8orId { get; set; }
        public string Name {get;set;}
    }
}