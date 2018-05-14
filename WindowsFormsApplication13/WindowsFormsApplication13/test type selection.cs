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
    public partial class test_type_selection : Form
    {
        public test_type_selection()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            catagory_selection frm = new catagory_selection();
            this.Hide();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox2.Checked)
            {
                MessageBox.Show("Invalid choice");
            }
            else if (!checkBox1.Checked && !checkBox2.Checked)
            {
                MessageBox.Show("Make one choice");
            }
            if(checkBox1.Checked)
            {
                MessageBox.Show("1:Test contains only 20 questions and you have only 5 minutes to complete the test" + "\n" +
"2:you have to answer each question" + "\n" +
"3:Each question has 4 options, you have to select one suitable option" + "\n" +
"4:Each question has one point" + "\n" +
"5:Submit each question, Otherwise you willn't get any point" + "\n" +
"6:you can move to next Question by clicking on the next button" + "\n" +
"7: you can go back also by clicking on the back button" + "\n" +
"8:you can also quit the test by clicking on the Quit button");
                testQuestion t = new testQuestion();
                this.Hide();
                t.Show();
            }
            if (checkBox2.Checked)
            {
                iqnonverbal iq = new iqnonverbal();
                iq.Show();
                this.Hide();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void test_type_selection_Load(object sender, EventArgs e)
        {

        }
    }
}
