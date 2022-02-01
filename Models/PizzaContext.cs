using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PizzaAppAPI.Models
{
    public class PizzaContext : DbContext
    {
        public PizzaContext(DbContextOptions<PizzaContext> options)
           : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; } = null!;
    }
}
