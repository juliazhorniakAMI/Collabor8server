using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.ModelsDTO.Projects;

namespace app.ModelsDTO.Founders
{
    public class FounderDashboardDTO
    {
        public int UserId { get; set; }
        public int ProjectId { get; set; }
        public string? BackgroundSummary { get; set; }
        public string? Resume { get; set; }
        public virtual ProjectDashboardDTO? Project { get; set; }
    }
}