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
            this.tbPrezIme = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.btnPass = new System.Windows.Forms.Button();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Praćenje obavljenih zahvata";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Prezime i ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Email:";
            // 
            // tbPrezIme
            // 
            this.tbPrezIme.Location = new System.Drawing.Point(81, 41);
            this.tbPrezIme.Name = "tbPrezIme";
            this.tbPrezIme.Size = new System.Drawing.Size(193, 20);
            this.tbPrezIme.TabIndex = 21;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(81, 67);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(193, 20);
            this.tbEmail.TabIndex = 22;
            // 
            // btnPass
            // 
            this.btnPass.Location = new System.Drawing.Point(168, 105);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(106, 23);
            this.btnPass.TabIndex = 23;
            this.btnPass.Text = "Promijeni lozinku";
            this.btnPass.UseVisualStyleBackColor = true;
            this.btnPass.Click += new System.EventHandler(this.btnPass_Click);
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Location = new System.Drawing.Point(56, 105);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(106, 23);
            this.btnAzuriraj.TabIndex = 24;
            this.btnAzuriraj.Text = "Ažuriraj podatke";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // Profil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.btnPass);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbPrezIme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "Profil";
            this.Size = new System.Drawing.Size(303, 156);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPrezIme;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Button btnPass;
        private System.Windows.Forms.Button btnAzuriraj;
    }
}
