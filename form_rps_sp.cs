using Minigame_Launcher.Properties;
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
    public partial class form_rps_sp : Form
    {
        int FirstPlayerChoice; // змінна яка зберігає у собі вибір ігрока людини
        // створюємо функцію типу string які утримують в собі шлях до картинок що використовуються в проекті
        // усі картинку шукаються від поточного .exe файлу програми
        string pathtohandrock = Path.GetFullPath("..\\..\\..\\pictures for project\\hand_rock.png");
        string pathtohandpaper = Path.GetFullPath("..\\..\\..\\pictures for project\\hand_paper.png");
        string pathtohandscissors = Path.GetFullPath("..\\..\\..\\pictures for project\\hand_scissors.png");

        public form_rps_sp()
        {
            InitializeComponent();
        }
        // метод для управління програмою з кнопок клавіатури
        private void form_rps_sp_KeyDown(object sender, KeyEventArgs e)
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
            pictureBox_partner_choice.Image = null; // стока розрахована не на перший хід гри, після першого ходу ця строка очищяє вікно вибору опонента
            label_winbox.Text = "..."; // вводимо текст у контекстну строку
            FirstPlayerChoice = 1; // ініціалізуємо змінну вибору ігрока на 1(камень)
        }
        // метод кнопки вибору бумаги
        private void but_paper_Click(object sender, EventArgs e)
        {
            pictureBox_your_choice.Image = Image.FromFile(pathtohandpaper); // відображаємо вибір у вікні вибору
            pictureBox_your_choice.SizeMode = PictureBoxSizeMode.CenterImage; // централізуємо картинку у PictureBox
            pictureBox_partner_choice.Image = null; // стока розрахована не на перший хід гри, після першого ходу ця строка очищяє вікно вибору опонента
            label_winbox.Text = "..."; // вводимо текст у контекстну строку
            FirstPlayerChoice = 2; // ініціалізуємо змінну вибору ігрока на 2(бумага)
        }
        // метод кнопки вибору ножиць
        private void but_scissors_Click(object sender, EventArgs e)
        {
            pictureBox_your_choice.Image = Image.FromFile(pathtohandscissors); // відображаємо вибір у вікні вибору
            pictureBox_your_choice.SizeMode = PictureBoxSizeMode.CenterImage; // централізуємо картинку у PictureBox
            pictureBox_partner_choice.Image = null; // стока розрахована не на перший хід гри, після першого ходу ця строка очищяє вікно вибору опонента
            label_winbox.Text = "..."; // вводимо текст у контекстну строку
            FirstPlayerChoice = 3; // ініціалізуємо змінну вибору ігрока на 3(ножиці)
        }
        // метод кнопкі підтвердження вибору ігрока людини та кнопка вибору та реалізації ігрока комп'ютера
        private void but_confirm_Click(object sender, EventArgs e)
        {
            int rps_PartnerChoice = bot_choice(1, 4); // створюємо змінну методу рандомного вибору числа від 1 до 4(не включно)
            // якщо випадає 1 то вибір комп'ютера камень, якщо випадає 2 то вибір бумага, якщо випадає 3 то вибір ножиці
            // 1 = rock, 2 = paper, 3 = scissors
            if (rps_PartnerChoice == 1)
            {
                pictureBox_partner_choice.Image = Image.FromFile(pathtohandrock);
                pictureBox_partner_choice.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else if (rps_PartnerChoice == 2)
            {
                pictureBox_partner_choice.Image = Image.FromFile(pathtohandpaper);
                pictureBox_partner_choice.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else if (rps_PartnerChoice == 3)
            {
                pictureBox_partner_choice.Image = Image.FromFile(pathtohandscissors);
                pictureBox_partner_choice.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            // обираємо переможця перебравши усі можливі комбінації Камень-Ножиці-Бумага 
            // 1 = rock, 2 = paper, 3 = scissors
            if ((FirstPlayerChoice == 1 && rps_PartnerChoice == 3) ||
                (FirstPlayerChoice == 2 && rps_PartnerChoice == 1) ||
                (FirstPlayerChoice == 3 && rps_PartnerChoice == 2))
            {
                label_winbox.Text = "You Win!";
            }
            else if ((FirstPlayerChoice == 1 && rps_PartnerChoice == 2) ||
                     (FirstPlayerChoice == 2 && rps_PartnerChoice == 3) ||
                     (FirstPlayerChoice == 3 && rps_PartnerChoice == 1))
            {
                label_winbox.Text = "You Lost :(";
            }
            else if ((FirstPlayerChoice == 1 && rps_PartnerChoice == 1) ||
                     (FirstPlayerChoice == 2 && rps_PartnerChoice == 2) ||
                     (FirstPlayerChoice == 3 && rps_PartnerChoice == 3))
            {
                label_winbox.Text = "Draw";
            }
        }
        // метод рандомного вибору ігрока комп'ютера
        public int bot_choice(int a, int b)
        {
            Random r = new Random(); // створюємо змінну класу рандомних чисел
            return r.Next(a, b); // повертаємо значення методу як рандомний вибір числа від а до b
        }
    }
}
