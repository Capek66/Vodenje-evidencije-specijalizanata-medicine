namespace Vodenje_evidencije_specijalizanata_medicine
{
    partial class SpecOdabir
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
            this.btnKnjizica = new System.Windows.Forms.Button();
            this.btnDnevnik = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSpecijalizacije = new System.Windows.Forms.ComboBox();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKnjizica
            // 
            this.btnKnjizica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKnjizica.Location = new System.Drawing.Point(75, 135);
            this.btnKnjizica.Name = "btnKnjizica";
            this.btnKnjizica.Size = new System.Drawing.Size(109, 38);
            this.btnKnjizica.TabIndex = 0;
            this.btnKnjizica.Text = "Knjižica";
            this.btnKnjizica.UseVisualStyleBackColor = true;
            this.btnKnjizica.Click += new System.EventHandler(this.btnKnjizica_Click);
            // 
            // btnDnevnik
            // 
            this.btnDnevnik.Enabled = false;
            this.btnDnevnik.Location = new System.Drawing.Point(265, 135);
            this.btnDnevnik.Name = "btnDnevnik";
            this.btnDnevnik.Size = new System.Drawing.Size(109, 38);
            this.btnDnevnik.TabIndex = 1;
            this.btnDnevnik.Text = "Dnevnik";
            this.btnDnevnik.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Specijalizacija";
            // 
            // cbSpecijalizacije
            // 
            this.cbSpecijalizacije.FormattingEnabled = true;
            this.cbSpecijalizacije.Location = new System.Drawing.Point(140, 57);
            this.cbSpecijalizacije.Name = "cbSpecijalizacije";
            this.cbSpecijalizacije.Size = new System.Drawing.Size(167, 21);
            this.cbSpecijalizacije.TabIndex = 3;
            // 
            // btnOdjava
            // 
            this.btnOdjava.Location = new System.Drawing.Point(380, 1);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(75, 23);
            this.btnOdjava.TabIndex = 4;
            this.btnOdjava.Text = "Odjavi se";
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // SpecOdabir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 245);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.cbSpecijalizacije);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDnevnik);
            this.Controls.Add(this.btnKnjizica);
            this.Name = "SpecOdabir";
            this.Text = "Evidencija specijalizanata";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKnjizica;
        private System.Windows.Forms.Button btnDnevnik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSpecijalizacije;
        private System.Windows.Forms.Button btnOdjava;
    }
}