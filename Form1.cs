using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace sodoko1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    TextBox b = new TextBox();
                    tableLayoutPanel1.Controls.Add(b, i, j);
                    b.Multiline = true;
                    b.TextAlign = HorizontalAlignment.Center;
                   



                }
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog x = new OpenFileDialog();
            x.ShowDialog();
            if (x.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("yes");

            }
            if (x.ShowDialog() == DialogResult.OK)
            {
                string file_path = x.FileName;
                StreamReader my_file_reade = new StreamReader(file_path);
                string s = my_file_reade.ReadToEnd();
                MessageBox.Show(s);
                char[] my_separators = { ' ', '\n' };
                string[] numbers = s.Split(my_separators);

            }
        }
    }
}