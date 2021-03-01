using PassengerManagement.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PassengerManagement.Database;

namespace PassengerManagement.Interface
{
    public interface IPassenger
    {
        int CreatePassenger(Passenger passengers);

        int DeletePassenger(int id);

        int UpdatePassenger(int id, Passenger passenger);
        
        Passenger GetPassenger(int id);
    }
}