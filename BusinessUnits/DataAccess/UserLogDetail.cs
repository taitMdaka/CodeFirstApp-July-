using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessUnits.Data_Access.Entities
{
    public partial class UserLogDetail
    {
        [Key]
        public int UserId { get; set; }
        public int UserLogDetailsId { get; set; }
        public string Message { get; set; }
        public System.DateTime DateCreated { get; set; }
        public virtual RegisteredUser RegisterUser { get; set; }
    }
}
