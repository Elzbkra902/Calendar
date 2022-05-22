
namespace Calendar
{
    partial class Rejestracja
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
            this.RejestrBtn = new System.Windows.Forms.Button();
            this.HasloLBL = new System.Windows.Forms.Label();
            this.LoginLBL = new System.Windows.Forms.Label();
            this.PassTBox = new System.Windows.Forms.TextBox();
            this.UserNameTBox = new System.Windows.Forms.TextBox();
            this.emailBOX = new System.Windows.Forms.Label();
            this.mailTBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RejestrBtn
            // 
            this.RejestrBtn.Location = new System.Drawing.Point(123, 237);
            this.RejestrBtn.Name = "RejestrBtn";
            this.RejestrBtn.Size = new System.Drawing.Size(216, 23);
            this.RejestrBtn.TabIndex = 9;
            this.RejestrBtn.Text = "Zarejestruj";
            this.RejestrBtn.UseVisualStyleBackColor = true;
            this.RejestrBtn.Click += new System.EventHandler(this.RejestrBtn_Click);
            // 
            // HasloLBL
            // 
            this.HasloLBL.AutoSize = true;
            this.HasloLBL.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HasloLBL.Location = new System.Drawing.Point(30, 156);
            this.HasloLBL.Name = "HasloLBL";
            this.HasloLBL.Size = new System.Drawing.Size(79, 30);
            this.HasloLBL.TabIndex = 8;
            this.HasloLBL.Text = "Hasło";
            // 
            // LoginLBL
            // 
            this.LoginLBL.AutoSize = true;
            this.LoginLBL.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LoginLBL.Location = new System.Drawing.Point(30, 103);
            this.LoginLBL.Name = "LoginLBL";
            this.LoginLBL.Size = new System.Drawing.Size(76, 30);
            this.LoginLBL.TabIndex = 7;
            this.LoginLBL.Text = "Login";
            // 
            // PassTBox
            // 
            this.PassTBox.Location = new System.Drawing.Point(123, 165);
            this.PassTBox.Name = "PassTBox";
            this.PassTBox.Size = new System.Drawing.Size(216, 20);
            this.PassTBox.TabIndex = 6;
            // 
            // UserNameTBox
            // 
            this.UserNameTBox.Location = new System.Drawing.Point(123, 112);
            this.UserNameTBox.Name = "UserNameTBox";
            this.UserNameTBox.Size = new System.Drawing.Size(216, 20);
            this.UserNameTBox.TabIndex = 5;
            // 
            // emailBOX
            // 
            this.emailBOX.AutoSize = true;
            this.emailBOX.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.emailBOX.Location = new System.Drawing.Point(30, 53);
            this.emailBOX.Name = "emailBOX";
            this.emailBOX.Size = new System.Drawing.Size(83, 30);
            this.emailBOX.TabIndex = 11;
            this.emailBOX.Text = "e-mail";
            // 
            // mailTBox
            // 
            this.mailTBox.Location = new System.Drawing.Point(123, 62);
            this.mailTBox.Name = "mailTBox";
            this.mailTBox.Size = new System.Drawing.Size(216, 20);
            this.mailTBox.TabIndex = 10;
            // 
            // Rejestracja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 347);
            this.Controls.Add(this.emailBOX);
            this.Controls.Add(this.mailTBox);
            this.Controls.Add(this.RejestrBtn);
            this.Controls.Add(this.HasloLBL);
            this.Controls.Add(this.LoginLBL);
            this.Controls.Add(this.PassTBox);
            this.Controls.Add(this.UserNameTBox);
            this.Name = "Rejestracja";
            this.Text = "Rejestracja";
            this.Load += new System.EventHandler(this.Rejestracja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RejestrBtn;
        private System.Windows.Forms.Label HasloLBL;
        private System.Windows.Forms.Label LoginLBL;
        private System.Windows.Forms.TextBox PassTBox;
        private System.Windows.Forms.TextBox UserNameTBox;
        private System.Windows.Forms.Label emailBOX;
        private System.Windows.Forms.TextBox mailTBox;
    }
}