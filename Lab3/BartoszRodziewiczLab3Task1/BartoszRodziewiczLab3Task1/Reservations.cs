using System.Data.SqlClient;
using System.Windows.Forms;

namespace BartoszRodziewiczLab3Task1
{
    class Reservations : DatabaseTable
    {
        /// <summary>
        /// Wyswietlanie wszystkich reserwacji
        /// </summary>
        /// <param name="sqlConnection"></param>
        /// <param name="dataGridView"></param>
        public static void ShowAllReservations(SqlConnection sqlConnection, DataGridView dataGridView)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT Reservations.ReservationID AS 'Numer rezerwacji', Clients.Name AS 'Imię rezerwującego', Clients.Surname AS 'Nazwisko rezerwujacego', Books.Name AS 'Tytul ksiazki', Books.Author AS 'Autor', DateOfReservation AS 'Data rezerwacji', DateOfPickup AS 'Data odebrania', DateOfReturn AS 'Data zwrotu' FROM Reservations JOIN Clients ON Reservations.ClientID = Clients.ClientID JOIN Books ON Reservations.BookID = Books.BookID", sqlConnection);
            FillDataGridView(sqlDataAdapter, dataGridView);
        }
    }
}
