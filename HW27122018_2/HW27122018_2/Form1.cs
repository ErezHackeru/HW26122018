using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW27122018_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    lbl5.Invoke((MethodInvoker)delegate { lbl5.Text = (4-i).ToString(); });
                    Thread.Sleep(1000);
                }


                lbl5.Invoke((MethodInvoker)delegate { lbl5.Text = "Surprise !"; });
            }).Start();

            ;
        }
    }
}
