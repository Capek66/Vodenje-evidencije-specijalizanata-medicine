namespace Vodenje_evidencije_specijalizanata_medicine.Mentor
{
    partial class PocetnaMentori
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
            this.btnOdjava = new System.Windows.Forms.Button();
            this.btnDnevnik = new System.Windows.Forms.Button();
            this.btnKnjizica = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOdjava
            // 
            this.btnOdjava.Location = new System.Drawing.Point(236, 2);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(75, 23);
            this.btnOdjava.TabIndex = 9;
            this.btnOdjava.Text = "Odjavi se";
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // btnDnevnik
            // 
            this.btnDnevnik.Location = new System.Drawing.Point(184, 120);
            this.btnDnevnik.Name = "btnDnevnik";
            this.btnDnevnik.Size = new System.Drawing.Size(109, 38);
            this.btnDnevnik.TabIndex = 6;
            this.btnDnevnik.Text = "Dnevnik";
            this.btnDnevnik.UseVisualStyleBackColor = true;
            // 
            // btnKnjizica
            // 
            this.btnKnjizica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKnjizica.Location = new System.Drawing.Point(29, 120);
            this.btnKnjizica.Name = "btnKnjizica";
            this.btnKnjizica.Size = new System.Drawing.Size(109, 38);
            this.btnKnjizica.TabIndex = 5;
            this.btnKnjizica.Text = "Knjižica";
            this.btnKnjizica.UseVisualStyleBackColor = true;
            this.btnKnjizica.Click += new System.EventHandler(this.btnKnjizica_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(103, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Odaberite";
            // 
            // PocetnaMentori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 175);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.btnDnevnik);
            this.Controls.Add(this.btnKnjizica);
            this.Name = "PocetnaMentori";
            this.Text = "Evidencija specijalizanata";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.Button btnDnevnik;
        private System.Windows.Forms.Button btnKnjizica;
        private System.Windows.Forms.Label label1;
    }
}