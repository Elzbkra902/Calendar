
namespace Calendar
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btnnext;
            System.Windows.Forms.Button btnprev;
            System.Windows.Forms.Button ZamknjiBtn;
            this.daycontainer = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LBdate = new System.Windows.Forms.Label();
            btnnext = new System.Windows.Forms.Button();
            btnprev = new System.Windows.Forms.Button();
            ZamknjiBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // daycontainer
            // 
            this.daycontainer.BackgroundImage = global::Calendar.Properties.Resources.paws;
            this.daycontainer.Location = new System.Drawing.Point(12, 91);
            this.daycontainer.Name = "daycontainer";
            this.daycontainer.Size = new System.Drawing.Size(770, 408);
            this.daycontainer.TabIndex = 0;
            // 
            // btnnext
            // 
            btnnext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            btnnext.ForeColor = System.Drawing.Color.LightSalmon;
            btnnext.Location = new System.Drawing.Point(667, 505);
            btnnext.Name = "btnnext";
            btnnext.Size = new System.Drawing.Size(115, 23);
            btnnext.TabIndex = 1;
            btnnext.Text = "Następny";
            btnnext.UseVisualStyleBackColor = true;
            btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnprev
            // 
            btnprev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            btnprev.ForeColor = System.Drawing.Color.LightSalmon;
            btnprev.Location = new System.Drawing.Point(12, 505);
            btnprev.Name = "btnprev";
            btnprev.Size = new System.Drawing.Size(115, 23);
            btnprev.TabIndex = 2;
            btnprev.Text = "Poprzedni";
            btnprev.UseVisualStyleBackColor = true;
            btnprev.Click += new System.EventHandler(this.btnprev_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(19, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Poniedziałek";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(147, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Wtorek";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(357, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Czwartek";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(260, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Środa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(591, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sobota";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(477, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Piątek";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(686, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 19);
            this.label8.TabIndex = 9;
            this.label8.Text = "Niedziela";
            // 
            // LBdate
            // 
            this.LBdate.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LBdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LBdate.Location = new System.Drawing.Point(264, 19);
            this.LBdate.Name = "LBdate";
            this.LBdate.Size = new System.Drawing.Size(264, 38);
            this.LBdate.TabIndex = 10;
            this.LBdate.Text = "MONTH YEAR";
            this.LBdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ZamknjiBtn
            // 
            ZamknjiBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            ZamknjiBtn.ForeColor = System.Drawing.Color.LightSalmon;
            ZamknjiBtn.Location = new System.Drawing.Point(361, 505);
            ZamknjiBtn.Name = "ZamknjiBtn";
            ZamknjiBtn.Size = new System.Drawing.Size(115, 23);
            ZamknjiBtn.TabIndex = 12;
            ZamknjiBtn.Text = "Zamknij";
            ZamknjiBtn.UseVisualStyleBackColor = true;
            ZamknjiBtn.Click += new System.EventHandler(this.ZamknjiBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(793, 538);
            this.Controls.Add(ZamknjiBtn);
            this.Controls.Add(this.LBdate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(btnprev);
            this.Controls.Add(btnnext);
            this.Controls.Add(this.daycontainer);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel daycontainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LBdate;
    }
}

