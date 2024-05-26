namespace Minigame_Launcher
{
    partial class form_rps_mp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_rps_mp));
            but_back = new Button();
            but_rock = new Button();
            but_paper = new Button();
            but_scissors = new Button();
            but_confirm = new Button();
            label_make_your_choice = new Label();
            pictureBox_your_choice = new PictureBox();
            label_winbox = new Label();
            pictureBox_second_player = new PictureBox();
            pictureBox_first_player = new PictureBox();
            label_what_player_try = new Label();
            label_first_player_choice = new Label();
            label_second_player_choice = new Label();
            lable_rps = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox_your_choice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_second_player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_first_player).BeginInit();
            SuspendLayout();
            // 
            // but_back
            // 
            but_back.BackColor = Color.FromArgb(190, 190, 190);
            but_back.BackgroundImageLayout = ImageLayout.Center;
            but_back.Image = (Image)resources.GetObject("but_back.Image");
            but_back.Location = new Point(10, 10);
            but_back.Name = "but_back";
            but_back.Size = new Size(50, 50);
            but_back.TabIndex = 15;
            but_back.UseVisualStyleBackColor = false;
            but_back.Click += but_back_Click;
            // 
            // but_rock
            // 
            but_rock.BackColor = Color.FromArgb(190, 190, 190);
            but_rock.BackgroundImageLayout = ImageLayout.Center;
            but_rock.Image = (Image)resources.GetObject("but_rock.Image");
            but_rock.Location = new Point(125, 400);
            but_rock.Name = "but_rock";
            but_rock.Size = new Size(70, 70);
            but_rock.TabIndex = 16;
            but_rock.UseVisualStyleBackColor = false;
            but_rock.Click += but_rock_Click;
            // 
            // but_paper
            // 
            but_paper.BackColor = Color.FromArgb(190, 190, 190);
            but_paper.BackgroundImageLayout = ImageLayout.Center;
            but_paper.Image = (Image)resources.GetObject("but_paper.Image");
            but_paper.Location = new Point(250, 400);
            but_paper.Name = "but_paper";
            but_paper.Size = new Size(70, 70);
            but_paper.TabIndex = 17;
            but_paper.UseVisualStyleBackColor = false;
            but_paper.Click += but_paper_Click;
            // 
            // but_scissors
            // 
            but_scissors.BackColor = Color.FromArgb(190, 190, 190);
            but_scissors.BackgroundImageLayout = ImageLayout.Center;
            but_scissors.Image = (Image)resources.GetObject("but_scissors.Image");
            but_scissors.Location = new Point(375, 400);
            but_scissors.Name = "but_scissors";
            but_scissors.Size = new Size(70, 70);
            but_scissors.TabIndex = 18;
            but_scissors.UseVisualStyleBackColor = false;
            but_scissors.Click += but_scissors_Click;
            // 
            // but_confirm
            // 
            but_confirm.BackColor = Color.FromArgb(190, 190, 190);
            but_confirm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            but_confirm.Location = new Point(234, 312);
            but_confirm.Name = "but_confirm";
            but_confirm.Size = new Size(105, 50);
            but_confirm.TabIndex = 19;
            but_confirm.Text = "Confirm choice";
            but_confirm.UseVisualStyleBackColor = false;
            but_confirm.Click += but_confirm_Click;
            // 
            // label_make_your_choice
            // 
            label_make_your_choice.BackColor = Color.FromArgb(190, 190, 190);
            label_make_your_choice.BorderStyle = BorderStyle.FixedSingle;
            label_make_your_choice.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_make_your_choice.Location = new Point(228, 365);
            label_make_your_choice.Name = "label_make_your_choice";
            label_make_your_choice.Size = new Size(112, 20);
            label_make_your_choice.TabIndex = 20;
            label_make_your_choice.Text = "Make your choice";
            label_make_your_choice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox_your_choice
            // 
            pictureBox_your_choice.BorderStyle = BorderStyle.FixedSingle;
            pictureBox_your_choice.Location = new Point(215, 155);
            pictureBox_your_choice.Name = "pictureBox_your_choice";
            pictureBox_your_choice.Size = new Size(140, 140);
            pictureBox_your_choice.TabIndex = 21;
            pictureBox_your_choice.TabStop = false;
            // 
            // label_winbox
            // 
            label_winbox.AutoSize = true;
            label_winbox.BackColor = Color.FromArgb(190, 190, 190);
            label_winbox.BorderStyle = BorderStyle.FixedSingle;
            label_winbox.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label_winbox.Location = new Point(358, 155);
            label_winbox.Name = "label_winbox";
            label_winbox.Size = new Size(177, 66);
            label_winbox.TabIndex = 22;
            label_winbox.Text = "Second Player\r\nWin";
            label_winbox.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox_second_player
            // 
            pictureBox_second_player.BorderStyle = BorderStyle.FixedSingle;
            pictureBox_second_player.Location = new Point(140, 155);
            pictureBox_second_player.Name = "pictureBox_second_player";
            pictureBox_second_player.Size = new Size(69, 69);
            pictureBox_second_player.TabIndex = 23;
            pictureBox_second_player.TabStop = false;
            // 
            // pictureBox_first_player
            // 
            pictureBox_first_player.BorderStyle = BorderStyle.FixedSingle;
            pictureBox_first_player.Location = new Point(140, 226);
            pictureBox_first_player.Name = "pictureBox_first_player";
            pictureBox_first_player.Size = new Size(69, 69);
            pictureBox_first_player.TabIndex = 24;
            pictureBox_first_player.TabStop = false;
            // 
            // label_what_player_try
            // 
            label_what_player_try.AutoSize = true;
            label_what_player_try.BackColor = Color.FromArgb(190, 190, 190);
            label_what_player_try.BorderStyle = BorderStyle.FixedSingle;
            label_what_player_try.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label_what_player_try.Location = new Point(358, 229);
            label_what_player_try.Name = "label_what_player_try";
            label_what_player_try.Size = new Size(177, 66);
            label_what_player_try.TabIndex = 25;
            label_what_player_try.Text = "Second Player\r\nTry";
            label_what_player_try.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_first_player_choice
            // 
            label_first_player_choice.BackColor = Color.FromArgb(190, 190, 190);
            label_first_player_choice.BorderStyle = BorderStyle.FixedSingle;
            label_first_player_choice.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_first_player_choice.Location = new Point(47, 226);
            label_first_player_choice.Name = "label_first_player_choice";
            label_first_player_choice.Size = new Size(87, 35);
            label_first_player_choice.TabIndex = 26;
            label_first_player_choice.Text = "First Player\r\nChoice";
            label_first_player_choice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_second_player_choice
            // 
            label_second_player_choice.BackColor = Color.FromArgb(190, 190, 190);
            label_second_player_choice.BorderStyle = BorderStyle.FixedSingle;
            label_second_player_choice.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_second_player_choice.Location = new Point(47, 189);
            label_second_player_choice.Name = "label_second_player_choice";
            label_second_player_choice.Size = new Size(87, 35);
            label_second_player_choice.TabIndex = 27;
            label_second_player_choice.Text = "Second Player\r\nChoice";
            label_second_player_choice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lable_rps
            // 
            lable_rps.AutoSize = true;
            lable_rps.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lable_rps.Location = new Point(182, 75);
            lable_rps.Name = "lable_rps";
            lable_rps.Size = new Size(191, 25);
            lable_rps.TabIndex = 28;
            lable_rps.Text = "Rock-Paper-Scissors";
            // 
            // form_rps_mp
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(175, 198, 201);
            ClientSize = new Size(554, 511);
            Controls.Add(lable_rps);
            Controls.Add(label_second_player_choice);
            Controls.Add(label_first_player_choice);
            Controls.Add(label_what_player_try);
            Controls.Add(pictureBox_first_player);
            Controls.Add(pictureBox_second_player);
            Controls.Add(label_winbox);
            Controls.Add(pictureBox_your_choice);
            Controls.Add(label_make_your_choice);
            Controls.Add(but_confirm);
            Controls.Add(but_scissors);
            Controls.Add(but_paper);
            Controls.Add(but_rock);
            Controls.Add(but_back);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "form_rps_mp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ч";
            KeyDown += form_rps_mp_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox_your_choice).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_second_player).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_first_player).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button but_back;
        private Button but_rock;
        private Button but_paper;
        private Button but_scissors;
        private Button but_confirm;
        private Label label_make_your_choice;
        private PictureBox pictureBox_your_choice;
        private Label label_winbox;
        private PictureBox pictureBox_second_player;
        private PictureBox pictureBox_first_player;
        private Label label_what_player_try;
        private Label label_first_player_choice;
        private Label label_second_player_choice;
        private Label lable_rps;
    }
}