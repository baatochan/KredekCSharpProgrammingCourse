using System.Data.SqlClient;
using System.Windows.Forms;

namespace BartoszRodziewiczLab3Task1
{
    class Branches : DatabaseTable
    {
        /// <summary>
        /// Wyswietlanie wszystkich filii
        /// </summary>
        /// <param name="sqlConnection"></param>
        /// <param name="dataGridView"></param>
        public static void ShowAllBranches(SqlConnection sqlConnection, DataGridView dataGridView)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT Name AS Nazwa, AddressLine1 AS Adres, PostalCode AS 'Kod Pocztowy', City AS Miasto, Phone AS 'Numer Telefonu' FROM Branches", sqlConnection);
            FillDataGridView(sqlDataAdapter, dataGridView);
        }
    }
}
