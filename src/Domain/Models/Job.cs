﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class TaskType : BaseEntity
    {
        public string Name { get; set; }
        public double Progress { get; set; } 
    }
}
