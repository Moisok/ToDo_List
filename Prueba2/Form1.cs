using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;using System.Data;

namespace Prueba2

{
    public partial class Form1 : Form
    {
        //  Variables
        String task;

        int ntask2;

        int task_number = 0;

        int task_complete = 0;

        Random rnd = new Random();

        Clases.Conect objecConex = new Clases.Conect();

       

        public Form1()
        {

        
            InitializeComponent();

            String time = "HH:mm";

            label7.Text = time;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fontDialog2_Apply(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*if (listView1.SelectedItems.Count > 0)
            {
                task2 = listView1.SelectedItems[0].Text;

                listView3.Items.Add(task2);

                listView1.SelectedItems[0].Remove();

                task_complete++;

                label6.Text = "Complete: " + task_complete; 
            }
            else
            {
                MessageBox.Show("Please select an item before assigning a value.");

            }*/

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
            if (textBox1.TextLength == 0)
            {
                MessageBox.Show("Please put the task");
            }
            else
            {

                task_number = rnd.Next(0, 9999);

                task = this.textBox1.Text;

                objecConex.insert(task_number, task);

                DataTable dataTable = objecConex.select();

                dataGridView2.DataSource = dataTable;

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
            /*if (listView1.SelectedItems.Count > 0)
            {
                task2 = listView1.SelectedItems[0].Text;

                listView2.Items.Add(task2);

                listView1.SelectedItems[0].Remove();
            }
            else

            {
                MessageBox.Show("Please select an item before assigning a value.");

            }*/

            ntask2 = Int32.Parse(textBox2.Text);

            objecConex.delete(ntask2);

            DataTable dataTable = objecConex.select();

            dataGridView2.DataSource = dataTable;

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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            objecConex.stablishConection();

            DataTable dataTable = objecConex.select();

            dataGridView2.DataSource = dataTable;
   
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Datos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}