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

            ntask2 = Int32.Parse(textBox2.Text);

            objecConex.copy_data(ntask2);

            objecConex.delete(ntask2);

            DataTable dataTable = objecConex.select();

            DataTable dataTable2 = objecConex.select2();

            task_complete++;

            dataGridView2.DataSource = dataTable;

            dataGridView1.DataSource = dataTable2;

            label6.Text = "Complete sesion task: " + task_complete;

            MessageBox.Show("Your task it's complete CONGRATULATIONS");

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
           
            ntask2 = Int32.Parse(textBox2.Text);

            objecConex.delete(ntask2);

            DataTable dataTable = objecConex.select();

            dataGridView2.DataSource = dataTable;

            MessageBox.Show("Your data it's delete");

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

            DataTable dataTable2 = objecConex.select2();

            dataGridView2.DataSource = dataTable;
            
            dataGridView1.DataSource = dataTable2;

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}