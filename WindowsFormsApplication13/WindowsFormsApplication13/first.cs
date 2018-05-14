using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication13
{
    public partial class first : Form
    {
        public first()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            start s = new start();
            this.Hide();
            s.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Project is about calculating EQ and IQ of a person" + "\n" + "You just need to login to start the test.");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            about a = new about();
            this.Hide();
            a.Show();
        }
    }
}
