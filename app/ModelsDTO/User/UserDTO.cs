using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.DTOs
{
    public class UserDTO
    {
       public int Id { get; set; }
       public string Name { get; set; }
       public string Email { get; set; }
       public string Pass { get; set; }
    }
}