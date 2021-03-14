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
        string model;

        public Car(int acceleration, string model)
        {
            this.acceleration = acceleration;
            this.model = model;
        }

        public void change(int acc_changed)
        {
            this.acceleration = acc_changed;
        }
    }
}
