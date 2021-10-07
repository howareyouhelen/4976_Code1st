using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Code1st.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Team> Teams { get; set; } // this is what becomes a table in the db
        public DbSet<Player> Players { get; set; }   
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // seeding the tables with sample data
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
    
            modelBuilder.Entity<Team>().HasData(SampleData.GetTeams()); // means if Team is empty, put in GetTeams() data in it
            modelBuilder.Entity<Player>().HasData(SampleData.GetPlayers());
        }
    }
}
