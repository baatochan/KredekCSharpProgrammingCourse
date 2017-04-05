using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BartoszRodziewiczLab3
{
    class Sloths
    {
        public static void showAllSloths(SqlConnection sqlConnection, DataGridView dataGridView)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(@"SELECT Sloths.Name, Sloths.Age, Zookeepers.Name, Zookeepers.Surname, Animals.Species from Sloths Join Animals On Animals.id=sloths.animalid Join Zookeepers on zookeepers.id=sloths.zookeeperid", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
        }
    }
}
