using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceyWebbApp.ViewModels
{
    public class BookingViewModel
    {
        public string[] SeatsToBook { get; set; }
        public string ExpeditionId { get; set; }

        public BookingViewModel(string[] seats, string expeditionId)
        {
            this.ExpeditionId = expeditionId;
            this.SeatsToBook = seats;
        }
    }
}
