using BusinessUnits.Data_Access.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessUnits.Data_Access.DatabaseContext
{
    public class BusinessUnitsDBContext : DbContext
    {
        public BusinessUnitsDBContext() : base("BusinessUnit") { }

        public DbSet<UserType> UserType { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Gender> Gender { get; set; }
        public DbSet<PostalAddress> PostalAddress { get; set; }
        public DbSet<PhysicalAddress> PhysicalAddress { get; set; }
        public DbSet<Suburb> Suburb { get; set; }
        public DbSet<RegisteredUser> RegisterUser { get; set; }
        public DbSet<UserLogDetail> UserLogDetail { get; set; }
        public DbSet<Province> Province { get; set; }
        public DbSet<Region> Region { get; set; }
        public DbSet<ApprovalStatus> ApprovalStatuses { get; set; }
        public DbSet<Department> Department { get; set; }
    }
}
