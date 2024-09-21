using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFlow.Entities.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int TaskId { get; set; }

        public int UserId { get; set; }
        public string? Content { get; set; }

        public DateTime CreatedDate { get; set; }
        ////

        public virtual User? User { get; set; }
        public virtual Task? Task { get; set; }
    }
}
