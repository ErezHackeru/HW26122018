using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW27122018_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            TextLbl.ForeColor = panel1.BackColor;
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            TextLbl.ForeColor = panel2.BackColor;
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            TextLbl.ForeColor = panel3.BackColor;
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            TextLbl.ForeColor = panel4.BackColor;
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            TextLbl.ForeColor = panel5.BackColor;
        }
    }
}
