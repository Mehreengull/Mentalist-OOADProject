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
    public partial class catagory_selection : Form
    {
        public catagory_selection()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox2.Checked)
            {
                MessageBox.Show("Invalid choice");
            }
            else if (!checkBox1.Checked && !checkBox2.Checked)
            {
                MessageBox.Show("Make atleast one choice");
            }
            else
            {

                test_type_selection f = new test_type_selection();
                this.Hide();
                f.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            this.Hide();
            f.Show();
        }
    }
}
