namespace Vodenje_evidencije_specijalizanata_medicine
{
    partial class SpecijalizacijaAdd
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSpecNaziv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbOdobrenaZa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbGlMentor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpPocetak = new System.Windows.Forms.DateTimePicker();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(400, 50);
            this.label4.TabIndex = 25;
            this.label4.Text = "Dodavanje nove specijalizacije";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Naziv specijalizacije:";
            // 
            // tbSpecNaziv
            // 
            this.tbSpecNaziv.Location = new System.Drawing.Point(16, 87);
            this.tbSpecNaziv.Name = "tbSpecNaziv";
            this.tbSpecNaziv.Size = new System.Drawing.Size(204, 20);
            this.tbSpecNaziv.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Odobrena za (pravnu/fizičku osobu):";
            // 
            // tbOdobrenaZa
            // 
            this.tbOdobrenaZa.Location = new System.Drawing.Point(16, 141);
            this.tbOdobrenaZa.Name = "tbOdobrenaZa";
            this.tbOdobrenaZa.Size = new System.Drawing.Size(204, 20);
            this.tbOdobrenaZa.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Glavni mentor:";
            // 
            // cbGlMentor
            // 
            this.cbGlMentor.FormattingEnabled = true;
            this.cbGlMentor.Location = new System.Drawing.Point(16, 194);
            this.cbGlMentor.Name = "cbGlMentor";
            this.cbGlMentor.Size = new System.Drawing.Size(204, 21);
            this.cbGlMentor.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(279, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Specijalističko usavršavanje specijalizant/ica započeo/la:";
            // 
            // dtpPocetak
            // 
            this.dtpPocetak.Location = new System.Drawing.Point(16, 249);
            this.dtpPocetak.Name = "dtpPocetak";
            this.dtpPocetak.Size = new System.Drawing.Size(204, 20);
            this.dtpPocetak.TabIndex = 35;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(193, 302);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 39;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(275, 302);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 38;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // SpecijalizacijaAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 337);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.dtpPocetak);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbGlMentor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbOdobrenaZa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSpecNaziv);
            this.Controls.Add(this.label4);
            this.Name = "SpecijalizacijaAdd";
            this.Text = "Dodavanje nove specijalizacije";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSpecNaziv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbOdobrenaZa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbGlMentor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpPocetak;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnOdustani;
    }
}