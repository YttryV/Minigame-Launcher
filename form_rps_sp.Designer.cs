namespace Minigame_Launcher
{
    partial class form_rps_sp
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_rps_sp));
            but_rock = new Button();
            but_paper = new Button();
            but_scissors = new Button();
            pictureBox_your_choice = new PictureBox();
            pictureBox_partner_choice = new PictureBox();
            but_confirm = new Button();
            label_winbox = new Label();
            label_partner_choice = new Label();
            label_your_choice = new Label();
            label_make_your_choice = new Label();
            but_back = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox_your_choice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_partner_choice).BeginInit();
            SuspendLayout();
            // 
            // but_rock
            // 
            but_rock.BackColor = Color.FromArgb(190, 190, 190);
            but_rock.BackgroundImageLayout = ImageLayout.Center;
            but_rock.Image = (Image)resources.GetObject("but_rock.Image");
            but_rock.Location = new Point(125, 400);
            but_rock.Name = "but_rock";
            but_rock.Size = new Size(70, 70);
            but_rock.TabIndex = 0;
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
            but_paper.TabIndex = 1;
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
            but_scissors.TabIndex = 2;
            but_scissors.UseVisualStyleBackColor = false;
            but_scissors.Click += but_scissors_Click;
            // 
            // pictureBox_your_choice
            // 
            pictureBox_your_choice.BorderStyle = BorderStyle.FixedSingle;
            pictureBox_your_choice.Location = new Point(215, 210);
            pictureBox_your_choice.Name = "pictureBox_your_choice";
            pictureBox_your_choice.Size = new Size(140, 140);
            pictureBox_your_choice.TabIndex = 5;
            pictureBox_your_choice.TabStop = false;
            // 
            // pictureBox_partner_choice
            // 
            pictureBox_partner_choice.BorderStyle = BorderStyle.FixedSingle;
            pictureBox_partner_choice.Location = new Point(215, 50);
            pictureBox_partner_choice.Name = "pictureBox_partner_choice";
            pictureBox_partner_choice.Size = new Size(140, 140);
            pictureBox_partner_choice.TabIndex = 6;
            pictureBox_partner_choice.TabStop = false;
            // 
            // but_confirm
            // 
            but_confirm.BackColor = Color.FromArgb(190, 190, 190);
            but_confirm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            but_confirm.Location = new Point(361, 257);
            but_confirm.Name = "but_confirm";
            but_confirm.Size = new Size(105, 50);
            but_confirm.TabIndex = 9;
            but_confirm.Text = "Confirm choice";
            but_confirm.UseVisualStyleBackColor = false;
            but_confirm.Click += but_confirm_Click;
            // 
            // label_winbox
            // 
            label_winbox.AutoSize = true;
            label_winbox.BackColor = Color.FromArgb(190, 190, 190);
            label_winbox.BorderStyle = BorderStyle.FixedSingle;
            label_winbox.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label_winbox.Location = new Point(361, 142);
            label_winbox.Name = "label_winbox";
            label_winbox.Size = new Size(144, 47);
            label_winbox.TabIndex = 10;
            label_winbox.Text = "First Try";
            label_winbox.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_partner_choice
            // 
            label_partner_choice.BackColor = Color.FromArgb(190, 190, 190);
            label_partner_choice.BorderStyle = BorderStyle.FixedSingle;
            label_partner_choice.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_partner_choice.Location = new Point(104, 109);
            label_partner_choice.Name = "label_partner_choice";
            label_partner_choice.Size = new Size(105, 23);
            label_partner_choice.TabIndex = 11;
            label_partner_choice.Text = "Partner choice";
            label_partner_choice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_your_choice
            // 
            label_your_choice.BackColor = Color.FromArgb(190, 190, 190);
            label_your_choice.BorderStyle = BorderStyle.FixedSingle;
            label_your_choice.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_your_choice.Location = new Point(104, 272);
            label_your_choice.Name = "label_your_choice";
            label_your_choice.Size = new Size(105, 23);
            label_your_choice.TabIndex = 12;
            label_your_choice.Text = "Your choice";
            label_your_choice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_make_your_choice
            // 
            label_make_your_choice.BackColor = Color.FromArgb(190, 190, 190);
            label_make_your_choice.BorderStyle = BorderStyle.FixedSingle;
            label_make_your_choice.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_make_your_choice.Location = new Point(228, 365);
            label_make_your_choice.Name = "label_make_your_choice";
            label_make_your_choice.Size = new Size(112, 20);
            label_make_your_choice.TabIndex = 13;
            label_make_your_choice.Text = "Make your choice";
            label_make_your_choice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // but_back
            // 
            but_back.BackColor = Color.FromArgb(190, 190, 190);
            but_back.BackgroundImageLayout = ImageLayout.Center;
            but_back.Image = (Image)resources.GetObject("but_back.Image");
            but_back.Location = new Point(10, 10);
            but_back.Name = "but_back";
            but_back.Size = new Size(50, 50);
            but_back.TabIndex = 14;
            but_back.UseVisualStyleBackColor = false;
            but_back.Click += but_back_Click;
            // 
            // form_rps_sp
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.FromArgb(175, 198, 201);
            ClientSize = new Size(554, 511);
            Controls.Add(but_back);
            Controls.Add(label_make_your_choice);
            Controls.Add(label_your_choice);
            Controls.Add(label_partner_choice);
            Controls.Add(label_winbox);
            Controls.Add(but_confirm);
            Controls.Add(pictureBox_partner_choice);
            Controls.Add(pictureBox_your_choice);
            Controls.Add(but_scissors);
            Controls.Add(but_paper);
            Controls.Add(but_rock);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "form_rps_sp";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rock-Paper-Scissors";
            KeyDown += form_rps_sp_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox_your_choice).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_partner_choice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button but_rock;
        private Button but_paper;
        private Button but_scissors;
        private Button but_confirm;
        private PictureBox pictureBox_your_choice;
        private PictureBox pictureBox_partner_choice;
        private Label label_winbox;
        private Label label_partner_choice;
        private Label label_your_choice;
        private Label label_make_your_choice;
        private Button but_back;
    }
}