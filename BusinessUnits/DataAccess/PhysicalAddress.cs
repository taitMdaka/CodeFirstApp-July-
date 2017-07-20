using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessUnits.Data_Access.Entities
{
    public partial class PhysicalAddress
    {
        public int PostalAddress;

        [Key]
        [Required]
        public int PhysicalAddressId { get; set; } 
        public int UserId { get; set; }

        [Required]
        [RegularExpression("^[a-zA-Z][a-zA-Z\\s]+$")]
        public int ProvinceId { get; set; }

        [Required]
        [RegularExpression("^[a-zA-Z][a-zA-Z\\s]+$")]
        public int RegionId { get; set; }

        [Required]
        [RegularExpression("^[a-zA-Z][a-zA-Z\\s]+$")]
        public int CityId { get; set; }

 
        [RegularExpression("^[a-zA-Z][a-zA-Z\\s]+$")]
        public int SuburbId { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string StreetName { get; set; }

        [Required]
        [RegularExpression("^[a-zA-Z][a-zA-Z\\s]+$")]
        public int Unit { get; set; }

        [Required]
        [RegularExpression("^[a-zA-Z][a-zA-Z\\s]+$")]
        public virtual City Cities { get; set; }


        [Required]
        [RegularExpression("^[a-zA-Z][a-zA-Z\\s]+$")]
        public virtual Province Province { get; set; }

        [Required]
        [RegularExpression("^[a-zA-Z][a-zA-Z\\s]+$")]
        public virtual Region Region { get; set; }

        [Required]
        [RegularExpression("^[a-zA-Z][a-zA-Z\\s]+$")]
        public virtual RegisteredUser RegisterUser { get; set; }

        [Required]
        [RegularExpression("^[a-zA-Z][a-zA-Z\\s]+$")]
        public virtual Suburb Suburb { get; set; }
        public int PostalCode { get; set; }
        public int AreaCode { get; set; }
    }
}
