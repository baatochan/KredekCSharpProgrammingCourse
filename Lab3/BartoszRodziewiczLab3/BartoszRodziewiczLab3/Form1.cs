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

namespace Zoo
{
    public partial class Form1 : Form
    {
        SqlConnection sqlConnection;

        public Form1()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection("Data Source=BARTOSZ-PC2\\SQLEXPRESS; database=ZOO;Trusted_Connection=yes");
            var Species = Animals.ListOfSpecies(sqlConnection);
            foreach (string n in Species)
            {
                comboBoxSpecies.Items.Add(n);
            }
        }

        private void buttonAnimals_Click(object sender, EventArgs e)
        {
            Animals.ShowAllAnimals(sqlConnection, dataGridViewZoo);
        }

        private void buttonSloths_Click(object sender, EventArgs e)
        {
            Sloths.ShowAllSloths(sqlConnection, dataGridViewZoo);
        }

        private void buttonAddZookeeper_Click(object sender, EventArgs e)
        {
            Zookeepers.AddZookeeper(sqlConnection, dataGridViewZoo, textBoxZookeeperName.Text, textBoxZookeeperSurname.Text);
        }

        private void buttonShowAllZookeepers_Click(object sender, EventArgs e)
        {
           Zookeepers.ShowAllZookeepers(sqlConnection, dataGridViewZoo);

        }

        private void buttonFindAge_Click(object sender, EventArgs e)
        {
            Sloths.AgeBeetween(sqlConnection, dataGridViewZoo, textBoxAgeLeft.Text, textBoxAgeRight.Text);
        }

        private void buttonOneMoreAnimal_Click(object sender, EventArgs e)
        {
            Animals.AddMore(sqlConnection, dataGridViewZoo, comboBoxSpecies.Text, textBoxNumberOfNewAnimals.Text);
        }

        private void textBoxFindSloths_TextChanged(object sender, EventArgs e)
        {
            Sloths.FindByName(sqlConnection, dataGridViewZoo, textBoxFindSloths.Text);
        }

        private void buttonRemoveZookeeper_Click(object sender, EventArgs e)
        {
            Zookeepers.RemoveZookeeper(sqlConnection, dataGridViewZoo, textBoxZookeeperName.Text, textBoxZookeeperSurname.Text);
        }
    }
}
