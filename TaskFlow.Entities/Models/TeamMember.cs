using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFlow.Entities.Models
{
    public class TeamMember
    {
       public int Id {  get; set; }
    public int TeamId {  get; set; }

        public int UserId { get; set; }
        public string? TeamRole {  get; set; }

        ///
        public virtual User? User { get; set; }
        public virtual Team? Team { get; set; }
        
    }
}
