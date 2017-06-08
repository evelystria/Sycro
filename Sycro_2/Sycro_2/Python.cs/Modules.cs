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
    public partial class Modules : Form
    {
        public Modules()
        {
            InitializeComponent();

                //Create new ListBox of MODULES :)
            string[] arr = { "Math", "Random", "Tkinter", "Image", "ScrolledText", "StringIO", "SocketServer", "json", "os", "xml", "*" };
            checkedListBox1.Items.AddRange(arr);
        }
            //Exit app
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
            //OK
        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {

            Main.setText.Text = Main.setText.Text.Insert(0, Environment.NewLine);

            foreach (Object item in checkedListBox1.CheckedItems)
            {
                string data = item.ToString();
                Main.setText.Text = Main.setText.Text.Insert(0, "import " + data.ToLower() + Environment.NewLine);
            }
 
            Main.setText.Font = new Font(Main.setText.Font.FontFamily, 12);
            Main.setText.ForeColor = Color.Orange;
            Main.setText.Text = Main.setText.Text.Insert(0, "#--- Imported Modules ---#" + Environment.NewLine);

            this.Close();

        }

    }
}
