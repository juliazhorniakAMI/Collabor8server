using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.ModelsDTO.C8or;
using app.ModelsDTO.Founders;

namespace app.ModelsDTO.User
{
    public class UserDashboardDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Pass { get; set; }
        public virtual ICollection<FounderDashboardDTO> Founders { get; set; }
        public virtual ICollection<C8orDashboardDTO> Collabor8ors { get; set; }
    }
}