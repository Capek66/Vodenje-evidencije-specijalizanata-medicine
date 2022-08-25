namespace Vodenje_evidencije_specijalizanata_medicine
{
    partial class Profil
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.btnPass = new System.Windows.Forms.Button();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDatRod = new System.Windows.Forms.DateTimePicker();
            this.lblVar = new System.Windows.Forms.Label();
            this.tbVar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Vaši podaci";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Email:";
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(57, 45);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(193, 20);
            this.tbIme.TabIndex = 21;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(57, 106);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(193, 20);
            this.tbEmail.TabIndex = 22;
            // 
            // btnPass
            // 
            this.btnPass.Location = new System.Drawing.Point(32, 208);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(106, 23);
            this.btnPass.TabIndex = 23;
            this.btnPass.Text = "Promijeni lozinku";
            this.btnPass.UseVisualStyleBackColor = true;
            this.btnPass.Click += new System.EventHandler(this.btnPass_Click);
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Location = new System.Drawing.Point(144, 208);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(106, 23);
            this.btnAzuriraj.TabIndex = 24;
            this.btnAzuriraj.Text = "Ažuriraj podatke";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(57, 75);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(193, 20);
            this.tbPrezime.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Prezime:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Datum rođenja:";
            // 
            // dtpDatRod
            // 
            this.dtpDatRod.Location = new System.Drawing.Point(90, 138);
            this.dtpDatRod.Name = "dtpDatRod";
            this.dtpDatRod.Size = new System.Drawing.Size(160, 20);
            this.dtpDatRod.TabIndex = 28;
            // 
            // lblVar
            // 
            this.lblVar.AutoSize = true;
            this.lblVar.Location = new System.Drawing.Point(4, 178);
            this.lblVar.Name = "lblVar";
            this.lblVar.Size = new System.Drawing.Size(111, 13);
            this.lblVar.TabIndex = 29;
            this.lblVar.Text = "Godina specijalizacije:";
            // 
            // tbVar
            // 
            this.tbVar.Location = new System.Drawing.Point(121, 171);
            this.tbVar.Name = "tbVar";
            this.tbVar.Size = new System.Drawing.Size(129, 20);
            this.tbVar.TabIndex = 30;
            // 
            // Profil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbVar);
            this.Controls.Add(this.lblVar);
            this.Controls.Add(this.dtpDatRod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbPrezime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.btnPass);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbIme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "Profil";
            this.Size = new System.Drawing.Size(273, 246);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Button btnPass;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDatRod;
        private System.Windows.Forms.Label lblVar;
        private System.Windows.Forms.TextBox tbVar;
    }
}
