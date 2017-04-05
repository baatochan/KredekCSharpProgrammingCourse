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
    }
}
