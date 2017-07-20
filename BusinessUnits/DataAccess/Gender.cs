using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessUnits.Data_Access.Entities
{
    public partial class Gender
    {
        public Gender()
        {
            this.RegisterUsers = new List<RegisteredUser>();
        }
        [Key]
        public int GenderId { get; set; }
        public string  Sex { get; set; }
        public virtual ICollection<RegisteredUser> RegisterUsers { get; set; }
    }
}

