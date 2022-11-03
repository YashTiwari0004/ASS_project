using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASS_API.Models;
using ASS_API.DbModels;

namespace ASS_API.DataAccessLayer
{
    public class EfDbContext:DbContext
    {
        
        public EfDbContext(DbContextOptions<EfDbContext> options):base(options)
        {

        }
            public DbSet<Customer> Customer { get; set; }
            public DbSet<Staff> Staff { get; set; }
            public DbSet<Court> Court { get; set; }
            public DbSet<AppointmentScheduling> Book { get; set; }
    }
}
