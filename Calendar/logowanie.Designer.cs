
namespace Calendar
{
    partial class logowanie
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
            this.UserNameTBox = new System.Windows.Forms.TextBox();
            this.PassTBox = new System.Windows.Forms.TextBox();
            this.LoginLBL = new System.Windows.Forms.Label();
            this.HasloLBL = new System.Windows.Forms.Label();
            this.RejestrBtn = new System.Windows.Forms.Button();
            this.LogInBUT = new System.Windows.Forms.Button();
            this.ZamknjiBtn = new System.Windows.Forms.Button();
            this.pokaz = new System.Windows.Forms.Button();
            this.ukryj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UserNameTBox
            // 
            this.UserNameTBox.Location = new System.Drawing.Point(104, 62);
            this.UserNameTBox.Name = "UserNameTBox";
            this.UserNameTBox.Size = new System.Drawing.Size(216, 20);
            this.UserNameTBox.TabIndex = 0;
            // 
            // PassTBox
            // 
            this.PassTBox.Location = new System.Drawing.Point(104, 115);
            this.PassTBox.Name = "PassTBox";
            this.PassTBox.PasswordChar = '*';
            this.PassTBox.Size = new System.Drawing.Size(179, 20);
            this.PassTBox.TabIndex = 1;
            // 
            // LoginLBL
            // 
            this.LoginLBL.AutoSize = true;
            this.LoginLBL.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LoginLBL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoginLBL.Location = new System.Drawing.Point(11, 53);
            this.LoginLBL.Name = "LoginLBL";
            this.LoginLBL.Size = new System.Drawing.Size(76, 30);
            this.LoginLBL.TabIndex = 2;
            this.LoginLBL.Text = "Login";
            // 
            // HasloLBL
            // 
            this.HasloLBL.AutoSize = true;
            this.HasloLBL.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HasloLBL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HasloLBL.Location = new System.Drawing.Point(11, 106);
            this.HasloLBL.Name = "HasloLBL";
            this.HasloLBL.Size = new System.Drawing.Size(79, 30);
            this.HasloLBL.TabIndex = 3;
            this.HasloLBL.Text = "Hasło";
            // 
            // RejestrBtn
            // 
            this.RejestrBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RejestrBtn.ForeColor = System.Drawing.Color.LightSalmon;
            this.RejestrBtn.Location = new System.Drawing.Point(128, 187);
            this.RejestrBtn.Name = "RejestrBtn";
            this.RejestrBtn.Size = new System.Drawing.Size(97, 23);
            this.RejestrBtn.TabIndex = 4;
            this.RejestrBtn.Text = "Zarejestruj";
            this.RejestrBtn.UseVisualStyleBackColor = true;
            this.RejestrBtn.Click += new System.EventHandler(this.RejestrBtn_Click);
            // 
            // LogInBUT
            // 
            this.LogInBUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LogInBUT.ForeColor = System.Drawing.Color.LightSalmon;
            this.LogInBUT.Location = new System.Drawing.Point(244, 187);
            this.LogInBUT.Name = "LogInBUT";
            this.LogInBUT.Size = new System.Drawing.Size(97, 23);
            this.LogInBUT.TabIndex = 5;
            this.LogInBUT.Text = "Zaloguj";
            this.LogInBUT.UseVisualStyleBackColor = true;
            this.LogInBUT.Click += new System.EventHandler(this.LogInBUT_Click);
            // 
            // ZamknjiBtn
            // 
            this.ZamknjiBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ZamknjiBtn.ForeColor = System.Drawing.Color.LightSalmon;
            this.ZamknjiBtn.Location = new System.Drawing.Point(12, 187);
            this.ZamknjiBtn.Name = "ZamknjiBtn";
            this.ZamknjiBtn.Size = new System.Drawing.Size(97, 23);
            this.ZamknjiBtn.TabIndex = 13;
            this.ZamknjiBtn.Text = "Zamknij";
            this.ZamknjiBtn.UseVisualStyleBackColor = true;
            this.ZamknjiBtn.Click += new System.EventHandler(this.ZamknjiBtn_Click);
            // 
            // pokaz
            // 
            this.pokaz.Image = global::Calendar.Properties.Resources.otwarte;
            this.pokaz.Location = new System.Drawing.Point(291, 108);
            this.pokaz.Name = "pokaz";
            this.pokaz.Size = new System.Drawing.Size(30, 30);
            this.pokaz.TabIndex = 18;
            this.pokaz.UseVisualStyleBackColor = true;
            this.pokaz.Click += new System.EventHandler(this.pokaz_Click);
            // 
            // ukryj
            // 
            this.ukryj.Image = global::Calendar.Properties.Resources.zamkniete;
            this.ukryj.Location = new System.Drawing.Point(291, 108);
            this.ukryj.Name = "ukryj";
            this.ukryj.Size = new System.Drawing.Size(30, 30);
            this.ukryj.TabIndex = 19;
            this.ukryj.UseVisualStyleBackColor = true;
            this.ukryj.Click += new System.EventHandler(this.ukryj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(60, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 45);
            this.label1.TabIndex = 20;
            this.label1.Text = "Zaloguj się!";
            // 
            // logowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.BackgroundImage = global::Calendar.Properties.Resources.paws;
            this.ClientSize = new System.Drawing.Size(359, 226);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pokaz);
            this.Controls.Add(this.ukryj);
            this.Controls.Add(this.ZamknjiBtn);
            this.Controls.Add(this.LogInBUT);
            this.Controls.Add(this.RejestrBtn);
            this.Controls.Add(this.HasloLBL);
            this.Controls.Add(this.LoginLBL);
            this.Controls.Add(this.PassTBox);
            this.Controls.Add(this.UserNameTBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "logowanie";
            this.Text = "logowanie";
            this.Load += new System.EventHandler(this.logowanie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserNameTBox;
        private System.Windows.Forms.TextBox PassTBox;
        private System.Windows.Forms.Label LoginLBL;
        private System.Windows.Forms.Label HasloLBL;
        private System.Windows.Forms.Button RejestrBtn;
        private System.Windows.Forms.Button LogInBUT;
        private System.Windows.Forms.Button ZamknjiBtn;
        private System.Windows.Forms.Button pokaz;
        private System.Windows.Forms.Button ukryj;
        private System.Windows.Forms.Label label1;
    }
}