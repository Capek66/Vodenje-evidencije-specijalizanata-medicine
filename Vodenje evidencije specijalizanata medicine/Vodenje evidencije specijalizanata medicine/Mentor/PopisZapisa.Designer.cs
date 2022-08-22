namespace Vodenje_evidencije_specijalizanata_medicine.Mentor
{
    partial class PopisZapisa
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.rbSvi = new System.Windows.Forms.RadioButton();
            this.rbNepotp = new System.Windows.Forms.RadioButton();
            this.rbPotpisani = new System.Windows.Forms.RadioButton();
            this.btnZatovi = new System.Windows.Forms.Button();
            this.btnDetalji = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 323);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zapisi specijalizanata:";
            // 
            // rbSvi
            // 
            this.rbSvi.AutoSize = true;
            this.rbSvi.Checked = true;
            this.rbSvi.Location = new System.Drawing.Point(722, 11);
            this.rbSvi.Name = "rbSvi";
            this.rbSvi.Size = new System.Drawing.Size(69, 17);
            this.rbSvi.TabIndex = 2;
            this.rbSvi.TabStop = true;
            this.rbSvi.Text = "Svi zapisi";
            this.rbSvi.UseVisualStyleBackColor = true;
            // 
            // rbNepotp
            // 
            this.rbNepotp.AutoSize = true;
            this.rbNepotp.Location = new System.Drawing.Point(561, 11);
            this.rbNepotp.Name = "rbNepotp";
            this.rbNepotp.Size = new System.Drawing.Size(81, 17);
            this.rbNepotp.TabIndex = 3;
            this.rbNepotp.Text = "Nepotpisani";
            this.rbNepotp.UseVisualStyleBackColor = true;
            // 
            // rbPotpisani
            // 
            this.rbPotpisani.AutoSize = true;
            this.rbPotpisani.Location = new System.Drawing.Point(648, 11);
            this.rbPotpisani.Name = "rbPotpisani";
            this.rbPotpisani.Size = new System.Drawing.Size(68, 17);
            this.rbPotpisani.TabIndex = 4;
            this.rbPotpisani.Text = "Potpisani";
            this.rbPotpisani.UseVisualStyleBackColor = true;
            // 
            // btnZatovi
            // 
            this.btnZatovi.Location = new System.Drawing.Point(713, 363);
            this.btnZatovi.Name = "btnZatovi";
            this.btnZatovi.Size = new System.Drawing.Size(75, 23);
            this.btnZatovi.TabIndex = 5;
            this.btnZatovi.Text = "Zatvori";
            this.btnZatovi.UseVisualStyleBackColor = true;
            this.btnZatovi.Click += new System.EventHandler(this.btnZatovi_Click);
            // 
            // btnDetalji
            // 
            this.btnDetalji.Location = new System.Drawing.Point(632, 363);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(75, 23);
            this.btnDetalji.TabIndex = 6;
            this.btnDetalji.Text = "Detalji";
            this.btnDetalji.UseVisualStyleBackColor = true;
            // 
            // PopisZapisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 397);
            this.Controls.Add(this.btnDetalji);
            this.Controls.Add(this.btnZatovi);
            this.Controls.Add(this.rbPotpisani);
            this.Controls.Add(this.rbNepotp);
            this.Controls.Add(this.rbSvi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PopisZapisa";
            this.Text = "Zapisi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbSvi;
        private System.Windows.Forms.RadioButton rbNepotp;
        private System.Windows.Forms.RadioButton rbPotpisani;
        private System.Windows.Forms.Button btnZatovi;
        private System.Windows.Forms.Button btnDetalji;
    }
}