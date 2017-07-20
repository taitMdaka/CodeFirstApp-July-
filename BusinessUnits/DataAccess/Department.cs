using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessUnits.Data_Access.Entities
{
    public partial class Department
    {
        public Department()
        {
            this.RegisterUsers = new List<RegisteredUser>();
        }
        [Key]
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public virtual ICollection<RegisteredUser> RegisterUsers { get; set; }
    }
}