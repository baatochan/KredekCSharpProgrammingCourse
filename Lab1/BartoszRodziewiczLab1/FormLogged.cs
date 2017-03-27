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
    public partial class FormLogged : Form
    {
        public FormLogged()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Przeciążony konstruktor pozwalający na utroworzenie okna z własnym tytułem
        /// </summary>
        /// <param name="windowTitle">Tytuł do ustawienia dla okna</param>
        public FormLogged(String windowTitle)
        {
            InitializeComponent();
            Text = windowTitle;
        }
        /// <summary>
        /// Funkcja do wykonania co sekundę pracy timera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerWindowTimeRunning_Tick(object sender, EventArgs e)
        {
            if(_isTimerActive)
            {
                _timeRunning++;
                labelTimerSeconds.Text = _timeRunning.ToString();
            }
        }
        /// <summary>
        /// Funkcja wywoływana po zmianie zaznaczenia checkboxa wyłączająca/włączająca licznik timera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxIsTimerActive_CheckedChanged(object sender, EventArgs e)
        {
            if (_isTimerActive) _isTimerActive = false;
            else _isTimerActive = true;
        }
        /// <summary>
        /// Kliknięcie przycisku powoduje wypełnienie paska
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFillBar_Click(object sender, EventArgs e)
        {
            progressBar.PerformStep();
        }
        /// <summary>
        /// Czas pracy timera
        /// </summary>
        private int _timeRunning = 0;
        /// <summary>
        /// Status timera
        /// </summary>
        private bool _isTimerActive = true;
        /// <summary>
        /// Przycisk wypełniający datagrid'a
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFillDataGridRow_Click(object sender, EventArgs e)
        {
            int temp = 0; //zmienna z kolejnymi liczbami do wypełnienia datagrida
            for (int i = 0; i < 5; i++)
            {
                dataGridView.Rows.Add(temp++, temp++);
            }
        }
    }
}
