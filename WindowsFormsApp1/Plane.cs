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
        string model;

        public Plane(int rise, string model)
        {
            this.rise = rise;
            this.model = model;
        }

        public void change(int ri_changed)
        {
            this.rise = ri_changed;
        }
    }
}
