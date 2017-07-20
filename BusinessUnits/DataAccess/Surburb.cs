using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessUnits.Data_Access.Entities
{
    public partial class Suburb
    {
        public Suburb()
        {
            this.PhysicalAddresses = new List<PhysicalAddress>();
        }
        [Key]
        public int SuburId { get; set; }
        public string SuburbName { get; set; }
        public virtual ICollection<PhysicalAddress> PhysicalAddresses { get; set; }
    }
}