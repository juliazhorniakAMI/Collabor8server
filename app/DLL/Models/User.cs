using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.DLL.Models
{
    public class User
    {
        public User()
        {
             Founders = new HashSet<Founder>();
             Collabor8ors = new HashSet<Collabor8or>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; } = new byte[0];
        public byte[] PasswordSalt { get; set; } = new byte[0];
        public virtual ICollection<Founder> Founders { get; set; }
        public virtual ICollection<Collabor8or> Collabor8ors { get; set; }

    }
}