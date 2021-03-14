using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			label1.Text = "Choose interface";
            label2.Text = "Choose toy";
			combo_interfaces.DropDownStyle = ComboBoxStyle.DropDownList;
			combo_interfaces.Items.Add("Car");
            combo_interfaces.Items.Add("Plane");
            combo_interfaces.Items.Add("Submarine");
        }

        ArrayList car_list = new ArrayList();
        ArrayList plane_list = new ArrayList();
        ArrayList sub_list = new ArrayList();

        private void Form1_Load(object sender, EventArgs e)
		{

		}

        private void label1_Click(object sender, EventArgs e)
        {
			
        }

        private void b_dodaj_Click(object sender, EventArgs e)
        {
            switch (combo_interfaces.Text)
            {
                case "Car":
                    {
                        car_list.Add(new Car(1));
                        break;
                    }
                case "Plane":
                    {
                        plane_list.Add(new Plane(1));
                        break;
                    }
                case "Submarine":
                    {
                        sub_list.Add(new Submarine(1));
                        break;
                    }

                default:
                    Error.error();
                    break;
            }
        }
    }
}
