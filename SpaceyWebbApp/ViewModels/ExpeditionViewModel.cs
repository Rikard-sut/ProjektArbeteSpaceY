using SpaceyWebbApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceyWebbApp.ViewModels
{
    public class ExpeditionViewModel
    {
        public List<Rocket> Rockets { get; set; }
        public List<Destination> Destinations { get; set; }
        public Expedition Expedition { get; set; }
        public ExpeditionViewModel(List<Rocket> rockets, List<Destination> destinations)
        {
            this.Rockets = rockets;
            this.Destinations = destinations;
        }
    }
}
