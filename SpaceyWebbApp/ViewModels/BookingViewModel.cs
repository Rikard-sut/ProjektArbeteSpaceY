using SpaceyWebbApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceyWebbApp.ViewModels
{
    public class BookingViewModel
    {
        public int[] SeatsToBook { get; set; }
        public Expedition Expedition { get; set; }
        public List<Customer> Customers{ get; set; }

        public BookingViewModel(string[] seats, Expedition expedition)
        {
            this.Expedition = expedition;
            this.SeatsToBook = seats.Select(int.Parse).ToArray();
        }
        public BookingViewModel()
        {

        }
    }
}
