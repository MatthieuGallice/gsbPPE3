namespace Formulaire
{
    partial class Rapport
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
            this.dgwRapport = new System.Windows.Forms.DataGridView();
            this.buttonModifierRapport = new System.Windows.Forms.Button();
            this.buttonSupprimerRapport = new System.Windows.Forms.Button();
            this.txtBoxDateRapport = new System.Windows.Forms.TextBox();
            this.txtBoxBilanRapport = new System.Windows.Forms.TextBox();
            this.comboBoxVisiteurRapport = new System.Windows.Forms.ComboBox();
            this.comboBoxMedecinRapport = new System.Windows.Forms.ComboBox();
            this.buttonValiderModifRapport = new System.Windows.Forms.Button();
            this.buttonAjouterRapport = new System.Windows.Forms.Button();
            this.txtQuantiteOffre = new System.Windows.Forms.TextBox();
            this.buttonAjouterOffre = new System.Windows.Forms.Button();
            this.buttonModifierOffre = new System.Windows.Forms.Button();
            this.buttonSupprimerOffre = new System.Windows.Forms.Button();
            this.dgwOffre = new System.Windows.Forms.DataGridView();
            this.idRapportOffert = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMedicamentoffert = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomCommercialMedicament = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantiteOff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxDateRapport = new System.Windows.Forms.GroupBox();
            this.groupBoxMotifRapport = new System.Windows.Forms.GroupBox();
            this.comboBoxMotifRapport = new System.Windows.Forms.ComboBox();
            this.groupBoxBilanRapport = new System.Windows.Forms.GroupBox();
            this.groupBoxVisiteurRapport = new System.Windows.Forms.GroupBox();
            this.groupBoxMedecinRapport = new System.Windows.Forms.GroupBox();
            this.groupBoxRapportOffert = new System.Windows.Forms.GroupBox();
            this.comboBoxIdOffreRapport = new System.Windows.Forms.ComboBox();
            this.groupBoxMedicamentOffert = new System.Windows.Forms.GroupBox();
            this.comboBoxIdMedicament = new System.Windows.Forms.ComboBox();
            this.groupBoxQuantite = new System.Windows.Forms.GroupBox();
            this.idRap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomVisiteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomVisiteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateRapport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motifRapport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bilanRapport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomMedecin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomMedecin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRapport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOffre)).BeginInit();
            this.groupBoxDateRapport.SuspendLayout();
            this.groupBoxMotifRapport.SuspendLayout();
            this.groupBoxBilanRapport.SuspendLayout();
            this.groupBoxVisiteurRapport.SuspendLayout();
            this.groupBoxMedecinRapport.SuspendLayout();
            this.groupBoxRapportOffert.SuspendLayout();
            this.groupBoxMedicamentOffert.SuspendLayout();
            this.groupBoxQuantite.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwRapport
            // 
            this.dgwRapport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRapport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRap,
            this.nomVisiteur,
            this.prenomVisiteur,
            this.dateRapport,
            this.motifRapport,
            this.bilanRapport,
            this.nomMedecin,
            this.prenomMedecin});
            this.dgwRapport.Location = new System.Drawing.Point(171, 39);
            this.dgwRapport.Name = "dgwRapport";
            this.dgwRapport.Size = new System.Drawing.Size(1113, 218);
            this.dgwRapport.TabIndex = 1;
            // 
            // buttonModifierRapport
            // 
            this.buttonModifierRapport.Location = new System.Drawing.Point(31, 96);
            this.buttonModifierRapport.Name = "buttonModifierRapport";
            this.buttonModifierRapport.Size = new System.Drawing.Size(102, 33);
            this.buttonModifierRapport.TabIndex = 2;
            this.buttonModifierRapport.Text = "Modifier";
            this.buttonModifierRapport.UseVisualStyleBackColor = true;
            // 
            // buttonSupprimerRapport
            // 
            this.buttonSupprimerRapport.Location = new System.Drawing.Point(31, 166);
            this.buttonSupprimerRapport.Name = "buttonSupprimerRapport";
            this.buttonSupprimerRapport.Size = new System.Drawing.Size(102, 33);
            this.buttonSupprimerRapport.TabIndex = 3;
            this.buttonSupprimerRapport.Text = "Supprimer";
            this.buttonSupprimerRapport.UseVisualStyleBackColor = true;
            // 
            // txtBoxDateRapport
            // 
            this.txtBoxDateRapport.Location = new System.Drawing.Point(60, 19);
            this.txtBoxDateRapport.Name = "txtBoxDateRapport";
            this.txtBoxDateRapport.Size = new System.Drawing.Size(306, 20);
            this.txtBoxDateRapport.TabIndex = 4;
            // 
            // txtBoxBilanRapport
            // 
            this.txtBoxBilanRapport.Location = new System.Drawing.Point(22, 33);
            this.txtBoxBilanRapport.Name = "txtBoxBilanRapport";
            this.txtBoxBilanRapport.Size = new System.Drawing.Size(306, 20);
            this.txtBoxBilanRapport.TabIndex = 6;
            // 
            // comboBoxVisiteurRapport
            // 
            this.comboBoxVisiteurRapport.FormattingEnabled = true;
            this.comboBoxVisiteurRapport.Location = new System.Drawing.Point(60, 19);
            this.comboBoxVisiteurRapport.Name = "comboBoxVisiteurRapport";
            this.comboBoxVisiteurRapport.Size = new System.Drawing.Size(306, 21);
            this.comboBoxVisiteurRapport.TabIndex = 7;
            // 
            // comboBoxMedecinRapport
            // 
            this.comboBoxMedecinRapport.FormattingEnabled = true;
            this.comboBoxMedecinRapport.Location = new System.Drawing.Point(53, 19);
            this.comboBoxMedecinRapport.Name = "comboBoxMedecinRapport";
            this.comboBoxMedecinRapport.Size = new System.Drawing.Size(306, 21);
            this.comboBoxMedecinRapport.TabIndex = 8;
            // 
            // buttonValiderModifRapport
            // 
            this.buttonValiderModifRapport.Location = new System.Drawing.Point(312, 417);
            this.buttonValiderModifRapport.Name = "buttonValiderModifRapport";
            this.buttonValiderModifRapport.Size = new System.Drawing.Size(125, 33);
            this.buttonValiderModifRapport.TabIndex = 9;
            this.buttonValiderModifRapport.Text = "Valider Modification";
            this.buttonValiderModifRapport.UseVisualStyleBackColor = true;
            // 
            // buttonAjouterRapport
            // 
            this.buttonAjouterRapport.Location = new System.Drawing.Point(476, 417);
            this.buttonAjouterRapport.Name = "buttonAjouterRapport";
            this.buttonAjouterRapport.Size = new System.Drawing.Size(125, 33);
            this.buttonAjouterRapport.TabIndex = 10;
            this.buttonAjouterRapport.Text = "Ajouter Rapport";
            this.buttonAjouterRapport.UseVisualStyleBackColor = true;
            // 
            // txtQuantiteOffre
            // 
            this.txtQuantiteOffre.Location = new System.Drawing.Point(25, 19);
            this.txtQuantiteOffre.Name = "txtQuantiteOffre";
            this.txtQuantiteOffre.Size = new System.Drawing.Size(243, 20);
            this.txtQuantiteOffre.TabIndex = 13;
            // 
            // buttonAjouterOffre
            // 
            this.buttonAjouterOffre.Location = new System.Drawing.Point(365, 483);
            this.buttonAjouterOffre.Name = "buttonAjouterOffre";
            this.buttonAjouterOffre.Size = new System.Drawing.Size(95, 38);
            this.buttonAjouterOffre.TabIndex = 14;
            this.buttonAjouterOffre.Text = "Ajouter Offre";
            this.buttonAjouterOffre.UseVisualStyleBackColor = true;
            // 
            // buttonModifierOffre
            // 
            this.buttonModifierOffre.Location = new System.Drawing.Point(365, 567);
            this.buttonModifierOffre.Name = "buttonModifierOffre";
            this.buttonModifierOffre.Size = new System.Drawing.Size(95, 38);
            this.buttonModifierOffre.TabIndex = 15;
            this.buttonModifierOffre.Text = "Modifier Offre";
            this.buttonModifierOffre.UseVisualStyleBackColor = true;
            // 
            // buttonSupprimerOffre
            // 
            this.buttonSupprimerOffre.Location = new System.Drawing.Point(365, 646);
            this.buttonSupprimerOffre.Name = "buttonSupprimerOffre";
            this.buttonSupprimerOffre.Size = new System.Drawing.Size(95, 38);
            this.buttonSupprimerOffre.TabIndex = 16;
            this.buttonSupprimerOffre.Text = "Supprimer Offre";
            this.buttonSupprimerOffre.UseVisualStyleBackColor = true;
            // 
            // dgwOffre
            // 
            this.dgwOffre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOffre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRapportOffert,
            this.idMedicamentoffert,
            this.nomCommercialMedicament,
            this.quantiteOff});
            this.dgwOffre.Location = new System.Drawing.Point(498, 474);
            this.dgwOffre.Name = "dgwOffre";
            this.dgwOffre.Size = new System.Drawing.Size(786, 223);
            this.dgwOffre.TabIndex = 17;
            // 
            // idRapportOffert
            // 
            this.idRapportOffert.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idRapportOffert.HeaderText = "numéro du rapport";
            this.idRapportOffert.Name = "idRapportOffert";
            // 
            // idMedicamentoffert
            // 
            this.idMedicamentoffert.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idMedicamentoffert.HeaderText = "numéro du médicament";
            this.idMedicamentoffert.Name = "idMedicamentoffert";
            // 
            // nomCommercialMedicament
            // 
            this.nomCommercialMedicament.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomCommercialMedicament.HeaderText = "nom du médicament";
            this.nomCommercialMedicament.Name = "nomCommercialMedicament";
            // 
            // quantiteOff
            // 
            this.quantiteOff.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantiteOff.HeaderText = "quantité offertes";
            this.quantiteOff.Name = "quantiteOff";
            // 
            // groupBoxDateRapport
            // 
            this.groupBoxDateRapport.Controls.Add(this.txtBoxDateRapport);
            this.groupBoxDateRapport.Location = new System.Drawing.Point(31, 275);
            this.groupBoxDateRapport.Name = "groupBoxDateRapport";
            this.groupBoxDateRapport.Size = new System.Drawing.Size(406, 55);
            this.groupBoxDateRapport.TabIndex = 18;
            this.groupBoxDateRapport.TabStop = false;
            this.groupBoxDateRapport.Text = "Date du Rapport";
            // 
            // groupBoxMotifRapport
            // 
            this.groupBoxMotifRapport.Controls.Add(this.comboBoxMotifRapport);
            this.groupBoxMotifRapport.Location = new System.Drawing.Point(476, 275);
            this.groupBoxMotifRapport.Name = "groupBoxMotifRapport";
            this.groupBoxMotifRapport.Size = new System.Drawing.Size(406, 55);
            this.groupBoxMotifRapport.TabIndex = 19;
            this.groupBoxMotifRapport.TabStop = false;
            this.groupBoxMotifRapport.Text = "Motif du rapport";
            // 
            // comboBoxMotifRapport
            // 
            this.comboBoxMotifRapport.FormattingEnabled = true;
            this.comboBoxMotifRapport.Location = new System.Drawing.Point(53, 19);
            this.comboBoxMotifRapport.Name = "comboBoxMotifRapport";
            this.comboBoxMotifRapport.Size = new System.Drawing.Size(306, 21);
            this.comboBoxMotifRapport.TabIndex = 23;
            // 
            // groupBoxBilanRapport
            // 
            this.groupBoxBilanRapport.Controls.Add(this.txtBoxBilanRapport);
            this.groupBoxBilanRapport.Location = new System.Drawing.Point(912, 275);
            this.groupBoxBilanRapport.Name = "groupBoxBilanRapport";
            this.groupBoxBilanRapport.Size = new System.Drawing.Size(372, 185);
            this.groupBoxBilanRapport.TabIndex = 20;
            this.groupBoxBilanRapport.TabStop = false;
            this.groupBoxBilanRapport.Text = "Bilan du Rapport";
            // 
            // groupBoxVisiteurRapport
            // 
            this.groupBoxVisiteurRapport.Controls.Add(this.comboBoxVisiteurRapport);
            this.groupBoxVisiteurRapport.Location = new System.Drawing.Point(31, 347);
            this.groupBoxVisiteurRapport.Name = "groupBoxVisiteurRapport";
            this.groupBoxVisiteurRapport.Size = new System.Drawing.Size(406, 55);
            this.groupBoxVisiteurRapport.TabIndex = 19;
            this.groupBoxVisiteurRapport.TabStop = false;
            this.groupBoxVisiteurRapport.Text = "Nom et Prenom du visiteur";
            // 
            // groupBoxMedecinRapport
            // 
            this.groupBoxMedecinRapport.Controls.Add(this.comboBoxMedecinRapport);
            this.groupBoxMedecinRapport.Location = new System.Drawing.Point(476, 347);
            this.groupBoxMedecinRapport.Name = "groupBoxMedecinRapport";
            this.groupBoxMedecinRapport.Size = new System.Drawing.Size(406, 55);
            this.groupBoxMedecinRapport.TabIndex = 20;
            this.groupBoxMedecinRapport.TabStop = false;
            this.groupBoxMedecinRapport.Text = "Nom et Prenom du medecin";
            // 
            // groupBoxRapportOffert
            // 
            this.groupBoxRapportOffert.Controls.Add(this.comboBoxIdOffreRapport);
            this.groupBoxRapportOffert.Location = new System.Drawing.Point(31, 474);
            this.groupBoxRapportOffert.Name = "groupBoxRapportOffert";
            this.groupBoxRapportOffert.Size = new System.Drawing.Size(292, 60);
            this.groupBoxRapportOffert.TabIndex = 20;
            this.groupBoxRapportOffert.TabStop = false;
            this.groupBoxRapportOffert.Text = "Rapport associé";
            // 
            // comboBoxIdOffreRapport
            // 
            this.comboBoxIdOffreRapport.FormattingEnabled = true;
            this.comboBoxIdOffreRapport.Location = new System.Drawing.Point(25, 19);
            this.comboBoxIdOffreRapport.Name = "comboBoxIdOffreRapport";
            this.comboBoxIdOffreRapport.Size = new System.Drawing.Size(243, 21);
            this.comboBoxIdOffreRapport.TabIndex = 23;
            // 
            // groupBoxMedicamentOffert
            // 
            this.groupBoxMedicamentOffert.Controls.Add(this.comboBoxIdMedicament);
            this.groupBoxMedicamentOffert.Location = new System.Drawing.Point(31, 558);
            this.groupBoxMedicamentOffert.Name = "groupBoxMedicamentOffert";
            this.groupBoxMedicamentOffert.Size = new System.Drawing.Size(292, 60);
            this.groupBoxMedicamentOffert.TabIndex = 21;
            this.groupBoxMedicamentOffert.TabStop = false;
            this.groupBoxMedicamentOffert.Text = "médicament offert";
            // 
            // comboBoxIdMedicament
            // 
            this.comboBoxIdMedicament.FormattingEnabled = true;
            this.comboBoxIdMedicament.Location = new System.Drawing.Point(25, 19);
            this.comboBoxIdMedicament.Name = "comboBoxIdMedicament";
            this.comboBoxIdMedicament.Size = new System.Drawing.Size(243, 21);
            this.comboBoxIdMedicament.TabIndex = 23;
            // 
            // groupBoxQuantite
            // 
            this.groupBoxQuantite.Controls.Add(this.txtQuantiteOffre);
            this.groupBoxQuantite.Location = new System.Drawing.Point(31, 637);
            this.groupBoxQuantite.Name = "groupBoxQuantite";
            this.groupBoxQuantite.Size = new System.Drawing.Size(292, 60);
            this.groupBoxQuantite.TabIndex = 22;
            this.groupBoxQuantite.TabStop = false;
            this.groupBoxQuantite.Text = "Quantité offertes";
            // 
            // idRap
            // 
            this.idRap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idRap.HeaderText = "Numéro du Rapport";
            this.idRap.Name = "idRap";
            // 
            // nomVisiteur
            // 
            this.nomVisiteur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomVisiteur.HeaderText = "Nom du Visiteur";
            this.nomVisiteur.Name = "nomVisiteur";
            // 
            // prenomVisiteur
            // 
            this.prenomVisiteur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prenomVisiteur.HeaderText = "Prenom du Visiteur";
            this.prenomVisiteur.Name = "prenomVisiteur";
            // 
            // dateRapport
            // 
            this.dateRapport.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateRapport.HeaderText = "Date du Rapport";
            this.dateRapport.Name = "dateRapport";
            // 
            // motifRapport
            // 
            this.motifRapport.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.motifRapport.HeaderText = "Motif du Rapport";
            this.motifRapport.Name = "motifRapport";
            // 
            // bilanRapport
            // 
            this.bilanRapport.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bilanRapport.HeaderText = "Bilan du Rapport";
            this.bilanRapport.Name = "bilanRapport";
            // 
            // nomMedecin
            // 
            this.nomMedecin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomMedecin.HeaderText = "Nom du Medecin";
            this.nomMedecin.Name = "nomMedecin";
            // 
            // prenomMedecin
            // 
            this.prenomMedecin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prenomMedecin.HeaderText = "Prenom du Medecin";
            this.prenomMedecin.Name = "prenomMedecin";
            // 
            // Rapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 722);
            this.Controls.Add(this.groupBoxQuantite);
            this.Controls.Add(this.groupBoxMedicamentOffert);
            this.Controls.Add(this.groupBoxRapportOffert);
            this.Controls.Add(this.groupBoxMedecinRapport);
            this.Controls.Add(this.groupBoxVisiteurRapport);
            this.Controls.Add(this.groupBoxBilanRapport);
            this.Controls.Add(this.groupBoxMotifRapport);
            this.Controls.Add(this.groupBoxDateRapport);
            this.Controls.Add(this.dgwOffre);
            this.Controls.Add(this.buttonSupprimerOffre);
            this.Controls.Add(this.buttonModifierOffre);
            this.Controls.Add(this.buttonAjouterOffre);
            this.Controls.Add(this.buttonAjouterRapport);
            this.Controls.Add(this.buttonValiderModifRapport);
            this.Controls.Add(this.buttonSupprimerRapport);
            this.Controls.Add(this.buttonModifierRapport);
            this.Controls.Add(this.dgwRapport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rapport";
            this.Text = "Rappors";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Rapport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwRapport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOffre)).EndInit();
            this.groupBoxDateRapport.ResumeLayout(false);
            this.groupBoxDateRapport.PerformLayout();
            this.groupBoxMotifRapport.ResumeLayout(false);
            this.groupBoxBilanRapport.ResumeLayout(false);
            this.groupBoxBilanRapport.PerformLayout();
            this.groupBoxVisiteurRapport.ResumeLayout(false);
            this.groupBoxMedecinRapport.ResumeLayout(false);
            this.groupBoxRapportOffert.ResumeLayout(false);
            this.groupBoxMedicamentOffert.ResumeLayout(false);
            this.groupBoxQuantite.ResumeLayout(false);
            this.groupBoxQuantite.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgwRapport;
        private System.Windows.Forms.Button buttonModifierRapport;
        private System.Windows.Forms.Button buttonSupprimerRapport;
        private System.Windows.Forms.TextBox txtBoxDateRapport;
        private System.Windows.Forms.TextBox txtBoxBilanRapport;
        private System.Windows.Forms.ComboBox comboBoxVisiteurRapport;
        private System.Windows.Forms.ComboBox comboBoxMedecinRapport;
        private System.Windows.Forms.Button buttonValiderModifRapport;
        private System.Windows.Forms.Button buttonAjouterRapport;
        private System.Windows.Forms.TextBox txtQuantiteOffre;
        private System.Windows.Forms.Button buttonAjouterOffre;
        private System.Windows.Forms.Button buttonModifierOffre;
        private System.Windows.Forms.Button buttonSupprimerOffre;
        private System.Windows.Forms.DataGridView dgwOffre;
        private System.Windows.Forms.GroupBox groupBoxDateRapport;
        private System.Windows.Forms.GroupBox groupBoxMotifRapport;
        private System.Windows.Forms.GroupBox groupBoxBilanRapport;
        private System.Windows.Forms.GroupBox groupBoxVisiteurRapport;
        private System.Windows.Forms.GroupBox groupBoxMedecinRapport;
        private System.Windows.Forms.GroupBox groupBoxRapportOffert;
        private System.Windows.Forms.GroupBox groupBoxMedicamentOffert;
        private System.Windows.Forms.GroupBox groupBoxQuantite;
        private System.Windows.Forms.ComboBox comboBoxIdOffreRapport;
        private System.Windows.Forms.ComboBox comboBoxIdMedicament;
        private System.Windows.Forms.ComboBox comboBoxMotifRapport;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRapportOffert;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMedicamentoffert;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomCommercialMedicament;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantiteOff;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRap;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomVisiteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomVisiteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateRapport;
        private System.Windows.Forms.DataGridViewTextBoxColumn motifRapport;
        private System.Windows.Forms.DataGridViewTextBoxColumn bilanRapport;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomMedecin;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomMedecin;
    }
}