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
    public partial class Print : Form
    {
        public Print()
        {
            InitializeComponent();
        }
            //Closes the application
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {

            string data = bunifuCustomTextbox1.Text;

            Main.setText.Text += "#--- Print ---#" + Environment.NewLine;

            if (data.Length > 1)
            {
                Main.setText.Font = new Font(bunifuCustomTextbox1.Font.FontFamily, 12);
                Main.setText.ForeColor = Color.Orange;
                Main.setText.Text += "print(" + data + ")" + Environment.NewLine + Environment.NewLine;

                this.Close();
            }
            else
            {
                Main.setText.Font = new Font(bunifuCustomTextbox1.Font.FontFamily, 12);
                Main.setText.ForeColor = Color.Orange;
                Main.setText.Text += "print(<String>)" + Environment.NewLine + Environment.NewLine;

                this.Close();
            }

        }




    }
}
