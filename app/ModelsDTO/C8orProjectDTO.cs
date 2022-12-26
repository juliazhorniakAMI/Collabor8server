using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.DLL.Models;
using app.DLL.Models.Enums;

namespace app.ModelsDTO
{
    public class C8orProjectDTO
    {
        public int Id { get; set; }
        public int Collabor8orId { get; set; }
        public int ProjectId { get; set; }
        public Direction Direction { get; set; }
        public Status status { get; set; } 
    }
}