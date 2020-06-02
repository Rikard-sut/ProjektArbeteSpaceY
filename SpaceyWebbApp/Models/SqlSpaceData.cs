using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceyWebbApp.Models
{
    /// <summary>
    /// Class for SqlInteractions with our database. 
    /// </summary>
    public class SqlSpaceData
    {
        private readonly SpaceyDbContext db;

        public SqlSpaceData(SpaceyDbContext db)
        {
            this.db = db;
        }
        public void AddRocketToDb(Rocket rocket)
        {
            db.Rockets.Add(rocket);
            db.SaveChanges();
        }
        public void AddDestinationtoDb(Destination destination)
        {
            db.Destinations.Add(destination);
            db.SaveChanges();
        }

        public void AddExpeditionToDb(Expedition expedition)
        {
            db.Expeditions.Add(expedition);
            db.SaveChanges();
        }
        public List<Rocket> GetRockets()
        {
            var rockets = db.Rockets.Select(x => x).ToList();
            return rockets;
        }
        public List<Destination> GetDestinations()
        {
            var destinations = db.Destinations.Select(x => x).ToList();
            return destinations;
        }
        //VI BEHÖVER SKAPA METODER FÖR ATT SPARA ROCKETS/DESTINATIONS/EXPEDITIONS FRÅN FRONTENDEN HÄR.
    }
}
