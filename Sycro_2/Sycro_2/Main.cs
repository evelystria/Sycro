using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.VisualBasic;
using System.IO;

namespace Sycro_2
{
    public partial class Main : Form
    {

        public Main()
        {

            InitializeComponent();

            //Set a static text box to send values
            setText = bunifuCustomTextbox1;

            //Show Main panel
            MainPanel.BringToFront();


        }

            //Close the application
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
            //Expand/Minimize sidebar
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

            if(panel1.Width == 50)
            {

                panel1.Visible = false;
                panel1.Width = 211;
                bunifuTransition2.ShowSync(panel1);
                pictureBox1.Visible = true;

            }
            else
            {

                panel1.Visible = false;
                panel1.Width = 50;
                bunifuTransition1.ShowSync(panel1);
                pictureBox1.Visible = false;

            }

        }

            // To send values
        public static TextBox setText = new TextBox();

        //ABOUT US
        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {

            panel3.BringToFront();

        }
            
            //PYTHON
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

            panel4.BringToFront();

        }
            //JAVA
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            panel5.BringToFront();
        }
            //C#
        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            panel5.BringToFront();
        }
            //HTML/CSS
        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            panel5.BringToFront();
        }
        //Visit GitHub
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/evelystria");
        }

            //Visit Steam
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Process.Start("http://steamcommunity.com/id/chadjesoo/");
        }
            //Python DATA TYPES
        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            DataTypes childForm = new DataTypes();
            childForm.ShowDialog(this);
        }
            //Python FOR LOOP
        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            ForLoop childForm = new ForLoop();
            childForm.ShowDialog(this);
        }
            //Python Function
        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            Function childForm = new Function();
            childForm.ShowDialog(this);
        }
            //Python If..Elif..Else
        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            Ifelse childForm = new Ifelse();
            childForm.ShowDialog(this);
        }
             //Python Modules
        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            Modules childForm = new Modules();
            childForm.ShowDialog(this);
        }
            //Python PRINT
        private void bunifuThinButton210_Click(object sender, EventArgs e)
        {
            Print childForm = new Print();
            childForm.ShowDialog(this);
        }   

        //Clear textbox
        private void bunifuThinButton29_Click(object sender, EventArgs e)
        {
            bunifuCustomTextbox1.Clear();
        }
            //Export code
        private void bunifuThinButton28_Click(object sender, EventArgs e)
        {
            SaveFileDialog export = new SaveFileDialog();
            export.Filter = "Python (.py) |*.py";
            export.FileName = "New Python File";
            export.Title = "Save Python File";

            if (export.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = export.FileName;
                StreamWriter sw = new StreamWriter(File.Create(path));
                sw.Write(bunifuCustomTextbox1.Text);
                sw.Dispose();
            }

        }

       
    }
}
