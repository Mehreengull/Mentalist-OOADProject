﻿using System;
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
    public partial class InstructionForm : Form
    {
        public InstructionForm()
        {
            InitializeComponent();
        }

        private void InstructionForm_Load(object sender, EventArgs e)
        {
           
        }

        private void startbtn_Click(object sender, EventArgs e)
        {
            testQuestion tst = new testQuestion();
            this.Hide();
            tst.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
