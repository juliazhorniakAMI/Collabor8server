using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.ModelsDTO
{
    public class ProjectFounderDTO
    {
        public int Id { get; set; }
        public string PMName { get; set; }
        public string ProjectName { get; set; }
        public int FounderId { get; set; }
        public int ProjectId { get; set; }
        public string FounderName {get;set;}
      
        
    }
}