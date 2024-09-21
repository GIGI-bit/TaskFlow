using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFlow.Entities.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Fullname { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string? Role { get; set; }
        public string? Email { get; set; }
        public string? PasswordHash { get; set; }
        public string?PasswordSalt {  get; set; }
        ////
        ///
        public virtual List<Comment>? Comments { get; set; }
        public virtual List<Project>? Projects{ get; set; }
        public virtual List<TeamMember>? TeamMembers { get; set; }

    }
}
