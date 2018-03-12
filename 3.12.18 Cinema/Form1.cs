using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._12._18_Cinema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label6.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label6.Text = DateTime.Now.ToLongTimeString();
            label7.Text = DateTime.Now.ToLongDateString();
            var btn = new Button();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            var myForm = new Form2();
            myForm.Show();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var myForm = new Form2();
            myForm.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var myForm = new Form2();
            myForm.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var myForm = new Form2();
            myForm.Show();

        }

        private void label5_Click(object sender, EventArgs e)
        {
          
        }
    }
}
