using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Model
{
    class AutoNumberModel : AbstractModel
    {
        public string prefix { set; get; }
        public string suffix { set; get; }
        public int currentSequence { set; get; } = 0;
        public int zeroPadding { set; get; }
        public string displaySequence { set; get; } = string.Empty;
        public string groupType { set; get; }
    }
}
