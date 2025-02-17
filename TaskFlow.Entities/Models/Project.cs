﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TaskFlow.Entities.Models
{
    public class Project
    {
        public int Id { get; set; }

        public string? Name {  get; set; }
        public string? Description {  get; set; }

        public DateTime CreatedDate {  get; set; }
        public DateTime Deadline {  get; set; }

        public string? Status {  get; set; }
        public int OwnerId {  get; set; }

        public virtual User? User { get; set; }

    }
}
