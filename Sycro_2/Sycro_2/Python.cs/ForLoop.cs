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
    public partial class ForLoop : Form
    {
        public ForLoop()
        {
            InitializeComponent();
        }
            //Closes the for loop dialog
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
            //When OK
        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {

            string variable = bunifuCustomTextbox1.Text;
            string sequence = bunifuCustomTextbox2.Text;

            Main.setText.Text += "#--- For Loop ---#" + Environment.NewLine;
            Main.setText.Font = new Font(bunifuCustomTextbox1.Font.FontFamily, 12);
            Main.setText.ForeColor = Color.Orange;

            if (variable.Length < 1 && sequence.Length < 1)
            {
                Main.setText.Text += "for <variable> in range(<sequence>):" + Environment.NewLine + "     #Do something.." + Environment.NewLine + Environment.NewLine;
            }
            else if (variable.Length < 1)
            {
                Main.setText.Text += "for <variable> in range(" + sequence + "):" + Environment.NewLine + "     #Do something.." + Environment.NewLine + Environment.NewLine;
            }
            else if (sequence.Length < 1)
            {
                Main.setText.Text += "for " + variable + " in range(<sequence>):" + Environment.NewLine + "     #Do something.." + Environment.NewLine + Environment.NewLine;
            }
            else
            {
                Main.setText.Text += "for " + variable + " in range(" + sequence + "):" + Environment.NewLine + "     #Do something.." + Environment.NewLine + Environment.NewLine;
            }

            this.Close();

        }
    }
}
