using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BusinessUnits.Data_Access.Entities

{
    public partial class RegisteredUser
    {
        public RegisteredUser()
        {
            this.PhysicalAddresses = new List<PhysicalAddress>();
            this.PostalAddresses = new List<PostalAddress>();
            this.UserLogDetails = new List<UserLogDetail>();
        }

        [Key]
        public int UserId { get; set; }


        [Required]
        [RegularExpression("")]
        [StringLength(100, MinimumLength = 1)]
        public string FirstName { get; set; }


        [Required]
        [RegularExpression("")]
        [StringLength(100, MinimumLength = 1)]
        public string Lastname { get; set; }


        [Required]
        [RegularExpression("")]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Required]
        [RegularExpression("")]
        [StringLength(100, MinimumLength = 1)]
        public string Passwordhash { get; set; }

        [Required]
        [RegularExpression("^[a-zA-Z][a-zA-Z\\s]+$")]
        public int UserTypeId { get; set; }

        [Required]
        [RegularExpression("^[a-zA-Z][a-zA-Z\\s]+$")]
        public int GenderId { get; set; }


        [Required]
        [RegularExpression("^[a-zA-Z][a-zA-Z\\s]+$")]
        public int DepartmentId { get; set; }
        
        [Required]
        [RegularExpression("^[a-zA-Z][a-zA-Z\\s]+$")]
        public int StatusId { get; set; }

        [RegularExpression("^[a-zA-Z][a-zA-Z\\s]+$")]
        public virtual ApprovalStatus ApprovalStatus { get; set; }

        [Required]
        [RegularExpression("^[a-zA-Z][a-zA-Z\\s]+$")]
        public virtual Department Department { get; set; }

        [Required]
        [RegularExpression("^[a-zA-Z][a-zA-Z\\s]+$")]
        public virtual Gender Gender { get; set; }

        [Required]
        [RegularExpression("^[a-zA-Z][a-zA-Z\\s]+$")]
        public virtual ICollection<PhysicalAddress> PhysicalAddresses { get; set; }

        [Required]
        [RegularExpression("^[a-zA-Z][a-zA-Z\\s]+$")]
        public virtual ICollection<PostalAddress> PostalAddresses { get; set; }

        [Required]
        [RegularExpression("^[a-zA-Z][a-zA-Z\\s]+$")]
        public virtual UserType UserType { get; set; }
        
        public virtual ICollection<UserLogDetail> UserLogDetails { get; set; }
        //   public string RegisterUser { get; set; }
        //public object Passwordhash { get; set; }
        //public string Lastname { get; set; }
    }
}