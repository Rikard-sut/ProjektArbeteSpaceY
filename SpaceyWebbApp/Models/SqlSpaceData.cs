﻿using System;
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

        #region User
        public List<User> GetUsers()
        {
            return db.Users.Select(x => x).ToList();
        }
        public bool LoginUser(User user)
        {
            var foundUser = db.Users.Where(x => x.Email == user.Email).FirstOrDefault();
            if (foundUser != null)
            {
                return true;
            }
            return false;
        }
        #endregion

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
            expedition.Rocket = db.Rockets.Where(x => x.RocketId == expedition.RocketId).FirstOrDefault();
            expedition.Destination = db.Destinations.Where(x => x.DestinationId == expedition.DestinationId).FirstOrDefault();
            expedition.Customers = db.Customers.Where(x => x.ExpeditionId == expedition.ExpeditionId).ToList();
            expedition.Departure.ToShortDateString();
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
