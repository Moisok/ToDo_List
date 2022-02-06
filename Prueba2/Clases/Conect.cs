using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Prueba2.Clases
{
    internal class Conect
    {
        NpgsqlConnection conect = new NpgsqlConnection();

        static String server = "localhost";
        static String bd = "ToDoList" ; //Database
        static String user = "postgres"; //user
        static String password = "admin"; //Password
        static String port = "5432"; //port 

        String conect_on = "server="+server+";"+"port="+port+";"+"user id="+user+";"+"password="+password+";"+"database="+bd+";" ;

        public NpgsqlConnection stablishConection()
        {
            try
            {
                conect.ConnectionString = conect_on;
                conect.Open();
                MessageBox.Show("You have connected to the database");

            }catch(NpgsqlException e){

                MessageBox.Show("Could not connect to the database: "+ e.ToString());
            }

            return conect;
        }

        public void insert(int id_task, String task_desp)
        {
            String query = "Insert into \"pending_task\" values(" + id_task + ",'" + task_desp + "');";
            Npgsql.NpgsqlCommand executor = new Npgsql.NpgsqlCommand(query, conect);
            executor.ExecuteNonQuery();
            MessageBox.Show("Your data it's save");



        }

        public DataTable select()
        {
            String query = "SELECT * " + "  FROM \"pending_task\";";
            Npgsql.NpgsqlCommand conector = new Npgsql.NpgsqlCommand(query, conect);
            Npgsql.NpgsqlDataAdapter datos = new Npgsql.NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;

        }

        public DataTable select2()
        {
            String query = "SELECT * " + "  FROM \"complete_task\";";
            Npgsql.NpgsqlCommand conector = new Npgsql.NpgsqlCommand(query, conect);
            Npgsql.NpgsqlDataAdapter datos = new Npgsql.NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;

        }

        public void delete(int id)
        {
            String query = "Delete from \"pending_task\"where \"id_task\" = " + id + " ";
            Npgsql.NpgsqlCommand execute = new Npgsql.NpgsqlCommand(query,conect);  
            //conect.Open();
            execute.ExecuteNonQuery();
            //conect.Close();
        }

        public void copy_data(int id)
        {
            String query = "INSERT INTO complete_task (id_task, task_description) SELECT * FROM pending_task WHERE id_task = " + id + ";";
            Npgsql.NpgsqlCommand executor = new Npgsql.NpgsqlCommand(query, conect);
            executor.ExecuteNonQuery();
            
        }
    }
}
