using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceyWebbApp.Models
{
    public class Destination
    {
        public int DestinationId { get; set; }
        public string Name { get; set; }
        public FlightLength expeditionRange { get; set; }
    }
}
