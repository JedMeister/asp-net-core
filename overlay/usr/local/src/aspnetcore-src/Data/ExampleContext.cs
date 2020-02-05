using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TurnkeyExampleApp.Models;

namespace TurnkeyExampleApp.Data
{
    public class ExampleContext : DbContext
    {
        public ExampleContext (DbContextOptions<ExampleContext> options)
            : base(options)
        {
        }

        public DbSet<ExampleThing> ExampleThings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ExampleThing>().ToTable("ExampleThing");
        }
    }
}
