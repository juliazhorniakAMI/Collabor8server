using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace app.DLL.Models
{
    public class Founder
    {
        public int UserId { get; set; }
        public int ProjectId { get; set; }
        public string? BackgroundSummary { get; set; }
        public string? Resume { get; set; }
        public virtual User? User { get; set; }
        public virtual Project? Project { get; set; }

    }
}