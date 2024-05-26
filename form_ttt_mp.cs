using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minigame_Launcher
{
    public partial class form_ttt_mp : Form
    {
        // створення змінних та встановлення дефолтних значень для них
        int wplayer_turn = 1, // змінна вказуюча на те чий ход. По дефолту стоїть перший грок бо він починає гру (1 - перший грок, 2 - другий грок)
            xowins = 0, // змінна вказуюча чи перемог будь який з ігроків
            xo1 = 0, xo2 = 0, xo3 = 0, xo4 = 0, xo5 = 0, xo6 = 0, xo7 = 0, xo8 = 0, xo9 = 0; // змінні які кожна відносяться до основних кнопок керування грою з 1 до 9
        // створення шляху до фото що використовуються у программі, шлях встановлюється від поточного .ехе файлу
        string pathtocross = Path.GetFullPath("..\\..\\..\\pictures for project\\cross.png");
        string pathtocircle = Path.GetFullPath("..\\..\\..\\pictures for project\\circle.png");

        public form_ttt_mp()
        {
            InitializeComponent();
        }
        // метод для управління програмою з кнопок клавіатури
        private void form_ttt_mp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad7) { but_xo1.PerformClick(); }
            else if (e.KeyCode == Keys.NumPad8) { but_xo2.PerformClick(); }
            else if (e.KeyCode == Keys.NumPad9) { but_xo3.PerformClick(); }
            else if (e.KeyCode == Keys.NumPad4) { but_xo4.PerformClick(); }
            else if (e.KeyCode == Keys.NumPad5) { but_xo5.PerformClick(); }
            else if (e.KeyCode == Keys.NumPad6) { but_xo6.PerformClick(); }
            else if (e.KeyCode == Keys.NumPad1) { but_xo7.PerformClick(); }
            else if (e.KeyCode == Keys.NumPad2) { but_xo8.PerformClick(); }
            else if (e.KeyCode == Keys.NumPad3) { but_xo9.PerformClick(); }
            else if (e.KeyCode == Keys.NumPad0) { but_restart.PerformClick(); }
            else if (e.KeyCode == Keys.Escape) { but_back.PerformClick(); }
        }
        // метод кнопки "back" для повернення на минулу форму
        private void but_back_Click(object sender, EventArgs e)
        {
            form_ttt form_Ttt = new form_ttt(); // створюємо функцію минулох форми
            form_Ttt.Show(); // відображає минулу форму
            this.Close(); // закриває поточну форму
        }
        // ПРИМІТКА:
        // усі методи кнопок типу "but_xo(1-9)_Click" є однотипні та мають відмінності тільки у змінних xo(1-9),
        // де змінена лише цифра відносно кожної кнопки, тому коментарії тільки для методу but_xo1_Click.
        // 
        // метод одної з основних кнопок керування грою
        private void but_xo1_Click(object sender, EventArgs e)
        {
            if (xowins == 0) // якщо змінна перемог = 0, то кнопка діє
            {
                if (wplayer_turn == 1) // перевірка на те ход якого ігрока на данний час
                {
                    if (xo1 == 2)
                    { } // якщо змінна вказуюча на стан кнопки = 2 чи 1 то нічого не виконується
                    else if (xo1 == 1)
                    { }
                    else if (xo1 == 0) // якщо змінна вказуюча на стан кнопки = 0, товстановлюємо кнопці картинку "Х" якщо ход першого ігрока та "О" якщо ход другого ігрока
                    {
                        but_xo1.Image = Image.FromFile(pathtocross);
                        wplayer_turn = 2; // передаємо ход наступному іграку
                        xo1 = 1; // займаємо кнопу картинкою Х
                    }
                    label_context.Text = "O Try"; // змінюємо надпис контекстнох строки, кажучи що ход грака О(другий ігрок)
                }
                else if (wplayer_turn == 2) // перевірка на те ход якого ігрока на данний час
                {
                    if (xo1 == 1)
                    { } // якщо змінна вказуюча на стан кнопки = 2 чи 1 то нічого не виконується
                    else if (xo1 == 2)
                    { }
                    else if (xo1 == 0) // якщо змінна вказуюча на стан кнопки = 0, товстановлюємо кнопці картинку "Х" якщо ход першого ігрока та "О" якщо ход другого ігрока
                    {
                        but_xo1.Image = Image.FromFile(pathtocircle);
                        wplayer_turn = 1; // передаємо ход наступному іграку
                        xo1 = 2; // займаємо кнопу картинкою О
                    }
                    label_context.Text = "X Try"; // змінюємо надпис контекстнох строки, кажучи що ход грака Х(перший ігрок)
                }
                wincheck();
            } // якщо змінна перемог не = 0, то код не виконується та гра стоїть на місті до натискання кнопки рестарту
        }

        private void but_xo2_Click(object sender, EventArgs e)
        {
            if (xowins == 0)
            {
                if (wplayer_turn == 1)
                {
                    if (xo2 == 2)
                    { }
                    else if (xo2 == 1)
                    { }
                    else if (xo2 == 0)
                    {
                        but_xo2.Image = Image.FromFile(pathtocross);
                        wplayer_turn = 2;
                        xo2 = 1;
                    }
                    label_context.Text = "O Try";
                }
                else if (wplayer_turn == 2)
                {
                    if (xo2 == 1)
                    { }
                    else if (xo2 == 2)
                    { }
                    else if (xo2 == 0)
                    {
                        but_xo2.Image = Image.FromFile(pathtocircle);
                        wplayer_turn = 1;
                        xo2 = 2;
                    }
                    label_context.Text = "X Try";
                }
                wincheck();
            }
        }

        private void but_xo3_Click(object sender, EventArgs e)
        {
            if (xowins == 0)
            {
                if (wplayer_turn == 1)
                {
                    if (xo3 == 2)
                    { }
                    else if (xo3 == 1)
                    { }
                    else if (xo3 == 0)
                    {
                        but_xo3.Image = Image.FromFile(pathtocross);
                        wplayer_turn = 2;
                        xo3 = 1;
                    }
                    label_context.Text = "O Try";
                }
                else if (wplayer_turn == 2)
                {
                    if (xo3 == 1)
                    { }
                    else if (xo3 == 2)
                    { }
                    else if (xo3 == 0)
                    {
                        but_xo3.Image = Image.FromFile(pathtocircle);
                        wplayer_turn = 1;
                        xo3 = 2;
                    }
                    label_context.Text = "X Try";
                }
                wincheck();
            }
        }

        private void but_xo4_Click(object sender, EventArgs e)
        {
            if (xowins == 0)
            {
                if (wplayer_turn == 1)
                {
                    if (xo4 == 2)
                    { }
                    else if (xo4 == 1)
                    { }
                    else if (xo4 == 0)
                    {
                        but_xo4.Image = Image.FromFile(pathtocross);
                        wplayer_turn = 2;
                        xo4 = 1;
                    }
                    label_context.Text = "O Try";
                }
                else if (wplayer_turn == 2)
                {
                    if (xo4 == 1)
                    { }
                    else if (xo4 == 2)
                    { }
                    else if (xo4 == 0)
                    {
                        but_xo4.Image = Image.FromFile(pathtocircle);
                        wplayer_turn = 1;
                        xo4 = 2;
                    }
                    label_context.Text = "X Try";
                }
                wincheck();
            }
        }

        private void but_xo5_Click(object sender, EventArgs e)
        {
            if (xowins == 0)
            {
                if (wplayer_turn == 1)
                {
                    if (xo5 == 2)
                    { }
                    else if (xo5 == 1)
                    { }
                    else if (xo5 == 0)
                    {
                        but_xo5.Image = Image.FromFile(pathtocross);
                        wplayer_turn = 2;
                        xo5 = 1;
                    }
                    label_context.Text = "O Try";
                }
                else if (wplayer_turn == 2)
                {
                    if (xo5 == 1)
                    { }
                    else if (xo5 == 2)
                    { }
                    else if (xo5 == 0)
                    {
                        but_xo5.Image = Image.FromFile(pathtocircle);
                        wplayer_turn = 1;
                        xo5 = 2;
                    }
                    label_context.Text = "X Try";
                }
                wincheck();
            }
        }

        private void but_xo6_Click(object sender, EventArgs e)
        {
            if (xowins == 0)
            {
                if (wplayer_turn == 1)
                {
                    if (xo6 == 2)
                    { }
                    else if (xo6 == 1)
                    { }
                    else if (xo6 == 0)
                    {
                        but_xo6.Image = Image.FromFile(pathtocross);
                        wplayer_turn = 2;
                        xo6 = 1;
                    }
                    label_context.Text = "O Try";
                }
                else if (wplayer_turn == 2)
                {
                    if (xo6 == 1)
                    { }
                    else if (xo6 == 2)
                    { }
                    else if (xo6 == 0)
                    {
                        but_xo6.Image = Image.FromFile(pathtocircle);
                        wplayer_turn = 1;
                        xo6 = 2;
                    }
                    label_context.Text = "X Try";
                }
                wincheck();
            }
        }

        private void but_xo7_Click(object sender, EventArgs e)
        {
            if (xowins == 0)
            {
                if (wplayer_turn == 1)
                {
                    if (xo7 == 2)
                    { }
                    else if (xo7 == 1)
                    { }
                    else if (xo7 == 0)
                    {
                        but_xo7.Image = Image.FromFile(pathtocross);
                        wplayer_turn = 2;
                        xo7 = 1;
                    }
                    label_context.Text = "O Try";
                }
                else if (wplayer_turn == 2)
                {
                    if (xo7 == 1)
                    { }
                    else if (xo7 == 2)
                    { }
                    else if (xo7 == 0)
                    {
                        but_xo7.Image = Image.FromFile(pathtocircle);
                        wplayer_turn = 1;
                        xo7 = 2;
                    }
                    label_context.Text = "X Try";
                }
                wincheck();
            }
        }

        private void but_xo8_Click(object sender, EventArgs e)
        {
            if (xowins == 0)
            {
                if (wplayer_turn == 1)
                {
                    if (xo8 == 2)
                    { }
                    else if (xo8 == 1)
                    { }
                    else if (xo8 == 0)
                    {
                        but_xo8.Image = Image.FromFile(pathtocross);
                        wplayer_turn = 2;
                        xo8 = 1;
                    }
                    label_context.Text = "O Try";
                }
                else if (wplayer_turn == 2)
                {
                    if (xo8 == 1)
                    { }
                    else if (xo8 == 2)
                    { }
                    else if (xo8 == 0)
                    {
                        but_xo8.Image = Image.FromFile(pathtocircle);
                        wplayer_turn = 1;
                        xo8 = 2;
                    }
                    label_context.Text = "X Try";
                }
                wincheck();
            }
        }

        private void but_xo9_Click(object sender, EventArgs e)
        {
            if (xowins == 0)
            {
                if (wplayer_turn == 1)
                {
                    if (xo9 == 2)
                    { }
                    else if (xo9 == 1)
                    { }
                    else if (xo9 == 0)
                    {
                        but_xo9.Image = Image.FromFile(pathtocross);
                        wplayer_turn = 2;
                        xo9 = 1;
                    }
                    label_context.Text = "O Try";
                }
                else if (wplayer_turn == 2)
                {
                    if (xo9 == 1)
                    { }
                    else if (xo9 == 2)
                    { }
                    else if (xo9 == 0)
                    {
                        but_xo9.Image = Image.FromFile(pathtocircle);
                        wplayer_turn = 1;
                        xo9 = 2;
                    }
                    label_context.Text = "X Try";
                }
                wincheck();
            }
        }
        // класс кнопки рестарту раунду
        private void but_restart_Click(object sender, EventArgs e)
        {
            // якщо не маж переможця программа скидуэ усы параметри до дефолтних та виводить напис до конектсної строки
            if (xowins == 0)
            { label_context.Text = "X Try"; } // напис для виводу
            wplayer_turn = 1;
            xowins = 0;
            xo1 = 0; xo2 = 0; xo3 = 0; xo4 = 0; xo5 = 0; xo6 = 0; xo7 = 0; xo8 = 0; xo9 = 0;
            but_xo1.Image = null; but_xo2.Image = null; but_xo3.Image = null; but_xo4.Image = null;
            but_xo5.Image = null; but_xo6.Image = null; but_xo7.Image = null; but_xo8.Image = null;
            but_xo9.Image = null;
        }
        // метод для перевірки вийгрошу гравців
        public void wincheck()
        {
            if ((xo1 == 1 && xo2 == 1 && xo3 == 1) ||
                (xo4 == 1 && xo5 == 1 && xo6 == 1) ||  // перебераємо усі переможні комбінації
                (xo7 == 1 && xo8 == 1 && xo9 == 1) ||  // та вписуємо що перемог ігрок Х(перший ігрок)
                (xo1 == 1 && xo4 == 1 && xo7 == 1) ||
                (xo2 == 1 && xo5 == 1 && xo8 == 1) ||
                (xo3 == 1 && xo6 == 1 && xo9 == 1) ||
                (xo1 == 1 && xo5 == 1 && xo9 == 1) ||
                (xo3 == 1 && xo5 == 1 && xo7 == 1))
            {
                label_context.Text = "X wins";
                xowins = 1; // ставимо у змінну перемог що один з ігроків переміг та який саме (перший ігрок)
            }
            else if ((xo1 == 2 && xo2 == 2 && xo3 == 2) ||
                     (xo4 == 2 && xo5 == 2 && xo6 == 2) ||  // перебераємо усі переможні комбінації
                     (xo7 == 2 && xo8 == 2 && xo9 == 2) ||  // та вписуємо що перемог ігрок О(другий ігрок)
                     (xo7 == 2 && xo8 == 2 && xo9 == 2) ||
                     (xo1 == 2 && xo4 == 2 && xo7 == 2) ||
                     (xo2 == 2 && xo5 == 2 && xo8 == 2) ||
                     (xo3 == 2 && xo6 == 2 && xo9 == 2) ||
                     (xo1 == 2 && xo5 == 2 && xo9 == 2) ||
                     (xo3 == 2 && xo5 == 2 && xo7 == 2))
            {
                label_context.Text = "O Wins";
                xowins = 2; // ставимо у змінну перемог що один з ігроків переміг та який саме (другий ігрок)
            }
            else if (xo1 != 0 && xo2 != 0 && xo3 != 0 && xo4 != 0 && xo5 != 0 && xo6 != 0 && xo7 != 0 && xo8 != 0 && xo9 != 0 && xowins == 0)
            { // якщо ніхто не перемог та усі кнопки займані будь-яким іграком пишемо про нічию у контекстну строку
                label_context.Text = "Draw!";
            }
        }
    }
}