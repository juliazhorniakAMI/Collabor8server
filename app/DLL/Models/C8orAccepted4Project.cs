using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.DLL.Models
{
    public class C8orAccepted4Project
    {
        public int Id { get; set; }
        public int Collabor8orId { get; set; }
        public int ProjectId { get; set; }
        public string Contracts {get;set;}
        public virtual Collabor8or? Collabor8or { get; set; }
        public virtual Project? Project { get; set; }
    }
}