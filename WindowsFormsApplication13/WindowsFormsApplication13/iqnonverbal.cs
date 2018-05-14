using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication13
{
    public partial class iqnonverbal : Form
    {
        string[] lines;
        string answer;
        int i = 0;
        int index = 0;
        int counter = 0;
        string value;
        int duration = 300;
        int questionNo = 0;
        int tmp;
        public static int total;
        public iqnonverbal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are going to end the test!");
            catagory_selection cat = new catagory_selection();
            this.Hide();
            cat.Show();
        }

        private void nxtbtn_Click(object sender, EventArgs e)
        {
          
            questionNo++;
       
            if(questionNo == 2)
            {
                pictureBox1.Image = Properties.Resources._2;
            }
            if (questionNo == 3)
            {
                pictureBox1.Image = Properties.Resources._3;
            }
             if (questionNo == 4)
            {
                pictureBox1.Image = Properties.Resources._4;
            }
            if (questionNo == 5)
            {
                pictureBox1.Image = Properties.Resources._5;
            }
             if (questionNo == 6)
            {
                pictureBox1.Image = Properties.Resources._6;
            }
             if (questionNo == 7)
            {
                pictureBox1.Image = Properties.Resources._7;
            }
             if (questionNo == 8)
            {
                pictureBox1.Image = Properties.Resources._8;
            }
             if (questionNo == 9)
            {
                pictureBox1.Image = Properties.Resources._9;
            }
            if (questionNo == 10)
            {
                pictureBox1.Image = Properties.Resources._10;
            }
             if (questionNo == 11)
            {
                pictureBox1.Image = Properties.Resources._11;
            }
             if (questionNo == 12)
            {
                pictureBox1.Image = Properties.Resources._12;
            }
             if (questionNo == 13)
            {
                pictureBox1.Image = Properties.Resources._13;
            }
             if (questionNo == 14)
            {
                pictureBox1.Image = Properties.Resources._14;
            }
            else if (questionNo == 15)
            {
                pictureBox1.Image = Properties.Resources._15;
            }
            else if (questionNo == 16)
            {
                pictureBox1.Image = Properties.Resources._16;
            }
            else if (questionNo == 17)
            {
                pictureBox1.Image = Properties.Resources._18;
            }
            else if (questionNo == 18)
            {
                pictureBox1.Image = Properties.Resources._19;
            }
          
            label1.Text = questionNo.ToString();

            if ((!radioButton1.Checked) && (!radioButton2.Checked) && (!radioButton3.Checked) && (!radioButton4.Checked) &&(!radioButton5.Checked))
            {
                MessageBox.Show("Select Atleast One Option");
            }
            else if (questionNo <= 20)
            {
                lblquestion.Text = lines[++counter];
                radioButton1.Text = lines[++counter];
                radioButton2.Text = lines[++counter];
                radioButton3.Text = lines[++counter];
                radioButton4.Text = lines[++counter];
                radioButton5.Text = lines[++counter];
                answer = lines[++counter];
                tmp = counter - 7;
                i = questionNo;
            }
            else
            {
                /*MessageBox.Show("Test has been ended");*/
                resultiqnon non = new resultiqnon();
                non.Show();
                this.Hide();
            }
           

        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                value = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                value = radioButton2.Text;
            }
            else if (radioButton3.Checked)
            {
                value = radioButton3.Text;
            }
            else if (radioButton4.Checked)
            {
                value = radioButton4.Text;
            }
            else if (radioButton5.Checked)
            {
                value = radioButton5.Text;
            }
            MessageBox.Show("YOUR ANSWER HAS BEEN SUBMITTED.");

            if (answer == value)
            {
                total= total+7;
            }
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
          

          

        }

        private void iqnonverbal_Load(object sender, EventArgs e)
        {
            
            questionNo++;
            pictureBox1.Image = Properties.Resources._1;
           
           // label2.Text = questionNo.ToString();
            timer1.Enabled = true;
            timer1.Start();
            //define path
           // lines = File.ReadAllLines(@"G:\Mehreen\semester4\OOAD\project\new\WindowsFormsApplication13\WindowsFormsApplication13\Resources\IQ NON VERBAL.txt");
            lblquestion.Text = lines[index];
            radioButton1.Text = lines[++index];
            radioButton2.Text = lines[++index];
            radioButton3.Text = lines[++index];
            radioButton4.Text = lines[++index];
            radioButton5.Text = lines[++index];
            answer = lines[++index];
            counter = index;

        }

        private void lblscnd_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            duration--;
            textBox1.Text = duration.ToString();
            if (duration == 0)
            {
                timer1.Stop();
                MessageBox.Show("SORRY! TIME IS UP.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
