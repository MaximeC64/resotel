﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resotel.Entities
{
    public class Payment
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string Mode { get; set; }
        public Invoice Invoice { get; set; }
    }
}