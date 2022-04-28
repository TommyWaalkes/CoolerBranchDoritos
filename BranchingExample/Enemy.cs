using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingExample
{
    public class Enemy
    {
        public int HP { get; set; }
        public int Attack { get; set; }
        public int GoldDropped { get; set; }

        public Enemy(int HP, int Attack, int GoldDropped)
        {
            this.HP = HP;
            this.Attack = Attack;
            this.GoldDropped = GoldDropped;
        }
    }
}
