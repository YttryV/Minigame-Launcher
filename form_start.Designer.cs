namespace Minigame_Launcher
{
    partial class form_start
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_start));
            but_rps_start = new Button();
            but_ttt_start = new Button();
            lable_app_name = new Label();
            but_exit = new Button();
            SuspendLayout();
            // 
            // but_rps_start
            // 
            but_rps_start.BackColor = Color.FromArgb(190, 190, 190);
            but_rps_start.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            but_rps_start.Location = new Point(70, 300);
            but_rps_start.Name = "but_rps_start";
            but_rps_start.Size = new Size(130, 50);
            but_rps_start.TabIndex = 0;
            but_rps_start.Text = "Rock-Paper-Scissors";
            but_rps_start.UseVisualStyleBackColor = false;
            but_rps_start.Click += but_rps_start_Click;
            // 
            // but_ttt_start
            // 
            but_ttt_start.BackColor = Color.FromArgb(190, 190, 190);
            but_ttt_start.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            but_ttt_start.Location = new Point(270, 300);
            but_ttt_start.Name = "but_ttt_start";
            but_ttt_start.Size = new Size(130, 50);
            but_ttt_start.TabIndex = 1;
            but_ttt_start.Text = "Tic-Tac-Toe";
            but_ttt_start.UseVisualStyleBackColor = false;
            but_ttt_start.Click += but_ttt_start_Click;
            // 
            // lable_app_name
            // 
            lable_app_name.AutoSize = true;
            lable_app_name.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lable_app_name.Location = new Point(141, 100);
            lable_app_name.Name = "lable_app_name";
            lable_app_name.Size = new Size(188, 25);
            lable_app_name.TabIndex = 2;
            lable_app_name.Text = "Minigame Launcher";
            // 
            // but_exit
            // 
            but_exit.BackColor = Color.FromArgb(190, 190, 190);
            but_exit.BackgroundImageLayout = ImageLayout.Center;
            but_exit.Image = (Image)resources.GetObject("but_exit.Image");
            but_exit.Location = new Point(427, 10);
            but_exit.Name = "but_exit";
            but_exit.Size = new Size(32, 32);
            but_exit.TabIndex = 16;
            but_exit.UseVisualStyleBackColor = false;
            but_exit.Click += but_exit_Click;
            // 
            // form_start
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(175, 198, 201);
            ClientSize = new Size(469, 411);
            Controls.Add(but_exit);
            Controls.Add(lable_app_name);
            Controls.Add(but_ttt_start);
            Controls.Add(but_rps_start);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "form_start";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Minigame Launcher";
            KeyDown += form_start_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button but_rps_start;
        private Button but_ttt_start;
        private Label lable_app_name;
        private Button but_exit;
    }
}