namespace Vodenje_evidencije_specijalizanata_medicine.Mentor
{
    partial class IzbornikMentor
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
            this.RasporedObavljanjaLbl = new System.Windows.Forms.ToolStripLabel();
            this.PracenjeNapredovanjaLbl = new System.Windows.Forms.ToolStripLabel();
            this.PracenjeObavljenihZahvataLbl = new System.Windows.Forms.ToolStripLabel();
            this.SpecijalizantiLbl = new System.Windows.Forms.ToolStripLabel();
            this.Profil = new System.Windows.Forms.ToolStripLabel();
            this.Pocetna = new System.Windows.Forms.ToolStripLabel();
            this.knjizica = new System.Windows.Forms.Panel();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RasporedObavljanjaLbl,
            this.PracenjeNapredovanjaLbl,
            this.PracenjeObavljenihZahvataLbl,
            this.SpecijalizantiLbl,
            this.Profil,
            this.Pocetna});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(1322, 25);
            this.Menu.TabIndex = 2;
            this.Menu.Text = "toolStrip1";
            // 
            // RasporedObavljanjaLbl
            // 
            this.RasporedObavljanjaLbl.Name = "RasporedObavljanjaLbl";
            this.RasporedObavljanjaLbl.Size = new System.Drawing.Size(242, 22);
            this.RasporedObavljanjaLbl.Text = "Raspored obavljanja programa specijalizacije";
            this.RasporedObavljanjaLbl.Click += new System.EventHandler(this.RasporedObavljanjaLbl_Click);
            // 
            // PracenjeNapredovanjaLbl
            // 
            this.PracenjeNapredovanjaLbl.Name = "PracenjeNapredovanjaLbl";
            this.PracenjeNapredovanjaLbl.Size = new System.Drawing.Size(127, 22);
            this.PracenjeNapredovanjaLbl.Text = "Praćenje napredovanja";
            this.PracenjeNapredovanjaLbl.Click += new System.EventHandler(this.PracenjeNapredovanjaLbl_Click);
            // 
            // PracenjeObavljenihZahvataLbl
            // 
            this.PracenjeObavljenihZahvataLbl.Name = "PracenjeObavljenihZahvataLbl";
            this.PracenjeObavljenihZahvataLbl.Size = new System.Drawing.Size(153, 22);
            this.PracenjeObavljenihZahvataLbl.Text = "Praćenje obavljenih zahvata";
            this.PracenjeObavljenihZahvataLbl.Click += new System.EventHandler(this.PracenjeObavljenihZahvataLbl_Click);
            // 
            // SpecijalizantiLbl
            // 
            this.SpecijalizantiLbl.Name = "SpecijalizantiLbl";
            this.SpecijalizantiLbl.Size = new System.Drawing.Size(75, 22);
            this.SpecijalizantiLbl.Text = "Specijalizanti";
            this.SpecijalizantiLbl.Click += new System.EventHandler(this.SpecijalizantiLbl_Click);
            // 
            // Profil
            // 
            this.Profil.Name = "Profil";
            this.Profil.Size = new System.Drawing.Size(35, 22);
            this.Profil.Text = "Profil";
            this.Profil.Click += new System.EventHandler(this.Profil_Click);
            // 
            // Pocetna
            // 
            this.Pocetna.Name = "Pocetna";
            this.Pocetna.Size = new System.Drawing.Size(50, 22);
            this.Pocetna.Text = "Početna";
            this.Pocetna.Click += new System.EventHandler(this.Pocetna_Click);
            // 
            // knjizica
            // 
            this.knjizica.Location = new System.Drawing.Point(0, 28);
            this.knjizica.Name = "knjizica";
            this.knjizica.Size = new System.Drawing.Size(1322, 621);
            this.knjizica.TabIndex = 3;
            // 
            // IzbornikMentor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 648);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.knjizica);
            this.Name = "IzbornikMentor";
            this.Text = "Evidencija specijalizanata";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip Menu;
        private System.Windows.Forms.ToolStripLabel RasporedObavljanjaLbl;
        private System.Windows.Forms.ToolStripLabel PracenjeNapredovanjaLbl;
        private System.Windows.Forms.ToolStripLabel PracenjeObavljenihZahvataLbl;
        private System.Windows.Forms.ToolStripLabel SpecijalizantiLbl;
        private System.Windows.Forms.ToolStripLabel Profil;
        private System.Windows.Forms.ToolStripLabel Pocetna;
        private System.Windows.Forms.Panel knjizica;
    }
}