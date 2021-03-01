using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using PassengerManagement.Database;
using PassengerManagement.Interface;

namespace PassengerManagement.Manager
{
    public class PassengerManager : IPassenger
    {
        private readonly DB_TestEntities Db;
        public PassengerManager()
        {
            Db = new DB_TestEntities();
        }

        public int CreatePassenger(Passenger passengers)
        {
            try 
            {
                Db.tblPassengers.Add(passengers);
                Db.SaveChanges();
                return 1;
            }
            catch 
            {
                return 0;
            }
        }

        public int DeletePassenger(int id)
        {
            try
            {
                var pass = Db.tblPassengers.Find(id);
                Db.tblPassengers.Remove(pass);
                Db.SaveChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public Passenger GetPassenger(int id)
        {
            try
            {
                var pass = Db.tblPassengers.Find(id);
                return pass;
            }
            catch
            {
                return null;
            }
        }

        public int UpdatePassenger(int id, Passenger passenger)
        {
            try
            {
                var pass = Db.tblPassengers.Find(id);
                pass.FirstName = passenger.FirstName;
                pass.LastName = passenger.LastName;
                pass.ContactNo = passenger.ContactNo;
                Db.Entry(pass).State = EntityState.Modified;
                Db.SaveChanges();
                return 0;
            }
            catch
            {
                return 0;
            }
        }
    }
}