using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Planilla.dao
{
    class ClientesDao
    {
        public MySqlConnection MySqlCommand { get; private set; }

        public void Conectar()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=clientes;";

            string query = "SELECT * FROM `cleintes`";
            MySqlConnection dataBaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, dataBaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try

            {
               
                dataBaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                       string [] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3) };


                    }
                }
                else
                {
                    MessageBox.Show("no se encontraron datos");

                }
                dataBaseConnection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}     
    







