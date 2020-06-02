using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceyWebbApp.Models
{
    public class Rocket
    {
        public int RocketId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public FlightLength Range { get; set; }
        public int Seats { get; set; }

    }

}
