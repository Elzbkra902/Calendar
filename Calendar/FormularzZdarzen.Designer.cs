
namespace Calendar
{
    partial class FormularzZdarzen
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
            this.label1 = new System.Windows.Forms.Label();
            this.txDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txOpis = new System.Windows.Forms.TextBox();
            this.ZamknjiBtn = new System.Windows.Forms.Button();
            this.comboCzynnosc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data";
            // 
            // txDate
            // 
            this.txDate.Enabled = false;
            this.txDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txDate.Location = new System.Drawing.Point(55, 83);
            this.txDate.Name = "txDate";
            this.txDate.Size = new System.Drawing.Size(284, 26);
            this.txDate.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Czynność";
            // 
            // btnZapisz
            // 
            this.btnZapisz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZapisz.ForeColor = System.Drawing.Color.LightSalmon;
            this.btnZapisz.Location = new System.Drawing.Point(264, 336);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(75, 23);
            this.btnZapisz.TabIndex = 4;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Opis";
            // 
            // txOpis
            // 
            this.txOpis.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txOpis.Location = new System.Drawing.Point(55, 191);
            this.txOpis.Multiline = true;
            this.txOpis.Name = "txOpis";
            this.txOpis.Size = new System.Drawing.Size(284, 56);
            this.txOpis.TabIndex = 5;
            // 
            // ZamknjiBtn
            // 
            this.ZamknjiBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ZamknjiBtn.ForeColor = System.Drawing.Color.LightSalmon;
            this.ZamknjiBtn.Location = new System.Drawing.Point(55, 336);
            this.ZamknjiBtn.Name = "ZamknjiBtn";
            this.ZamknjiBtn.Size = new System.Drawing.Size(75, 23);
            this.ZamknjiBtn.TabIndex = 13;
            this.ZamknjiBtn.Text = "Zamknij";
            this.ZamknjiBtn.UseVisualStyleBackColor = true;
            this.ZamknjiBtn.Click += new System.EventHandler(this.ZamknjiBtn_Click);
            // 
            // comboCzynnosc
            // 
            this.comboCzynnosc.FormattingEnabled = true;
            this.comboCzynnosc.Items.AddRange(new object[] {
            "Karmienie",
            "Leki",
            "Czesanie",
            "Mycie",
            "Inne"});
            this.comboCzynnosc.Location = new System.Drawing.Point(55, 140);
            this.comboCzynnosc.Name = "comboCzynnosc";
            this.comboCzynnosc.Size = new System.Drawing.Size(284, 21);
            this.comboCzynnosc.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(13, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(373, 45);
            this.label4.TabIndex = 21;
            this.label4.Text = "Dodaj do kalendarza";
            // 
            // FormularzZdarzen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.BackgroundImage = global::Calendar.Properties.Resources.paws;
            this.ClientSize = new System.Drawing.Size(392, 388);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboCzynnosc);
            this.Controls.Add(this.ZamknjiBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txOpis);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txDate);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularzZdarzen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formularz Zdarzeń";
            this.Load += new System.EventHandler(this.FormularzZdarzen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txOpis;
        private System.Windows.Forms.Button ZamknjiBtn;
        private System.Windows.Forms.ComboBox comboCzynnosc;
        private System.Windows.Forms.Label label4;
    }
}