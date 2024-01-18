using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.AuthModel
{
    public class SystemUser:BaseModel
    {
        [Required]
        [DisplayName("Full name")]
        public string FullName { get; set; }
        [Required]
        [DisplayName("Email")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DisplayName("Password")]
        [DataType(DataType.Password)]
        [PasswordPropertyText]
        public string Password { get; set; }
        [Required]
        [DisplayName("Job Title")]
        public string JobTitle { get; set; }
        [DisplayName("Is Active")]
        public bool IsActive { get; set; }
        public virtual List<SystemUserPermission> SystemUserPermissions { get; set; }
    }
}
