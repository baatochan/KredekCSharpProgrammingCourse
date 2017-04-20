using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BartoszRodziewiczLab3Task1
{
    class Books : DatabaseTable
    {
        /// <summary>
        /// Wyswietlanie wszystkich ksiazek
        /// </summary>
        /// <param name="sqlConnection"></param>
        /// <param name="dataGridView"></param>
        public static void ShowAllBooks(SqlConnection sqlConnection, DataGridView dataGridView)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT Books.Name AS Tytul, Books.Author AS Autor, Books.ISBN AS ISBN, Books.Publisher AS Wydawca, Books.YearOfPublishion AS 'Rok Wydania', Books.Info AS Opis, Categories.Name AS Gatunek, Branches.Name AS Filia, Branches.AddressLine1 AS 'Adres filii', Branches.Phone AS 'Numer telefonu filii' FROM Books JOIN Categories ON Books.CategoryID = Categories.CategoryID JOIN Branches ON Books.BranchID = Branches.BranchID", sqlConnection);
            FillDataGridView(sqlDataAdapter, dataGridView);
        }
        /// <summary>
        /// Wyszukiwanie ksiazki o podanym tytule
        /// </summary>
        /// <param name="sqlConnection"></param>
        /// <param name="dataGridView"></param>
        /// <param name="name"></param>
        public static void FindByName(SqlConnection sqlConnection, DataGridView dataGridView, string name)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"SELECT* FROM Books WHERE Name LIKE '%{name}%'", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
        }
    }
}
