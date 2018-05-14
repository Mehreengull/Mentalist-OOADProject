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
using System.Resources;
namespace WindowsFormsApplication13
{
    public partial class Eq_non_verba : Form
    {
        string[] lines;
        string answer;
        int i = 0;
        int index = 0;
        int counter = 0;
        string value;
        int questionNo = 0;
        int tmp;
        public static int score;
        public Eq_non_verba()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Eq_non_verba_Load(object sender, EventArgs e)
        {
            questionNo++;
            label1.Text = questionNo.ToString();
          //please define path
         //lines = File.ReadAllLines(@"C:\Users\Tehreem Shazadi\Desktop\ooad\WindowsFormsApplication13\WindowsFormsApplication13\Resources\TextFile1.txt");
           
            radioButton1.Text = lines[index];
            radioButton2.Text = lines[++index];
            radioButton3.Text = lines[++index];
            radioButton4.Text = lines[++index];
            answer = lines[++index];
            counter = index;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            questionNo++;
            label1.Text = questionNo.ToString();
            if(questionNo== 1)
            {
                pictureBox1.Image = Properties.Resources.e1;
            }
            else if(questionNo ==2)
            {
                pictureBox1.Image = Properties.Resources.e2;
            }
            else if (questionNo == 3)
            {
                pictureBox1.Image = Properties.Resources.e3;
            }
            else if (questionNo == 4)
            {
                pictureBox1.Image = Properties.Resources.e4;
            }
            else if (questionNo == 5)
            {
                pictureBox1.Image = Properties.Resources.e5;
            }
            else if (questionNo == 6)
            {
                pictureBox1.Image = Properties.Resources.e6;
            }
            else if (questionNo == 7)
            {
                pictureBox1.Image = Properties.Resources.e7;
            }
            else if (questionNo == 8)
            {
                pictureBox1.Image = Properties.Resources.e8;
            }
            else if (questionNo == 9)
            {
                pictureBox1.Image = Properties.Resources.e9;
            }
            else if (questionNo == 10)
            {
                pictureBox1.Image = Properties.Resources.e10;
            }
            else if (questionNo == 11)
            {
                pictureBox1.Image = Properties.Resources.e11;
            }
            else if (questionNo == 12)
            {
                pictureBox1.Image = Properties.Resources.e12;
            }
            else if (questionNo == 13)
            {
                pictureBox1.Image = Properties.Resources.e13;
            }
            else if (questionNo == 14)
            {
                pictureBox1.Image = Properties.Resources.e14;
            }
            else if (questionNo == 15)
            {
                pictureBox1.Image = Properties.Resources.e15;
            }
            else if (questionNo == 16)
            {
                pictureBox1.Image = Properties.Resources.e16;
            }
            else if (questionNo == 17)
            {
                pictureBox1.Image = Properties.Resources.e17;
            }
            else if (questionNo == 18)
            {
                pictureBox1.Image = Properties.Resources.e18;
            }
            else if (questionNo == 19)
            {
                pictureBox1.Image = Properties.Resources.e19;
            }
            else if (questionNo == 20)
            {
                pictureBox1.Image = Properties.Resources.e20;
            }
            if ((!radioButton1.Checked) && (!radioButton2.Checked) && (!radioButton3.Checked) && (!radioButton4.Checked))
            {
                MessageBox.Show("PLEASE, SELECT ATLEAST ONE OPTION");
            }
            else if (questionNo <= 20)
            {

                radioButton1.Text = lines[++counter];
                radioButton2.Text = lines[++counter];
                radioButton3.Text = lines[++counter];
                radioButton4.Text = lines[++counter];
                answer = lines[++counter];
                tmp = counter - 5;
            }
            else
            {
                //MessageBox.Show("HEY! YOUR TEST HAS BEEN ENDED.");
                resulteqnon non = new resulteqnon();
                non.Show();
                this.Hide();
            }

        }

        private void button2_Click(object sender, EventArgs e)
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


            if (answer == value)
            {
                score=score+ 7;
            }
            MessageBox.Show("YOUR ANSWER HAS BEEN SUBMITTED.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("You are going to end the test!");
            catagory_selection c = new catagory_selection();
            this.Hide();
            c.Show();
        }
    }
}
