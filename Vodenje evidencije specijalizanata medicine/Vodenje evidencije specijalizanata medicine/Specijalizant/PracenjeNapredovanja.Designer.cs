﻿namespace Vodenje_evidencije_specijalizanata_medicine
{
    partial class PracenjeNapredovanja
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
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnDetalji = new System.Windows.Forms.Button();
            this.dgvKompetencije = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKompetencije)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(625, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Praćenje napredovanja u stjecanju općih i posebnih kompetencija";
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(1084, 481);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(104, 23);
            this.btnAddNew.TabIndex = 15;
            this.btnAddNew.Text = "Novi zapis";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnDetalji
            // 
            this.btnDetalji.Location = new System.Drawing.Point(1194, 481);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(75, 23);
            this.btnDetalji.TabIndex = 14;
            this.btnDetalji.Text = "Detalji";
            this.btnDetalji.UseVisualStyleBackColor = true;
            this.btnDetalji.Click += new System.EventHandler(this.btnDetalji_Click);
            // 
            // dgvKompetencije
            // 
            this.dgvKompetencije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKompetencije.Location = new System.Drawing.Point(7, 55);
            this.dgvKompetencije.Name = "dgvKompetencije";
            this.dgvKompetencije.Size = new System.Drawing.Size(1262, 420);
            this.dgvKompetencije.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Dosadašnji zapisi";
            // 
            // PracenjeNapredovanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnDetalji);
            this.Controls.Add(this.dgvKompetencije);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "PracenjeNapredovanja";
            this.Size = new System.Drawing.Size(1273, 565);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKompetencije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnDetalji;
        private System.Windows.Forms.DataGridView dgvKompetencije;
        private System.Windows.Forms.Label label1;
    }
}
