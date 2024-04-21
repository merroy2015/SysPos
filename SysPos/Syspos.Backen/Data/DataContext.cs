﻿
using Microsoft.EntityFrameworkCore;
using Syspos.Shered.Entites;

namespace Syspos.Backen.Data
{
    public class DataContext : DbContext
    {
         
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasIndex(c => c.Name).IsUnique();
        }
    }
}

