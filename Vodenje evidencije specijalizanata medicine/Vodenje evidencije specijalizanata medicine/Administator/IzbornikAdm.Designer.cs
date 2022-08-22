namespace Vodenje_evidencije_specijalizanata_medicine.Administator
{
    partial class IzbornikAdm
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
            this.Menu = new System.Windows.Forms.ToolStrip();
            this.lblTrenutni = new System.Windows.Forms.ToolStripLabel();
            this.lblNovi = new System.Windows.Forms.ToolStripLabel();
            this.lblOdjava = new System.Windows.Forms.ToolStripLabel();
            this.panel = new System.Windows.Forms.Panel();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTrenutni,
            this.lblNovi,
            this.lblOdjava});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(1322, 25);
            this.Menu.TabIndex = 4;
            this.Menu.Text = "toolStrip1";
            // 
            // lblTrenutni
            // 
            this.lblTrenutni.Name = "lblTrenutni";
            this.lblTrenutni.Size = new System.Drawing.Size(97, 22);
            this.lblTrenutni.Text = "Trenutni korisnici";
            this.lblTrenutni.Click += new System.EventHandler(this.lblTrenutni_Click);
            // 
            // lblNovi
            // 
            this.lblNovi.Name = "lblNovi";
            this.lblNovi.Size = new System.Drawing.Size(76, 22);
            this.lblNovi.Text = "Novi korisnik";
            this.lblNovi.Click += new System.EventHandler(this.lblNovi_Click);
            // 
            // lblOdjava
            // 
            this.lblOdjava.Name = "lblOdjava";
            this.lblOdjava.Size = new System.Drawing.Size(55, 22);
            this.lblOdjava.Text = "Odjavi se";
            this.lblOdjava.Click += new System.EventHandler(this.lblOdjava_Click);
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(0, 28);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1322, 619);
            this.panel.TabIndex = 5;
            // 
            // IzbornikAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 648);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.Menu);
            this.Name = "IzbornikAdm";
            this.Text = "Upravljanje korisnicima";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip Menu;
        private System.Windows.Forms.ToolStripLabel lblTrenutni;
        private System.Windows.Forms.ToolStripLabel lblNovi;
        private System.Windows.Forms.ToolStripLabel lblOdjava;
        private System.Windows.Forms.Panel panel;
    }
}