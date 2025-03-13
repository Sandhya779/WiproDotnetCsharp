
using JWTAuthJWTBearerWebApi.Models.ExperiencePostWebApi.Models;
using Microsoft.EntityFrameworkCore;
//using System.Data.Entity;

namespace JWTAuthJWTBearerWebApi.Models
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();

        }

        public DbSet<ITRole> ITRoles { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Skill> Skills { get; set; }





    }
}
