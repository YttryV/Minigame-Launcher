namespace Minigame_Launcher
{
    partial class form_rps
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_rps));
            but_start_sp = new Button();
            but_start_mp = new Button();
            but_back = new Button();
            lable_rps = new Label();
            SuspendLayout();
            // 
            // but_start_sp
            // 
            but_start_sp.BackColor = Color.FromArgb(190, 190, 190);
            but_start_sp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            but_start_sp.Location = new Point(70, 300);
            but_start_sp.Name = "but_start_sp";
            but_start_sp.Size = new Size(130, 50);
            but_start_sp.TabIndex = 0;
            but_start_sp.Text = "Singleplayer";
            but_start_sp.UseVisualStyleBackColor = false;
            but_start_sp.Click += but_start_sp_Click;
            // 
            // but_start_mp
            // 
            but_start_mp.BackColor = Color.FromArgb(190, 190, 190);
            but_start_mp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            but_start_mp.Location = new Point(270, 300);
            but_start_mp.Name = "but_start_mp";
            but_start_mp.Size = new Size(130, 50);
            but_start_mp.TabIndex = 1;
            but_start_mp.Text = "Multiplayer";
            but_start_mp.UseVisualStyleBackColor = false;
            but_start_mp.Click += but_start_mp_Click;
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
            // lable_rps
            // 
            lable_rps.AutoSize = true;
            lable_rps.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lable_rps.Location = new Point(136, 100);
            lable_rps.Name = "lable_rps";
            lable_rps.Size = new Size(191, 25);
            lable_rps.TabIndex = 16;
            lable_rps.Text = "Rock-Paper-Scissors";
            // 
            // form_rps
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(175, 198, 201);
            ClientSize = new Size(469, 411);
            Controls.Add(lable_rps);
            Controls.Add(but_back);
            Controls.Add(but_start_mp);
            Controls.Add(but_start_sp);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "form_rps";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rock-Paper-Scissors";
            KeyDown += form_rps_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button but_start_sp;
        private Button but_start_mp;
        private Button but_back;
        private Label lable_rps;
    }
}