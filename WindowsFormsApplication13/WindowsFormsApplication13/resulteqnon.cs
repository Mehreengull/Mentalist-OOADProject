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
    public partial class resulteqnon : Form
    {
        public resulteqnon()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void resulteqnon_Load(object sender, EventArgs e)
        {
            if(Eq_non_verba.score <=55)
            {
                label1.Text = "Weak Emotions";
                pictureBox1.Image = Properties.Resources.Control_Negative_Emotions_The_Great_Everything;
            }
            else if(Eq_non_verba.score >55 && Eq_non_verba.score <= 77 )
            {
                label1.Text = "Emotional Incapacit";
                pictureBox1.Image = Properties.Resources.A_Cartoon_Young_Girl_Screaming_and_Scaring_Her_Cat_As_He_Jumps_High_In_the_Air_Royalty_Free_Clipart_Picture_101008_042283_267053;
            }

            else if(Eq_non_verba.score >77 && Eq_non_verba.score <= 85)
            {
                label1.Text = "Weak Emotional Intelligence";
                pictureBox1.Image = Properties.Resources.v4_728px_Gain_Control_of_Your_Emotions_Step_16;
            }
            else if (Eq_non_verba.score > 85 && Eq_non_verba.score <= 100)
            {
                label1.Text = "Average Emotional Intelligence";
                pictureBox1.Image = Properties.Resources.samuel_1233415_960_720;
            }
            else if (Eq_non_verba.score > 100 && Eq_non_verba.score <= 115)
            {
                label1.Text = "Satisfectory Emotional Intelligence";
                pictureBox1.Image = Properties.Resources.depositphotos_138496362_stock_illustration_customer_and_satisfaction;
            }
            else if (Eq_non_verba.score > 115 && Eq_non_verba.score <= 130)
            {
                label1.Text = "High Emotional Intelligence";
                pictureBox1.Image = Properties.Resources.emoticon_1628080_960_720;
            }
            else if (Eq_non_verba.score > 130 && Eq_non_verba.score <= 145)
            {
                label1.Text = "Excellent Emotional Intelligence";
                pictureBox1.Image = Properties.Resources.fine;
            }
            else
            {
                label1.Text = "Exceptional Emotional Intelligence";
                pictureBox1.Image = Properties.Resources._240_F_166973432_javz4rryzDllayjfDhjXPuniehmeU8S3;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            catagory_selection c = new catagory_selection();
            this.Hide();
            c.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*first s = new first();
            this.Hide();
            s.Show();*/
            Application.Exit();
        }
    }
}
