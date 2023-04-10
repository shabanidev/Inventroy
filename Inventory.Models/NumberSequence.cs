using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Models
{
    public class NumberSequence
    {
        public int  Id { get; set; }

        public int Name { get; set; }
        public string Module { get; set; }

        public string Prefix { get; set; }

        public int LastNumber { get; set; }
    }
}
