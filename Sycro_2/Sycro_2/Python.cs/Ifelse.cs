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
    public partial class Ifelse : Form
    {
        public Ifelse()
        {
            InitializeComponent();
        }
            //Close app
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
            //IF OK
        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            Main.setText.Text += "#--- If, Elif, Else ---#" + Environment.NewLine;
            Main.setText.Font = new Font(Main.setText.Font.FontFamily, 12);
            Main.setText.ForeColor = Color.Orange;

            Main.setText.Text += "if <Condition 1> :" + Environment.NewLine + "     #Do something.." + Environment.NewLine + "elif <Condition 2> :" + Environment.NewLine + "     #Do something.." + Environment.NewLine + "else:" + Environment.NewLine + "     #Do something.." + Environment.NewLine + Environment.NewLine;

            this.Close();
        }

    }
}
