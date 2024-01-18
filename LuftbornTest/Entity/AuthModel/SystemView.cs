using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.AuthModel
{
    public class SystemView:BaseModel
    {
        [DisplayName("Page Name")]
        [Required(ErrorMessage = "Please fill this field")]
        public string Name { get; set; }
        public virtual List<SystemUserPermission> SystemUserPermissions { get; set; }
    }
}
