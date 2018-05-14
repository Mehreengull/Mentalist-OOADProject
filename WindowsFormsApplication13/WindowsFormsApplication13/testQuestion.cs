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
using System.Timers;

namespace WindowsFormsApplication13
{
    public partial class testQuestion : Form
    {
        string[] lines;
        string answer;
        int i = 0;
        int index=0;
        int counter = 0;
        string value;
        int duration = 300;
        int questionNo = 0;
        int tmp;
        public static int gain;
        public testQuestion()
        {
            InitializeComponent();
        }

     

        private void testQuestion_Load(object sender, EventArgs e)
        {
            questionNo++;
            label2.Text = questionNo.ToString();
            timer1.Enabled = true;
            timer1.Start();
            // define path
            //lines = File.ReadAllLines(@"G:\Mehreen\semester4\OOAD\project\new\WindowsFormsApplication13\WindowsFormsApplication13\Resources\testttt.txt");
            lblquestion.Text = lines[index];
            radioButton1.Text = lines[++index];
            radioButton2.Text = lines[++index];
            radioButton3.Text = lines[++index];
            radioButton4.Text = lines[++index];
            answer = lines[++index];
            counter = index;

        }

        private void nxtbtn_Click(object sender, EventArgs e)
        {
            questionNo++;
            label2.Text = questionNo.ToString();
           
            if ((!radioButton1.Checked) && (!radioButton2.Checked) && (!radioButton3.Checked) && (!radioButton4.Checked))
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
                answer = lines[++counter];
                tmp = counter - 6;
            }
            else
            {
               /* MessageBox.Show("Test has been ended");*/
                resultiqverbal re = new resultiqverbal();
                re.Show();
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
            MessageBox.Show("YOUR ANSWER HAS BEEN SUBMITTED.");

            if (answer == value)
            {
                gain = gain + 7; ;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            duration--;
            textBox1.Text = duration.ToString();
            if (duration == 0)
            {
                timer1.Stop();
                MessageBox.Show("OHHH!! TIME IS UP.");
            }
           
        }

     

        private void Backbtn_Click(object sender, EventArgs e)
        {
            if(tmp <=0 )
            {
                MessageBox.Show("THIS IS 1ST QUESTION YOU CANNOT GO BACK.");
            }
            else {
                questionNo--;
                label1.Text = questionNo.ToString();
                answer = lines[tmp];
                radioButton4.Text = lines[--tmp];
                radioButton3.Text = lines[--tmp];
                radioButton2.Text = lines[--tmp];
                radioButton1.Text = lines[--tmp];
                lblquestion.Text = lines[--tmp];


                tmp = tmp - 6;
            }
           


        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are going to end the test!");
            catagory_selection cat = new catagory_selection();
            this.Hide();
            cat.Show();
        }

        private void lblscnd_Click(object sender, EventArgs e)
        {

        }

        private void lblqtn_Click(object sender, EventArgs e)
        {

        }
    }
}
