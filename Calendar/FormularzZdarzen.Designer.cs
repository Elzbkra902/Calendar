
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
            this.jakaKarma = new System.Windows.Forms.ComboBox();
            this.iloscKarmy = new System.Windows.Forms.TextBox();
            this.lblJaka = new System.Windows.Forms.Label();
            this.lblIle = new System.Windows.Forms.Label();
            this.lekLista = new System.Windows.Forms.ComboBox();
            this.lblLek = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.nowyLek = new System.Windows.Forms.TextBox();
            this.lblNowyLek = new System.Windows.Forms.Label();
            this.lblDawka = new System.Windows.Forms.Label();
            this.dawkaBox = new System.Windows.Forms.TextBox();
            this.czesanieCzekBox = new System.Windows.Forms.CheckedListBox();
            this.mycieCzekBox = new System.Windows.Forms.CheckedListBox();
            this.szampon = new System.Windows.Forms.ComboBox();
            this.odzywka = new System.Windows.Forms.ComboBox();
            this.szamponNazwa = new System.Windows.Forms.Label();
            this.odrzywkaNazwa = new System.Windows.Forms.Label();
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
            this.btnZapisz.Location = new System.Drawing.Point(264, 388);
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
            this.label3.Location = new System.Drawing.Point(52, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Opis";
            // 
            // txOpis
            // 
            this.txOpis.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txOpis.Location = new System.Drawing.Point(55, 312);
            this.txOpis.Multiline = true;
            this.txOpis.Name = "txOpis";
            this.txOpis.Size = new System.Drawing.Size(284, 56);
            this.txOpis.TabIndex = 5;
            // 
            // ZamknjiBtn
            // 
            this.ZamknjiBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ZamknjiBtn.ForeColor = System.Drawing.Color.LightSalmon;
            this.ZamknjiBtn.Location = new System.Drawing.Point(55, 388);
            this.ZamknjiBtn.Name = "ZamknjiBtn";
            this.ZamknjiBtn.Size = new System.Drawing.Size(75, 23);
            this.ZamknjiBtn.TabIndex = 13;
            this.ZamknjiBtn.Text = "Zamknij";
            this.ZamknjiBtn.UseVisualStyleBackColor = true;
            this.ZamknjiBtn.Click += new System.EventHandler(this.ZamknjiBtn_Click);
            // 
            // comboCzynnosc
            // 
            this.comboCzynnosc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.comboCzynnosc.SelectedIndexChanged += new System.EventHandler(this.comboCzynnosc_SelectedIndexChanged);
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
            // jakaKarma
            // 
            this.jakaKarma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jakaKarma.FormattingEnabled = true;
            this.jakaKarma.Items.AddRange(new object[] {
            "Karma sucha",
            "Saszetka",
            "Puszka",
            "Przysmak",
            "Inne"});
            this.jakaKarma.Location = new System.Drawing.Point(120, 188);
            this.jakaKarma.Name = "jakaKarma";
            this.jakaKarma.Size = new System.Drawing.Size(121, 21);
            this.jakaKarma.TabIndex = 22;
            this.jakaKarma.Visible = false;
            this.jakaKarma.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // iloscKarmy
            // 
            this.iloscKarmy.Location = new System.Drawing.Point(120, 252);
            this.iloscKarmy.Name = "iloscKarmy";
            this.iloscKarmy.Size = new System.Drawing.Size(121, 20);
            this.iloscKarmy.TabIndex = 23;
            this.iloscKarmy.Visible = false;
            this.iloscKarmy.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblJaka
            // 
            this.lblJaka.AutoSize = true;
            this.lblJaka.Location = new System.Drawing.Point(52, 191);
            this.lblJaka.Name = "lblJaka";
            this.lblJaka.Size = new System.Drawing.Size(62, 13);
            this.lblJaka.TabIndex = 24;
            this.lblJaka.Text = "Jaka karma";
            this.lblJaka.Visible = false;
            // 
            // lblIle
            // 
            this.lblIle.AutoSize = true;
            this.lblIle.Location = new System.Drawing.Point(52, 252);
            this.lblIle.Name = "lblIle";
            this.lblIle.Size = new System.Drawing.Size(60, 13);
            this.lblIle.TabIndex = 25;
            this.lblIle.Text = "Ilość karmy";
            this.lblIle.Visible = false;
            // 
            // lekLista
            // 
            this.lekLista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lekLista.FormattingEnabled = true;
            this.lekLista.Items.AddRange(new object[] {
            "Kroplówka ",
            "Insulina",
            "Tabletka do odrobaczania"});
            this.lekLista.Location = new System.Drawing.Point(120, 188);
            this.lekLista.Name = "lekLista";
            this.lekLista.Size = new System.Drawing.Size(219, 21);
            this.lekLista.TabIndex = 26;
            this.lekLista.Visible = false;
            // 
            // lblLek
            // 
            this.lblLek.AutoSize = true;
            this.lblLek.Location = new System.Drawing.Point(52, 191);
            this.lblLek.Name = "lblLek";
            this.lblLek.Size = new System.Drawing.Size(63, 13);
            this.lblLek.TabIndex = 27;
            this.lblLek.Text = "Nazwa leku";
            this.lblLek.Visible = false;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(245, 222);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 28;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Visible = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // nowyLek
            // 
            this.nowyLek.Location = new System.Drawing.Point(120, 222);
            this.nowyLek.Name = "nowyLek";
            this.nowyLek.Size = new System.Drawing.Size(121, 20);
            this.nowyLek.TabIndex = 29;
            this.nowyLek.Visible = false;
            // 
            // lblNowyLek
            // 
            this.lblNowyLek.AutoSize = true;
            this.lblNowyLek.Location = new System.Drawing.Point(52, 225);
            this.lblNowyLek.Name = "lblNowyLek";
            this.lblNowyLek.Size = new System.Drawing.Size(51, 13);
            this.lblNowyLek.TabIndex = 30;
            this.lblNowyLek.Text = "Nowy lek";
            this.lblNowyLek.Visible = false;
            // 
            // lblDawka
            // 
            this.lblDawka.AutoSize = true;
            this.lblDawka.Location = new System.Drawing.Point(52, 255);
            this.lblDawka.Name = "lblDawka";
            this.lblDawka.Size = new System.Drawing.Size(41, 13);
            this.lblDawka.TabIndex = 31;
            this.lblDawka.Text = "Dawka";
            this.lblDawka.Visible = false;
            // 
            // dawkaBox
            // 
            this.dawkaBox.Location = new System.Drawing.Point(120, 252);
            this.dawkaBox.Name = "dawkaBox";
            this.dawkaBox.Size = new System.Drawing.Size(121, 20);
            this.dawkaBox.TabIndex = 32;
            this.dawkaBox.Visible = false;
            // 
            // czesanieCzekBox
            // 
            this.czesanieCzekBox.BackColor = System.Drawing.Color.LightSalmon;
            this.czesanieCzekBox.FormattingEnabled = true;
            this.czesanieCzekBox.Items.AddRange(new object[] {
            "Groomer",
            "Trymowanie",
            "Grzebień",
            "Szczotka"});
            this.czesanieCzekBox.Location = new System.Drawing.Point(55, 188);
            this.czesanieCzekBox.Name = "czesanieCzekBox";
            this.czesanieCzekBox.Size = new System.Drawing.Size(120, 94);
            this.czesanieCzekBox.TabIndex = 33;
            this.czesanieCzekBox.Visible = false;
            // 
            // mycieCzekBox
            // 
            this.mycieCzekBox.BackColor = System.Drawing.Color.LightSalmon;
            this.mycieCzekBox.FormattingEnabled = true;
            this.mycieCzekBox.Items.AddRange(new object[] {
            "Groomer",
            "Szampon",
            "Odżywka",
            "Przycinanie pazurów",
            "Suszarka"});
            this.mycieCzekBox.Location = new System.Drawing.Point(55, 188);
            this.mycieCzekBox.Name = "mycieCzekBox";
            this.mycieCzekBox.Size = new System.Drawing.Size(136, 94);
            this.mycieCzekBox.TabIndex = 34;
            this.mycieCzekBox.Visible = false;
            // 
            // szampon
            // 
            this.szampon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.szampon.FormattingEnabled = true;
            this.szampon.Items.AddRange(new object[] {
            "Super Beno ",
            "VetExpert",
            "pet care Naturaphy",
            "Bio",
            "Inny"});
            this.szampon.Location = new System.Drawing.Point(218, 205);
            this.szampon.Name = "szampon";
            this.szampon.Size = new System.Drawing.Size(121, 21);
            this.szampon.TabIndex = 35;
            this.szampon.Visible = false;
            // 
            // odzywka
            // 
            this.odzywka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.odzywka.FormattingEnabled = true;
            this.odzywka.Items.AddRange(new object[] {
            "Super Beno ",
            "VetExpert",
            "pet care Naturaphy",
            "Bio",
            "Inna"});
            this.odzywka.Location = new System.Drawing.Point(218, 252);
            this.odzywka.Name = "odzywka";
            this.odzywka.Size = new System.Drawing.Size(121, 21);
            this.odzywka.TabIndex = 36;
            this.odzywka.Visible = false;
            // 
            // szamponNazwa
            // 
            this.szamponNazwa.AutoSize = true;
            this.szamponNazwa.Location = new System.Drawing.Point(215, 188);
            this.szamponNazwa.Name = "szamponNazwa";
            this.szamponNazwa.Size = new System.Drawing.Size(91, 13);
            this.szamponNazwa.TabIndex = 37;
            this.szamponNazwa.Text = "Nazwa szamponu";
            this.szamponNazwa.Visible = false;
            // 
            // odrzywkaNazwa
            // 
            this.odrzywkaNazwa.AutoSize = true;
            this.odrzywkaNazwa.Location = new System.Drawing.Point(215, 232);
            this.odrzywkaNazwa.Name = "odrzywkaNazwa";
            this.odrzywkaNazwa.Size = new System.Drawing.Size(81, 13);
            this.odrzywkaNazwa.TabIndex = 38;
            this.odrzywkaNazwa.Text = "Nazwa odżywki";
            this.odrzywkaNazwa.Visible = false;
            // 
            // FormularzZdarzen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.BackgroundImage = global::Calendar.Properties.Resources.paws;
            this.ClientSize = new System.Drawing.Size(392, 423);
            this.Controls.Add(this.odrzywkaNazwa);
            this.Controls.Add(this.szamponNazwa);
            this.Controls.Add(this.odzywka);
            this.Controls.Add(this.szampon);
            this.Controls.Add(this.mycieCzekBox);
            this.Controls.Add(this.czesanieCzekBox);
            this.Controls.Add(this.dawkaBox);
            this.Controls.Add(this.lblDawka);
            this.Controls.Add(this.lblNowyLek);
            this.Controls.Add(this.nowyLek);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.lblLek);
            this.Controls.Add(this.lekLista);
            this.Controls.Add(this.lblIle);
            this.Controls.Add(this.lblJaka);
            this.Controls.Add(this.iloscKarmy);
            this.Controls.Add(this.jakaKarma);
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
        private System.Windows.Forms.ComboBox jakaKarma;
        private System.Windows.Forms.TextBox iloscKarmy;
        private System.Windows.Forms.Label lblJaka;
        private System.Windows.Forms.Label lblIle;
        private System.Windows.Forms.ComboBox lekLista;
        private System.Windows.Forms.Label lblLek;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox nowyLek;
        private System.Windows.Forms.Label lblNowyLek;
        private System.Windows.Forms.Label lblDawka;
        private System.Windows.Forms.TextBox dawkaBox;
        private System.Windows.Forms.CheckedListBox czesanieCzekBox;
        private System.Windows.Forms.CheckedListBox mycieCzekBox;
        private System.Windows.Forms.ComboBox szampon;
        private System.Windows.Forms.ComboBox odzywka;
        private System.Windows.Forms.Label szamponNazwa;
        private System.Windows.Forms.Label odrzywkaNazwa;
    }
}