using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rodziewicz_Egzamin_D
{
    public partial class Form1 : Form
    {
        SqlConnection sqlConnection;

        public Form1()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection("Data Source=BARTOSZ-PC2\\SQLEXPRESS; database=NORTHWND;Trusted_Connection=yes");

        }

        private void buttonSuppliers_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * From Suppliers", sqlConnection);
            FillDataGridView(sqlDataAdapter, dataGridView);
        }

        private static void FillDataGridView(SqlDataAdapter sqlDataAdapter, DataGridView dataGridView)
        {
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;

        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * From Products", sqlConnection);
            FillDataGridView(sqlDataAdapter, dataGridView);
        }

        private void buttonFilterByPrice_Click(object sender, EventArgs e)
        {
            //int price = Intger. textBoxPriceToFilter.Text
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * From Products Where price>='%{price}%'", sqlConnection);
            FillDataGridView(sqlDataAdapter, dataGridView);
        }
    }
}
