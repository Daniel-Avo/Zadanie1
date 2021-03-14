using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Plane : IRise
    {
        int rise;

        public Plane(int rise)
        {
            this.rise = rise;
        }

        public void change(int ri_changed)
        {
            this.rise = ri_changed;
        }
    }
}
