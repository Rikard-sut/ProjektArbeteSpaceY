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
        public int AddRocket(Rocket rocket)
        {
            db.Rockets.Add(rocket);
            return db.SaveChanges();
        }
        public List<Rocket> GetRockets()
        {
            var rockets = db.Rockets.Select(x => x).ToList();
            return rockets;
        }

        public Rocket GetRocketById(int id)
        {
            var rocket = db.Rockets.Where(x => x.RocketId == id).FirstOrDefault();
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
        public int AddDestination(Destination destination)
        {
            db.Destinations.Add(destination);
            return db.SaveChanges();
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
        public int AddExpedition(Expedition expedition)
        {
            db.Expeditions.Add(expedition);
            return db.SaveChanges();
        }

        public List<Expedition> GetExpeditions()
        {
            var expeditions = db.Expeditions.Select(x => x).ToList();
            foreach(var expedition in expeditions)
            {
                expedition.Rocket = db.Rockets.Where(x => x.RocketId == expedition.RocketId).FirstOrDefault();
                expedition.Destination = db.Destinations.Where(x => x.DestinationId == expedition.DestinationId).FirstOrDefault();
                expedition.Customers = db.Customers.Where(x => x.ExpeditionId == expedition.ExpeditionId).ToList();
            }
            return expeditions;
        }

        public Expedition GetExpeditionById(int id)
        {
            var expedition = db.Expeditions.Where(x => x.ExpeditionId == id).FirstOrDefault();
            if(expedition != null)
            {
                expedition.Rocket = db.Rockets.Where(x => x.RocketId == expedition.RocketId).FirstOrDefault();
                expedition.Destination = db.Destinations.Where(x => x.DestinationId == expedition.DestinationId).FirstOrDefault();
                expedition.Customers = db.Customers.Where(x => x.ExpeditionId == expedition.ExpeditionId).ToList();
                expedition.Departure.ToShortDateString();
                return expedition;
            }
            return null;
        }

        public Expedition DeleteExpedition(int id)
        {
            var expedition = db.Expeditions.Where(x => x.ExpeditionId == id).FirstOrDefault();
            db.Remove(expedition);
            db.SaveChanges();
            return expedition;
        }
        /// <summary>
        /// ??????????????? FIXA DENNA
        /// </summary>
        /// <param name="expedition"></param>
        public void BookSeats(Expedition expedition)
        {
            Expedition expeditionToUpdate = (from e in db.Expeditions
                                   where e.ExpeditionId == expedition.ExpeditionId
                                   select e).FirstOrDefault();
            foreach(var customer in expedition.Customers)
            {
                expeditionToUpdate.Customers.Add(customer);
            }
            db.SaveChanges();
        }
        #endregion Expedition
    }
}
