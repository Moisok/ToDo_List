using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba2

{
    public partial class Form1 : Form
    {
        //  Variables
        String task;
        String task2;
        int task_numer = 0;
        int task_complete = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fontDialog2_Apply(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            task2 = listView1.SelectedItems[0].Text;
            listView3.Items.Add(task2);
            listView1.SelectedItems[0].Remove();
            task_complete++;
            label6.Text = "Complete: " + task_complete;

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
            {
                textBox1.AppendText("Please put the task");
            }
            else
            {
                task_numer++;
                task = this.textBox1.Text;
                listView1.Items.Add(task_numer + " " + task);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
  
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            task2 = listView1.SelectedItems[0].Text;
            listView2.Items.Add(task2);
            listView1.SelectedItems[0].Remove();
        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click_2(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
