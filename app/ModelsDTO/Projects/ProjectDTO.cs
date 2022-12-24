using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.DLL.Models;
namespace app.ModelsDTO
{
    public class ProjectDTO
    {
         public int Id { get; set; }
        public string Name { get; set; }
        public string Purpose { get; set; }
        public string Ideas { get; set; }
        public string Contracts { get; set; }
       
    }
}