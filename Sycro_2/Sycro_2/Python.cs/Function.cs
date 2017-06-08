using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sycro_2
{
    public partial class Function : Form
    {
        public Function()
        {
            InitializeComponent();
        }
            //Closes the func window
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            string funcname = bunifuCustomTextbox1.Text;
            string arguments = bunifuCustomTextbox2.Text;

            Main.setText.Text += "#--- Function ---#" + Environment.NewLine;
            Main.setText.Font = new Font(bunifuCustomTextbox1.Font.FontFamily, 12);
            Main.setText.ForeColor = Color.Orange;

            if (funcname.Length < 1 && arguments.Length < 1)
            {
                Main.setText.Text += "def <func_name>(<arguments>):" + Environment.NewLine + "     #Do something.." + Environment.NewLine + "     return;" + Environment.NewLine + Environment.NewLine;
            }
            else if (funcname.Length < 1)
            {
                Main.setText.Text += "def <func_name>(" + arguments + "):" + Environment.NewLine + "     #Do something.." + Environment.NewLine + "     return;" + Environment.NewLine + Environment.NewLine;
            }
            else if (arguments.Length < 1)
            {
                Main.setText.Text += "def " + funcname + "(<arguments>):" + Environment.NewLine + "     #Do something.." + Environment.NewLine + "     return;" + Environment.NewLine + Environment.NewLine;
            }
            else
            {
                Main.setText.Text += "def " + funcname + "(" + arguments + "):" + Environment.NewLine + "     #Do something.." + Environment.NewLine + "     return;" + Environment.NewLine + Environment.NewLine;
            }

            this.Close();

        }

 
    }
}
