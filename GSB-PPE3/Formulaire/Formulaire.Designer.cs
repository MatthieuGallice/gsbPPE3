﻿namespace Formulaire
{
    partial class Formulaire
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.accueilMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.rapportMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.visiteurMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.medecinMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.medicamentMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerMédicamentMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.listeMédicamentMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aProposMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accueilMenuStrip,
            this.rapportMenuStrip,
            this.visiteurMenuStrip,
            this.medecinMenuStrip,
            this.medicamentMenuStrip,
            this.aProposMenuStrip});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(1284, 24);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "menuStrip1";
            // 
            // accueilMenuStrip
            // 
            this.accueilMenuStrip.Name = "accueilMenuStrip";
            this.accueilMenuStrip.Size = new System.Drawing.Size(58, 20);
            this.accueilMenuStrip.Text = "Accueil";
            this.accueilMenuStrip.Click += new System.EventHandler(this.accueilMenuStrip_Click);
            // 
            // rapportMenuStrip
            // 
            this.rapportMenuStrip.Name = "rapportMenuStrip";
            this.rapportMenuStrip.Size = new System.Drawing.Size(66, 20);
            this.rapportMenuStrip.Text = "Rapports";
            this.rapportMenuStrip.Click += new System.EventHandler(this.rapportMenuStrip_Click);
            // 
            // visiteurMenuStrip
            // 
            this.visiteurMenuStrip.Name = "visiteurMenuStrip";
            this.visiteurMenuStrip.Size = new System.Drawing.Size(63, 20);
            this.visiteurMenuStrip.Text = "Visiteurs";
            this.visiteurMenuStrip.Click += new System.EventHandler(this.visiteurMenuStrip_Click);
            // 
            // medecinMenuStrip
            // 
            this.medecinMenuStrip.Name = "medecinMenuStrip";
            this.medecinMenuStrip.Size = new System.Drawing.Size(70, 20);
            this.medecinMenuStrip.Text = "Medecins";
            this.medecinMenuStrip.Click += new System.EventHandler(this.medecinMenuStrip_Click);
            // 
            // medicamentMenuStrip
            // 
            this.medicamentMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gérerMédicamentMenuStrip,
            this.listeMédicamentMenuStrip,
            this.toolStripSeparator1});
            this.medicamentMenuStrip.Name = "medicamentMenuStrip";
            this.medicamentMenuStrip.Size = new System.Drawing.Size(91, 20);
            this.medicamentMenuStrip.Text = "Medicaments";
            // 
            // gérerMédicamentMenuStrip
            // 
            this.gérerMédicamentMenuStrip.Name = "gérerMédicamentMenuStrip";
            this.gérerMédicamentMenuStrip.Size = new System.Drawing.Size(202, 22);
            this.gérerMédicamentMenuStrip.Text = "Gérer Médicament";
            this.gérerMédicamentMenuStrip.Click += new System.EventHandler(this.gérerMédicamentMenuStrip_Click);
            // 
            // listeMédicamentMenuStrip
            // 
            this.listeMédicamentMenuStrip.Name = "listeMédicamentMenuStrip";
            this.listeMédicamentMenuStrip.Size = new System.Drawing.Size(202, 22);
            this.listeMédicamentMenuStrip.Text = "Liste Médicament Offert";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(199, 6);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(199, 6);
            // 
            // aProposMenuStrip
            // 
            this.aProposMenuStrip.Name = "aProposMenuStrip";
            this.aProposMenuStrip.Size = new System.Drawing.Size(65, 20);
            this.aProposMenuStrip.Text = "a propos";
            this.aProposMenuStrip.Click += new System.EventHandler(this.aProposMenuStrip_Click);
            // 
            // Formulaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 713);
            this.Controls.Add(this.Menu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.Menu;
            this.Name = "Formulaire";
            this.Text = "Accueil";
            this.Shown += new System.EventHandler(this.accueilMenuStrip_Click);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private new System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem accueilMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem rapportMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem visiteurMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem medecinMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem medicamentMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem gérerMédicamentMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem listeMédicamentMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem aProposMenuStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

