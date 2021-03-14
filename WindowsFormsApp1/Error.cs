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
        public static void error()
        {
            string message = "Wybierz interfejs";
            string caption = "Error";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.OK);
        }
    }
}
