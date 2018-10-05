﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListingTodos.Models
{
    public class Todo
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public DateTime CreationDate { get; set; }
        public bool IsUrgent { get; set; }
        public bool IsDone { get; set; }
        public Assigne Assigne { get; set; }

        public Todo()
        {
            IsUrgent = false;
            IsDone = true;
        }
    }
}