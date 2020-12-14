namespace Formulaire
{
    partial class Visiteur
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
            this.dgwVisiteur = new System.Windows.Forms.DataGridView();
            this.idVis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomVis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomVis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseVis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpVis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeVis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateEmbaucheVis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonModifierVisiteur = new System.Windows.Forms.Button();
            this.buttonSupprimerVisiteur = new System.Windows.Forms.Button();
            this.buttonValiderModificationVisiteur = new System.Windows.Forms.Button();
            this.buttonAjouterVisiteur = new System.Windows.Forms.Button();
            this.txtMdpVisiteur = new System.Windows.Forms.TextBox();
            this.txtLoginVisiteur = new System.Windows.Forms.TextBox();
            this.txtVilleVisiteur = new System.Windows.Forms.TextBox();
            this.txtAdresseVisiteur = new System.Windows.Forms.TextBox();
            this.txtDateEmbaucheVisiteur = new System.Windows.Forms.TextBox();
            this.txtCodePostalVisiteur = new System.Windows.Forms.TextBox();
            this.txtNomVisiteur = new System.Windows.Forms.TextBox();
            this.txtPrenomVisiteur = new System.Windows.Forms.TextBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.groupBoxNomVisiteur = new System.Windows.Forms.GroupBox();
            this.groupBoxDateEmbauche = new System.Windows.Forms.GroupBox();
            this.groupBoxVille = new System.Windows.Forms.GroupBox();
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.groupBoxPrenomVisiteur = new System.Windows.Forms.GroupBox();
            this.groupBoxCodePostal = new System.Windows.Forms.GroupBox();
            this.groupBoxAdresse = new System.Windows.Forms.GroupBox();
            this.groupBoxMdp = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwVisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.groupBoxNomVisiteur.SuspendLayout();
            this.groupBoxDateEmbauche.SuspendLayout();
            this.groupBoxVille.SuspendLayout();
            this.groupBoxLogin.SuspendLayout();
            this.groupBoxPrenomVisiteur.SuspendLayout();
            this.groupBoxCodePostal.SuspendLayout();
            this.groupBoxAdresse.SuspendLayout();
            this.groupBoxMdp.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwVisiteur
            // 
            this.dgwVisiteur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwVisiteur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVis,
            this.nomVis,
            this.prenomVis,
            this.adresseVis,
            this.cpVis,
            this.villeVis,
            this.dateEmbaucheVis});
            this.dgwVisiteur.Location = new System.Drawing.Point(11, 12);
            this.dgwVisiteur.Name = "dgwVisiteur";
            this.dgwVisiteur.Size = new System.Drawing.Size(1351, 256);
            this.dgwVisiteur.TabIndex = 1;
            // 
            // idVis
            // 
            this.idVis.HeaderText = "numéro du visiteur";
            this.idVis.Name = "idVis";
            // 
            // nomVis
            // 
            this.nomVis.HeaderText = "nom";
            this.nomVis.Name = "nomVis";
            // 
            // prenomVis
            // 
            this.prenomVis.HeaderText = "prénom";
            this.prenomVis.Name = "prenomVis";
            // 
            // adresseVis
            // 
            this.adresseVis.HeaderText = "adresse";
            this.adresseVis.Name = "adresseVis";
            // 
            // cpVis
            // 
            this.cpVis.HeaderText = "code postal ";
            this.cpVis.Name = "cpVis";
            // 
            // villeVis
            // 
            this.villeVis.HeaderText = "ville";
            this.villeVis.Name = "villeVis";
            // 
            // dateEmbaucheVis
            // 
            this.dateEmbaucheVis.HeaderText = "date d\'embauche";
            this.dateEmbaucheVis.Name = "dateEmbaucheVis";
            // 
            // buttonModifierVisiteur
            // 
            this.buttonModifierVisiteur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonModifierVisiteur.Location = new System.Drawing.Point(416, 286);
            this.buttonModifierVisiteur.Name = "buttonModifierVisiteur";
            this.buttonModifierVisiteur.Size = new System.Drawing.Size(132, 29);
            this.buttonModifierVisiteur.TabIndex = 2;
            this.buttonModifierVisiteur.Text = "Modifier Visiteur";
            this.buttonModifierVisiteur.UseVisualStyleBackColor = true;
            // 
            // buttonSupprimerVisiteur
            // 
            this.buttonSupprimerVisiteur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSupprimerVisiteur.Location = new System.Drawing.Point(818, 286);
            this.buttonSupprimerVisiteur.Name = "buttonSupprimerVisiteur";
            this.buttonSupprimerVisiteur.Size = new System.Drawing.Size(132, 29);
            this.buttonSupprimerVisiteur.TabIndex = 3;
            this.buttonSupprimerVisiteur.Text = "Supprimer Visiteur";
            this.buttonSupprimerVisiteur.UseVisualStyleBackColor = true;
            // 
            // buttonValiderModificationVisiteur
            // 
            this.buttonValiderModificationVisiteur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonValiderModificationVisiteur.Location = new System.Drawing.Point(416, 736);
            this.buttonValiderModificationVisiteur.Name = "buttonValiderModificationVisiteur";
            this.buttonValiderModificationVisiteur.Size = new System.Drawing.Size(132, 29);
            this.buttonValiderModificationVisiteur.TabIndex = 4;
            this.buttonValiderModificationVisiteur.Text = "Valider Modification";
            this.buttonValiderModificationVisiteur.UseVisualStyleBackColor = true;
            // 
            // buttonAjouterVisiteur
            // 
            this.buttonAjouterVisiteur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAjouterVisiteur.Location = new System.Drawing.Point(818, 736);
            this.buttonAjouterVisiteur.Name = "buttonAjouterVisiteur";
            this.buttonAjouterVisiteur.Size = new System.Drawing.Size(132, 29);
            this.buttonAjouterVisiteur.TabIndex = 5;
            this.buttonAjouterVisiteur.Text = "Ajouter Visiteur";
            this.buttonAjouterVisiteur.UseVisualStyleBackColor = true;
            // 
            // txtMdpVisiteur
            // 
            this.txtMdpVisiteur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMdpVisiteur.Location = new System.Drawing.Point(108, 19);
            this.txtMdpVisiteur.Name = "txtMdpVisiteur";
            this.txtMdpVisiteur.Size = new System.Drawing.Size(341, 20);
            this.txtMdpVisiteur.TabIndex = 13;
            // 
            // txtLoginVisiteur
            // 
            this.txtLoginVisiteur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLoginVisiteur.Location = new System.Drawing.Point(108, 19);
            this.txtLoginVisiteur.Name = "txtLoginVisiteur";
            this.txtLoginVisiteur.Size = new System.Drawing.Size(309, 20);
            this.txtLoginVisiteur.TabIndex = 12;
            // 
            // txtVilleVisiteur
            // 
            this.txtVilleVisiteur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVilleVisiteur.Location = new System.Drawing.Point(108, 19);
            this.txtVilleVisiteur.Name = "txtVilleVisiteur";
            this.txtVilleVisiteur.Size = new System.Drawing.Size(309, 20);
            this.txtVilleVisiteur.TabIndex = 10;
            // 
            // txtAdresseVisiteur
            // 
            this.txtAdresseVisiteur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAdresseVisiteur.Location = new System.Drawing.Point(108, 19);
            this.txtAdresseVisiteur.Name = "txtAdresseVisiteur";
            this.txtAdresseVisiteur.Size = new System.Drawing.Size(341, 20);
            this.txtAdresseVisiteur.TabIndex = 11;
            // 
            // txtDateEmbaucheVisiteur
            // 
            this.txtDateEmbaucheVisiteur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDateEmbaucheVisiteur.Location = new System.Drawing.Point(108, 19);
            this.txtDateEmbaucheVisiteur.Name = "txtDateEmbaucheVisiteur";
            this.txtDateEmbaucheVisiteur.Size = new System.Drawing.Size(309, 20);
            this.txtDateEmbaucheVisiteur.TabIndex = 8;
            // 
            // txtCodePostalVisiteur
            // 
            this.txtCodePostalVisiteur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodePostalVisiteur.Location = new System.Drawing.Point(108, 19);
            this.txtCodePostalVisiteur.Name = "txtCodePostalVisiteur";
            this.txtCodePostalVisiteur.Size = new System.Drawing.Size(341, 20);
            this.txtCodePostalVisiteur.TabIndex = 9;
            // 
            // txtNomVisiteur
            // 
            this.txtNomVisiteur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomVisiteur.Location = new System.Drawing.Point(108, 19);
            this.txtNomVisiteur.Name = "txtNomVisiteur";
            this.txtNomVisiteur.Size = new System.Drawing.Size(309, 20);
            this.txtNomVisiteur.TabIndex = 6;
            // 
            // txtPrenomVisiteur
            // 
            this.txtPrenomVisiteur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrenomVisiteur.Location = new System.Drawing.Point(108, 19);
            this.txtPrenomVisiteur.Name = "txtPrenomVisiteur";
            this.txtPrenomVisiteur.Size = new System.Drawing.Size(341, 20);
            this.txtPrenomVisiteur.TabIndex = 7;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // groupBoxNomVisiteur
            // 
            this.groupBoxNomVisiteur.Controls.Add(this.txtNomVisiteur);
            this.groupBoxNomVisiteur.Location = new System.Drawing.Point(36, 362);
            this.groupBoxNomVisiteur.Name = "groupBoxNomVisiteur";
            this.groupBoxNomVisiteur.Size = new System.Drawing.Size(512, 57);
            this.groupBoxNomVisiteur.TabIndex = 21;
            this.groupBoxNomVisiteur.TabStop = false;
            this.groupBoxNomVisiteur.Text = "Nom du Visiteur";
            // 
            // groupBoxDateEmbauche
            // 
            this.groupBoxDateEmbauche.Controls.Add(this.txtDateEmbaucheVisiteur);
            this.groupBoxDateEmbauche.Location = new System.Drawing.Point(36, 454);
            this.groupBoxDateEmbauche.Name = "groupBoxDateEmbauche";
            this.groupBoxDateEmbauche.Size = new System.Drawing.Size(512, 57);
            this.groupBoxDateEmbauche.TabIndex = 22;
            this.groupBoxDateEmbauche.TabStop = false;
            this.groupBoxDateEmbauche.Text = "Date Embauche";
            // 
            // groupBoxVille
            // 
            this.groupBoxVille.Controls.Add(this.txtVilleVisiteur);
            this.groupBoxVille.Location = new System.Drawing.Point(36, 541);
            this.groupBoxVille.Name = "groupBoxVille";
            this.groupBoxVille.Size = new System.Drawing.Size(512, 57);
            this.groupBoxVille.TabIndex = 23;
            this.groupBoxVille.TabStop = false;
            this.groupBoxVille.Text = "Ville";
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.Controls.Add(this.txtLoginVisiteur);
            this.groupBoxLogin.Location = new System.Drawing.Point(36, 620);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Size = new System.Drawing.Size(512, 57);
            this.groupBoxLogin.TabIndex = 24;
            this.groupBoxLogin.TabStop = false;
            this.groupBoxLogin.Text = "Login";
            // 
            // groupBoxPrenomVisiteur
            // 
            this.groupBoxPrenomVisiteur.Controls.Add(this.txtPrenomVisiteur);
            this.groupBoxPrenomVisiteur.Location = new System.Drawing.Point(818, 362);
            this.groupBoxPrenomVisiteur.Name = "groupBoxPrenomVisiteur";
            this.groupBoxPrenomVisiteur.Size = new System.Drawing.Size(512, 57);
            this.groupBoxPrenomVisiteur.TabIndex = 25;
            this.groupBoxPrenomVisiteur.TabStop = false;
            this.groupBoxPrenomVisiteur.Text = "Prenom du Visiteur";
            // 
            // groupBoxCodePostal
            // 
            this.groupBoxCodePostal.Controls.Add(this.txtCodePostalVisiteur);
            this.groupBoxCodePostal.Location = new System.Drawing.Point(818, 454);
            this.groupBoxCodePostal.Name = "groupBoxCodePostal";
            this.groupBoxCodePostal.Size = new System.Drawing.Size(512, 57);
            this.groupBoxCodePostal.TabIndex = 26;
            this.groupBoxCodePostal.TabStop = false;
            this.groupBoxCodePostal.Text = "Code Postal";
            // 
            // groupBoxAdresse
            // 
            this.groupBoxAdresse.Controls.Add(this.txtAdresseVisiteur);
            this.groupBoxAdresse.Location = new System.Drawing.Point(818, 541);
            this.groupBoxAdresse.Name = "groupBoxAdresse";
            this.groupBoxAdresse.Size = new System.Drawing.Size(512, 57);
            this.groupBoxAdresse.TabIndex = 27;
            this.groupBoxAdresse.TabStop = false;
            this.groupBoxAdresse.Text = "Adresse";
            // 
            // groupBoxMdp
            // 
            this.groupBoxMdp.Controls.Add(this.txtMdpVisiteur);
            this.groupBoxMdp.Location = new System.Drawing.Point(818, 620);
            this.groupBoxMdp.Name = "groupBoxMdp";
            this.groupBoxMdp.Size = new System.Drawing.Size(512, 57);
            this.groupBoxMdp.TabIndex = 27;
            this.groupBoxMdp.TabStop = false;
            this.groupBoxMdp.Text = "Mot de Passe";
            // 
            // Visiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 809);
            this.Controls.Add(this.buttonAjouterVisiteur);
            this.Controls.Add(this.buttonValiderModificationVisiteur);
            this.Controls.Add(this.groupBoxMdp);
            this.Controls.Add(this.groupBoxAdresse);
            this.Controls.Add(this.groupBoxCodePostal);
            this.Controls.Add(this.groupBoxPrenomVisiteur);
            this.Controls.Add(this.groupBoxLogin);
            this.Controls.Add(this.groupBoxVille);
            this.Controls.Add(this.groupBoxDateEmbauche);
            this.Controls.Add(this.groupBoxNomVisiteur);
            this.Controls.Add(this.dgwVisiteur);
            this.Controls.Add(this.buttonSupprimerVisiteur);
            this.Controls.Add(this.buttonModifierVisiteur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Visiteur";
            this.Text = "Visiteur";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Visiteur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwVisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.groupBoxNomVisiteur.ResumeLayout(false);
            this.groupBoxNomVisiteur.PerformLayout();
            this.groupBoxDateEmbauche.ResumeLayout(false);
            this.groupBoxDateEmbauche.PerformLayout();
            this.groupBoxVille.ResumeLayout(false);
            this.groupBoxVille.PerformLayout();
            this.groupBoxLogin.ResumeLayout(false);
            this.groupBoxLogin.PerformLayout();
            this.groupBoxPrenomVisiteur.ResumeLayout(false);
            this.groupBoxPrenomVisiteur.PerformLayout();
            this.groupBoxCodePostal.ResumeLayout(false);
            this.groupBoxCodePostal.PerformLayout();
            this.groupBoxAdresse.ResumeLayout(false);
            this.groupBoxAdresse.PerformLayout();
            this.groupBoxMdp.ResumeLayout(false);
            this.groupBoxMdp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgwVisiteur;
        private System.Windows.Forms.Button buttonModifierVisiteur;
        private System.Windows.Forms.Button buttonSupprimerVisiteur;
        private System.Windows.Forms.Button buttonValiderModificationVisiteur;
        private System.Windows.Forms.Button buttonAjouterVisiteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVis;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomVis;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomVis;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseVis;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpVis;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeVis;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateEmbaucheVis;
        private System.Windows.Forms.TextBox txtMdpVisiteur;
        private System.Windows.Forms.TextBox txtLoginVisiteur;
        private System.Windows.Forms.TextBox txtVilleVisiteur;
        private System.Windows.Forms.TextBox txtAdresseVisiteur;
        private System.Windows.Forms.TextBox txtDateEmbaucheVisiteur;
        private System.Windows.Forms.TextBox txtCodePostalVisiteur;
        private System.Windows.Forms.TextBox txtNomVisiteur;
        private System.Windows.Forms.TextBox txtPrenomVisiteur;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.GroupBox groupBoxNomVisiteur;
        private System.Windows.Forms.GroupBox groupBoxMdp;
        private System.Windows.Forms.GroupBox groupBoxAdresse;
        private System.Windows.Forms.GroupBox groupBoxCodePostal;
        private System.Windows.Forms.GroupBox groupBoxPrenomVisiteur;
        private System.Windows.Forms.GroupBox groupBoxLogin;
        private System.Windows.Forms.GroupBox groupBoxVille;
        private System.Windows.Forms.GroupBox groupBoxDateEmbauche;
    }
}