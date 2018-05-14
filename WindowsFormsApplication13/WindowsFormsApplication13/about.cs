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
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
    }

        private void about_Load(object sender, EventArgs e)
        {
            label2.Text = "Submitted to:" + "\n" + "\t" + "\t" + "Sir Awais";
            label3.Text = "\n" + "Submitted by:" + "\n" + "2016- CS- 151" + "\n" + "2016- CS- 152" + "\n" + "2016- CS- 158";
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            first f = new first();
            this.Hide();
            f.Show();
        }
    }
    }
