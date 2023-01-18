using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.DLL.Models;
using app.DLL.Models.Enums;
using app.ModelsDTO.Projects;

namespace app.ModelsDTO
{
    public class C8orProjectDashboardDTO
    {
         public int UserId { get; set; }
        public string SphereId { get; set; }
        public int ProjectId { get; set; }
        public string? ProposedURL { get; set; }
        public string? AgreementURL { get; set; }
        public Direction Direction { get; set; } = Direction.Null;
        public Status status { get; set; } = Status.Null;
         public virtual ProjectDashboardDTO? Project { get; set; }
    }
}