using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingExample
{
    public class Dungeon
    {
        public string Name { get; set; }
        public int Difficulty { get; set; }

        public Dungeon(string Name, int Difficulty)
        {
            this.Name = Name;
            this.Difficulty = Difficulty;
        }
    }
}
