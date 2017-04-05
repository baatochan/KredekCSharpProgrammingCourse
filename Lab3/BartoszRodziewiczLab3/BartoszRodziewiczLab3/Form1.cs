using System.Data.SqlClient;
using System.Windows.Forms;

namespace BartoszRodziewiczLab3
{
    public partial class FormZoo : Form
    {
        SqlConnection sqlConnection;
        SqlDataAdapter sqlDataAdapter;
        
        public FormZoo()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection("Data Source=BARTOSZ-PC2\\SQLEXPRESS; database=Zoo; Trusted_Connection=yes");
        }

        private void buttonAllAnimals_Click(object sender, System.EventArgs e)
        {
            Animal.showAllAnimals(sqlConnection, dataGridViewZoo);
        }

        private void buttonShowAllSloths_Click(object sender, System.EventArgs e)
        {
            Sloths.showAllSloths(sqlConnection, dataGridViewZoo);
        }

        private void buttonAdd_Click(object sender, System.EventArgs e)
        {
            Animal.addAnimal(sqlConnection, textBoxSpecies.Text, textBoxAmount.Text);
            Animal.showAllAnimals(sqlConnection, dataGridViewZoo);
        }
    }
}
