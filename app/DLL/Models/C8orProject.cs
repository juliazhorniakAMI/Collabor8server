using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.DLL.Models.Enums;

namespace app.DLL.Models
{
    public class C8orProject
    {
        public int Id { get; set; }
        public int Collabor8orId { get; set; }
        public int ProjectId { get; set; }
        public Direction Direction { get; set; }
        public Status status { get; set; } = Status.Pending;
        public virtual Collabor8or? Collabor8or { get; set; }
        public virtual Project? Project { get; set; }
        
    }
}