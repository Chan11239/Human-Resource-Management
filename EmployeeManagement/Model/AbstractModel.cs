using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Model
{
    public abstract class AbstractModel
    {
        public int id { get; set; }
        public DateTime lastModifiedDate { get; set; } = DateTime.Now;
        public bool isActive { get; set; } = true;
    }
}
