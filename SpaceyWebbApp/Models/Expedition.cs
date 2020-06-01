using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceyWebbApp.Models
{
    public class Expedition
    {
        public int ExpeditionId { get; set; }
        [Required]
        public DateTime Departure { get; set; }
        public int RocketId { get; set; }
        public Rocket Rocket { get; set; }
        public int DestinationId { get; set; }
        public Destination Destination { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }

    }
}
