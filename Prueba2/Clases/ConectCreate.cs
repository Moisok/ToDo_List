using Npgsql;
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList.Clases
{
    internal class ConectCreate
    {
        NpgsqlConnection conect = new NpgsqlConnection();
        static String server = "localhost";
        static String bd = "postgres"; //Database
        static String user = "postgres"; //user
        static String password = "admin"; //Password
        static String port = "5432"; //port 

        String conect_on = "server=" + server + ";" + "port=" + port + ";" + "user id=" + user + ";" + "password=" + password + ";" + "database=" + bd + ";";

        public NpgsqlConnection stablishConection()
        {
            try
            {
                conect.ConnectionString = conect_on;
                conect.Open();
                MessageBox.Show("You have connected to the database");

            } catch (NpgsqlException e)
            {
                MessageBox.Show("Database not found");
            }
            return conect;
        }

        public void createTables()
        {
            String query = "CREATE TABLE pending_task (id_task integer NOT NULL, description_task character varying(250), CONSTRAINT pk_id PRIMARY KEY(id_task));"+
                "CREATE TABLE complete_task ( id_task integer,  task_description character varying(250));";


            Npgsql.NpgsqlCommand executor = new Npgsql.NpgsqlCommand(query, conect);
            executor.ExecuteNonQuery();
            MessageBox.Show("Your database it's ready, restart the program please");

        }


    }

    
}
