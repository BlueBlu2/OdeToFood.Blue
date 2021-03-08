using Microsoft.EntityFrameworkCore;
using OdeToFood.Blue.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace OdeToFood.Blue.Data
{
    public class OdeToFoodDbContext: DbContext
    {
        public OdeToFoodDbContext(DbContextOptions<OdeToFoodDbContext> options)
            :base(options)
        {

        }
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
