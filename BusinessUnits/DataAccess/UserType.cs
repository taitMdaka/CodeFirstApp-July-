using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessUnits.Data_Access.Entities
{
    public partial class UserType
    {
        public UserType()
        {
            this.RegisterUsers = new List<RegisteredUser>();
        }

        [Key]
        public int UserType1 { get; set; }
        public string descriptiom { get; set; }
        public virtual ICollection<RegisteredUser> RegisterUsers { get; set; }
    }
}

