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
    public partial class adminlogin : Form
    {
        public adminlogin()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            adminreg a = new adminreg();
            a.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isvalid = true;
            bool isvalidpss;
            //bool isvalidemail;
            server.Service1 myserver = new server.Service1();
            myserver.isvalidadmin(textBox1.Text, textBox2.Text, textBox3.Text, out isvalid, out isvalidpss);
            if (!isvalid)
            {
                MessageBox.Show("GREAT!! VALID PERSON");
                admincontrols c = new admincontrols();
                this.Hide();
                c.Show();
            }
            else if (!isvalid)
            {
                MessageBox.Show("OOPS!! INVALID PERSON");
            }
        }

        private void adminlogin_Load(object sender, EventArgs e)
        {

        }
    }
}
