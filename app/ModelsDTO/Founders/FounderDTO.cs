using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.DLL.Models;

namespace app.ModelsDTO
{
    public class FounderDTO
    {
        public int UserId { get; set; }
        public int ProjectId { get; set; }
        public string? Name { get; set; }
        public string? BackgroundSummary { get; set; }
        public string? Resume { get; set; }



    }
}