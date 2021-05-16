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
            this.login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mdp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonModifierVisiteur = new System.Windows.Forms.Button();
            this.buttonSupprimerVisiteur = new System.Windows.Forms.Button();
            this.buttonValiderModificationVisiteur = new System.Windows.Forms.Button();
            this.buttonAjouterVisiteur = new System.Windows.Forms.Button();
            this.txtVilleVisiteur = new System.Windows.Forms.TextBox();
            this.txtAdresseVisiteur = new System.Windows.Forms.TextBox();
            this.txtCodePostalVisiteur = new System.Windows.Forms.TextBox();
            this.txtNomVisiteur = new System.Windows.Forms.TextBox();
            this.txtPrenomVisiteur = new System.Windows.Forms.TextBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.groupBoxNomVisiteur = new System.Windows.Forms.GroupBox();
            this.groupBoxVille = new System.Windows.Forms.GroupBox();
            this.groupBoxPrenomVisiteur = new System.Windows.Forms.GroupBox();
            this.groupBoxCodePostal = new System.Windows.Forms.GroupBox();
            this.groupBoxAdresse = new System.Windows.Forms.GroupBox();
            this.CalendrierDateEmbauche = new System.Windows.Forms.MonthCalendar();
            this.groupBoxDateEmbauche = new System.Windows.Forms.GroupBox();
            this.btn_Reinitialiser = new System.Windows.Forms.Button();
            this.btnAjoutVisiteur = new System.Windows.Forms.Button();
            this.btnRechercheVis = new System.Windows.Forms.Button();
            this.cboxNPVisiteurRechercher = new System.Windows.Forms.ComboBox();
            this.cboxVilleRechercher = new System.Windows.Forms.ComboBox();
            this.grpboxNPVisiteurRecherche = new System.Windows.Forms.GroupBox();
            this.grpboxVilleRecherche = new System.Windows.Forms.GroupBox();
            this.grpboxCPRechercher = new System.Windows.Forms.GroupBox();
            this.cboxCPRechercher = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwVisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.groupBoxNomVisiteur.SuspendLayout();
            this.groupBoxVille.SuspendLayout();
            this.groupBoxPrenomVisiteur.SuspendLayout();
            this.groupBoxCodePostal.SuspendLayout();
            this.groupBoxAdresse.SuspendLayout();
            this.groupBoxDateEmbauche.SuspendLayout();
            this.grpboxNPVisiteurRecherche.SuspendLayout();
            this.grpboxVilleRecherche.SuspendLayout();
            this.grpboxCPRechercher.SuspendLayout();
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
            this.dateEmbaucheVis,
            this.login,
            this.mdp});
            this.dgwVisiteur.Location = new System.Drawing.Point(18, 37);
            this.dgwVisiteur.Name = "dgwVisiteur";
            this.dgwVisiteur.Size = new System.Drawing.Size(1270, 236);
            this.dgwVisiteur.TabIndex = 80;
            this.dgwVisiteur.TabStop = false;
            // 
            // idVis
            // 
            this.idVis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idVis.HeaderText = "numéro du visiteur";
            this.idVis.Name = "idVis";
            // 
            // nomVis
            // 
            this.nomVis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomVis.HeaderText = "nom";
            this.nomVis.Name = "nomVis";
            // 
            // prenomVis
            // 
            this.prenomVis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prenomVis.HeaderText = "prénom";
            this.prenomVis.Name = "prenomVis";
            // 
            // adresseVis
            // 
            this.adresseVis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.adresseVis.HeaderText = "adresse";
            this.adresseVis.Name = "adresseVis";
            // 
            // cpVis
            // 
            this.cpVis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cpVis.HeaderText = "code postal ";
            this.cpVis.Name = "cpVis";
            // 
            // villeVis
            // 
            this.villeVis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.villeVis.HeaderText = "ville";
            this.villeVis.Name = "villeVis";
            // 
            // dateEmbaucheVis
            // 
            this.dateEmbaucheVis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateEmbaucheVis.HeaderText = "date d\'embauche";
            this.dateEmbaucheVis.Name = "dateEmbaucheVis";
            // 
            // login
            // 
            this.login.HeaderText = "Login";
            this.login.Name = "login";
            this.login.Visible = false;
            // 
            // mdp
            // 
            this.mdp.HeaderText = "mdp";
            this.mdp.Name = "mdp";
            this.mdp.Visible = false;
            // 
            // buttonModifierVisiteur
            // 
            this.buttonModifierVisiteur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonModifierVisiteur.Location = new System.Drawing.Point(576, 300);
            this.buttonModifierVisiteur.Name = "buttonModifierVisiteur";
            this.buttonModifierVisiteur.Size = new System.Drawing.Size(132, 29);
            this.buttonModifierVisiteur.TabIndex = 2;
            this.buttonModifierVisiteur.Text = "Modifier Visiteur";
            this.buttonModifierVisiteur.UseVisualStyleBackColor = true;
            this.buttonModifierVisiteur.Click += new System.EventHandler(this.buttonModifierVisiteur_Click);
            // 
            // buttonSupprimerVisiteur
            // 
            this.buttonSupprimerVisiteur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSupprimerVisiteur.Location = new System.Drawing.Point(855, 300);
            this.buttonSupprimerVisiteur.Name = "buttonSupprimerVisiteur";
            this.buttonSupprimerVisiteur.Size = new System.Drawing.Size(132, 29);
            this.buttonSupprimerVisiteur.TabIndex = 3;
            this.buttonSupprimerVisiteur.Text = "Supprimer Visiteur";
            this.buttonSupprimerVisiteur.UseVisualStyleBackColor = true;
            this.buttonSupprimerVisiteur.Click += new System.EventHandler(this.buttonSupprimerVisiteur_Click);
            // 
            // buttonValiderModificationVisiteur
            // 
            this.buttonValiderModificationVisiteur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonValiderModificationVisiteur.Location = new System.Drawing.Point(576, 645);
            this.buttonValiderModificationVisiteur.Name = "buttonValiderModificationVisiteur";
            this.buttonValiderModificationVisiteur.Size = new System.Drawing.Size(132, 29);
            this.buttonValiderModificationVisiteur.TabIndex = 7;
            this.buttonValiderModificationVisiteur.Text = "Valider Modification";
            this.buttonValiderModificationVisiteur.UseVisualStyleBackColor = true;
            this.buttonValiderModificationVisiteur.Click += new System.EventHandler(this.buttonValiderModificationVisiteur_Click);
            // 
            // buttonAjouterVisiteur
            // 
            this.buttonAjouterVisiteur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAjouterVisiteur.Location = new System.Drawing.Point(303, 300);
            this.buttonAjouterVisiteur.Name = "buttonAjouterVisiteur";
            this.buttonAjouterVisiteur.Size = new System.Drawing.Size(132, 29);
            this.buttonAjouterVisiteur.TabIndex = 1;
            this.buttonAjouterVisiteur.Text = "Ajouter Visiteur";
            this.buttonAjouterVisiteur.UseVisualStyleBackColor = true;
            this.buttonAjouterVisiteur.Click += new System.EventHandler(this.buttonAjouterVisiteur_Click);
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
            this.groupBoxNomVisiteur.Location = new System.Drawing.Point(36, 348);
            this.groupBoxNomVisiteur.Name = "groupBoxNomVisiteur";
            this.groupBoxNomVisiteur.Size = new System.Drawing.Size(512, 57);
            this.groupBoxNomVisiteur.TabIndex = 1;
            this.groupBoxNomVisiteur.TabStop = false;
            this.groupBoxNomVisiteur.Text = "Nom du Visiteur";
            // 
            // groupBoxVille
            // 
            this.groupBoxVille.Controls.Add(this.txtVilleVisiteur);
            this.groupBoxVille.Location = new System.Drawing.Point(36, 418);
            this.groupBoxVille.Name = "groupBoxVille";
            this.groupBoxVille.Size = new System.Drawing.Size(512, 57);
            this.groupBoxVille.TabIndex = 3;
            this.groupBoxVille.TabStop = false;
            this.groupBoxVille.Text = "Ville";
            // 
            // groupBoxPrenomVisiteur
            // 
            this.groupBoxPrenomVisiteur.Controls.Add(this.txtPrenomVisiteur);
            this.groupBoxPrenomVisiteur.Location = new System.Drawing.Point(755, 348);
            this.groupBoxPrenomVisiteur.Name = "groupBoxPrenomVisiteur";
            this.groupBoxPrenomVisiteur.Size = new System.Drawing.Size(512, 57);
            this.groupBoxPrenomVisiteur.TabIndex = 2;
            this.groupBoxPrenomVisiteur.TabStop = false;
            this.groupBoxPrenomVisiteur.Text = "Prenom du Visiteur";
            // 
            // groupBoxCodePostal
            // 
            this.groupBoxCodePostal.Controls.Add(this.txtCodePostalVisiteur);
            this.groupBoxCodePostal.Location = new System.Drawing.Point(36, 490);
            this.groupBoxCodePostal.Name = "groupBoxCodePostal";
            this.groupBoxCodePostal.Size = new System.Drawing.Size(512, 57);
            this.groupBoxCodePostal.TabIndex = 4;
            this.groupBoxCodePostal.TabStop = false;
            this.groupBoxCodePostal.Text = "Code Postal";
            // 
            // groupBoxAdresse
            // 
            this.groupBoxAdresse.Controls.Add(this.txtAdresseVisiteur);
            this.groupBoxAdresse.Location = new System.Drawing.Point(36, 562);
            this.groupBoxAdresse.Name = "groupBoxAdresse";
            this.groupBoxAdresse.Size = new System.Drawing.Size(512, 57);
            this.groupBoxAdresse.TabIndex = 5;
            this.groupBoxAdresse.TabStop = false;
            this.groupBoxAdresse.Text = "Adresse";
            // 
            // CalendrierDateEmbauche
            // 
            this.CalendrierDateEmbauche.Location = new System.Drawing.Point(163, 21);
            this.CalendrierDateEmbauche.Name = "CalendrierDateEmbauche";
            this.CalendrierDateEmbauche.TabIndex = 28;
            // 
            // groupBoxDateEmbauche
            // 
            this.groupBoxDateEmbauche.Controls.Add(this.CalendrierDateEmbauche);
            this.groupBoxDateEmbauche.Location = new System.Drawing.Point(755, 418);
            this.groupBoxDateEmbauche.Name = "groupBoxDateEmbauche";
            this.groupBoxDateEmbauche.Size = new System.Drawing.Size(512, 201);
            this.groupBoxDateEmbauche.TabIndex = 6;
            this.groupBoxDateEmbauche.TabStop = false;
            this.groupBoxDateEmbauche.Text = "Date d\'Embauche";
            // 
            // btn_Reinitialiser
            // 
            this.btn_Reinitialiser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Reinitialiser.Location = new System.Drawing.Point(1072, 645);
            this.btn_Reinitialiser.Name = "btn_Reinitialiser";
            this.btn_Reinitialiser.Size = new System.Drawing.Size(132, 29);
            this.btn_Reinitialiser.TabIndex = 43;
            this.btn_Reinitialiser.Text = "Réinitialiser";
            this.btn_Reinitialiser.UseVisualStyleBackColor = true;
            this.btn_Reinitialiser.Click += new System.EventHandler(this.btn_Reinitialiser_Click);
            // 
            // btnAjoutVisiteur
            // 
            this.btnAjoutVisiteur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAjoutVisiteur.Location = new System.Drawing.Point(576, 645);
            this.btnAjoutVisiteur.Name = "btnAjoutVisiteur";
            this.btnAjoutVisiteur.Size = new System.Drawing.Size(132, 29);
            this.btnAjoutVisiteur.TabIndex = 7;
            this.btnAjoutVisiteur.Text = "Ajouter le Visiteur";
            this.btnAjoutVisiteur.UseVisualStyleBackColor = true;
            this.btnAjoutVisiteur.Click += new System.EventHandler(this.btnAjoutVisiteur_Click);
            // 
            // btnRechercheVis
            // 
            this.btnRechercheVis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRechercheVis.Location = new System.Drawing.Point(576, 446);
            this.btnRechercheVis.Name = "btnRechercheVis";
            this.btnRechercheVis.Size = new System.Drawing.Size(132, 29);
            this.btnRechercheVis.TabIndex = 4;
            this.btnRechercheVis.Text = "Rechercher Visiteur";
            this.btnRechercheVis.UseVisualStyleBackColor = true;
            this.btnRechercheVis.Click += new System.EventHandler(this.btnRechercheVis_Click);
            // 
            // cboxNPVisiteurRechercher
            // 
            this.cboxNPVisiteurRechercher.FormattingEnabled = true;
            this.cboxNPVisiteurRechercher.Location = new System.Drawing.Point(108, 19);
            this.cboxNPVisiteurRechercher.Name = "cboxNPVisiteurRechercher";
            this.cboxNPVisiteurRechercher.Size = new System.Drawing.Size(309, 21);
            this.cboxNPVisiteurRechercher.TabIndex = 33;
            this.cboxNPVisiteurRechercher.TextChanged += new System.EventHandler(this.cboxNPVisiteurRechercher_TextChanged);
            // 
            // cboxVilleRechercher
            // 
            this.cboxVilleRechercher.FormattingEnabled = true;
            this.cboxVilleRechercher.Location = new System.Drawing.Point(108, 15);
            this.cboxVilleRechercher.Name = "cboxVilleRechercher";
            this.cboxVilleRechercher.Size = new System.Drawing.Size(309, 21);
            this.cboxVilleRechercher.TabIndex = 34;
            this.cboxVilleRechercher.TextChanged += new System.EventHandler(this.cboxVilleRechercher_TextChanged);
            // 
            // grpboxNPVisiteurRecherche
            // 
            this.grpboxNPVisiteurRecherche.Controls.Add(this.cboxNPVisiteurRechercher);
            this.grpboxNPVisiteurRecherche.Location = new System.Drawing.Point(30, 348);
            this.grpboxNPVisiteurRecherche.Name = "grpboxNPVisiteurRecherche";
            this.grpboxNPVisiteurRecherche.Size = new System.Drawing.Size(512, 57);
            this.grpboxNPVisiteurRecherche.TabIndex = 40;
            this.grpboxNPVisiteurRecherche.TabStop = false;
            this.grpboxNPVisiteurRecherche.Text = "Nom - Prenom du Visiteur";
            this.grpboxNPVisiteurRecherche.Visible = false;
            // 
            // grpboxVilleRecherche
            // 
            this.grpboxVilleRecherche.Controls.Add(this.cboxVilleRechercher);
            this.grpboxVilleRecherche.Location = new System.Drawing.Point(30, 418);
            this.grpboxVilleRecherche.Name = "grpboxVilleRecherche";
            this.grpboxVilleRecherche.Size = new System.Drawing.Size(512, 57);
            this.grpboxVilleRecherche.TabIndex = 41;
            this.grpboxVilleRecherche.TabStop = false;
            this.grpboxVilleRecherche.Text = "Ville";
            this.grpboxVilleRecherche.Visible = false;
            // 
            // grpboxCPRechercher
            // 
            this.grpboxCPRechercher.Controls.Add(this.cboxCPRechercher);
            this.grpboxCPRechercher.Location = new System.Drawing.Point(30, 490);
            this.grpboxCPRechercher.Name = "grpboxCPRechercher";
            this.grpboxCPRechercher.Size = new System.Drawing.Size(512, 57);
            this.grpboxCPRechercher.TabIndex = 42;
            this.grpboxCPRechercher.TabStop = false;
            this.grpboxCPRechercher.Text = "Code Postal";
            this.grpboxCPRechercher.Visible = false;
            // 
            // cboxCPRechercher
            // 
            this.cboxCPRechercher.FormattingEnabled = true;
            this.cboxCPRechercher.Location = new System.Drawing.Point(108, 18);
            this.cboxCPRechercher.Name = "cboxCPRechercher";
            this.cboxCPRechercher.Size = new System.Drawing.Size(309, 21);
            this.cboxCPRechercher.TabIndex = 0;
            this.cboxCPRechercher.TextChanged += new System.EventHandler(this.cboxCPRechercher_TextChanged);
            // 
            // Visiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 722);
            this.Controls.Add(this.grpboxCPRechercher);
            this.Controls.Add(this.grpboxNPVisiteurRecherche);
            this.Controls.Add(this.btnRechercheVis);
            this.Controls.Add(this.grpboxVilleRecherche);
            this.Controls.Add(this.btnAjoutVisiteur);
            this.Controls.Add(this.btn_Reinitialiser);
            this.Controls.Add(this.buttonAjouterVisiteur);
            this.Controls.Add(this.groupBoxDateEmbauche);
            this.Controls.Add(this.buttonValiderModificationVisiteur);
            this.Controls.Add(this.groupBoxAdresse);
            this.Controls.Add(this.groupBoxCodePostal);
            this.Controls.Add(this.groupBoxPrenomVisiteur);
            this.Controls.Add(this.groupBoxVille);
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
            this.groupBoxVille.ResumeLayout(false);
            this.groupBoxVille.PerformLayout();
            this.groupBoxPrenomVisiteur.ResumeLayout(false);
            this.groupBoxPrenomVisiteur.PerformLayout();
            this.groupBoxCodePostal.ResumeLayout(false);
            this.groupBoxCodePostal.PerformLayout();
            this.groupBoxAdresse.ResumeLayout(false);
            this.groupBoxAdresse.PerformLayout();
            this.groupBoxDateEmbauche.ResumeLayout(false);
            this.grpboxNPVisiteurRecherche.ResumeLayout(false);
            this.grpboxVilleRecherche.ResumeLayout(false);
            this.grpboxCPRechercher.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgwVisiteur;
        private System.Windows.Forms.Button buttonModifierVisiteur;
        private System.Windows.Forms.Button buttonSupprimerVisiteur;
        private System.Windows.Forms.Button buttonValiderModificationVisiteur;
        private System.Windows.Forms.Button buttonAjouterVisiteur;
        private System.Windows.Forms.TextBox txtVilleVisiteur;
        private System.Windows.Forms.TextBox txtAdresseVisiteur;
        private System.Windows.Forms.TextBox txtCodePostalVisiteur;
        private System.Windows.Forms.TextBox txtNomVisiteur;
        private System.Windows.Forms.TextBox txtPrenomVisiteur;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.GroupBox groupBoxNomVisiteur;
        private System.Windows.Forms.GroupBox groupBoxAdresse;
        private System.Windows.Forms.GroupBox groupBoxCodePostal;
        private System.Windows.Forms.GroupBox groupBoxPrenomVisiteur;
        private System.Windows.Forms.GroupBox groupBoxVille;
        private System.Windows.Forms.GroupBox groupBoxDateEmbauche;
        private System.Windows.Forms.MonthCalendar CalendrierDateEmbauche;
        private System.Windows.Forms.Button btn_Reinitialiser;
        private System.Windows.Forms.Button btnAjoutVisiteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVis;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomVis;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomVis;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseVis;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpVis;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeVis;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateEmbaucheVis;
        private System.Windows.Forms.DataGridViewTextBoxColumn login;
        private System.Windows.Forms.DataGridViewTextBoxColumn mdp;
        private System.Windows.Forms.Button btnRechercheVis;
        private System.Windows.Forms.GroupBox grpboxVilleRecherche;
        private System.Windows.Forms.ComboBox cboxVilleRechercher;
        private System.Windows.Forms.GroupBox grpboxNPVisiteurRecherche;
        private System.Windows.Forms.ComboBox cboxNPVisiteurRechercher;
        private System.Windows.Forms.GroupBox grpboxCPRechercher;
        private System.Windows.Forms.ComboBox cboxCPRechercher;
    }
}