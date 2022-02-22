using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
   
    public partial class TutorialSQL : Form
    {
        Clases.ConectCreate conexioncreate = new Clases.ConectCreate();

        int passNo = 0;
        List<string> steps = new List<string>();
        String pass1 = "For use this program, you need install PostgreSQL, please follow the next steps (this app only it's compatible whit Windows).";
        String pass2 = "Step 1: In first time, download postgreSQL in the official Web https://www.postgresql.org";
        String pass3 = "Step 2: Open the postgreSQL installer and click in next.";
        String pass4 = "Step 3: Choose or create a directory to install program and click in next.";
        String pass5 = "Step 5: mark componentes (PostgreSQL server, pgAdmin and Command Line Tools) and click next.";
        String pass6 = "Step 6: Choose or create a directory to save datas and click in next.";
        String pass7 = "Step 7: Here it will ask you for the password you want to choose, you must put admin and repeat admin, click in next";
        String pass8 = "Step 8: Don't touch the default port, it should be 5432 and click in next";
        String pass9 = "Step 9: Press next until it starts to install the program";
        String pass10 = "Step 10: Once the program is installed, click on the finish button of this same tutorial, wait 20 seconds and restart\n" +
            "     the program, then start it and hit connect posgreSQL in the main window, and it will be ready to use!";
   

        public TutorialSQL()
        {
            
            steps.Add(pass1);
            steps.Add(pass2);
            steps.Add(pass3);
            steps.Add(pass4);
            steps.Add(pass5);
            steps.Add(pass6);
            steps.Add(pass7);
            steps.Add(pass8);
            steps.Add(pass9);
            steps.Add(pass10);
            InitializeComponent();   
            label1.Text = steps[0];
            button2.Hide();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            passNo++;
            label1.Text = steps[passNo];
            if (passNo == 9)
            {
               button1.Hide();
            }
            if (passNo >= 0)
            {
                button2.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            passNo--;
            label1.Text = steps[passNo];
            if (passNo == 0)
            {
                button2.Hide();
            }
            if (passNo < 9)
            {
                button1.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conexioncreate.stablishConection();
            conexioncreate.createTables();
        }
    }
}
