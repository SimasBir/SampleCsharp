﻿using _1228RegistrationApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1228RegistrationApp.Dtos
{
    public class Entry
    {
        public List<Prompt> Prompts { get; set; }
        public List<Value> Values { get; set; }
    }
}
