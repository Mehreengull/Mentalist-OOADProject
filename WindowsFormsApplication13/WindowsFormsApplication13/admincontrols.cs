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

namespace WindowsFormsApplication13
{
    public partial class admincontrols : Form
    {
        public admincontrols()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminlogin l = new adminlogin();
            l.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process proc = new Process();
            proc.StartInfo = new ProcessStartInfo(@"G:\Mehreen\semester4\OOAD\project\ooad\WindowsFormsApplication13\WindowsFormsApplication13\Resources\testttt.txt");
            proc.Start();
            
        }

        private void admincontrols_Load(object sender, EventArgs e)
        {
            
        }
    }
}
