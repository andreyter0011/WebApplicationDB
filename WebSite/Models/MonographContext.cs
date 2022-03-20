﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace WebSite.Models
{
    public class MonographContext : DbContext
    {
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Monograph> Monographs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();
                var connectionString = configuration.GetConnectionString("MonographContextdb");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
        public MonographContext() { }
        public MonographContext(DbContextOptions<MonographContext> options)
        : base(options)
        { }
    }
}
