using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceyWebbApp.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        public int ExpeditionId { get; set; }

        public int SeatNumber { get; set; }
        [Required]
        public string FullName { get; set; }

    }
}
