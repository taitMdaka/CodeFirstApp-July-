using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessUnits.Data_Access.Entities
{
    public partial class PostalAddress
    {
        [Key]
        public int PostalAddressID { get; set; }
        public int UserId { get; set; }
        public string AddressLine { get; set; }
        public string PostalCode { get; set; }
        public string AreaCode { get; set; }
        public virtual RegisteredUser RegisterUser { get; set; }
    }
}
