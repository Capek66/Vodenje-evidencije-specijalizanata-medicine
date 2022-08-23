namespace Vodenje_evidencije_specijalizanata_medicine.Administator
{
    partial class TrenutniKor
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
            this.dgvSpecijalizanti = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMentori = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecijalizanti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMentori)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSpecijalizanti
            // 
            this.dgvSpecijalizanti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpecijalizanti.Location = new System.Drawing.Point(8, 64);
            this.dgvSpecijalizanti.Name = "dgvSpecijalizanti";
            this.dgvSpecijalizanti.Size = new System.Drawing.Size(776, 222);
            this.dgvSpecijalizanti.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 24);
            this.label4.TabIndex = 23;
            this.label4.Text = "Popis trenutnih korisnika";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(4, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Specijalizanti";
            // 
            // dgvMentori
            // 
            this.dgvMentori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMentori.Location = new System.Drawing.Point(8, 325);
            this.dgvMentori.Name = "dgvMentori";
            this.dgvMentori.Size = new System.Drawing.Size(776, 222);
            this.dgvMentori.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(4, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Mentori";
            // 
            // TrenutniKor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvMentori);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvSpecijalizanti);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "TrenutniKor";
            this.Size = new System.Drawing.Size(810, 571);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecijalizanti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMentori)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvSpecijalizanti;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMentori;
        private System.Windows.Forms.Label label2;
    }
}
