﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1215EFCTodoListApp.Models
{
    public class Todo : NamedEntity
    {
        public string Description { get; set; }

        public Category Category { get; set; }
    }
}
