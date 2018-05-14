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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isvaliduser;
            bool isvaliduserpassed;
            server.Service1 myserver = new server.Service1();
            myserver.isvaliduser(textBox1.Text, textBox2.Text, out isvaliduser, out isvaliduserpassed);
            if (isvaliduser == true) 
            {
                MessageBox.Show("VALID USER!");
                catagory_selection c = new catagory_selection();
                this.Hide();
                c.Show();
            }
            else
            {
                MessageBox.Show("OOPS, INVALID USER");
            }


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
