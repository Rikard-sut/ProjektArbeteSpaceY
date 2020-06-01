using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceyWebbApp.Models
{
    public class Destination
    {
        public int DestinationId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public FlightLength expeditionRange { get; set; }

        //Validate so that only high range rockets can make high range destinations
    }
}
