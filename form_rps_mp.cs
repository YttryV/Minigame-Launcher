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
    public partial class form_rps_mp : Form
    {
        // створюємо та ініціалізуємо змінні вибору першого та другого ігрока, а також змінну ходу гри
        int FirstPlayerChoice = 0, SecondPlayerChoice = 0, turn = 0;
        // створюємо функцію типу string які утримують в собі шлях до картинок що використовуються в проекті
        // усі картинку шукаються від поточного .exe файлу програми
        string pathtohandrock = Path.GetFullPath("..\\..\\..\\pictures for project\\hand_rock.png");
        string pathtohandpaper = Path.GetFullPath("..\\..\\..\\pictures for project\\hand_paper.png");
        string pathtohandscissors = Path.GetFullPath("..\\..\\..\\pictures for project\\hand_scissors.png");

        public form_rps_mp()
        {
            InitializeComponent();
        }
        // метод для управління програмою з кнопок клавіатури
        private void form_rps_mp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { but_back.PerformClick(); }
            else if (e.KeyCode == Keys.NumPad1) { but_rock.PerformClick(); }
            else if (e.KeyCode == Keys.NumPad2) { but_paper.PerformClick(); }
            else if (e.KeyCode == Keys.NumPad3) { but_scissors.PerformClick(); }
            else if (e.KeyCode == Keys.NumPad0) { but_confirm.PerformClick(); }
        }
        // метод кнопки повернення до минулої форми
        private void but_back_Click(object sender, EventArgs e)
        {
            form_rps form_Rps = new form_rps(); // створюємо функцію минулох форми
            form_Rps.Show(); // відображає минулу форму
            this.Close(); // закриває поточну форму
        }
        // метод кнопки вибору каменю
        private void but_rock_Click(object sender, EventArgs e)
        {
            pictureBox_your_choice.Image = Image.FromFile(pathtohandrock); // відображаємо вибір у вікні вибору
            pictureBox_your_choice.SizeMode = PictureBoxSizeMode.CenterImage; // централізуємо картинку у PictureBox
            if (turn == 0)
            { // якщо ход 0(підготовчий етап) усі PictureBox'и очищюються, зберігаємо вибір першого ігрока та переводимо ход на перший
                pictureBox_first_player.Image = null; // очищуємо PictureBox
                pictureBox_second_player.Image = null; // очищуємо PictureBox
                FirstPlayerChoice = 1; // зберігаємо вибір першого ігрока
                turn = 1; // переводимо ход
            }
            else if (turn == 1)
            { // якщо ход перший то зберігаємо вибір другого ігрока та переводимо ход на другий
                SecondPlayerChoice = 1; // зберігаємо вибір другого ігрока
                turn = 2; // переводимо ход
            }
        }
        // метод кнопки вибору бумаги
        private void but_paper_Click(object sender, EventArgs e)
        {
            pictureBox_your_choice.Image = Image.FromFile(pathtohandpaper); // відображаємо вибір у вікні вибору
            pictureBox_your_choice.SizeMode = PictureBoxSizeMode.CenterImage; // централізуємо картинку у PictureBox
            if (turn == 0)
            { // якщо ход 0(підготовчий етап) усі PictureBox'и очищюються, зберігаємо вибір першого ігрока та переводимо ход на перший
                pictureBox_first_player.Image = null; // очищуємо PictureBox
                pictureBox_second_player.Image = null; // очищуємо PictureBox
                FirstPlayerChoice = 2; // зберігаємо вибір першого ігрока
                turn = 1; // переводимо ход
            }
            else if (turn == 1)
            { // якщо ход перший то зберігаємо вибір другого ігрока та переводимо ход на другий
                SecondPlayerChoice = 2; // зберігаємо вибір другого ігрока
                turn = 2; // переводимо ход
            }
        }
        // метод кнопки вибору ножиць
        private void but_scissors_Click(object sender, EventArgs e)
        {
            pictureBox_your_choice.Image = Image.FromFile(pathtohandscissors); // відображаємо вибір у вікні вибору
            pictureBox_your_choice.SizeMode = PictureBoxSizeMode.CenterImage; // централізуємо картинку у PictureBox
            if (turn == 0)
            { // якщо ход 0(підготовчий етап) усі PictureBox'и очищюються, зберігаємо вибір першого ігрока та переводимо ход на перший
                pictureBox_first_player.Image = null; // очищуємо PictureBox
                pictureBox_second_player.Image = null; // очищуємо PictureBox
                FirstPlayerChoice = 3; // зберігаємо вибір першого ігрока
                turn = 1; // переводимо ход
            }
            else if (turn == 1)
            { // якщо ход перший то зберігаємо вибір другого ігрока та переводимо ход на другий
                SecondPlayerChoice = 3; // зберігаємо вибір другого ігрока
                turn = 2;
            }
        }
        // метод кнопки підтвердження ходу, яка виконує ще функцію обирання переможця
        private void but_confirm_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            { // якщо ход 1 то заповнюємо контекстну строку що ход другого ігрока та очищюємо PictureBox
                pictureBox_your_choice.Image = null; // очищюємо PictureBox
                label_what_player_try.Text = "Second Player\nTry"; // заповнюємо контекстну строку
            }
            if (turn == 2)
            {
                // якщо ход 2 то очищуємо PictureBox вибіру та заповнюємо допоміжні PictureBox'и в залежності від вибору першого гравця
                pictureBox_your_choice.Image = null;
                if (FirstPlayerChoice == 1)
                {
                    pictureBox_first_player.Image = Image.FromFile(pathtohandrock);
                    pictureBox_first_player.SizeMode = PictureBoxSizeMode.CenterImage;
                }
                else if (FirstPlayerChoice == 2)
                {
                    pictureBox_first_player.Image = Image.FromFile(pathtohandpaper);
                    pictureBox_first_player.SizeMode = PictureBoxSizeMode.CenterImage;
                }
                else if (FirstPlayerChoice == 3)
                {
                    pictureBox_first_player.Image = Image.FromFile(pathtohandscissors);
                    pictureBox_first_player.SizeMode = PictureBoxSizeMode.CenterImage;
                }
                // якщо ход 2 то очищуємо PictureBox вибіру та заповнюємо допоміжні PictureBox'и в залежності від вибору другого гравця
                if (SecondPlayerChoice == 1)
                {
                    pictureBox_second_player.Image = Image.FromFile(pathtohandrock);
                    pictureBox_second_player.SizeMode = PictureBoxSizeMode.CenterImage;
                }
                else if (SecondPlayerChoice == 2)
                {
                    pictureBox_second_player.Image = Image.FromFile(pathtohandpaper);
                    pictureBox_second_player.SizeMode = PictureBoxSizeMode.CenterImage;
                }
                else if (SecondPlayerChoice == 3)
                {
                    pictureBox_second_player.Image = Image.FromFile(pathtohandscissors);
                    pictureBox_second_player.SizeMode = PictureBoxSizeMode.CenterImage;
                }
                // обераємо переможця по принципу перебору усіх комбінацій Камень-Ножиці-Бумага
                // пишемо переможця у контекстну строку
                if ((FirstPlayerChoice == 1 && SecondPlayerChoice == 3) ||
                    (FirstPlayerChoice == 2 && SecondPlayerChoice == 1) ||
                    (FirstPlayerChoice == 3 && SecondPlayerChoice == 2))
                {
                    label_winbox.Text = "First Player\nWin";
                }
                else if ((FirstPlayerChoice == 1 && SecondPlayerChoice == 2) ||
                         (FirstPlayerChoice == 2 && SecondPlayerChoice == 3) ||
                         (FirstPlayerChoice == 3 && SecondPlayerChoice == 1))
                {
                    label_winbox.Text = "Second Player\nWin";
                }
                else if ((FirstPlayerChoice == 1 && SecondPlayerChoice == 1) ||
                         (FirstPlayerChoice == 2 && SecondPlayerChoice == 2) ||
                         (FirstPlayerChoice == 3 && SecondPlayerChoice == 3))
                {
                    label_winbox.Text = "Draw";
                }
                label_what_player_try.Text = "First Player\nTry"; // пишемо про те що ход першого грака для наступного раунду
                // змінюємо значення усіх змінних на дефолтні
                turn = 0;
                FirstPlayerChoice = 0;
                SecondPlayerChoice = 0;
            }
        }
    }
}
