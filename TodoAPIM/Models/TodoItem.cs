﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoAPIM.Models
{
    public class Todo
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Owner { get; set; }
    }
}
