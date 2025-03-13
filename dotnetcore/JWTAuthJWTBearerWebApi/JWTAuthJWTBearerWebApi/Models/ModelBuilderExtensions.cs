using JWTAuthJWTBearerWebApi.Models.ExperiencePostWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace JWTAuthJWTBearerWebApi.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                           new Employee() { EmployeeId = 1, FirstName = "Abhishek", LastName = "Sharma", CellNumber = "7891234567", LandLine = "055322616143", EmailId = "abhisharma@gmail.com", Password = "abhi@123" }

                           );
            modelBuilder.Entity<ITRole>().HasData(
                new ITRole() { ITRoleId = 1, RoleName = "Software engineer" },
                new ITRole() { ITRoleId = 2, RoleName = "Applications engineer" },
                new ITRole() { ITRoleId = 3, RoleName = "Computer programmer" },
                new ITRole() { ITRoleId = 4, RoleName = "Data scientist" },
                new ITRole() { ITRoleId = 5, RoleName = "Web administrator" },
                 new ITRole() { ITRoleId = 6, RoleName = "Quality assurance tester" }

                );

            modelBuilder.Entity<Skill>().HasData(
                new Skill() { SkillId = 1, EmployeeId = 1, ITRoleId = 1, SkillName = "DOT NET CORE", ExperienceYears = 5 },
                new Skill() { SkillId = 2, EmployeeId = 1, ITRoleId = 5, SkillName = "AZ-204", ExperienceYears = 2 }

               );

        }
    }
}
