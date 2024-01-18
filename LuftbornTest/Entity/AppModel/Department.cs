using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.AppModel
{
    public class Department:BaseModel
    {
        [Required]
        [DisplayName("Department Name")]
        public string Name { get; set; }
        [DisplayName("Location")]
        public string Location { get; set; }
        [DisplayName("Employees")]
        public virtual List<Employee> Employees { get; set; }
    }
}
