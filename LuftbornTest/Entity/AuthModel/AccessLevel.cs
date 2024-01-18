using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.AuthModel
{
    public class AccessLevel:BaseModel
    {
        [Required(ErrorMessage = "Please fill this field")]
        [DisplayName("Access Level Name")]
        public string Name { get; set; }
        public virtual List<SystemUserPermission> SystemUserPermissions { get; set; }
    }
}
