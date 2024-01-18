using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.AuthModel
{
    public class SystemUserPermission:BaseModel
    {
        [ForeignKey(nameof(SystemUser))]
        public int FK_SystemUser { get; set; }
        [DisplayName("System User")]
        public virtual SystemUser SystemUser { get; set; }
        [ForeignKey(nameof(AccessLevel))]
        public int FK_AccessLevel { get; set; }
        [DisplayName("Access Level")]
        public virtual AccessLevel AccessLevel { get; set; }
        [ForeignKey(nameof(SystemView))]
        public int FK_SystemView { get; set; }
        [DisplayName("System View")]
        public virtual SystemView SystemView { get; set; }

    }
}
