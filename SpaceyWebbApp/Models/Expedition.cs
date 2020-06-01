﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceyWebbApp.Models
{
    public class Expedition
    {
        public int ExpeditionId { get; set; }
        public DateTime Departure { get; set; }
        public int RocketId { get; set; }
        public int DestinationId { get; set; }
        public List<Customers> Customers { get; set; }

    }
}
