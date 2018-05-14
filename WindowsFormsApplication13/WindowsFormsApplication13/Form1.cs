using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;

namespace WindowsFormsApplication13
{
    public partial class Form1 : Form
    {
  
      
        public Form1()
        {
            InitializeComponent();
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 5)
            {
                MessageBox.Show("PLEASE ENTER A USERNAME OF LENGTH 5");
            }
            else if (!textBox2.Text.Contains("@gmail.com"))
            {
                MessageBox.Show("PLEASE ENTER A VALID EMAIL ADDRESS");
            }
            else
            {

                server.Service1 myserver = new server.Service1();
                myserver.registration(textBox1.Text, textBox2.Text);

                MessageBox.Show("REGISTERED!");
            }
        
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 frm = new Form2();
            this.Hide();
            frm.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            start a = new start();
            a.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            Size = new System.Drawing.Size(400, 400);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

         
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    
    }
}
