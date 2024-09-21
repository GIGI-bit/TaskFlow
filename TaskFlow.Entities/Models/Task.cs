using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFlow.Entities.Models
{
    public class Task
    {
      public int Id { get; set; }
        public string? Title {  get; set; }

        public string? Description {  get; set; }
        public DateTime CreatedDate {  get; set; }

        public DateTime Deadline {  get; set; }
        public string? Status {  get; set; }

        public string? Priority {  get; set; }// Urgent, Primary, Simple
        public int ProjectId {  get; set; }

        public int AssignedUserId {  get; set; }
        public virtual User? User { get; set; }
        public virtual Project? Project { get; set; }
    }
}
