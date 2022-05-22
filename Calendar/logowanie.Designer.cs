
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
            this.PassTBox.Size = new System.Drawing.Size(216, 20);
            this.PassTBox.TabIndex = 1;
            // 
            // LoginLBL
            // 
            this.LoginLBL.AutoSize = true;
            this.LoginLBL.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
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
            this.HasloLBL.Location = new System.Drawing.Point(11, 106);
            this.HasloLBL.Name = "HasloLBL";
            this.HasloLBL.Size = new System.Drawing.Size(79, 30);
            this.HasloLBL.TabIndex = 3;
            this.HasloLBL.Text = "Hasło";
            // 
            // RejestrBtn
            // 
            this.RejestrBtn.Location = new System.Drawing.Point(104, 187);
            this.RejestrBtn.Name = "RejestrBtn";
            this.RejestrBtn.Size = new System.Drawing.Size(97, 23);
            this.RejestrBtn.TabIndex = 4;
            this.RejestrBtn.Text = "Zarejestruj";
            this.RejestrBtn.UseVisualStyleBackColor = true;
            // 
            // LogInBUT
            // 
            this.LogInBUT.Location = new System.Drawing.Point(223, 187);
            this.LogInBUT.Name = "LogInBUT";
            this.LogInBUT.Size = new System.Drawing.Size(97, 23);
            this.LogInBUT.TabIndex = 5;
            this.LogInBUT.Text = "Zaloguj";
            this.LogInBUT.UseVisualStyleBackColor = true;
            // 
            // logowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 226);
            this.Controls.Add(this.LogInBUT);
            this.Controls.Add(this.RejestrBtn);
            this.Controls.Add(this.HasloLBL);
            this.Controls.Add(this.LoginLBL);
            this.Controls.Add(this.PassTBox);
            this.Controls.Add(this.UserNameTBox);
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
    }
}