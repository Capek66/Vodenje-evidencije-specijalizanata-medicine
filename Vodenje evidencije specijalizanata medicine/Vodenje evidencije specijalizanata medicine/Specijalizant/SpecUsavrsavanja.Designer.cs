namespace Vodenje_evidencije_specijalizanata_medicine
{
    partial class SpecUsavrsavanja
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
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnDetalji = new System.Windows.Forms.Button();
            this.dgvSpecijalizacije = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOdaberiSpec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecijalizacije)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(772, 15);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(192, 37);
            this.btnAddNew.TabIndex = 20;
            this.btnAddNew.Text = "Novo specijalističko usavršavanje";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnDetalji
            // 
            this.btnDetalji.Location = new System.Drawing.Point(889, 329);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(75, 23);
            this.btnDetalji.TabIndex = 19;
            this.btnDetalji.Text = "Detalji";
            this.btnDetalji.UseVisualStyleBackColor = true;
            this.btnDetalji.Click += new System.EventHandler(this.btnDetalji_Click);
            // 
            // dgvSpecijalizacije
            // 
            this.dgvSpecijalizacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpecijalizacije.Location = new System.Drawing.Point(7, 55);
            this.dgvSpecijalizacije.Name = "dgvSpecijalizacije";
            this.dgvSpecijalizacije.Size = new System.Drawing.Size(957, 268);
            this.dgvSpecijalizacije.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Dosadašnja usavršavanja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(267, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "Specijalistička usavršavanja";
            // 
            // btnOdaberiSpec
            // 
            this.btnOdaberiSpec.Location = new System.Drawing.Point(749, 329);
            this.btnOdaberiSpec.Name = "btnOdaberiSpec";
            this.btnOdaberiSpec.Size = new System.Drawing.Size(134, 23);
            this.btnOdaberiSpec.TabIndex = 21;
            this.btnOdaberiSpec.Text = "Odaberi usavršavanje";
            this.btnOdaberiSpec.UseVisualStyleBackColor = true;
            this.btnOdaberiSpec.Click += new System.EventHandler(this.btnOdaberiSpec_Click);
            // 
            // SpecUsavrsavanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnOdaberiSpec);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnDetalji);
            this.Controls.Add(this.dgvSpecijalizacije);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "SpecUsavrsavanja";
            this.Size = new System.Drawing.Size(977, 395);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecijalizacije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnDetalji;
        private System.Windows.Forms.DataGridView dgvSpecijalizacije;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOdaberiSpec;
    }
}
