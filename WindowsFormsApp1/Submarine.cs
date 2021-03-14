using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Submarine : IDive
    {
        int depth;

        public Submarine(int depth)
        {
            this.depth = depth;
        }

        public void change(int dep_changed)
        {
            this.depth = dep_changed;
        }
    }
}
