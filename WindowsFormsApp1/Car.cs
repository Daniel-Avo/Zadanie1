using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Car : IAccelerate
    {
        int acceleration;

        public Car(int acceleration)
        {
            this.acceleration = acceleration;
        }

        public void change(int acc_changed)
        {
            this.acceleration = acc_changed;
        }
    }
}
