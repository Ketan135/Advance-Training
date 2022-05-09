using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    [Serializable]
    public class Batch
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public string Location { get; set; }
        public string Trainer { get; set; }
    }
}
