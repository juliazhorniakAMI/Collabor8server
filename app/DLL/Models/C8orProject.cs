using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.DLL.Models.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace app.DLL.Models
{
    public class C8orProject
    {
        public int UserId { get; set; }
        public string SphereId { get; set; }
        public int ProjectId { get; set; }
        public string? ProposedURL { get; set; }
        public string? AgreementURL { get; set; }
        public Direction Direction { get; set; } = Direction.Null;
        public Status status { get; set; } = Status.Null;
        public virtual Collabor8or? Collabor8or { get; set; }
        public virtual Project? Project { get; set; }
        
    }
}