using System.Data.SqlClient;
using System.Windows.Forms;

namespace BartoszRodziewiczLab3Task1
{
    public partial class FormLibrary : Form
    {
        SqlConnection sqlConnection;

        public FormLibrary()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection("Data Source=BARTOSZ-PC2\\SQLEXPRESS; database=Library;Trusted_Connection=yes");
        }

        private void buttonBooks_Click(object sender, System.EventArgs e)
        {
            Books.ShowAllBooks(sqlConnection, dataGridViewLibrary);
        }

        private void buttonCategories_Click(object sender, System.EventArgs e)
        {
            Categories.ShowAllCategories(sqlConnection, dataGridViewLibrary);
        }

        private void buttonClients_Click(object sender, System.EventArgs e)
        {
            Clients.ShowAllClients(sqlConnection, dataGridViewLibrary);
        }

        private void buttonBranches_Click(object sender, System.EventArgs e)
        {
            Branches.ShowAllBranches(sqlConnection, dataGridViewLibrary);
        }

        private void buttonLibrarians_Click(object sender, System.EventArgs e)
        {
            Librarians.ShowAllLibrarians(sqlConnection, dataGridViewLibrary);
        }

        private void buttonReservations_Click(object sender, System.EventArgs e)
        {
            Reservations.ShowAllReservations(sqlConnection, dataGridViewLibrary);
        }

        private void buttonLibrarianAdd_Click(object sender, System.EventArgs e)
        {
            Librarians.AddLibrarian(sqlConnection, dataGridViewLibrary, textBoxLibrarianName.Text, textBoxLibrarianSurname.Text, textBoxLibrarianHireDate.Text);
        }

        private void buttonLibrarianRemove_Click(object sender, System.EventArgs e)
        {
            Librarians.RemoveLibrarian(sqlConnection, dataGridViewLibrary, textBoxLibrarianName.Text, textBoxLibrarianSurname.Text, textBoxLibrarianHireDate.Text);
        }

        private void textBoxBookTitle_TextChanged(object sender, System.EventArgs e)
        {
            Books.FindByName(sqlConnection, dataGridViewLibrary, textBoxBookTitle.Text);
        }

        private void buttonLibrarianEdit_Click(object sender, System.EventArgs e)
        {
            Librarians.UpdateLibrarian(sqlConnection, dataGridViewLibrary, textBoxLibrarianID.Text, textBoxLibrarianName.Text, textBoxLibrarianSurname.Text, textBoxLibrarianHireDate.Text);
        }
    }
}
