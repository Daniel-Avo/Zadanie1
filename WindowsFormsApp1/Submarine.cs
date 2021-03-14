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
        string model;

        public Submarine(int depth, string model)
        {
            this.depth = depth;
            this.model = model;
        }

        public void change(int dep_changed)
        {
            this.depth = dep_changed;
        }
    }
}
