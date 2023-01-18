using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.ModelsDTO.C8or
{
    public class Collabor8orUpdateDTO
    {
        public int UserId { get; set; }
        public string SphereId { get; set; }
        public string? BackgroundSummary { get; set; }
        public string? Resume { get; set; }
    }
}