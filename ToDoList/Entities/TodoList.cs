﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class TodoList
    {
        public int id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime DateAdded { get; set; }
    }
}
