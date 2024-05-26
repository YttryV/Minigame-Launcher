using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minigame_Launcher
{
    public partial class form_rps : Form
    {
        public form_rps()
        {
            InitializeComponent();
        }
        // метод для управління програмою з кнопок клавіатури
        private void form_rps_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { but_back.PerformClick(); }
            else if (e.KeyCode == Keys.NumPad1) { but_start_sp.PerformClick(); }
            else if (e.KeyCode == Keys.NumPad3) { but_start_mp.PerformClick(); }
        }
        // метод кнопки перехід до форми режиму "Ігрок проти комп'ютера"
        private void but_start_sp_Click(object sender, EventArgs e)
        {
            form_rps_sp form_Rps_Sp = new form_rps_sp(); // створюємо функцію форми режиму "Ігрок проти комп'ютера"
            form_Rps_Sp.Show(); // відображаємо форму режиму "Ігрок проти комп'ютера"
            this.Hide(); // скриваємо поточну форму
        }
        // метод кнопки перехід до форми режиму "Ігрок проти ігрока"
        private void but_start_mp_Click(object sender, EventArgs e)
        {
            form_rps_mp form_Rps_Mp = new form_rps_mp(); // створюємо функцію форми режиму "Ігрок проти ігрока"
            form_Rps_Mp.Show(); // відображаємо форму режиму "Ігрок проти ігрока"
            this.Hide(); // скриваємо поточну форму
        }
        // метод кнопки повернення до минулої форми
        private void but_back_Click(object sender, EventArgs e)
        {
            form_start form_Start = new form_start(); // створюємо функцію минулих форми
            form_Start.Show(); // відображає минулу форму
            this.Close(); // закриває поточну форму
        }
    }
}