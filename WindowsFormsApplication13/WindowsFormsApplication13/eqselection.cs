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
    public partial class eqselection : Form
    {
        public eqselection()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            catagory_selection cq = new catagory_selection();
            this.Hide();
            cq.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                eqverbal ver = new eqverbal();
                this.Hide();
                ver.Show();
            
            }
            else if(checkBox2.Checked)
            {
                Eq_non_verba eq = new Eq_non_verba();
                this.Hide();
                eq.Show();
            }
        }

        private void eqselection_Load(object sender, EventArgs e)
        {

        }
    }
}
