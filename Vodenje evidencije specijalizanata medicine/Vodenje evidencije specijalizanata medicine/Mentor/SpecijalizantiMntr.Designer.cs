namespace Vodenje_evidencije_specijalizanata_medicine.Mentor
{
    partial class SpecijalizantiMntr
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
            this.btnPregMntr = new System.Windows.Forms.Button();
            this.dgvGlMentor = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvMentor = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPregGlMntr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGlMentor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMentor)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Označite specijalizanta i pritisnite \"Pregledaj specijalizanta\" za detalje";
            // 
            // btnPregMntr
            // 
            this.btnPregMntr.Location = new System.Drawing.Point(1183, 551);
            this.btnPregMntr.Name = "btnPregMntr";
            this.btnPregMntr.Size = new System.Drawing.Size(87, 51);
            this.btnPregMntr.TabIndex = 32;
            this.btnPregMntr.Text = "Pregledaj specijalizanta";
            this.btnPregMntr.UseVisualStyleBackColor = true;
            this.btnPregMntr.Click += new System.EventHandler(this.btnPregledaj_Click);
            // 
            // dgvGlMentor
            // 
            this.dgvGlMentor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGlMentor.Location = new System.Drawing.Point(8, 85);
            this.dgvGlMentor.Name = "dgvGlMentor";
            this.dgvGlMentor.Size = new System.Drawing.Size(1262, 198);
            this.dgvGlMentor.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(4, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Vi ste glavni mentor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 24);
            this.label4.TabIndex = 29;
            this.label4.Text = "Popis specijalizanata";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(332, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Označite specijalizanta i pritisnite \"Pregledaj specijalizanta\" za detalje";
            // 
            // dgvMentor
            // 
            this.dgvMentor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMentor.Location = new System.Drawing.Point(8, 347);
            this.dgvMentor.Name = "dgvMentor";
            this.dgvMentor.Size = new System.Drawing.Size(1262, 198);
            this.dgvMentor.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(4, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Vi ste mentor";
            // 
            // btnPregGlMntr
            // 
            this.btnPregGlMntr.Location = new System.Drawing.Point(1183, 289);
            this.btnPregGlMntr.Name = "btnPregGlMntr";
            this.btnPregGlMntr.Size = new System.Drawing.Size(87, 51);
            this.btnPregGlMntr.TabIndex = 38;
            this.btnPregGlMntr.Text = "Pregledaj specijalizanta";
            this.btnPregGlMntr.UseVisualStyleBackColor = true;
            this.btnPregGlMntr.Click += new System.EventHandler(this.btnPregGlMntr_Click);
            // 
            // SpecijalizantiMntr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPregGlMntr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvMentor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPregMntr);
            this.Controls.Add(this.dgvGlMentor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "SpecijalizantiMntr";
            this.Size = new System.Drawing.Size(1273, 609);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGlMentor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMentor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPregMntr;
        private System.Windows.Forms.DataGridView dgvGlMentor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvMentor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPregGlMntr;
    }
}
