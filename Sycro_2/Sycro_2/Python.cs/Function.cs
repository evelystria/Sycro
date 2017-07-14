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
            string funcresult = "";

            const String BR = "\r\n";

            Main.setText.Text += "#--- Function ---#" + Environment.NewLine;
            Main.setText.Font = new Font(bunifuCustomTextbox1.Font.FontFamily, 12);
            Main.setText.ForeColor = Color.Orange;

            foreach(string line in textBox1.Lines)
            {
                funcresult += "      " + line + Environment.NewLine;
            }

            if (funcname.Length < 1 && arguments.Length < 1)
            {
                Main.setText.Text += "def <func_name>(<arguments>):" + BR + funcresult + BR + BR;
            }
            else if (funcname.Length < 1)
            {
                Main.setText.Text += "def <func_name>(" + arguments + "):" + BR + funcresult + BR + BR;
            }
            else if (arguments.Length < 1)
            {
                Main.setText.Text += "def " + funcname + "(<arguments>):" + BR + funcresult + BR + BR;
            }
            else
            {
                Main.setText.Text += "def " + funcname + "(" + arguments + "):" + BR + funcresult + BR + BR;
            }

            this.Close();

        }

        
    }
}
