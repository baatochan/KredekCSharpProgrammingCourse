using System.Data.SqlClient;
using System.Windows.Forms;

namespace BartoszRodziewiczLab3Task1
{
    class Librarians : DatabaseTable
    {
        static SqlCommand sqlCommand;

        /// <summary>
        /// Wyswietlanie wszystkich pracownikow
        /// </summary>
        /// <param name="sqlConnection"></param>
        /// <param name="dataGridView"></param>
        public static void ShowAllLibrarians(SqlConnection sqlConnection, DataGridView dataGridView)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT LibrarianID AS 'Index', Name AS Imie, Surname AS Nazwisko, HireDate AS 'Data zatrudnienia' FROM Librarians", sqlConnection);
            FillDataGridView(sqlDataAdapter, dataGridView);
        }
        /// <summary>
        /// Dodawanie nowego pracownika
        /// </summary>
        /// <param name="sqlConnection"></param>
        /// <param name="dataGridView"></param>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="hiredate"></param>
        public static void AddLibrarian(SqlConnection sqlConnection, DataGridView dataGridView, string name, string surname, string hiredate)
        {
            try
            {
                sqlConnection.Open();
                string command = $"INSERT INTO Librarians (Name,Surname,HireDate) values ('{name}','{surname}','{hiredate}')";
                sqlCommand = new SqlCommand(command, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                ShowAllLibrarians(sqlConnection, dataGridView);
                sqlConnection.Close();
            }
            catch
            {
                MessageBox.Show("Błąd");
            }
        }
        /// <summary>
        /// Usuniecie pracownika
        /// </summary>
        /// <param name="sqlConnection"></param>
        /// <param name="dataGridView"></param>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="hiredate"></param>
        public static void RemoveLibrarian(SqlConnection sqlConnection, DataGridView dataGridView, string name, string surname, string hiredate)
        {
            try
            {
                sqlConnection.Open();
                string command = $"DELETE FROM Librarians WHERE name = '{name}' AND surname = '{surname}' AND HireDate = '{hiredate}'";
                sqlCommand = new SqlCommand(command, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                ShowAllLibrarians(sqlConnection, dataGridView);
                sqlConnection.Close();
            }
            catch
            {
                MessageBox.Show("Błąd");
            }
        }
        /// <summary>
        /// aktualizuj pracownika
        /// </summary>
        /// <param name="sqlConnection"></param>
        /// <param name="dataGridView"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="hiredate"></param>
        public static void UpdateLibrarian(SqlConnection sqlConnection, DataGridView dataGridView, string id, string name, string surname, string hiredate)
        {
            try
            {
                sqlConnection.Open();
                string command = $"UPDATE Librarians SET name = '{name}', surname = '{surname}', HireDate = '{hiredate}' WHERE LibrarianID = '{id}'";
                sqlCommand = new SqlCommand(command, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                ShowAllLibrarians(sqlConnection, dataGridView);
                sqlConnection.Close();
            }
            catch
            {
                MessageBox.Show("Błąd");
            }
        }
    }
}
