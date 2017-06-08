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
    public partial class DataTypes : Form
    {
        public DataTypes()
        {
            InitializeComponent();

        }

            //Close user prompt
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

            //When OK
        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {

            string varname = bunifuCustomTextbox1.Text;
            string vardata = bunifuCustomTextbox2.Text;

            Main.setText.Text += "#--- Data Types ---#" + Environment.NewLine;
            Main.setText.Font = new Font(bunifuCustomTextbox1.Font.FontFamily, 12);
            Main.setText.ForeColor = Color.Orange;

            if (varname.Length < 1 && vardata.Length < 1)
            {
                Main.setText.Text += "<var_name> = <var_data>" + Environment.NewLine + Environment.NewLine;
            }
            else if(varname.Length < 1)
            {
                Main.setText.Text += "<var_name>" + " = " + vardata + Environment.NewLine + Environment.NewLine;
            }
            else if(vardata.Length < 1)
            {
                Main.setText.Text += varname + " = " + "<var_data>" + Environment.NewLine + Environment.NewLine;
            }
            else
            {
                Main.setText.Text += varname + " = " + vardata + Environment.NewLine + Environment.NewLine;
            }

            this.Close();

        }

    }
}
