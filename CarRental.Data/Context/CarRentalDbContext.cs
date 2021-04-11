
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CarRental.Data.Context
{
    public class CarRentalDbContext : DbContext
    {
        public CarRentalDbContext() : base() 
        {
        
        }

        
        public DbSet<Car> Cars { get; set; }
    }
}
