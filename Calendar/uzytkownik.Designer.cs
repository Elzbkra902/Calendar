
namespace Calendar
{
    partial class uzytkownik
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
            this.listaKalendarzy = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.czyNowy = new System.Windows.Forms.CheckBox();
            this.imiePupila = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.zatwierdz = new System.Windows.Forms.Button();
            this.zapiszZamknij = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(143, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 45);
            this.label1.TabIndex = 21;
            this.label1.Text = "Witaj!";
            // 
            // listaKalendarzy
            // 
            this.listaKalendarzy.FormattingEnabled = true;
            this.listaKalendarzy.Location = new System.Drawing.Point(56, 90);
            this.listaKalendarzy.Name = "listaKalendarzy";
            this.listaKalendarzy.Size = new System.Drawing.Size(302, 21);
            this.listaKalendarzy.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Wybierz istniejący kalendarz";
            // 
            // czyNowy
            // 
            this.czyNowy.AutoSize = true;
            this.czyNowy.Location = new System.Drawing.Point(56, 134);
            this.czyNowy.Name = "czyNowy";
            this.czyNowy.Size = new System.Drawing.Size(131, 17);
            this.czyNowy.TabIndex = 25;
            this.czyNowy.Text = "Dodaj nowy kalendarz";
            this.czyNowy.UseVisualStyleBackColor = true;
            this.czyNowy.CheckedChanged += new System.EventHandler(this.czyNowy_CheckedChanged);
            // 
            // imiePupila
            // 
            this.imiePupila.Location = new System.Drawing.Point(132, 171);
            this.imiePupila.Name = "imiePupila";
            this.imiePupila.Size = new System.Drawing.Size(226, 20);
            this.imiePupila.TabIndex = 26;
            this.imiePupila.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Imię pupila";
            this.label3.Visible = false;
            // 
            // zatwierdz
            // 
            this.zatwierdz.ForeColor = System.Drawing.Color.LightSalmon;
            this.zatwierdz.Location = new System.Drawing.Point(283, 199);
            this.zatwierdz.Name = "zatwierdz";
            this.zatwierdz.Size = new System.Drawing.Size(75, 23);
            this.zatwierdz.TabIndex = 28;
            this.zatwierdz.Text = "Zatwierdź";
            this.zatwierdz.UseVisualStyleBackColor = true;
            this.zatwierdz.Visible = false;
            this.zatwierdz.Click += new System.EventHandler(this.zatwierdz_Click);
            // 
            // zapiszZamknij
            // 
            this.zapiszZamknij.ForeColor = System.Drawing.Color.LightSalmon;
            this.zapiszZamknij.Location = new System.Drawing.Point(56, 252);
            this.zapiszZamknij.Name = "zapiszZamknij";
            this.zapiszZamknij.Size = new System.Drawing.Size(302, 23);
            this.zapiszZamknij.TabIndex = 29;
            this.zapiszZamknij.Text = "Zapisz i zamknij";
            this.zapiszZamknij.UseVisualStyleBackColor = true;
            this.zapiszZamknij.Click += new System.EventHandler(this.zapiszZamknij_Click);
            // 
            // uzytkownik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.BackgroundImage = global::Calendar.Properties.Resources.paws;
            this.ClientSize = new System.Drawing.Size(407, 287);
            this.Controls.Add(this.zapiszZamknij);
            this.Controls.Add(this.zatwierdz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.imiePupila);
            this.Controls.Add(this.czyNowy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listaKalendarzy);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "uzytkownik";
            this.Text = "uzytkownik";
            this.Load += new System.EventHandler(this.uzytkownik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox listaKalendarzy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox czyNowy;
        private System.Windows.Forms.TextBox imiePupila;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button zatwierdz;
        private System.Windows.Forms.Button zapiszZamknij;
    }
}