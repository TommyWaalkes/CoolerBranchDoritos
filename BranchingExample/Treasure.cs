using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingExample
{
    class Treasure
    {
        public int Value { get; set; }
        public string Material { get; set; }

        public Treasure(int Value, string Material)
        {
            this.Value = Value;
            this.Material = Material;
        }
    }
}
