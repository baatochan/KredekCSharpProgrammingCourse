using System.Data.SqlClient;
using System.Windows.Forms;

namespace BartoszRodziewiczLab3Task1
{
    class Categories : DatabaseTable
    {
        /// <summary>
        /// Wyswietlanie wszystkich kategorii
        /// </summary>
        /// <param name="sqlConnection"></param>
        /// <param name="dataGridView"></param>
        public static void ShowAllCategories(SqlConnection sqlConnection, DataGridView dataGridView)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT Name AS Nazwa FROM Categories", sqlConnection);
            FillDataGridView(sqlDataAdapter, dataGridView);
        }
    }
}
