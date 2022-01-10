﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0106HotelApp.Models
{
    public class CleanerRoom 
    {
        public int CleanerId { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }
        public Cleaner Cleaner { get; set; }
        public bool Cleaned { get; set; }
    }
}
