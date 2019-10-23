using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DockerComposeDemo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<WeatherForecast> Forecasts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}