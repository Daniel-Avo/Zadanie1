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
            label3.Text = "Model";
            label4.Text = "Property";
            label5.Text = "Property value:";
            label6.Text = "";
            

			combo_interfaces.DropDownStyle = ComboBoxStyle.DropDownList;
            toy_box.DropDownStyle = ComboBoxStyle.DropDownList;

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
                        try {
                            car_list.Add(new Car(Convert.ToInt32(propertybox.Text), modelbox.Text));
                            toyBoxMethod();
                        }
                        catch(Exception ex)
                        {
                            Error.errVariables();
                        }
                        break;
                    }
                case "Plane":
                    {
                        try
                        {
                            plane_list.Add(new Plane(Convert.ToInt32(propertybox.Text), modelbox.Text));
                            toyBoxMethod();
                        }
                        catch (Exception ex)
                        {
                            Error.errVariables();
                        }
                        break;
                    }
                case "Submarine":
                    {
                        try
                        {
                            sub_list.Add(new Submarine(Convert.ToInt32(propertybox.Text), modelbox.Text));
                            toyBoxMethod();
                        }
                        catch (Exception ex)
                        {
                            Error.errVariables();
                        }
                        break;
                    }

                default:
                    Error.errInterface();
                    break;
            }
        }

        private void combo_interfaces_SelectedIndexChanged(object sender, EventArgs e)
        {
            toyBoxMethod();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (combo_interfaces.Text)
            {
                case "Car":
                    {
                        foreach (Car i in car_list)
                        {
                            if (toy_box.Text == i.getModel())
                            {
                                label6.Text = i.getAcceleration().ToString();
                            }
                        }
                    }
                    break;

                case "Plane":
                    {
                        label4.Text = "Rise";
                        foreach (Plane i in plane_list)
                        {
                            if (toy_box.Text == i.getModel())
                            {
                                label6.Text = i.getRise().ToString();
                            }
                        }
                        break;
                    }
                case "Submarine":
                    {
                        label4.Text = "Depth";
                        foreach (Submarine i in sub_list)
                        {
                            if (toy_box.Text == i.getModel())
                            {
                                label6.Text = i.getDepth().ToString();
                            }
                        }
                        break;
                    }

                default:
                    Error.errInterface();
                    break;
            }
        }

        private void toyBoxMethod()
        {
            toy_box.Items.Clear();

            switch (combo_interfaces.Text)
            {
                case "Car":
                    {
                        label4.Text = "Acceleration";
                        foreach (Car i in car_list)
                        {
                            toy_box.Items.Add(i.getModel());
                        }
                    }
                    break;

                case "Plane":
                    {
                        label4.Text = "Rise";
                        foreach (Plane i in plane_list)
                        {
                            toy_box.Items.Add(i.getModel());
                        }
                        break;
                    }
                case "Submarine":
                    {
                        label4.Text = "Depth";
                        foreach (Submarine i in sub_list)
                        {
                            toy_box.Items.Add(i.getModel());
                        }
                        break;
                    }

                default:
                    Error.errInterface();
                    break;
            }
        }

        private void addNewEntry()
        {

        }
    }
}
