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
    public partial class eqverbal : Form
    {
        string[] lines;
        int i = 0;
        int index = 0;
        int counter = 0;
        int questionNo = 0;
        int tmp;
        public static int marks;
        public eqverbal()
        {
            InitializeComponent();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
        }

        private void nxtbtn_Click(object sender, EventArgs e)
        {
            questionNo++;
            label1.Text = questionNo.ToString();

            if ((!radioButton1.Checked) && (!radioButton2.Checked) && (!radioButton3.Checked) && (!radioButton4.Checked))
            {
                MessageBox.Show("PLEASE, SELECT ATLEAST 1 OPTION.");
            }
            else if (questionNo <= 20)
            {
                lblquestion.Text = lines[++counter];
                radioButton1.Text = lines[++counter];
                radioButton2.Text = lines[++counter];
                radioButton3.Text = lines[++counter];
                radioButton4.Text = lines[++counter];
               
                tmp = counter - 5;
            }
           else 
            {
               /* MessageBox.Show("Test has been ended");*/
                resulteqverbal non = new resulteqverbal();
                non.Show();
                this.Hide();
            }
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                marks = marks + 25;
            }
            else if (radioButton2.Checked)
            {
                marks = marks + 45;
            }
            else if (radioButton3.Checked)
            {
                marks = marks + 15;
            }
            else if (radioButton4.Checked)
            {
                marks = marks + 0;
            }

            MessageBox.Show("YOUR ANSWER HAS BEEN SUBMITTED");
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are going to end the test");
            catagory_selection cat = new catagory_selection();
            this.Hide();
            cat.Show();
        }

        private void eqverbal_Load(object sender, EventArgs e)
        {
            questionNo++;
            label1.Text = questionNo.ToString();
            //define path
         //   lines = File.ReadAllLines(@"G:\Mehreen\semester4\OOAD\project\new\WindowsFormsApplication13\WindowsFormsApplication13\Resources\Eq.txt");
            lblquestion.Text = lines[index];
            radioButton1.Text = lines[++index];
            radioButton2.Text = lines[++index];
            radioButton3.Text = lines[++index];
            radioButton4.Text = lines[++index];
           
            counter = index;
        }

    }
}
