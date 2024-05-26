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
    public partial class form_ttt_sp  : Form
    {
        int whatPlayerChoice = -1, // 0 = O, 1 = X; змінна яка зберігає значення того що саме обрав ігрок Х чи О
            playerChoiceXOrO = 0, // змінна яка зберігає значення того чи обрав ігрок Х чи О
            botDifficult = 0, // змінна яка зберігає складність інтелекту комп'ютера
            isAnyoneWin = 0, // змінна вказуюча чи перемог будь який з ігроків
            xox = 0, // допоміжна змінна для інтелекту комп'ютера
            xo1 = 0, xo2 = 0, xo3 = 0, xo4 = 0, xo5 = 0, xo6 = 0, xo7 = 0, xo8 = 0, xo9 = 0; // змінні які кожна відносяться до основних кнопок керування грою з 1 до 9
        // створення шляху до фото що використовуються у программі, шлях встановлюється від поточного .ехе файлу
        string pathtocross = Path.GetFullPath("..\\..\\..\\pictures for project\\cross.png");
        string pathtocircle = Path.GetFullPath("..\\..\\..\\pictures for project\\circle.png");

        public form_ttt_sp()
        {
            InitializeComponent();
        }
        // метод для управління програмою з кнопок клавіатури
        private void form_ttt_sp_KeyDown(object sender, KeyEventArgs e)
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
            else if (e.KeyCode == Keys.Add) { but_difficulty.PerformClick(); }
        }
        // метод кнопки повернення до минулої форми
        private void but_back_Click(object sender, EventArgs e)
        {
            form_ttt form_Ttt = new form_ttt(); // створюємо функцію минулох форми
            form_Ttt.Show(); // відображає минулу форму
            this.Close(); // закриває поточну форму
        }
        // метод кнопки налаштування складності інтелекту комп'ютера
        private void but_difficulty_Click(object sender, EventArgs e)
        {
            if (botDifficult == 0)
            {
                label_context.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
                label_context.Text = "Medium Difficult";
                botDifficult = 1;
            }
            else if (botDifficult == 1)
            {
                label_context.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
                label_context.Text = "Hard Difficult";
                botDifficult = 2;
            }
            else if (botDifficult == 2)
            {
                label_context.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
                label_context.Text = "Easy Difficult";
                botDifficult = 0;
            }
        }
        // ПРИМІТКА:
        // усі методи кнопок типу "but_xo(1-9)_Click"(окрім but_xo(4 та 6)_Click, але там не значні зміни які указані у самих методах)
        // є однотипні та мають відмінності тільки у змінних xo(1-9), де змінена лише цифра відносно кожної кнопки, тому коментарії
        // тільки для методів but_xo1_Click і частково до but_xo4_Click та but_xo6_Click.
        // 
        // метод одної з основних кнопок керування грою
        private void but_xo1_Click(object sender, EventArgs e)
        {
            if (playerChoiceXOrO == 0) // не продовжуємо код якщо ігрок не обрав Х чи О
            { }
            else if (playerChoiceXOrO == 1) // якщо ігрок обрав сторону продовжуємо код
            {
                if (xo1 == 1 || xo1 == 2)
                { } // якщо кнопка зайнята не виконуємо код, зроблено для уникнення ходу комп'ютера навіть якщо ігрок не поставив свій знак
                else if (xo1 == 0)
                { // якщо кнопка не зайнята продовжуємо
                    if (whatPlayerChoice == 1) // якщо ігрок обрав Х
                    {
                        if (isAnyoneWin == 0) // якщо змінна перемог = 0, то кнопка діє
                        {
                            if (botDifficult == 0) // якщо ігрок обрав складність комп'ютера "easy"
                            {
                                if (xo1 == 2) // якщо комірка зайнята О не займаємо її
                                { }
                                else if (xo1 == 1) // якщо комірка зайнята Х не займаємо її
                                { }
                                else if (xo1 == 0) // якщо комірка не зайнята займаємо її та передаємо ход
                                {
                                    but_xo1.Image = Image.FromFile(pathtocross); // візуалізуємо для користовача займання комірки
                                    xo1 = 1; // займаємо комірку
                                }
                                easy_bot_intellect_o(); // метод інтелекту рівня легко
                            } // далі пеевірка йде на теж саме але змінена важкість змінена
                            else if (botDifficult == 1)
                            {
                                if (xo1 == 2)
                                { }
                                else if (xo1 == 1)
                                { }
                                else if (xo1 == 0)
                                {
                                    but_xo1.Image = Image.FromFile(pathtocross);
                                    xo1 = 1;
                                }
                                medium_bot_intellect_o(); // метод інтелекту рівня середньо
                            }
                            else if (botDifficult == 2)
                            {
                                if (xo1 == 2)
                                { }
                                else if (xo1 == 1)
                                { }
                                else if (xo1 == 0)
                                {
                                    but_xo1.Image = Image.FromFile(pathtocross);
                                    xo1 = 1;
                                }
                                hard_bot_intellect_o(); // метод інтелекту рівня важко
                            }
                            winCheck();
                        } // якщо змінна перемог не = 0, то код не виконується та гра стоїть на місті до натискання кнопки рестарту
                    } // якщо ігрок обрав О
                    else if (whatPlayerChoice == 0) // усе від цієї строки до кінця методу є майже повністю однаковим з минулою частиною методу,
                                                   // але якщо грок обрав грати за О, тому опис буде мінімальним
                    {
                        if (isAnyoneWin == 0)
                        {
                            if (botDifficult == 0)
                            {
                                if (xo1 == 2)
                                { }
                                else if (xo1 == 1)
                                { }
                                else if (xo1 == 0)
                                {
                                    but_xo1.Image = Image.FromFile(pathtocircle);
                                    xo1 = 2;
                                }
                                easy_bot_intellect_x();
                            }
                            else if (botDifficult == 1)
                            {
                                if (xo1 == 2)
                                { }
                                else if (xo1 == 1)
                                { }
                                else if (xo1 == 0)
                                {
                                    but_xo1.Image = Image.FromFile(pathtocircle);
                                    xo1 = 2;
                                }
                                medium_bot_intellect_x();
                            }
                            else if (botDifficult == 2)
                            {
                                if (xo1 == 2)
                                { }
                                else if (xo1 == 1)
                                { }
                                else if (xo1 == 0)
                                {
                                    but_xo1.Image = Image.FromFile(pathtocircle);
                                    xo1 = 2;
                                }
                                hard_bot_intellect_x();
                            }
                            winCheck();
                        }
                    }
                }
            }
        }

        private void but_xo2_Click(object sender, EventArgs e)
        {
            if (playerChoiceXOrO == 0)
            { }
            else if (playerChoiceXOrO == 1)
            {
                if (xo2 == 1 || xo2 == 2)
                { }
                else if (xo2 == 0)
                {
                    if (whatPlayerChoice == 1)
                    {
                        if (isAnyoneWin == 0)
                        {
                            if (botDifficult == 0)
                            {
                                if (xo2 == 2)
                                { }
                                else if (xo2 == 1)
                                { }
                                else if (xo2 == 0)
                                {
                                    but_xo2.Image = Image.FromFile(pathtocross);
                                    xo2 = 1;
                                }
                                easy_bot_intellect_o();
                            }
                            else if (botDifficult == 1)
                            {
                                if (xo2 == 2)
                                { }
                                else if (xo2 == 1)
                                { }
                                else if (xo2 == 0)
                                {
                                    but_xo2.Image = Image.FromFile(pathtocross);
                                    xo2 = 1;
                                }
                                medium_bot_intellect_o();
                            }
                            else if (botDifficult == 2)
                            {
                                if (xo2 == 2)
                                { }
                                else if (xo2 == 1)
                                { }
                                else if (xo2 == 0)
                                {
                                    but_xo2.Image = Image.FromFile(pathtocross);
                                    xo2 = 1;
                                }
                                hard_bot_intellect_o();
                            }
                            winCheck();
                        }
                    }
                    else if (whatPlayerChoice == 0)
                    {
                        if (isAnyoneWin == 0)
                        {
                            if (botDifficult == 0)
                            {
                                if (xo2 == 2)
                                { }
                                else if (xo2 == 1)
                                { }
                                else if (xo2 == 0)
                                {
                                    but_xo2.Image = Image.FromFile(pathtocircle);
                                    xo2 = 2;
                                }
                                easy_bot_intellect_x();
                            }
                            else if (botDifficult == 1)
                            {
                                if (xo2 == 2)
                                { }
                                else if (xo2 == 1)
                                { }
                                else if (xo2 == 0)
                                {
                                    but_xo2.Image = Image.FromFile(pathtocircle);
                                    xo2 = 2;
                                }
                                medium_bot_intellect_x();
                            }
                            else if (botDifficult == 2)
                            {
                                if (xo2 == 2)
                                { }
                                else if (xo2 == 1)
                                { }
                                else if (xo2 == 0)
                                {
                                    but_xo2.Image = Image.FromFile(pathtocircle);
                                    xo2 = 2;
                                }
                                hard_bot_intellect_x();
                            }
                            winCheck();
                        }
                    }
                }
            }
        }

        private void but_xo3_Click(object sender, EventArgs e)
        {
            if (playerChoiceXOrO == 0)
            { }
            else if (playerChoiceXOrO == 1)
            {
                if (xo3 == 1 || xo3 == 2)
                { }
                else if (xo3 == 0)
                {
                    if (whatPlayerChoice == 1)
                    {
                        if (isAnyoneWin == 0)
                        {
                            if (botDifficult == 0)
                            {
                                if (xo3 == 2)
                                { }
                                else if (xo3 == 1)
                                { }
                                else if (xo3 == 0)
                                {
                                    but_xo3.Image = Image.FromFile(pathtocross);
                                    xo3 = 1;
                                }
                                easy_bot_intellect_o();
                            }
                            else if (botDifficult == 1)
                            {
                                if (xo3 == 2)
                                { }
                                else if (xo3 == 1)
                                { }
                                else if (xo3 == 0)
                                {
                                    but_xo3.Image = Image.FromFile(pathtocross);
                                    xo3 = 1;
                                }
                                medium_bot_intellect_o();
                            }
                            else if (botDifficult == 2)
                            {
                                if (xo3 == 2)
                                { }
                                else if (xo3 == 1)
                                { }
                                else if (xo3 == 0)
                                {
                                    but_xo3.Image = Image.FromFile(pathtocross);
                                    xo3 = 1;
                                }
                                hard_bot_intellect_o();
                            }
                            winCheck();
                        }
                    }
                    else if (whatPlayerChoice == 0)
                    {
                        if (isAnyoneWin == 0)
                        {
                            if (botDifficult == 0)
                            {
                                if (xo3 == 2)
                                { }
                                else if (xo3 == 1)
                                { }
                                else if (xo3 == 0)
                                {
                                    but_xo3.Image = Image.FromFile(pathtocircle);
                                    xo3 = 2;
                                }
                                easy_bot_intellect_x();
                            }
                            else if (botDifficult == 1)
                            {
                                if (xo3 == 2)
                                { }
                                else if (xo3 == 1)
                                { }
                                else if (xo3 == 0)
                                {
                                    but_xo3.Image = Image.FromFile(pathtocircle);
                                    xo3 = 2;
                                }
                                medium_bot_intellect_x();
                            }
                            else if (botDifficult == 2)
                            {
                                if (xo3 == 2)
                                { }
                                else if (xo3 == 1)
                                { }
                                else if (xo3 == 0)
                                {
                                    but_xo3.Image = Image.FromFile(pathtocircle);
                                    xo3 = 2;
                                }
                                hard_bot_intellect_x();
                            }
                            winCheck();
                        }
                    }
                }
            }
        }

        private void but_xo4_Click(object sender, EventArgs e)
        {
            if (playerChoiceXOrO == 0)
            {
                but_xo1.Text = null; but_xo2.Text = null; but_xo3.Text = null;
                but_xo4.Image = null; but_xo5.Text = null; but_xo6.Image = null;
                but_xo7.Text = null; but_xo8.Text = null; but_xo9.Text = null;
                whatPlayerChoice = 1;
                playerChoiceXOrO = 1;
            }
            else if (playerChoiceXOrO == 1)
            {

                if (xo4 == 1 || xo4 == 2)
                { }
                else if (xo4 == 0)
                {
                    if (whatPlayerChoice == 1)
                    {
                        if (isAnyoneWin == 0)
                        {
                            if (botDifficult == 0)
                            {
                                if (xo4 == 2)
                                { }
                                else if (xo4 == 1)
                                { }
                                else if (xo4 == 0)
                                {
                                    but_xo4.Image = Image.FromFile(pathtocross);
                                    xo4 = 1;
                                }
                                easy_bot_intellect_o();
                            }
                            else if (botDifficult == 1)
                            {
                                if (xo4 == 2)
                                { }
                                else if (xo4 == 1)
                                { }
                                else if (xo4 == 0)
                                {
                                    but_xo4.Image = Image.FromFile(pathtocross);
                                    xo4 = 1;
                                }
                                medium_bot_intellect_o();
                            }
                            else if (botDifficult == 2)
                            {
                                if (xo4 == 2)
                                { }
                                else if (xo4 == 1)
                                { }
                                else if (xo4 == 0)
                                {
                                    but_xo4.Image = Image.FromFile(pathtocross);
                                    xo4 = 1;
                                }
                                hard_bot_intellect_o();
                            }
                            winCheck();
                        }
                    }
                    else if (whatPlayerChoice == 0)
                    {
                        if (isAnyoneWin == 0)
                        {
                            if (botDifficult == 0)
                            {
                                if (xo4 == 2)
                                { }
                                else if (xo4 == 1)
                                { }
                                else if (xo4 == 0)
                                {
                                    but_xo4.Image = Image.FromFile(pathtocircle);
                                    xo4 = 2;
                                }
                                easy_bot_intellect_x();
                            }
                            else if (botDifficult == 1)
                            {
                                if (xo4 == 2)
                                { }
                                else if (xo4 == 1)
                                { }
                                else if (xo4 == 0)
                                {
                                    but_xo4.Image = Image.FromFile(pathtocircle);
                                    xo4 = 2;
                                }
                                medium_bot_intellect_x();
                            }
                            else if (botDifficult == 2)
                            {
                                if (xo4 == 2)
                                { }
                                else if (xo4 == 1)
                                { }
                                else if (xo4 == 0)
                                {
                                    but_xo4.Image = Image.FromFile(pathtocircle);
                                    xo4 = 2;
                                }
                                hard_bot_intellect_x();
                            }
                            winCheck();
                        }
                    }
                }
            }
        }

        private void but_xo5_Click(object sender, EventArgs e)
        {
            if (playerChoiceXOrO == 0)
            { }
            else if (playerChoiceXOrO == 1)
            {
                if (xo5 == 1 || xo5 == 2)
                { }
                else if (xo5 == 0)
                {
                    if (whatPlayerChoice == 1)
                    {
                        if (isAnyoneWin == 0)
                        {
                            if (botDifficult == 0)
                            {
                                if (xo5 == 2)
                                { }
                                else if (xo5 == 1)
                                { }
                                else if (xo5 == 0)
                                {
                                    but_xo5.Image = Image.FromFile(pathtocross);
                                    xo5 = 1;
                                }
                                easy_bot_intellect_o();
                            }
                            else if (botDifficult == 1)
                            {
                                if (xo5 == 2)
                                { }
                                else if (xo5 == 1)
                                { }
                                else if (xo5 == 0)
                                {
                                    but_xo5.Image = Image.FromFile(pathtocross);
                                    xo5 = 1;
                                }
                                medium_bot_intellect_o();
                            }
                            else if (botDifficult == 2)
                            {
                                if (xo5 == 2)
                                { }
                                else if (xo5 == 1)
                                { }
                                else if (xo5 == 0)
                                {
                                    but_xo5.Image = Image.FromFile(pathtocross);
                                    xo5 = 1;
                                }
                                hard_bot_intellect_o();
                            }
                            winCheck();
                        }
                    }
                    else if (whatPlayerChoice == 0)
                    {
                        if (isAnyoneWin == 0)
                        {
                            if (botDifficult == 0)
                            {
                                if (xo5 == 2)
                                { }
                                else if (xo5 == 1)
                                { }
                                else if (xo5 == 0)
                                {
                                    but_xo5.Image = Image.FromFile(pathtocircle);
                                    xo5 = 2;
                                }
                                easy_bot_intellect_x();
                            }
                            else if (botDifficult == 1)
                            {
                                if (xo5 == 2)
                                { }
                                else if (xo5 == 1)
                                { }
                                else if (xo5 == 0)
                                {
                                    but_xo5.Image = Image.FromFile(pathtocircle);
                                    xo5 = 2;
                                }
                                medium_bot_intellect_x();
                            }
                            else if (botDifficult == 2)
                            {
                                if (xo5 == 2)
                                { }
                                else if (xo5 == 1)
                                { }
                                else if (xo5 == 0)
                                {
                                    but_xo5.Image = Image.FromFile(pathtocircle);
                                    xo5 = 2;
                                }
                                hard_bot_intellect_x();
                            }
                            winCheck();
                        }
                    }
                }
            }
        }

        private void but_xo6_Click(object sender, EventArgs e)
        {
            if (playerChoiceXOrO == 0)
            {
                but_xo1.Text = null; but_xo2.Text = null; but_xo3.Text = null;
                but_xo4.Image = null; but_xo5.Text = null; but_xo6.Image = null;
                but_xo7.Text = null; but_xo8.Text = null; but_xo9.Text = null;
                whatPlayerChoice = 0;
                playerChoiceXOrO = 1;
                if (whatPlayerChoice == 0)
                { easy_bot_intellect_x(); }
            }
            else if (playerChoiceXOrO == 1)
            {
                if (xo6 == 1 || xo6 == 2)
                { }
                else if (xo6 == 0)
                {
                    if (whatPlayerChoice == 1)
                    {
                        if (isAnyoneWin == 0)
                        {
                            if (botDifficult == 0)
                            {
                                if (xo6 == 2)
                                { }
                                else if (xo6 == 1)
                                { }
                                else if (xo6 == 0)
                                {
                                    but_xo6.Image = Image.FromFile(pathtocross);
                                    xo6 = 1;
                                }
                                easy_bot_intellect_o();
                            }
                            else if (botDifficult == 1)
                            {
                                if (xo6 == 2)
                                { }
                                else if (xo6 == 1)
                                { }
                                else if (xo6 == 0)
                                {
                                    but_xo6.Image = Image.FromFile(pathtocross);
                                    xo6 = 1;
                                }
                                medium_bot_intellect_o();
                            }
                            else if (botDifficult == 2)
                            {
                                if (xo6 == 2)
                                { }
                                else if (xo6 == 1)
                                { }
                                else if (xo6 == 0)
                                {
                                    but_xo6.Image = Image.FromFile(pathtocross);
                                    xo6 = 1;
                                }
                                hard_bot_intellect_o();
                            }
                            winCheck();
                        }
                    }
                    else if (whatPlayerChoice == 0)
                    {
                        if (isAnyoneWin == 0)
                        {
                            if (botDifficult == 0)
                            {
                                if (xo6 == 2)
                                { }
                                else if (xo6 == 1)
                                { }
                                else if (xo6 == 0)
                                {
                                    but_xo6.Image = Image.FromFile(pathtocircle);
                                    xo6 = 2;
                                }
                                easy_bot_intellect_x();
                            }
                            else if (botDifficult == 1)
                            {
                                if (xo6 == 2)
                                { }
                                else if (xo6 == 1)
                                { }
                                else if (xo6 == 0)
                                {
                                    but_xo6.Image = Image.FromFile(pathtocircle);
                                    xo6 = 2;
                                }
                                medium_bot_intellect_x();
                            }
                            else if (botDifficult == 2)
                            {
                                if (xo6 == 2)
                                { }
                                else if (xo6 == 1)
                                { }
                                else if (xo6 == 0)
                                {
                                    but_xo6.Image = Image.FromFile(pathtocircle);
                                    xo6 = 2;
                                }
                                hard_bot_intellect_x();
                            }
                            winCheck();
                        }
                    }
                }
            }
        }

        private void but_xo7_Click(object sender, EventArgs e)
        {
            if (playerChoiceXOrO == 0)
            { }
            else if (playerChoiceXOrO == 1)
            {
                if (xo7 == 1 || xo7 == 2)
                { }
                else if (xo7 == 0)
                {
                    if (whatPlayerChoice == 1)
                    {
                        if (isAnyoneWin == 0)
                        {
                            if (botDifficult == 0)
                            {
                                if (xo7 == 2)
                                { }
                                else if (xo7 == 1)
                                { }
                                else if (xo7 == 0)
                                {
                                    but_xo7.Image = Image.FromFile(pathtocross);
                                    xo7 = 1;
                                }
                                easy_bot_intellect_o();
                            }
                            else if (botDifficult == 1)
                            {
                                if (xo7 == 2)
                                { }
                                else if (xo7 == 1)
                                { }
                                else if (xo7 == 0)
                                {
                                    but_xo7.Image = Image.FromFile(pathtocross);
                                    xo7 = 1;
                                }
                                medium_bot_intellect_o();
                            }
                            else if (botDifficult == 2)
                            {
                                if (xo7 == 2)
                                { }
                                else if (xo7 == 1)
                                { }
                                else if (xo7 == 0)
                                {
                                    but_xo7.Image = Image.FromFile(pathtocross);
                                    xo7 = 1;
                                }
                                hard_bot_intellect_o();
                            }
                            winCheck();
                        }
                    }
                    else if (whatPlayerChoice == 0)
                    {
                        if (isAnyoneWin == 0)
                        {
                            if (botDifficult == 0)
                            {
                                if (xo7 == 2)
                                { }
                                else if (xo7 == 1)
                                { }
                                else if (xo7 == 0)
                                {
                                    but_xo7.Image = Image.FromFile(pathtocircle);
                                    xo7 = 2;
                                }
                                easy_bot_intellect_x();
                            }
                            else if (botDifficult == 1)
                            {
                                if (xo7 == 2)
                                { }
                                else if (xo7 == 1)
                                { }
                                else if (xo7 == 0)
                                {
                                    but_xo7.Image = Image.FromFile(pathtocircle);
                                    xo7 = 2;
                                }
                                medium_bot_intellect_x();
                            }
                            else if (botDifficult == 2)
                            {
                                if (xo7 == 2)
                                { }
                                else if (xo7 == 1)
                                { }
                                else if (xo7 == 0)
                                {
                                    but_xo7.Image = Image.FromFile(pathtocircle);
                                    xo7 = 2;
                                }
                                hard_bot_intellect_x();
                            }
                            winCheck();
                        }
                    }
                }
            }
        }

        private void but_xo8_Click(object sender, EventArgs e)
        {
            if (playerChoiceXOrO == 0)
            { }
            else if (playerChoiceXOrO == 1)
            {
                if (xo8 == 1 || xo8 == 2)
                { }
                else if (xo8 == 0)
                {
                    if (whatPlayerChoice == 1)
                    {
                        if (isAnyoneWin == 0)
                        {
                            if (botDifficult == 0)
                            {
                                if (xo8 == 2)
                                { }
                                else if (xo8 == 1)
                                { }
                                else if (xo8 == 0)
                                {
                                    but_xo8.Image = Image.FromFile(pathtocross);
                                    xo8 = 1;
                                }
                                easy_bot_intellect_o();
                            }
                            else if (botDifficult == 1)
                            {
                                if (xo8 == 2)
                                { }
                                else if (xo8 == 1)
                                { }
                                else if (xo8 == 0)
                                {
                                    but_xo8.Image = Image.FromFile(pathtocross);
                                    xo8 = 1;
                                }
                                medium_bot_intellect_o();
                            }
                            else if (botDifficult == 2)
                            {
                                if (xo8 == 2)
                                { }
                                else if (xo8 == 1)
                                { }
                                else if (xo8 == 0)
                                {
                                    but_xo8.Image = Image.FromFile(pathtocross);
                                    xo8 = 1;
                                }
                                hard_bot_intellect_o();
                            }
                            winCheck();
                        }
                    }
                    else if (whatPlayerChoice == 0)
                    {
                        if (isAnyoneWin == 0)
                        {
                            if (botDifficult == 0)
                            {
                                if (xo8 == 2)
                                { }
                                else if (xo8 == 1)
                                { }
                                else if (xo8 == 0)
                                {
                                    but_xo8.Image = Image.FromFile(pathtocircle);
                                    xo8 = 2;
                                }
                                easy_bot_intellect_x();
                            }
                            else if (botDifficult == 1)
                            {
                                if (xo8 == 2)
                                { }
                                else if (xo8 == 1)
                                { }
                                else if (xo8 == 0)
                                {
                                    but_xo8.Image = Image.FromFile(pathtocircle);
                                    xo8 = 2;
                                }
                                medium_bot_intellect_x();
                            }
                            else if (botDifficult == 2)
                            {
                                if (xo8 == 2)
                                { }
                                else if (xo8 == 1)
                                { }
                                else if (xo8 == 0)
                                {
                                    but_xo8.Image = Image.FromFile(pathtocircle);
                                    xo8 = 2;
                                }
                                hard_bot_intellect_x();
                            }
                            winCheck();
                        }
                    }
                }
            }
        }

        private void but_xo9_Click(object sender, EventArgs e)
        {
            if (playerChoiceXOrO == 0)
            { }
            else if (playerChoiceXOrO == 1)
            {
                if (xo9 == 1 || xo9 == 2)
                { }
                else if (xo9 == 0)
                {
                    if (whatPlayerChoice == 1)
                    {
                        if (isAnyoneWin == 0)
                        {
                            if (botDifficult == 0)
                            {
                                if (xo9 == 2)
                                { }
                                else if (xo9 == 1)
                                { }
                                else if (xo9 == 0)
                                {
                                    but_xo9.Image = Image.FromFile(pathtocross);
                                    xo9 = 1;
                                }
                                easy_bot_intellect_o();
                            }
                            else if (botDifficult == 1)
                            {
                                if (xo9 == 2)
                                { }
                                else if (xo9 == 1)
                                { }
                                else if (xo9 == 0)
                                {
                                    but_xo9.Image = Image.FromFile(pathtocross);
                                    xo9 = 1;
                                }
                                medium_bot_intellect_o();
                            }
                            else if (botDifficult == 2)
                            {
                                if (xo9 == 2)
                                { }
                                else if (xo9 == 1)
                                { }
                                else if (xo9 == 0)
                                {
                                    but_xo9.Image = Image.FromFile(pathtocross);
                                    xo9 = 1;
                                }
                                hard_bot_intellect_o();
                            }
                            winCheck();
                        }
                    }
                    else if (whatPlayerChoice == 0)
                    {
                        if (isAnyoneWin == 0)
                        {
                            if (botDifficult == 0)
                            {
                                if (xo9 == 2)
                                { }
                                else if (xo9 == 1)
                                { }
                                else if (xo9 == 0)
                                {
                                    but_xo9.Image = Image.FromFile(pathtocircle);
                                    xo9 = 2;
                                }
                                easy_bot_intellect_x();
                            }
                            else if (botDifficult == 1)
                            {
                                if (xo9 == 2)
                                { }
                                else if (xo9 == 1)
                                { }
                                else if (xo9 == 0)
                                {
                                    but_xo9.Image = Image.FromFile(pathtocircle);
                                    xo9 = 2;
                                }
                                medium_bot_intellect_x();
                            }
                            else if (botDifficult == 2)
                            {
                                if (xo9 == 2)
                                { }
                                else if (xo9 == 1)
                                { }
                                else if (xo9 == 0)
                                {
                                    but_xo9.Image = Image.FromFile(pathtocircle);
                                    xo9 = 2;
                                }
                                hard_bot_intellect_x();
                            }
                            winCheck();
                        }
                    }
                }
            }
        }
        // метод кнопки рестарту гри
        private void but_restart_Click(object sender, EventArgs e)
        {
            // змінюємо усі змінні на дефолтні значення, та повертаємо усі кнопки(їх текст та зображення) до стартового стану
            whatPlayerChoice = -1;
            playerChoiceXOrO = 0;
            isAnyoneWin = 0;
            xox = 0;
            xo1 = 0; xo2 = 0; xo3 = 0; xo4 = 0; xo5 = 0; xo6 = 0; xo7 = 0; xo8 = 0; xo9 = 0;
            but_xo1.Image = null;
            but_xo1.Text = "Choice\r\n\\/";
            but_xo2.Image = null;
            but_xo2.Text = "Your\r\n\\/";
            but_xo3.Image = null;
            but_xo3.Text = "Site\r\n\\/";
            but_xo4.Image = Image.FromFile(pathtocross);
            but_xo5.Image = null;
            but_xo5.Text = "OR";
            but_xo6.Image = Image.FromFile(pathtocircle);
            but_xo7.Image = null;
            but_xo7.Text = "/\\\r\nChoice";
            but_xo8.Image = null;
            but_xo8.Text = "/\\\r\nYour";
            but_xo9.Image = null;
            but_xo9.Text = "/\\\r\nSite";
        }
        // метод рандомного вибору ігрока комп'ютера
        public int bot_choice(int a, int b)
        {
            Random r = new Random(); // створюємо змінну класу рандомних чисел
            return r.Next(a, b); // повертаємо значення методу як рандомний вибір числа від а до b
        }
        // метод інтелекту комп'ютера на легкій складності який грає за О
        public void easy_bot_intellect_o()
        {
            if ((xo1 == 1 && xo2 == 1 && xo3 == 1) ||
                (xo4 == 1 && xo5 == 1 && xo6 == 1) ||  // переліковуємо усі переможні патерни супротивника це потрібно для того щоб
                (xo7 == 1 && xo8 == 1 && xo9 == 1) ||  // при перемозі супротивника не робився ще один ход, естетичне та практичне рішення
                (xo1 == 1 && xo4 == 1 && xo7 == 1) ||  // коли комп'ютер грає за хрестики та ходить ход під час якого він перемогає, навіть
                (xo2 == 1 && xo5 == 1 && xo8 == 1) ||  // якщо ходом раніше перемогли ноліки перемога віддається хрестикам, сенсова помилка
                (xo3 == 1 && xo6 == 1 && xo9 == 1) ||
                (xo1 == 1 && xo5 == 1 && xo9 == 1) ||
                (xo3 == 1 && xo5 == 1 && xo7 == 1))
            {
                winCheck(); // присуджуємо перемогу тому хто переміг якщо такий є
            }
            else
            { // при ситуації коли комп'ютер ходить останній крок у сесії без перевірки усього поля на заповненість гра вилітає
                if ((xo1 == 1 || xo1 == 2) && (xo2 == 1 || xo2 == 2) && (xo3 == 1 || xo3 == 2) &&
                    (xo4 == 1 || xo4 == 2) && (xo5 == 1 || xo5 == 2) && (xo6 == 1 || xo6 == 2) &&
                    (xo7 == 1 || xo7 == 2) && (xo8 == 1 || xo8 == 2) && (xo9 == 1 || xo9 == 2))
                { }
                else
                { // поки не випаде вільна комірка цикл буде продовжувати шукати такову
                    while (xox == 0)
                    {
                        int bc = bot_choice(1, 10); // обираємо рандомне число від 1 до 10(не включно)
                        if (bc == 1)
                        {
                            if (xo1 == 1 || xo1 == 2)
                            { } // якщо кнопка зайнята не займаємо її
                            else if (xo1 == 0)
                            {
                                but_xo1.Image = Image.FromFile(pathtocircle); // візуалізуємо займаність комірки
                                xo1 = 2; // займаємо комірку
                                xox = 1; // зупиняємо цикл
                            }
                        } // наступна частина циклу ідентична для наступних 8 кнопок
                        else if (bc == 2)
                        {
                            if (xo2 == 1 || xo2 == 2)
                            { }
                            else if (xo2 == 0)
                            {
                                but_xo2.Image = Image.FromFile(pathtocircle);
                                xo2 = 2;
                                xox = 1;
                            }
                        }
                        else if (bc == 3)
                        {
                            if (xo3 == 1 || xo3 == 2)
                            { }
                            else if (xo3 == 0)
                            {
                                but_xo3.Image = Image.FromFile(pathtocircle);
                                xo3 = 2;
                                xox = 1;
                            }
                        }
                        else if (bc == 4)
                        {
                            if (xo4 == 1 || xo4 == 2)
                            { }
                            else if (xo4 == 0)
                            {
                                but_xo4.Image = Image.FromFile(pathtocircle);
                                xo4 = 2;
                                xox = 1;
                            }
                        }
                        else if (bc == 5)
                        {
                            if (xo5 == 1 || xo5 == 2)
                            { }
                            else if (xo5 == 0)
                            {
                                but_xo5.Image = Image.FromFile(pathtocircle);
                                xo5 = 2;
                                xox = 1;
                            }
                        }
                        else if (bc == 6)
                        {
                            if (xo6 == 1 || xo6 == 2)
                            { }
                            else if (xo6 == 0)
                            {
                                but_xo6.Image = Image.FromFile(pathtocircle);
                                xo6 = 2;
                                xox = 1;
                            }
                        }
                        else if (bc == 7)
                        {
                            if (xo7 == 1 || xo7 == 2)
                            { }
                            else if (xo7 == 0)
                            {
                                but_xo7.Image = Image.FromFile(pathtocircle);
                                xo7 = 2;
                                xox = 1;
                            }
                        }
                        else if (bc == 8)
                        {
                            if (xo8 == 1 || xo8 == 2)
                            { }
                            else if (xo8 == 0)
                            {
                                but_xo8.Image = Image.FromFile(pathtocircle);
                                xo8 = 2;
                                xox = 1;
                            }
                        }
                        else if (bc == 9)
                        {
                            if (xo9 == 1 || xo9 == 2)
                            { }
                            else if (xo9 == 0)
                            {
                                but_xo9.Image = Image.FromFile(pathtocircle);
                                xo9 = 2;
                                xox = 1;
                            }
                        }
                    }
                    xox = 0; // онуляємо допоміжну функцію
                }
            }
        }
        // метод інтелекту комп'ютера на легкій складності який грає за Х 
        public void easy_bot_intellect_x()
        { // метод ідентичний easy_bot_intelect_o, але для бота що грає за Х
            if ((xo1 == 2 && xo2 == 2 && xo3 == 2) ||
                (xo4 == 2 && xo5 == 2 && xo6 == 2) ||
                (xo7 == 2 && xo8 == 2 && xo9 == 2) ||
                (xo7 == 2 && xo8 == 2 && xo9 == 2) ||
                (xo1 == 2 && xo4 == 2 && xo7 == 2) ||
                (xo2 == 2 && xo5 == 2 && xo8 == 2) ||
                (xo3 == 2 && xo6 == 2 && xo9 == 2) ||
                (xo1 == 2 && xo5 == 2 && xo9 == 2) ||
                (xo3 == 2 && xo5 == 2 && xo7 == 2))
            {
                winCheck();
            }
            else
            {
                if ((xo1 == 1 || xo1 == 2) && (xo2 == 1 || xo2 == 2) && (xo3 == 1 || xo3 == 2) &&
                    (xo4 == 1 || xo4 == 2) && (xo5 == 1 || xo5 == 2) && (xo6 == 1 || xo6 == 2) &&
                    (xo7 == 1 || xo7 == 2) && (xo8 == 1 || xo8 == 2) && (xo9 == 1 || xo9 == 2))
                { }
                else
                {
                    while (xox == 0)
                    {
                        int bc = bot_choice(1, 10);
                        if (bc == 1)
                        {
                            if (xo1 == 1 || xo1 == 2)
                            { }
                            else if (xo1 == 0)
                            {
                                but_xo1.Image = Image.FromFile(pathtocross);
                                xo1 = 1;
                                xox = 1;
                            }
                        }
                        else if (bc == 2)
                        {
                            if (xo2 == 1 || xo2 == 2)
                            { }
                            else if (xo2 == 0)
                            {
                                but_xo2.Image = Image.FromFile(pathtocross);
                                xo2 = 1;
                                xox = 1;
                            }
                        }
                        else if (bc == 3)
                        {
                            if (xo3 == 1 || xo3 == 2)
                            { }
                            else if (xo3 == 0)
                            {
                                but_xo3.Image = Image.FromFile(pathtocross);
                                xo3 = 1;
                                xox = 1;
                            }
                        }
                        else if (bc == 4)
                        {
                            if (xo4 == 1 || xo4 == 2)
                            { }
                            else if (xo4 == 0)
                            {
                                but_xo4.Image = Image.FromFile(pathtocross);
                                xo4 = 1;
                                xox = 1;
                            }
                        }
                        else if (bc == 5)
                        {
                            if (xo5 == 1 || xo5 == 2)
                            { }
                            else if (xo5 == 0)
                            {
                                but_xo5.Image = Image.FromFile(pathtocross);
                                xo5 = 1;
                                xox = 1;
                            }
                        }
                        else if (bc == 6)
                        {
                            if (xo6 == 1 || xo6 == 2)
                            { }
                            else if (xo6 == 0)
                            {
                                but_xo6.Image = Image.FromFile(pathtocross);
                                xo6 = 1;
                                xox = 1;
                            }
                        }
                        else if (bc == 7)
                        {
                            if (xo7 == 1 || xo7 == 2)
                            { }
                            else if (xo7 == 0)
                            {
                                but_xo7.Image = Image.FromFile(pathtocross);
                                xo7 = 1;
                                xox = 1;
                            }
                        }
                        else if (bc == 8)
                        {
                            if (xo8 == 1 || xo8 == 2)
                            { }
                            else if (xo8 == 0)
                            {
                                but_xo8.Image = Image.FromFile(pathtocross);
                                xo8 = 1;
                                xox = 1;
                            }
                        }
                        else if (bc == 9)
                        {
                            if (xo9 == 1 || xo9 == 2)
                            { }
                            else if (xo9 == 0)
                            {
                                but_xo9.Image = Image.FromFile(pathtocross);
                                xo9 = 1;
                                xox = 1;
                            }
                        }
                    }
                    xox = 0;
                }
            }
        }
        // метод інтелекту комп'ютера на середній складності який грає за О
        public void medium_bot_intellect_o()
        {
            if ((xo1 == 1 && xo2 == 1 && xo3 == 1) ||
                (xo4 == 1 && xo5 == 1 && xo6 == 1) ||  // переліковуємо усі переможні патерни супротивника це потрібно для того щоб
                (xo7 == 1 && xo8 == 1 && xo9 == 1) ||  // при перемозі супротивника не робився ще один ход, естетичне та практичне рішення
                (xo1 == 1 && xo4 == 1 && xo7 == 1) ||  // коли комп'ютер грає за хрестики та ходить ход під час якого він перемогає, навіть
                (xo2 == 1 && xo5 == 1 && xo8 == 1) ||  // якщо ходом раніше перемогли ноліки перемога віддається хрестикам, сенсова помилка
                (xo3 == 1 && xo6 == 1 && xo9 == 1) ||
                (xo1 == 1 && xo5 == 1 && xo9 == 1) ||
                (xo3 == 1 && xo5 == 1 && xo7 == 1))
            {
                winCheck(); // присуджуємо перемогу тому хто переміг якщо такий є
            }
            else
            {// поки не випаде вільна комірка циул буде продовжувати шукати такову
                if ((xo1 == 1 || xo1 == 2) && (xo2 == 1 || xo2 == 2) && (xo3 == 1 || xo3 == 2) &&
                    (xo4 == 1 || xo4 == 2) && (xo5 == 1 || xo5 == 2) && (xo6 == 1 || xo6 == 2) &&
                    (xo7 == 1 || xo7 == 2) && (xo8 == 1 || xo8 == 2) && (xo9 == 1 || xo9 == 2))
                { }
                else
                { // перебераємо цсі комбінації де комп'ютеру треба зробити лише один вірний хід щоб перемогти та якщо такі є, перемогаємо
                    if (xo1 == 2 && xo4 == 2 && xo7 != 1)
                    {
                        but_xo7.Image = Image.FromFile(pathtocircle);
                        xo7 = 2;
                    }
                    else if (xo2 == 2 && xo5 == 2 && xo8 != 1)
                    {
                        but_xo8.Image = Image.FromFile(pathtocircle);
                        xo8 = 2;
                    }
                    else if (xo3 == 2 && xo6 == 2 && xo9 != 1)
                    {
                        but_xo9.Image = Image.FromFile(pathtocircle);
                        xo9 = 2;
                    }
                    else if (xo4 == 2 && xo7 == 2 && xo1 != 1)
                    {
                        but_xo1.Image = Image.FromFile(pathtocircle);
                        xo1 = 2;
                    }
                    else if (xo5 == 2 && xo8 == 2 && xo2 != 1)
                    {
                        but_xo2.Image = Image.FromFile(pathtocircle);
                        xo2 = 2;
                    }
                    else if (xo6 == 2 && xo9 == 2 && xo3 != 1)
                    {
                        but_xo3.Image = Image.FromFile(pathtocircle);
                        xo3 = 2;
                    }
                    else if (xo1 == 2 && xo2 == 2 && xo3 != 1)
                    {
                        but_xo3.Image = Image.FromFile(pathtocircle);
                        xo3 = 2;
                    }
                    else if (xo4 == 2 && xo5 == 2 && xo6 != 1)
                    {
                        but_xo6.Image = Image.FromFile(pathtocircle);
                        xo6 = 2;
                    }
                    else if (xo7 == 2 && xo8 == 2 && xo9 != 1)
                    {
                        but_xo9.Image = Image.FromFile(pathtocircle);
                        xo9 = 2;
                    }
                    else if (xo2 == 2 && xo3 == 2 && xo1 != 1)
                    {
                        but_xo1.Image = Image.FromFile(pathtocircle);
                        xo1 = 2;
                    }
                    else if (xo5 == 2 && xo6 == 2 && xo4 != 1)
                    {
                        but_xo4.Image = Image.FromFile(pathtocircle);
                        xo4 = 2;
                    }
                    else if (xo8 == 2 && xo9 == 2 && xo7 != 1)
                    {
                        but_xo7.Image = Image.FromFile(pathtocircle);
                        xo7 = 2;
                    }
                    else if (xo1 == 2 && xo5 == 2 && xo9 != 1)
                    {
                        but_xo9.Image = Image.FromFile(pathtocircle);
                        xo9 = 2;
                    }
                    else if (xo5 == 2 && xo9 == 2 && xo1 != 1)
                    {
                        but_xo1.Image = Image.FromFile(pathtocircle);
                        xo1 = 2;
                    }
                    else if (xo1 == 2 && xo9 == 2 && xo5 != 1)
                    {
                        but_xo5.Image = Image.FromFile(pathtocircle);
                        xo5 = 2;
                    }
                    else if (xo1 == 2 && xo7 == 2 && xo4 != 1)
                    {
                        but_xo4.Image = Image.FromFile(pathtocircle);
                        xo4 = 2;
                    }
                    else if (xo2 == 2 && xo8 == 2 && xo5 != 1)
                    {
                        but_xo5.Image = Image.FromFile(pathtocircle);
                        xo5 = 2;
                    }
                    else if (xo3 == 2 && xo9 == 2 && xo6 != 1)
                    {
                        but_xo6.Image = Image.FromFile(pathtocircle);
                        xo6 = 2;
                    }
                    else if (xo1 == 2 && xo3 == 2 && xo2 != 1)
                    {
                        but_xo2.Image = Image.FromFile(pathtocircle);
                        xo2 = 2;
                    }
                    else if (xo4 == 2 && xo6 == 2 && xo5 != 1)
                    {
                        but_xo5.Image = Image.FromFile(pathtocircle);
                        xo5 = 2;
                    }
                    else if (xo7 == 2 && xo9 == 2 && xo8 != 1)
                    {
                        but_xo8.Image = Image.FromFile(pathtocircle);
                        xo8 = 2;
                    }
                    else if (xo3 == 2 && xo5 == 2 && xo7 != 1)
                    {
                        but_xo7.Image = Image.FromFile(pathtocircle);
                        xo7 = 2;
                    }
                    else if (xo5 == 2 && xo7 == 2 && xo3 != 1)
                    {
                        but_xo3.Image = Image.FromFile(pathtocircle);
                        xo3 = 2;
                    }
                    else if (xo3 == 2 && xo7 == 2 && xo5 != 1)
                    {
                        but_xo5.Image = Image.FromFile(pathtocircle);
                        xo5 = 2;
                    }
                    else // якщо переможних патернів ще не має, то використовуємо рандомне заповнення поля
                        easy_bot_intellect_o();
                }
            }
        }
        // метод інтелекту комп'ютера на середній складності який грає за Х
        public void medium_bot_intellect_x()
        {// метод ідентичний medium_bot_intelect_o, але для бота що грає за Х
            if ((xo1 == 2 && xo2 == 2 && xo3 == 2) ||
                (xo4 == 2 && xo5 == 2 && xo6 == 2) ||
                (xo7 == 2 && xo8 == 2 && xo9 == 2) ||
                (xo1 == 2 && xo4 == 2 && xo7 == 2) ||
                (xo2 == 2 && xo5 == 2 && xo8 == 2) ||
                (xo3 == 2 && xo6 == 2 && xo9 == 2) ||
                (xo1 == 2 && xo5 == 2 && xo9 == 2) ||
                (xo3 == 2 && xo5 == 2 && xo7 == 2))
            {
                winCheck();
            }
            else
            {
                if ((xo1 == 1 || xo1 == 2) && (xo2 == 1 || xo2 == 2) && (xo3 == 1 || xo3 == 2) &&
                    (xo4 == 1 || xo4 == 2) && (xo5 == 1 || xo5 == 2) && (xo6 == 1 || xo6 == 2) &&
                    (xo7 == 1 || xo7 == 2) && (xo8 == 1 || xo8 == 2) && (xo9 == 1 || xo9 == 2))
                { }
                else
                {
                    if (xo1 == 1 && xo4 == 1 && xo7 != 2)
                    {
                        but_xo7.Image = Image.FromFile(pathtocross);
                        xo7 = 1;
                    }
                    else if (xo2 == 1 && xo5 == 1 && xo8 != 2)
                    {
                        but_xo8.Image = Image.FromFile(pathtocross);
                        xo8 = 1;
                    }
                    else if (xo3 == 1 && xo6 == 1 && xo9 != 2)
                    {
                        but_xo9.Image = Image.FromFile(pathtocross);
                        xo9 = 1;
                    }
                    else if (xo4 == 1 && xo7 == 1 && xo1 != 2)
                    {
                        but_xo1.Image = Image.FromFile(pathtocross);
                        xo1 = 1;
                    }
                    else if (xo5 == 1 && xo8 == 1 && xo2 != 2)
                    {
                        but_xo2.Image = Image.FromFile(pathtocross);
                        xo2 = 1;
                    }
                    else if (xo6 == 1 && xo9 == 1 && xo3 != 2)
                    {
                        but_xo3.Image = Image.FromFile(pathtocross);
                        xo3 = 1;
                    }
                    else if (xo1 == 1 && xo2 == 1 && xo3 != 2)
                    {
                        but_xo3.Image = Image.FromFile(pathtocross);
                        xo3 = 1;
                    }
                    else if (xo4 == 1 && xo5 == 1 && xo6 != 2)
                    {
                        but_xo6.Image = Image.FromFile(pathtocross);
                        xo6 = 1;
                    }
                    else if (xo7 == 1 && xo8 == 1 && xo9 != 2)
                    {
                        but_xo9.Image = Image.FromFile(pathtocross);
                        xo9 = 1;
                    }
                    else if (xo2 == 1 && xo3 == 1 && xo1 != 2)
                    {
                        but_xo1.Image = Image.FromFile(pathtocross);
                        xo1 = 1;
                    }
                    else if (xo5 == 1 && xo6 == 1 && xo4 != 2)
                    {
                        but_xo4.Image = Image.FromFile(pathtocross);
                        xo4 = 1;
                    }
                    else if (xo8 == 1 && xo9 == 1 && xo7 != 2)
                    {
                        but_xo7.Image = Image.FromFile(pathtocross);
                        xo7 = 1;
                    }
                    else if (xo1 == 1 && xo5 == 1 && xo9 != 2)
                    {
                        but_xo9.Image = Image.FromFile(pathtocross);
                        xo9 = 1;
                    }
                    else if (xo5 == 1 && xo9 == 1 && xo1 != 2)
                    {
                        but_xo1.Image = Image.FromFile(pathtocross);
                        xo1 = 1;
                    }
                    else if (xo1 == 1 && xo7 == 1 && xo4 != 2)
                    {
                        but_xo4.Image = Image.FromFile(pathtocross);
                        xo4 = 1;
                    }
                    else if (xo2 == 1 && xo8 == 1 && xo5 != 2)
                    {
                        but_xo5.Image = Image.FromFile(pathtocross);
                        xo5 = 1;
                    }
                    else if (xo3 == 1 && xo9 == 1 && xo6 != 2)
                    {
                        but_xo6.Image = Image.FromFile(pathtocross);
                        xo6 = 1;
                    }
                    else if (xo1 == 1 && xo3 == 1 && xo2 != 2)
                    {
                        but_xo2.Image = Image.FromFile(pathtocross);
                        xo2 = 1;
                    }
                    else if (xo4 == 1 && xo6 == 1 && xo5 != 2)
                    {
                        but_xo5.Image = Image.FromFile(pathtocross);
                        xo5 = 1;
                    }
                    else if (xo7 == 1 && xo9 == 1 && xo8 != 2)
                    {
                        but_xo8.Image = Image.FromFile(pathtocross);
                        xo8 = 1;
                    }
                    else if (xo3 == 1 && xo5 == 1 && xo7 != 2)
                    {
                        but_xo7.Image = Image.FromFile(pathtocross);
                        xo7 = 1;
                    }
                    else if (xo5 == 1 && xo7 == 1 && xo3 != 2)
                    {
                        but_xo3.Image = Image.FromFile(pathtocross);
                        xo3 = 1;
                    }
                    else if (xo1 == 1 && xo9 == 1 && xo5 != 2)
                    {
                        but_xo5.Image = Image.FromFile(pathtocross);
                        xo5 = 1;
                    }
                    else if (xo3 == 1 && xo7 == 1 && xo5 != 2)
                    {
                        but_xo5.Image = Image.FromFile(pathtocross);
                        xo5 = 1;
                    }
                    else
                        easy_bot_intellect_x();
                }
            }
        }
        // метод інтелекту комп'ютера на важкій складності який грає за О
        public void hard_bot_intellect_o()
        {
            if ((xo1 == 1 && xo2 == 1 && xo3 == 1) ||
                (xo4 == 1 && xo5 == 1 && xo6 == 1) ||  // переліковуємо усі переможні патерни супротивника це потрібно для того щоб
                (xo7 == 1 && xo8 == 1 && xo9 == 1) ||  // при перемозі супротивника не робився ще один ход, естетичне та практичне рішення
                (xo1 == 1 && xo4 == 1 && xo7 == 1) ||  // коли комп'ютер грає за хрестики та ходить ход під час якого він перемогає, навіть
                (xo2 == 1 && xo5 == 1 && xo8 == 1) ||  // якщо ходом раніше перемогли ноліки перемога віддається хрестикам, сенсова помилка
                (xo3 == 1 && xo6 == 1 && xo9 == 1) ||
                (xo1 == 1 && xo5 == 1 && xo9 == 1) ||
                (xo3 == 1 && xo5 == 1 && xo7 == 1))
            {
                winCheck(); // присуджуємо перемогу тому хто переміг якщо такий є
            }
            else
            {// поки не випаде вільна комірка циул буде продовжувати шукати такову
                if ((xo1 == 1 || xo1 == 2) && (xo2 == 1 || xo2 == 2) && (xo3 == 1 || xo3 == 2) &&
                    (xo4 == 1 || xo4 == 2) && (xo5 == 1 || xo5 == 2) && (xo6 == 1 || xo6 == 2) &&
                    (xo7 == 1 || xo7 == 2) && (xo8 == 1 || xo8 == 2) && (xo9 == 1 || xo9 == 2))
                { }
                else
                {
                    if (xo1 == 1 && xo4 == 1 && xo7 != 2)
                    {
                        but_xo7.Image = Image.FromFile(pathtocircle);
                        xo7 = 2;
                    }
                    else if (xo2 == 1 && xo5 == 1 && xo8 != 2)
                    {
                        but_xo8.Image = Image.FromFile(pathtocircle);
                        xo8 = 2;
                    }
                    else if (xo3 == 1 && xo6 == 1 && xo9 != 2)
                    {
                        but_xo9.Image = Image.FromFile(pathtocircle);
                        xo9 = 2;
                    }
                    else if (xo4 == 1 && xo7 == 1 && xo1 != 2)
                    {
                        but_xo1.Image = Image.FromFile(pathtocircle);
                        xo1 = 2;
                    }
                    else if (xo5 == 1 && xo8 == 1 && xo2 != 2)
                    {
                        but_xo2.Image = Image.FromFile(pathtocircle);
                        xo2 = 2;
                    }
                    else if (xo6 == 1 && xo9 == 1 && xo3 != 2)
                    {
                        but_xo3.Image = Image.FromFile(pathtocircle);
                        xo3 = 2;
                    }
                    else if (xo1 == 1 && xo2 == 1 && xo3 != 2)
                    {
                        but_xo3.Image = Image.FromFile(pathtocircle);
                        xo3 = 2;
                    }
                    else if (xo4 == 1 && xo5 == 1 && xo6 != 2)
                    {
                        but_xo6.Image = Image.FromFile(pathtocircle);
                        xo6 = 2;
                    }
                    else if (xo7 == 1 && xo8 == 1 && xo9 != 2)
                    {
                        but_xo9.Image = Image.FromFile(pathtocircle);
                        xo9 = 2;
                    }
                    else if (xo2 == 1 && xo3 == 1 && xo1 != 2)
                    {
                        but_xo1.Image = Image.FromFile(pathtocircle);
                        xo1 = 2;
                    }
                    else if (xo5 == 1 && xo6 == 1 && xo4 != 2)
                    {
                        but_xo4.Image = Image.FromFile(pathtocircle);
                        xo4 = 2;
                    }
                    else if (xo8 == 1 && xo9 == 1 && xo7 != 2)
                    {
                        but_xo7.Image = Image.FromFile(pathtocircle);
                        xo7 = 2;
                    }
                    else if (xo1 == 1 && xo5 == 1 && xo9 != 2)
                    {
                        but_xo9.Image = Image.FromFile(pathtocircle);
                        xo9 = 2;
                    }
                    else if (xo5 == 1 && xo9 == 1 && xo1 != 2)
                    {
                        but_xo1.Image = Image.FromFile(pathtocircle);
                        xo1 = 2;
                    }
                    else if (xo1 == 1 && xo7 == 1 && xo4 != 2)
                    {
                        but_xo4.Image = Image.FromFile(pathtocircle);
                        xo4 = 2;
                    }
                    else if (xo2 == 1 && xo8 == 1 && xo5 != 2)
                    {
                        but_xo5.Image = Image.FromFile(pathtocircle);
                        xo5 = 2;
                    }
                    else if (xo3 == 1 && xo9 == 1 && xo6 != 2)
                    {
                        but_xo6.Image = Image.FromFile(pathtocircle);
                        xo6 = 2;
                    }
                    else if (xo1 == 1 && xo3 == 1 && xo2 != 2)
                    {
                        but_xo2.Image = Image.FromFile(pathtocircle);
                        xo2 = 2;
                    }
                    else if (xo4 == 1 && xo6 == 1 && xo5 != 2)
                    {
                        but_xo5.Image = Image.FromFile(pathtocircle);
                        xo5 = 2;
                    }
                    else if (xo7 == 1 && xo9 == 1 && xo8 != 2)
                    {
                        but_xo8.Image = Image.FromFile(pathtocircle);
                        xo8 = 2;
                    }
                    else if (xo3 == 1 && xo5 == 1 && xo7 != 2)
                    {
                        but_xo7.Image = Image.FromFile(pathtocircle);
                        xo7 = 2;
                    }
                    else if (xo5 == 1 && xo7 == 1 && xo3 != 2)
                    {
                        but_xo3.Image = Image.FromFile(pathtocircle);
                        xo3 = 2;
                    }
                    else if (xo1 == 1 && xo9 == 1 && xo5 != 2)
                    {
                        but_xo5.Image = Image.FromFile(pathtocircle);
                        xo5 = 2;
                    }
                    else if (xo3 == 1 && xo7 == 1 && xo5 != 2)
                    {
                        but_xo5.Image = Image.FromFile(pathtocircle);
                        xo5 = 2;
                    }
                    else
                        medium_bot_intellect_o();
                }
            }
        }
        // метод інтелекту комп'ютера на важкій складності який грає за X
        public void hard_bot_intellect_x()
        {
            if ((xo1 == 2 && xo2 == 2 && xo3 == 2) ||
                (xo4 == 2 && xo5 == 2 && xo6 == 2) ||  // переліковуємо усі переможні патерни супротивника це потрібно для того щоб
                (xo7 == 2 && xo8 == 2 && xo9 == 2) ||  // при перемозі супротивника не робився ще один ход, естетичне та практичне рішення
                (xo1 == 2 && xo4 == 2 && xo7 == 2) ||  // коли комп'ютер грає за хрестики та ходить ход під час якого він перемогає, навіть
                (xo2 == 2 && xo5 == 2 && xo8 == 2) ||  // якщо ходом раніше перемогли ноліки перемога віддається хрестикам, сенсова помилка
                (xo3 == 2 && xo6 == 2 && xo9 == 2) ||
                (xo1 == 2 && xo5 == 2 && xo9 == 2) ||
                (xo3 == 2 && xo5 == 2 && xo7 == 2))
            {
                winCheck(); // присуджуємо перемогу тому хто переміг якщо такий є
            }
            else
            {// поки не випаде вільна комірка циул буде продовжувати шукати такову
                if ((xo1 == 1 || xo1 == 2) && (xo2 == 1 || xo2 == 2) && (xo3 == 1 || xo3 == 2) &&
                    (xo4 == 1 || xo4 == 2) && (xo5 == 1 || xo5 == 2) && (xo6 == 1 || xo6 == 2) &&
                    (xo7 == 1 || xo7 == 2) && (xo8 == 1 || xo8 == 2) && (xo9 == 1 || xo9 == 2))
                { }
                else
                {
                    if (xo1 == 2 && xo4 == 2 && xo7 != 1)
                    {
                        but_xo7.Image = Image.FromFile(pathtocross);
                        xo7 = 1;
                    }
                    else if (xo2 == 2 && xo5 == 2 && xo8 != 1)
                    {
                        but_xo8.Image = Image.FromFile(pathtocross);
                        xo8 = 1;
                    }
                    else if (xo3 == 2 && xo6 == 2 && xo9 != 1)
                    {
                        but_xo9.Image = Image.FromFile(pathtocross);
                        xo9 = 1;
                    }
                    else if (xo4 == 2 && xo7 == 2 && xo1 != 1)
                    {
                        but_xo1.Image = Image.FromFile(pathtocross);
                        xo1 = 1;
                    }
                    else if (xo5 == 2 && xo8 == 2 && xo2 != 1)
                    {
                        but_xo2.Image = Image.FromFile(pathtocross);
                        xo2 = 1;
                    }
                    else if (xo6 == 2 && xo9 == 2 && xo3 != 1)
                    {
                        but_xo3.Image = Image.FromFile(pathtocross);
                        xo3 = 1;
                    }
                    else if (xo1 == 2 && xo2 == 2 && xo3 != 1)
                    {
                        but_xo3.Image = Image.FromFile(pathtocross);
                        xo3 = 1;
                    }
                    else if (xo4 == 2 && xo5 == 2 && xo6 != 1)
                    {
                        but_xo6.Image = Image.FromFile(pathtocross);
                        xo6 = 1;
                    }
                    else if (xo7 == 2 && xo8 == 2 && xo9 != 1)
                    {
                        but_xo9.Image = Image.FromFile(pathtocross);
                        xo9 = 1;
                    }
                    else if (xo2 == 2 && xo3 == 2 && xo1 != 1)
                    {
                        but_xo1.Image = Image.FromFile(pathtocross);
                        xo1 = 1;
                    }
                    else if (xo5 == 2 && xo6 == 2 && xo4 != 1)
                    {
                        but_xo4.Image = Image.FromFile(pathtocross);
                        xo4 = 1;
                    }
                    else if (xo8 == 2 && xo9 == 2 && xo7 != 1)
                    {
                        but_xo7.Image = Image.FromFile(pathtocross);
                        xo7 = 1;
                    }
                    else if (xo1 == 2 && xo5 == 2 && xo9 != 1)
                    {
                        but_xo9.Image = Image.FromFile(pathtocross);
                        xo9 = 1;
                    }
                    else if (xo5 == 2 && xo9 == 2 && xo1 != 1)
                    {
                        but_xo1.Image = Image.FromFile(pathtocross);
                        xo1 = 1;
                    }
                    else if (xo1 == 2 && xo7 == 2 && xo4 != 1)
                    {
                        but_xo4.Image = Image.FromFile(pathtocross);
                        xo4 = 1;
                    }
                    else if (xo2 == 2 && xo8 == 2 && xo5 != 1)
                    {
                        but_xo5.Image = Image.FromFile(pathtocross);
                        xo5 = 1;
                    }
                    else if (xo3 == 2 && xo9 == 2 && xo6 != 1)
                    {
                        but_xo6.Image = Image.FromFile(pathtocross);
                        xo6 = 1;
                    }
                    else if (xo1 == 2 && xo3 == 2 && xo2 != 1)
                    {
                        but_xo2.Image = Image.FromFile(pathtocross);
                        xo2 = 1;
                    }
                    else if (xo4 == 2 && xo6 == 2 && xo5 != 1)
                    {
                        but_xo5.Image = Image.FromFile(pathtocross);
                        xo5 = 1;
                    }
                    else if (xo7 == 2 && xo9 == 2 && xo8 != 1)
                    {
                        but_xo8.Image = Image.FromFile(pathtocross);
                        xo8 = 1;
                    }
                    else if (xo3 == 2 && xo5 == 2 && xo7 != 1)
                    {
                        but_xo7.Image = Image.FromFile(pathtocross);
                        xo7 = 1;
                    }
                    else if (xo5 == 2 && xo7 == 2 && xo3 != 1)
                    {
                        but_xo3.Image = Image.FromFile(pathtocross);
                        xo3 = 1;
                    }
                    else if (xo1 == 2 && xo9 == 2 && xo5 != 1)
                    {
                        but_xo5.Image = Image.FromFile(pathtocross);
                        xo5 = 1;
                    }
                    else if (xo3 == 2 && xo7 == 2 && xo5 != 1)
                    {
                        but_xo5.Image = Image.FromFile(pathtocross);
                        xo5 = 1;
                    }
                    else
                        medium_bot_intellect_x();
                }
            }
        }
        // метод для перевірки вийгрошу гравців
        public void winCheck()
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
                isAnyoneWin = 1; // ставимо у змінну перемог що один з ігроків переміг та який саме (перший ігрок)
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
                isAnyoneWin = 2; // ставимо у змінну перемог що один з ігроків переміг та який саме (другий ігрок)
            }
            else if (xo1 != 0 && xo2 != 0 && xo3 != 0 && xo4 != 0 && xo5 != 0 && xo6 != 0 && xo7 != 0 && xo8 != 0 && xo9 != 0 && isAnyoneWin == 0)
            { // якщо ніхто не перемог та усі кнопки займані будь-яким іграком пишемо про нічию у контекстну строку
                label_context.Text = "Draw!";
            }
        }
    }
}