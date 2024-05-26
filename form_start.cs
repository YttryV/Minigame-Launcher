namespace Minigame_Launcher
{
    public partial class form_start : Form
    {
        public form_start()
        {
            InitializeComponent();
        }
        // метод для управління програмою з кнопок клавіатури
        private void form_start_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { but_exit.PerformClick(); }
            else if (e.KeyCode == Keys.NumPad1) { but_rps_start.PerformClick(); }
            else if (e.KeyCode == Keys.NumPad3) { but_ttt_start.PerformClick(); }
        }
        // метод кнопки переходу до форми Камень-Ножиці-Бумага
        private void but_rps_start_Click(object sender, EventArgs e)
        {
            form_rps form_Rps = new form_rps(); // створюємо функцію форми Камень-Ножиці-Бумага
            form_Rps.Show(); // відображаємо форму Камень-Ножиці-Бумага
            this.Hide(); // скриваємо поточну форму
        }
        // метод кнопки переходу до форми Хрестики-Нольіки
        private void but_ttt_start_Click(object sender, EventArgs e)
        {
            form_ttt form_ttt = new form_ttt(); // створюємо функцію форми Хрестики-Нольіки
            form_ttt.Show(); // відображаємо форму Хрестики-Нольіки
            this.Hide(); // скриваємо поточну форму
        }
        // метод кнопки закриття програми
        private void but_exit_Click(object sender, EventArgs e)
        {
            Application.ExitThread(); // клас Application та його метод ExitThread закриває усі дочерні форми та поточну
        }
    }
}