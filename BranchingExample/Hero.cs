using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingExample
{
    class Hero
    {
        public int HP { get; set; }
        public int Attack { get; set; }

        public Hero(int HP, int Attack)
        {
            this.HP = HP;
            this.Attack = Attack;
        }

    }
}
