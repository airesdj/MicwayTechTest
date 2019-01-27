using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MicwayTechTest.Models
{
    public class MicwayTechTestContext : DbContext
    {
        //MicwayTechTest - connectionstring
        public MicwayTechTestContext() : base("MicwayTechTest")
        {
        }

        public DbSet<Driver> Drivers { get; set; }
    }
}