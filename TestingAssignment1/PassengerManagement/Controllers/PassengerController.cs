using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PassengerManagement.Database;
using PassengerManagement.Interface;

namespace PassengerManagement.Controllers
{
    public class PassengerController : ApiController
    {
        private static IPassenger _passenger;

        public PassengerController(IPassenger passenger)
        {
            _passenger = passenger;
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var passenger = _passenger.GetPassenger(id);
            if(passenger!=null)
            {
                return Ok(passenger);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public IHttpActionResult Create(Passenger passengers)
        {
            if (_passenger.CreatePassenger(passengers) == 1)
            {
                return Ok("Success");
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public IHttpActionResult Edit(int id, Passenger passenger)
        {
            if (_passenger.UpdatePassenger(id, passenger) == 1)
            {
                return Ok("Success");
            }
            else
            {
                return BadRequest();
            }
        }

        public IHttpActionResult Delete(int id)
        {
            if (_passenger.DeletePassenger(id) == 1)
            {
                return Ok("Success");
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
