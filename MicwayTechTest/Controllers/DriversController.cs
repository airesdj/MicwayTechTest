using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MicwayTechTest.Models;

namespace MicwayTechTest.Controllers
{
    public class DriversController : ApiController
    {
        private MicwayTechTestContext db = new MicwayTechTestContext();

        //Insert action
        public IHttpActionResult PostDriver(Driver driver)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (driver == null)
                return BadRequest("There are no values in the URL. Action not done.");

            db.Drivers.Add(driver);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = driver.Id }, driver);
        }

        //Get Details action
        public IHttpActionResult GetDriver(int id)
        {
            if (id <= 0)
                return BadRequest("'Id' field must be greater than 0.");

            var driver = db.Drivers.Find(id);

            if (driver == null)
                return NotFound();

            return Ok(driver);
        }

        //Update action
        public IHttpActionResult PutDriver(int id, Driver driver)
        {
            if (id != driver.Id)
                return BadRequest("'Id' selected in URL is different of the 'Id' of the driver record.");

            if (db.Drivers.Count(c => c.Id == id) == 0)
                return NotFound();

            db.Entry(driver).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }

        //Delete action
        public IHttpActionResult DeleteDriver(int id)
        {
            if (id <= 0)
                return BadRequest("'Id' field must be greater than 0.");

            var driver = db.Drivers.Find(id);

            if (driver == null)
                return NotFound();

            db.Drivers.Remove(driver);
            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }

        //Select action
        public IHttpActionResult GetDriver()
        {
            //Only 3 columns are returning in the query: id, full name (join between first and last name) and email
            var drivers = db.Drivers.OrderBy(c => c.Id).Select(c => new { ID = c.Id, FullName = (c.FirstName + " " + c.LastName), Email = c.EmailAddress});
            return Ok(drivers);
        }



    }
}
