using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BartoszRodziewiczLab1
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Przycisk obsługujący logowanie.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "test" && textBoxLogin.Text == "test") //poprawne dane logowania
            {
                FormLogged formLogged = new FormLogged(textBoxLogin.Text);
                formLogged.Show();
                textBoxLogin.BackColor = Color.White;
                textBoxPassword.BackColor = Color.White;
                textBoxLogin.ForeColor = Color.Black;
                textBoxPassword.ForeColor = Color.Black;
            }
            else //niepoprawne dane logowania
            {
                textBoxLogin.BackColor = Color.Red;
                textBoxPassword.BackColor = Color.Red;
                textBoxLogin.ForeColor = Color.White;
                textBoxPassword.ForeColor = Color.White;
                textBoxLogin.Text = "";
                textBoxPassword.Text = "";
            }
        }
    }
}
