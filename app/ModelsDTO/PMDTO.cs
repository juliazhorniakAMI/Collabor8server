using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.ModelsDTO
{
    public class PMDTO
    {
        public int Id { get; set; }
        public string Name {get;set;}
        public string? BackgroundSummary { get; set; }
        public string? Resume { get; set; }
    }
}