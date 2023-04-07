using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Displaying_Triangles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pattern1 = "";

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    pattern1 += "*";
                }

                pattern1 += "\n";
            }
            MessageBox.Show(pattern1, "Pattern 1");

            string pattern2 = "";
            for (int i = 10; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    pattern2 += "*";
                }
                pattern2 += "\n";
            }
            MessageBox.Show(pattern2, "Pattern 2");
        }
    }
}
