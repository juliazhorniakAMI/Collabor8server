using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.DLL.Models;

namespace app.ModelsDTO
{
    public class ProjectSupportInfoDTO
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string Idea {get;set;}
    
    }
}