using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessUnits.Data_Access.Entities
{
    public partial class ApprovalStatus
    {
        public ApprovalStatus()
        {
            this.RegisterUsers = new List<RegisteredUser>();
        }
        [Key]
        public int StatusId { get; set; }
        public bool? IsApproved { get; set; }
        public virtual ICollection<RegisteredUser> RegisterUsers { get; set; }
    }
}
