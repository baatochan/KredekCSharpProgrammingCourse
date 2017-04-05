using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BartoszRodziewiczLab3
{
    class Animal
    {
        public static void showAllAnimals(SqlConnection sqlConnection, DataGridView dataGridView) 
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT Species AS 'Gatunek', Amount AS 'Ilosc' FROM Animals", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
        }

        public static void addAnimal(SqlConnection sqlConnection, string species, string amount) 
        {
            sqlConnection.Open();
            string command = $"INSERT INTO Animals (Species, Amount) values('{species}','{amount}')";
            SqlCommand sqlCommand = new SqlCommand(command,sqlConnection);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("wyszlo!");
            sqlConnection.Close();
        }
    }
}
