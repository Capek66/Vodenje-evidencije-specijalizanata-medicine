namespace Vodenje_evidencije_specijalizanata_medicine.Mentor
{
    partial class PracenjeNapMntr
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnPotpisi = new System.Windows.Forms.Button();
            this.btnDetalji = new System.Windows.Forms.Button();
            this.dgvKompetencije = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.cbSpecijalizanti = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKompetencije)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Označite zapis za potpisivanje";
            // 
            // btnPotpisi
            // 
            this.btnPotpisi.Location = new System.Drawing.Point(1147, 511);
            this.btnPotpisi.Name = "btnPotpisi";
            this.btnPotpisi.Size = new System.Drawing.Size(123, 51);
            this.btnPotpisi.TabIndex = 21;
            this.btnPotpisi.Text = "Označi kao pregledano";
            this.btnPotpisi.UseVisualStyleBackColor = true;
            this.btnPotpisi.Click += new System.EventHandler(this.btnPotpisi_Click);
            // 
            // btnDetalji
            // 
            this.btnDetalji.Location = new System.Drawing.Point(1054, 511);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(87, 51);
            this.btnDetalji.TabIndex = 20;
            this.btnDetalji.Text = "Detalji";
            this.btnDetalji.UseVisualStyleBackColor = true;
            this.btnDetalji.Click += new System.EventHandler(this.btnDetalji_Click);
            // 
            // dgvKompetencije
            // 
            this.dgvKompetencije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKompetencije.Location = new System.Drawing.Point(8, 85);
            this.dgvKompetencije.Name = "dgvKompetencije";
            this.dgvKompetencije.Size = new System.Drawing.Size(1262, 420);
            this.dgvKompetencije.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(4, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Zapisi specijalizanata";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(625, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Praćenje napredovanja u stjecanju općih i posebnih kompetencija";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(1195, 61);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 21);
            this.btnReset.TabIndex = 25;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cbSpecijalizanti
            // 
            this.cbSpecijalizanti.FormattingEnabled = true;
            this.cbSpecijalizanti.Location = new System.Drawing.Point(1017, 61);
            this.cbSpecijalizanti.Name = "cbSpecijalizanti";
            this.cbSpecijalizanti.Size = new System.Drawing.Size(172, 21);
            this.cbSpecijalizanti.TabIndex = 24;
            this.cbSpecijalizanti.SelectedIndexChanged += new System.EventHandler(this.cbSpecijalizanti_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(979, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Filter:";
            // 
            // PracenjeNapMntr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cbSpecijalizanti);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPotpisi);
            this.Controls.Add(this.btnDetalji);
            this.Controls.Add(this.dgvKompetencije);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "PracenjeNapMntr";
            this.Size = new System.Drawing.Size(1273, 565);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKompetencije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPotpisi;
        private System.Windows.Forms.Button btnDetalji;
        private System.Windows.Forms.DataGridView dgvKompetencije;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cbSpecijalizanti;
        private System.Windows.Forms.Label label3;
    }
}
