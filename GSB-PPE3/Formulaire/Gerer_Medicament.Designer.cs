namespace Formulaire
{
    partial class Gerer_Medicament
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
            this.dgwGererMedicament = new System.Windows.Forms.DataGridView();
            this.idMedicament = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomCommercialMedicament = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFamilleMedicament = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compositionMedicament = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.effetsMedicament = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contreIndicationsMedicament = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonModifierMedicament = new System.Windows.Forms.Button();
            this.buttonSupprimerMedicament = new System.Windows.Forms.Button();
            this.buttonValiderModification = new System.Windows.Forms.Button();
            this.buttonAjouterMedicament = new System.Windows.Forms.Button();
            this.txtNomMedicament = new System.Windows.Forms.TextBox();
            this.txtCompositionMedicament = new System.Windows.Forms.TextBox();
            this.txtEffetMedicament = new System.Windows.Forms.TextBox();
            this.txtContreIndicationMedicament = new System.Windows.Forms.TextBox();
            this.comboBoxFamilleMedicament = new System.Windows.Forms.ComboBox();
            this.groupBoxNomMedicament = new System.Windows.Forms.GroupBox();
            this.groupBoxCompositionMedicament = new System.Windows.Forms.GroupBox();
            this.groupBoxEffetMedicament = new System.Windows.Forms.GroupBox();
            this.groupBoxFamilleMedicament = new System.Windows.Forms.GroupBox();
            this.groupBoxContreIndication = new System.Windows.Forms.GroupBox();
            this.btnValiderAjout = new System.Windows.Forms.Button();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.grpboxRechercherNom = new System.Windows.Forms.GroupBox();
            this.cboxRechercherNom = new System.Windows.Forms.ComboBox();
            this.grpboxRechercherCompo = new System.Windows.Forms.GroupBox();
            this.cboxRechercherCompo = new System.Windows.Forms.ComboBox();
            this.grpboxRechercheCI = new System.Windows.Forms.GroupBox();
            this.cboxRechercheCI = new System.Windows.Forms.ComboBox();
            this.grpboxRechercheEffet = new System.Windows.Forms.GroupBox();
            this.cboxRechercheEffet = new System.Windows.Forms.ComboBox();
            this.grpboxRechercheFamille = new System.Windows.Forms.GroupBox();
            this.cboxRechercheFamille = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwGererMedicament)).BeginInit();
            this.groupBoxNomMedicament.SuspendLayout();
            this.groupBoxCompositionMedicament.SuspendLayout();
            this.groupBoxEffetMedicament.SuspendLayout();
            this.groupBoxFamilleMedicament.SuspendLayout();
            this.groupBoxContreIndication.SuspendLayout();
            this.grpboxRechercherNom.SuspendLayout();
            this.grpboxRechercherCompo.SuspendLayout();
            this.grpboxRechercheCI.SuspendLayout();
            this.grpboxRechercheEffet.SuspendLayout();
            this.grpboxRechercheFamille.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwGererMedicament
            // 
            this.dgwGererMedicament.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwGererMedicament.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMedicament,
            this.nomCommercialMedicament,
            this.idFamilleMedicament,
            this.compositionMedicament,
            this.effetsMedicament,
            this.contreIndicationsMedicament});
            this.dgwGererMedicament.Location = new System.Drawing.Point(12, 30);
            this.dgwGererMedicament.Name = "dgwGererMedicament";
            this.dgwGererMedicament.Size = new System.Drawing.Size(1276, 255);
            this.dgwGererMedicament.TabIndex = 1;
            this.dgwGererMedicament.TabStop = false;
            // 
            // idMedicament
            // 
            this.idMedicament.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idMedicament.HeaderText = "Numéro du Médicament";
            this.idMedicament.Name = "idMedicament";
            // 
            // nomCommercialMedicament
            // 
            this.nomCommercialMedicament.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomCommercialMedicament.HeaderText = "Nom Commercial";
            this.nomCommercialMedicament.Name = "nomCommercialMedicament";
            // 
            // idFamilleMedicament
            // 
            this.idFamilleMedicament.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idFamilleMedicament.HeaderText = "Libelle de la Famille ";
            this.idFamilleMedicament.Name = "idFamilleMedicament";
            // 
            // compositionMedicament
            // 
            this.compositionMedicament.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.compositionMedicament.HeaderText = "Composition";
            this.compositionMedicament.Name = "compositionMedicament";
            // 
            // effetsMedicament
            // 
            this.effetsMedicament.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.effetsMedicament.HeaderText = "Effets";
            this.effetsMedicament.Name = "effetsMedicament";
            // 
            // contreIndicationsMedicament
            // 
            this.contreIndicationsMedicament.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.contreIndicationsMedicament.HeaderText = "Contre Indications";
            this.contreIndicationsMedicament.Name = "contreIndicationsMedicament";
            // 
            // buttonModifierMedicament
            // 
            this.buttonModifierMedicament.Location = new System.Drawing.Point(615, 304);
            this.buttonModifierMedicament.Name = "buttonModifierMedicament";
            this.buttonModifierMedicament.Size = new System.Drawing.Size(98, 39);
            this.buttonModifierMedicament.TabIndex = 2;
            this.buttonModifierMedicament.Text = "Modifier ";
            this.buttonModifierMedicament.UseVisualStyleBackColor = true;
            this.buttonModifierMedicament.Click += new System.EventHandler(this.buttonModifierMedicament_Click);
            // 
            // buttonSupprimerMedicament
            // 
            this.buttonSupprimerMedicament.Location = new System.Drawing.Point(749, 304);
            this.buttonSupprimerMedicament.Name = "buttonSupprimerMedicament";
            this.buttonSupprimerMedicament.Size = new System.Drawing.Size(98, 39);
            this.buttonSupprimerMedicament.TabIndex = 3;
            this.buttonSupprimerMedicament.Text = "Supprimer ";
            this.buttonSupprimerMedicament.UseVisualStyleBackColor = true;
            this.buttonSupprimerMedicament.Click += new System.EventHandler(this.buttonSupprimerMedicament_Click);
            // 
            // buttonValiderModification
            // 
            this.buttonValiderModification.Location = new System.Drawing.Point(615, 648);
            this.buttonValiderModification.Name = "buttonValiderModification";
            this.buttonValiderModification.Size = new System.Drawing.Size(98, 39);
            this.buttonValiderModification.TabIndex = 4;
            this.buttonValiderModification.Text = "Valider Modification";
            this.buttonValiderModification.UseVisualStyleBackColor = true;
            this.buttonValiderModification.Visible = false;
            this.buttonValiderModification.Click += new System.EventHandler(this.buttonValiderModification_Click);
            // 
            // buttonAjouterMedicament
            // 
            this.buttonAjouterMedicament.Location = new System.Drawing.Point(480, 304);
            this.buttonAjouterMedicament.Name = "buttonAjouterMedicament";
            this.buttonAjouterMedicament.Size = new System.Drawing.Size(98, 39);
            this.buttonAjouterMedicament.TabIndex = 5;
            this.buttonAjouterMedicament.Text = "Ajouter ";
            this.buttonAjouterMedicament.UseVisualStyleBackColor = true;
            this.buttonAjouterMedicament.Click += new System.EventHandler(this.buttonAjouterMedicament_Click);
            // 
            // txtNomMedicament
            // 
            this.txtNomMedicament.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtNomMedicament.Location = new System.Drawing.Point(30, 47);
            this.txtNomMedicament.Name = "txtNomMedicament";
            this.txtNomMedicament.Size = new System.Drawing.Size(305, 20);
            this.txtNomMedicament.TabIndex = 0;
            // 
            // txtCompositionMedicament
            // 
            this.txtCompositionMedicament.Location = new System.Drawing.Point(53, 38);
            this.txtCompositionMedicament.Name = "txtCompositionMedicament";
            this.txtCompositionMedicament.Size = new System.Drawing.Size(305, 20);
            this.txtCompositionMedicament.TabIndex = 2;
            // 
            // txtEffetMedicament
            // 
            this.txtEffetMedicament.Location = new System.Drawing.Point(37, 47);
            this.txtEffetMedicament.Name = "txtEffetMedicament";
            this.txtEffetMedicament.Size = new System.Drawing.Size(305, 20);
            this.txtEffetMedicament.TabIndex = 3;
            // 
            // txtContreIndicationMedicament
            // 
            this.txtContreIndicationMedicament.Location = new System.Drawing.Point(55, 42);
            this.txtContreIndicationMedicament.Name = "txtContreIndicationMedicament";
            this.txtContreIndicationMedicament.Size = new System.Drawing.Size(305, 20);
            this.txtContreIndicationMedicament.TabIndex = 4;
            // 
            // comboBoxFamilleMedicament
            // 
            this.comboBoxFamilleMedicament.FormattingEnabled = true;
            this.comboBoxFamilleMedicament.Location = new System.Drawing.Point(45, 48);
            this.comboBoxFamilleMedicament.Name = "comboBoxFamilleMedicament";
            this.comboBoxFamilleMedicament.Size = new System.Drawing.Size(305, 21);
            this.comboBoxFamilleMedicament.TabIndex = 1;
            // 
            // groupBoxNomMedicament
            // 
            this.groupBoxNomMedicament.Controls.Add(this.txtNomMedicament);
            this.groupBoxNomMedicament.Location = new System.Drawing.Point(36, 396);
            this.groupBoxNomMedicament.Name = "groupBoxNomMedicament";
            this.groupBoxNomMedicament.Size = new System.Drawing.Size(380, 102);
            this.groupBoxNomMedicament.TabIndex = 12;
            this.groupBoxNomMedicament.TabStop = false;
            this.groupBoxNomMedicament.Text = "Nom du Médicament";
            this.groupBoxNomMedicament.Visible = false;
            // 
            // groupBoxCompositionMedicament
            // 
            this.groupBoxCompositionMedicament.Controls.Add(this.txtCompositionMedicament);
            this.groupBoxCompositionMedicament.Location = new System.Drawing.Point(893, 396);
            this.groupBoxCompositionMedicament.Name = "groupBoxCompositionMedicament";
            this.groupBoxCompositionMedicament.Size = new System.Drawing.Size(380, 102);
            this.groupBoxCompositionMedicament.TabIndex = 14;
            this.groupBoxCompositionMedicament.TabStop = false;
            this.groupBoxCompositionMedicament.Text = "Composition du Médicament";
            this.groupBoxCompositionMedicament.Visible = false;
            // 
            // groupBoxEffetMedicament
            // 
            this.groupBoxEffetMedicament.Controls.Add(this.txtEffetMedicament);
            this.groupBoxEffetMedicament.Location = new System.Drawing.Point(236, 524);
            this.groupBoxEffetMedicament.Name = "groupBoxEffetMedicament";
            this.groupBoxEffetMedicament.Size = new System.Drawing.Size(380, 102);
            this.groupBoxEffetMedicament.TabIndex = 15;
            this.groupBoxEffetMedicament.TabStop = false;
            this.groupBoxEffetMedicament.Text = "Effet du Médicament";
            this.groupBoxEffetMedicament.Visible = false;
            // 
            // groupBoxFamilleMedicament
            // 
            this.groupBoxFamilleMedicament.Controls.Add(this.comboBoxFamilleMedicament);
            this.groupBoxFamilleMedicament.Location = new System.Drawing.Point(467, 396);
            this.groupBoxFamilleMedicament.Name = "groupBoxFamilleMedicament";
            this.groupBoxFamilleMedicament.Size = new System.Drawing.Size(380, 102);
            this.groupBoxFamilleMedicament.TabIndex = 13;
            this.groupBoxFamilleMedicament.TabStop = false;
            this.groupBoxFamilleMedicament.Text = "Libelle de la Famille du Médicament";
            this.groupBoxFamilleMedicament.Visible = false;
            // 
            // groupBoxContreIndication
            // 
            this.groupBoxContreIndication.Controls.Add(this.txtContreIndicationMedicament);
            this.groupBoxContreIndication.Location = new System.Drawing.Point(709, 524);
            this.groupBoxContreIndication.Name = "groupBoxContreIndication";
            this.groupBoxContreIndication.Size = new System.Drawing.Size(380, 102);
            this.groupBoxContreIndication.TabIndex = 16;
            this.groupBoxContreIndication.TabStop = false;
            this.groupBoxContreIndication.Text = "Contre Indications ";
            this.groupBoxContreIndication.Visible = false;
            // 
            // btnValiderAjout
            // 
            this.btnValiderAjout.Location = new System.Drawing.Point(615, 649);
            this.btnValiderAjout.Name = "btnValiderAjout";
            this.btnValiderAjout.Size = new System.Drawing.Size(98, 39);
            this.btnValiderAjout.TabIndex = 25;
            this.btnValiderAjout.Text = "Valider ";
            this.btnValiderAjout.UseVisualStyleBackColor = true;
            this.btnValiderAjout.Visible = false;
            this.btnValiderAjout.Click += new System.EventHandler(this.btnValiderAjout_Click);
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(1153, 304);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(98, 39);
            this.btnRechercher.TabIndex = 17;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(1153, 648);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(98, 39);
            this.btnRetour.TabIndex = 26;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Visible = false;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // grpboxRechercherNom
            // 
            this.grpboxRechercherNom.Controls.Add(this.cboxRechercherNom);
            this.grpboxRechercherNom.Location = new System.Drawing.Point(30, 396);
            this.grpboxRechercherNom.Name = "grpboxRechercherNom";
            this.grpboxRechercherNom.Size = new System.Drawing.Size(380, 102);
            this.grpboxRechercherNom.TabIndex = 20;
            this.grpboxRechercherNom.TabStop = false;
            this.grpboxRechercherNom.Text = "Nom du Médicament";
            this.grpboxRechercherNom.Visible = false;
            // 
            // cboxRechercherNom
            // 
            this.cboxRechercherNom.FormattingEnabled = true;
            this.cboxRechercherNom.Location = new System.Drawing.Point(22, 40);
            this.cboxRechercherNom.Name = "cboxRechercherNom";
            this.cboxRechercherNom.Size = new System.Drawing.Size(305, 21);
            this.cboxRechercherNom.TabIndex = 5;
            this.cboxRechercherNom.TextChanged += new System.EventHandler(this.cboxRechercherNom_TextChanged);
            // 
            // grpboxRechercherCompo
            // 
            this.grpboxRechercherCompo.Controls.Add(this.cboxRechercherCompo);
            this.grpboxRechercherCompo.Location = new System.Drawing.Point(887, 396);
            this.grpboxRechercherCompo.Name = "grpboxRechercherCompo";
            this.grpboxRechercherCompo.Size = new System.Drawing.Size(380, 102);
            this.grpboxRechercherCompo.TabIndex = 22;
            this.grpboxRechercherCompo.TabStop = false;
            this.grpboxRechercherCompo.Text = "Composition du Médicament";
            this.grpboxRechercherCompo.Visible = false;
            // 
            // cboxRechercherCompo
            // 
            this.cboxRechercherCompo.FormattingEnabled = true;
            this.cboxRechercherCompo.Location = new System.Drawing.Point(47, 48);
            this.cboxRechercherCompo.Name = "cboxRechercherCompo";
            this.cboxRechercherCompo.Size = new System.Drawing.Size(305, 21);
            this.cboxRechercherCompo.TabIndex = 7;
            this.cboxRechercherCompo.TextChanged += new System.EventHandler(this.cboxRechercherCompo_TextChanged);
            // 
            // grpboxRechercheCI
            // 
            this.grpboxRechercheCI.Controls.Add(this.cboxRechercheCI);
            this.grpboxRechercheCI.Location = new System.Drawing.Point(703, 524);
            this.grpboxRechercheCI.Name = "grpboxRechercheCI";
            this.grpboxRechercheCI.Size = new System.Drawing.Size(380, 102);
            this.grpboxRechercheCI.TabIndex = 24;
            this.grpboxRechercheCI.TabStop = false;
            this.grpboxRechercheCI.Text = "Contre Indications ";
            this.grpboxRechercheCI.Visible = false;
            // 
            // cboxRechercheCI
            // 
            this.cboxRechercheCI.FormattingEnabled = true;
            this.cboxRechercheCI.Location = new System.Drawing.Point(22, 40);
            this.cboxRechercheCI.Name = "cboxRechercheCI";
            this.cboxRechercheCI.Size = new System.Drawing.Size(338, 21);
            this.cboxRechercheCI.TabIndex = 9;
            this.cboxRechercheCI.TextChanged += new System.EventHandler(this.cboxRechercheCI_TextChanged);
            // 
            // grpboxRechercheEffet
            // 
            this.grpboxRechercheEffet.Controls.Add(this.cboxRechercheEffet);
            this.grpboxRechercheEffet.Location = new System.Drawing.Point(230, 524);
            this.grpboxRechercheEffet.Name = "grpboxRechercheEffet";
            this.grpboxRechercheEffet.Size = new System.Drawing.Size(380, 102);
            this.grpboxRechercheEffet.TabIndex = 23;
            this.grpboxRechercheEffet.TabStop = false;
            this.grpboxRechercheEffet.Text = "Effet du Médicament";
            this.grpboxRechercheEffet.Visible = false;
            // 
            // cboxRechercheEffet
            // 
            this.cboxRechercheEffet.FormattingEnabled = true;
            this.cboxRechercheEffet.Location = new System.Drawing.Point(14, 42);
            this.cboxRechercheEffet.Name = "cboxRechercheEffet";
            this.cboxRechercheEffet.Size = new System.Drawing.Size(346, 21);
            this.cboxRechercheEffet.TabIndex = 8;
            this.cboxRechercheEffet.TextChanged += new System.EventHandler(this.cboxRechercheEffet_TextChanged);
            // 
            // grpboxRechercheFamille
            // 
            this.grpboxRechercheFamille.Controls.Add(this.cboxRechercheFamille);
            this.grpboxRechercheFamille.Location = new System.Drawing.Point(461, 396);
            this.grpboxRechercheFamille.Name = "grpboxRechercheFamille";
            this.grpboxRechercheFamille.Size = new System.Drawing.Size(380, 102);
            this.grpboxRechercheFamille.TabIndex = 21;
            this.grpboxRechercheFamille.TabStop = false;
            this.grpboxRechercheFamille.Text = "Libelle de la Famille du Médicament";
            this.grpboxRechercheFamille.Visible = false;
            // 
            // cboxRechercheFamille
            // 
            this.cboxRechercheFamille.FormattingEnabled = true;
            this.cboxRechercheFamille.Location = new System.Drawing.Point(45, 48);
            this.cboxRechercheFamille.Name = "cboxRechercheFamille";
            this.cboxRechercheFamille.Size = new System.Drawing.Size(305, 21);
            this.cboxRechercheFamille.TabIndex = 6;
            this.cboxRechercheFamille.TextChanged += new System.EventHandler(this.cboxRechercheFamille_TextChanged);
            // 
            // Gerer_Medicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 722);
            this.Controls.Add(this.grpboxRechercherCompo);
            this.Controls.Add(this.grpboxRechercheFamille);
            this.Controls.Add(this.grpboxRechercheCI);
            this.Controls.Add(this.grpboxRechercherNom);
            this.Controls.Add(this.grpboxRechercheEffet);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.btnValiderAjout);
            this.Controls.Add(this.groupBoxContreIndication);
            this.Controls.Add(this.groupBoxFamilleMedicament);
            this.Controls.Add(this.groupBoxEffetMedicament);
            this.Controls.Add(this.groupBoxCompositionMedicament);
            this.Controls.Add(this.groupBoxNomMedicament);
            this.Controls.Add(this.buttonAjouterMedicament);
            this.Controls.Add(this.buttonValiderModification);
            this.Controls.Add(this.buttonSupprimerMedicament);
            this.Controls.Add(this.buttonModifierMedicament);
            this.Controls.Add(this.dgwGererMedicament);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Gerer_Medicament";
            this.Text = "Gerer_Medicament";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Gerer_Medicament_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwGererMedicament)).EndInit();
            this.groupBoxNomMedicament.ResumeLayout(false);
            this.groupBoxNomMedicament.PerformLayout();
            this.groupBoxCompositionMedicament.ResumeLayout(false);
            this.groupBoxCompositionMedicament.PerformLayout();
            this.groupBoxEffetMedicament.ResumeLayout(false);
            this.groupBoxEffetMedicament.PerformLayout();
            this.groupBoxFamilleMedicament.ResumeLayout(false);
            this.groupBoxContreIndication.ResumeLayout(false);
            this.groupBoxContreIndication.PerformLayout();
            this.grpboxRechercherNom.ResumeLayout(false);
            this.grpboxRechercherCompo.ResumeLayout(false);
            this.grpboxRechercheCI.ResumeLayout(false);
            this.grpboxRechercheEffet.ResumeLayout(false);
            this.grpboxRechercheFamille.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgwGererMedicament;
        private System.Windows.Forms.Button buttonModifierMedicament;
        private System.Windows.Forms.Button buttonSupprimerMedicament;
        private System.Windows.Forms.Button buttonValiderModification;
        private System.Windows.Forms.Button buttonAjouterMedicament;
        private System.Windows.Forms.TextBox txtNomMedicament;
        private System.Windows.Forms.TextBox txtCompositionMedicament;
        private System.Windows.Forms.TextBox txtEffetMedicament;
        private System.Windows.Forms.TextBox txtContreIndicationMedicament;
        private System.Windows.Forms.ComboBox comboBoxFamilleMedicament;
        private System.Windows.Forms.GroupBox groupBoxNomMedicament;
        private System.Windows.Forms.GroupBox groupBoxCompositionMedicament;
        private System.Windows.Forms.GroupBox groupBoxEffetMedicament;
        private System.Windows.Forms.GroupBox groupBoxFamilleMedicament;
        private System.Windows.Forms.GroupBox groupBoxContreIndication;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMedicament;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomCommercialMedicament;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFamilleMedicament;
        private System.Windows.Forms.DataGridViewTextBoxColumn compositionMedicament;
        private System.Windows.Forms.DataGridViewTextBoxColumn effetsMedicament;
        private System.Windows.Forms.DataGridViewTextBoxColumn contreIndicationsMedicament;
        private System.Windows.Forms.Button btnValiderAjout;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.GroupBox grpboxRechercherNom;
        private System.Windows.Forms.ComboBox cboxRechercherNom;
        private System.Windows.Forms.GroupBox grpboxRechercherCompo;
        private System.Windows.Forms.ComboBox cboxRechercherCompo;
        private System.Windows.Forms.GroupBox grpboxRechercheCI;
        private System.Windows.Forms.ComboBox cboxRechercheCI;
        private System.Windows.Forms.GroupBox grpboxRechercheEffet;
        private System.Windows.Forms.ComboBox cboxRechercheEffet;
        private System.Windows.Forms.GroupBox grpboxRechercheFamille;
        private System.Windows.Forms.ComboBox cboxRechercheFamille;
    }
}