﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePetProject
{
    internal class TaskItem
    {
        
        public string Description { get; set; }
        public bool IsCompleted { get; set; }

        public TaskItem(string Description)
        {

            this.Description = Description;
            IsCompleted = false;
        }

        public override string ToString()
        {
            return $" [{(IsCompleted ? "X" : " ")}] {Description}";
        }
    }
}
