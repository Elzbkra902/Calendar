
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
            this.txCzynnosc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data";
            // 
            // txDate
            // 
            this.txDate.Enabled = false;
            this.txDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txDate.Location = new System.Drawing.Point(55, 50);
            this.txDate.Name = "txDate";
            this.txDate.Size = new System.Drawing.Size(284, 26);
            this.txDate.TabIndex = 1;
            // 
            // txCzynnosc
            // 
            this.txCzynnosc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txCzynnosc.Location = new System.Drawing.Point(55, 125);
            this.txCzynnosc.Name = "txCzynnosc";
            this.txCzynnosc.Size = new System.Drawing.Size(284, 26);
            this.txCzynnosc.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Czynność";
            // 
            // btnZapisz
            // 
            this.btnZapisz.Location = new System.Drawing.Point(264, 197);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(75, 23);
            this.btnZapisz.TabIndex = 4;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // FormularzZdarzen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 262);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txCzynnosc);
            this.Controls.Add(this.txDate);
            this.Controls.Add(this.label1);
            this.Name = "FormularzZdarzen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularzZdarzen";
            this.Load += new System.EventHandler(this.FormularzZdarzen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txDate;
        private System.Windows.Forms.TextBox txCzynnosc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnZapisz;
    }
}