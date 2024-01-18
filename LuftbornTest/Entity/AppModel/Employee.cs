using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Entity.AppModel
{
    public class Employee:BaseModel
    {
        [Required]
        [DisplayName("Full Name")]
        public string FullName { get; set; }
        [DisplayName("Date Of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DateOfBirth { get; set; }
        [Required]
        [DisplayName("Phone")]
        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string PhoneNumber { get; set; }
        [Required]
        [DisplayName("Email")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DisplayName("Password")]
        [DataType(DataType.Password)]
        [PasswordPropertyText]
        [MinLength(6)]
        public string Password { get; set; }
        [NotMapped]
        [Required]
        [DisplayName("Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        [ForeignKey(nameof(Gender))]
        [DisplayName("Gender")]
        public int FK_Gender { get; set; }
        [DisplayName("Gender")]
        public virtual Gender Gender { get; set; }
        [ForeignKey(nameof(Department))]
        [DisplayName("Department")]
        public int Fk_Department { get; set; }
        [DisplayName("Department")]
        public virtual Department Department { get; set; }
        [NotMapped]
        [DisplayName("Remember Me")]
        public bool RememberMe { get; set; }
         
    }
}
