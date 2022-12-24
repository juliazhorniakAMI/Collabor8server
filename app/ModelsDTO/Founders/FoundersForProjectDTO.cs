using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.ModelsDTO.Founders
{
    public class FoundersForProjectDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public int ProjectId { get; set; }
        public string BackgroundSummary { get; set; }
        public string Resume { get; set; }
    }
}