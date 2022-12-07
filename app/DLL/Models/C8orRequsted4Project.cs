using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace app.DLL.Models
{
    public class C8orRequsted4Project
    {
        public int Id { get; set; }
        public int C8orId { get; set; }
        public int ProjectId { get; set; }
        public Status status { get; set; } = Status.Pending;
        public virtual Collabor8or? Collabor8or { get; set; }
        public virtual Project? Project { get; set; }
        
    }
}