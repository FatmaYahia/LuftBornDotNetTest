using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Entity.AppModel
{
    public class Gender:BaseModel
    {
        [Required]
        [DisplayName("Gender")]
        public string Name { get; set; }
        [DisplayName("Employees")]
        public virtual List<Employee> Employees { get; set; }
    }
}
