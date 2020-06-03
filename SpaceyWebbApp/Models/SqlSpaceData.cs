using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceyWebbApp.Models
{
    /// <summary>
    /// Class for SqlInteractions with our database. 
    /// </summary>
    public partial class SqlSpaceData
    {
        private readonly SpaceyDbContext db;

        public SqlSpaceData(SpaceyDbContext db)
        {
            this.db = db;
        }

        #region Rocket
        public void AddRocketToDb(Rocket rocket)
        {
            db.Rockets.Add(rocket);
            db.SaveChanges();
        }
        public List<Rocket> GetRockets()
        {
            var rockets = db.Rockets.Select(x => x).ToList();
            return rockets;
        }

        public Rocket GetRocketById(int id)
        {
            var rocket = db.Rockets.Where(x => x.RocketId == id).FirstOrDefault();
            //Här kan vi lägga även hämta vilka expeditions som är kopplade till denna rocket
            return rocket;
        }
        public Rocket DeleteRocket(int id)
        {
            var rocket = db.Rockets.Where(x => x.RocketId == id).FirstOrDefault();
            db.Remove(rocket);
            db.SaveChanges();
            return rocket;
        }
        #endregion Rocket

        #region Destination
        public void AddDestinationToDb(Destination destination)
        {
            db.Destinations.Add(destination);
            db.SaveChanges();
        }
        public List<Destination> GetDestinations()
        {
            var destinations = db.Destinations.Select(x => x).ToList();
            return destinations;
        }

        public Destination GetDestinationById(int id)
        {
            var destination = db.Destinations.Where(x => x.DestinationId == id).FirstOrDefault();
            return destination;
        }

        public Destination DeleteDestination(int id)
        {
            var destination = db.Destinations.Where(x => x.DestinationId == id).FirstOrDefault();
            db.Remove(destination);
            db.SaveChanges();
            return destination;
        }
        #endregion Destination

        #region Expedition
        public void AddExpeditionToDb(Expedition expedition)
        {
            db.Expeditions.Add(expedition);
            db.SaveChanges();
        }

        public List<Expedition> GetExpeditions()
        {
            var expeditions = db.Expeditions.Select(x => x).ToList();
            foreach(var expedition in expeditions)
            {
                var rocket = db.Rockets.Where(x => x.RocketId == expedition.RocketId).FirstOrDefault();
                var destination = db.Destinations.Where(x => x.DestinationId == expedition.DestinationId).FirstOrDefault();

                expedition.Rocket = rocket;
                expedition.Destination = destination;
            }
            return expeditions;
        }

        public Expedition GetExpeditionById(int id)
        {
            var expedition = db.Expeditions.Where(x => x.ExpeditionId == id).FirstOrDefault();
            var rocket = db.Rockets.Where(x => x.RocketId == expedition.RocketId).FirstOrDefault();
            var destination = db.Destinations.Where(x => x.DestinationId == expedition.DestinationId).FirstOrDefault();

            expedition.Rocket = rocket;
            expedition.Destination = destination;

            return expedition;
        }

        public Expedition DeleteExpedition(int id)
        {
            var expedition = db.Expeditions.Where(x => x.ExpeditionId == id).FirstOrDefault();
            db.Remove(expedition);
            db.SaveChanges();
            return expedition;
        }
        #endregion Expedition
    }
}
