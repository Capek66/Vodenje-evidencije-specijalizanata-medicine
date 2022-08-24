namespace Vodenje_evidencije_specijalizanata_medicine.Mentor
{
    partial class RasporedObavljanjaMentor
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
            this.btnPregledaj = new System.Windows.Forms.Button();
            this.btnDetalji = new System.Windows.Forms.Button();
            this.dgvRaspored = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSpecijalizanti = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaspored)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPregledaj
            // 
            this.btnPregledaj.Location = new System.Drawing.Point(1147, 511);
            this.btnPregledaj.Name = "btnPregledaj";
            this.btnPregledaj.Size = new System.Drawing.Size(123, 51);
            this.btnPregledaj.TabIndex = 15;
            this.btnPregledaj.Text = "Označi kao pregledano";
            this.btnPregledaj.UseVisualStyleBackColor = true;
            this.btnPregledaj.Click += new System.EventHandler(this.btnPregledaj_Click);
            // 
            // btnDetalji
            // 
            this.btnDetalji.Location = new System.Drawing.Point(1054, 511);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(87, 51);
            this.btnDetalji.TabIndex = 14;
            this.btnDetalji.Text = "Detalji";
            this.btnDetalji.UseVisualStyleBackColor = true;
            this.btnDetalji.Click += new System.EventHandler(this.btnDetalji_Click);
            // 
            // dgvRaspored
            // 
            this.dgvRaspored.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRaspored.Location = new System.Drawing.Point(8, 85);
            this.dgvRaspored.Name = "dgvRaspored";
            this.dgvRaspored.Size = new System.Drawing.Size(1262, 420);
            this.dgvRaspored.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(4, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Zapisi specijalizanata";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(431, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Raspored obavljanja programa specijalizacije";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Označite zapis za potpisivanje";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(979, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Filter:";
            // 
            // cbSpecijalizanti
            // 
            this.cbSpecijalizanti.FormattingEnabled = true;
            this.cbSpecijalizanti.Location = new System.Drawing.Point(1017, 61);
            this.cbSpecijalizanti.Name = "cbSpecijalizanti";
            this.cbSpecijalizanti.Size = new System.Drawing.Size(172, 21);
            this.cbSpecijalizanti.TabIndex = 18;
            this.cbSpecijalizanti.SelectedIndexChanged += new System.EventHandler(this.cbSpecijalizanti_SelectedIndexChanged);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(1195, 61);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 21);
            this.btnReset.TabIndex = 19;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // RasporedObavljanjaMentor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cbSpecijalizanti);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPregledaj);
            this.Controls.Add(this.btnDetalji);
            this.Controls.Add(this.dgvRaspored);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "RasporedObavljanjaMentor";
            this.Size = new System.Drawing.Size(1273, 565);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaspored)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPregledaj;
        private System.Windows.Forms.Button btnDetalji;
        private System.Windows.Forms.DataGridView dgvRaspored;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSpecijalizanti;
        private System.Windows.Forms.Button btnReset;
    }
}
