﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder.Domain.Entities
{
    public class Component
    {
        public string Name { get; set; }
        public string Link { get; set; }
        public int Count { get; set; }
        public int Cost { get; set; }
        public string Decription { get; set; }
    }
}
