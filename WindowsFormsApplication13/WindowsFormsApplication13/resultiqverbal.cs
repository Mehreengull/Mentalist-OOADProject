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
    public partial class resultiqverbal : Form
    {
        public resultiqverbal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void resultiqverbal_Load(object sender, EventArgs e)
        {

            if (testQuestion.gain < 77)
            {
                label1.Text = "Mentally deficient";
                pictureBox1.Image = Properties.Resources.thinking_cap;
            }
            else if (testQuestion.gain >= 77 && testQuestion.gain < 79)
            {
                label1.Text = "IQ Is on Borderline";
                pictureBox1.Image = Properties.Resources.Jyly_6_amygdala_hijacking;
            }
            else if (testQuestion.gain >= 79 && testQuestion.gain < 89)
            {
                label1.Text = "IQ Is at Low Average";
                pictureBox1.Image = Properties.Resources.chemicals1;
            }
            else if (testQuestion.gain >= 89 && testQuestion.gain < 109)
            {
                label1.Text = "IQ Is at Average";
                pictureBox1.Image = Properties.Resources.mexcalamity_spawn___mr_average_by_percyfan94;
            }
            else if (testQuestion.gain >= 109 && testQuestion.gain < 115)
            {
                label1.Text = "IQ Is Above Average";
                pictureBox1.Image = Properties.Resources.smarter_than1;
            }
            else if (testQuestion.gain >= 115 && testQuestion.gain < 129)
            {
                label1.Text = "IQ Is High";
                pictureBox1.Image = Properties.Resources.iq;
            }
            else
            {
                label1.Text = "Highly gifted";
                pictureBox1.Image = Properties.Resources.giftedness;
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            catagory_selection c = new catagory_selection();
            this.Hide();
            c.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*first f = new first();
            this.Hide();
            f.Show();*/
            Application.Exit();
        }
    }
}
