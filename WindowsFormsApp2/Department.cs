using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    [Serializable]
    public class Department
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public long Contact { get; set; }
        public string Address { get; set; }

    }
}
