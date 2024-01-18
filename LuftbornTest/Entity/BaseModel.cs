using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class BaseModel
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Created At")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime CreatedAt { get; set; } = CurrentLocalTime.GetCurrentTime();
        [DisplayName("Last Modified At")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime LastModifiedAt { get; set; } = CurrentLocalTime.GetCurrentTime();
    }
}
