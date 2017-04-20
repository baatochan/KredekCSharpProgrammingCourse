using System.Data.SqlClient;
using System.Windows.Forms;

namespace BartoszRodziewiczLab3Task1
{
    class Clients : DatabaseTable
    {
        /// <summary>
        /// Wyswietlanie wszystkich klientow
        /// </summary>
        /// <param name="sqlConnection"></param>
        /// <param name="dataGridView"></param>
        public static void ShowAllClients(SqlConnection sqlConnection, DataGridView dataGridView)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT Name AS Imie, Surname AS Nazwisko, AddressLine1 AS Adres, PostalCode AS 'Kod Pocztowy', City AS Miasto, Phone AS 'Numer telefonu', Email AS 'E-mail' FROM Clients", sqlConnection);
            FillDataGridView(sqlDataAdapter, dataGridView);
        }
    }
}
