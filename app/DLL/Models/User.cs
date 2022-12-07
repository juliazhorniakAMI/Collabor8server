using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.DLL.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Collabor8or? Collabor8or { get; set; }
        public virtual PM? PM { get; set; }
        public virtual Founder? Founder { get; set; }


    }
}