namespace BusinessUnits.Migrations
{
    using Data_Access.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BusinessUnits.Data_Access.DatabaseContext.BusinessUnitsDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BusinessUnits.Data_Access.DatabaseContext.BusinessUnitsDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Gender.AddOrUpdate(

                new Gender { Sex = "Male" },
                new Gender { Sex = "Female" }


                );
            context.Department.AddOrUpdate(

                new Department { DepartmentName = "GMIC" },
                new Department { DepartmentName = "GQUA" }

                );

            context.UserType.AddOrUpdate(


                new UserType { descriptiom = "Admin" },
                new UserType { descriptiom = "User" }



                );
            context.ApprovalStatuses.AddOrUpdate(

                new ApprovalStatus { IsApproved = true },
                 new ApprovalStatus { IsApproved = false }
                );

            context.Province.AddOrUpdate(
                new Province { ProvinceName = "Limpompo" },
                new Province { ProvinceName = "Gauteng" },
                new Province { ProvinceName = "Mpumalanga" },
               new Province { ProvinceName = "NorthWest" },
               new Province { ProvinceName = "Kwa-Zulu natal " },
              new Province { ProvinceName = "Western Cape" }
                );

            context.City.AddOrUpdate(
                new City { CityName = "JHB" },
                new City { CityName = "DRBn" }
                );
            context.Region.AddOrUpdate(
                new Region { RegionName = "east" },
                new Region { RegionName = "West" },
                new Region { RegionName = "east" }
                );
            context.Suburb.AddOrUpdate(
               new Suburb { SuburbName = "North " },
                new Suburb { SuburbName = "Ekurhuleni " },
               new Suburb { SuburbName = "West " }

                );
        }
    }

    internal class Cities
    {
        public string City { get; set; }
    }
}
