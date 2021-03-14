using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Error
    {
        public static void errInterface()
        {
            string message = "Choose interface";
            string caption = "Error";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.OK);
        }

        public static void errVariables()
        {
            string message = "Enter properly property and model";
            string caption = "Error";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.OK);
        }



    }
}
