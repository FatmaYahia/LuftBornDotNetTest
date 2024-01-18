using Entity.AppModel;
using System.ComponentModel;

namespace LuftbornTest.AppAdmin.ViewModel
{
    public class DepartmentVM
    {
        public int Id { get; set; }
        [DisplayName("Department Name")]
        public string Name { get; set; }
     
        public string Location { get; set; }
        }
}
