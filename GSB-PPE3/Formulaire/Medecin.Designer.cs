namespace Formulaire
{
    partial class Medecin
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
            this.dgwMedecin = new System.Windows.Forms.DataGridView();
            this.nomMed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomMed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseMed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telMed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomSpecialite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departementMed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgwDernierRapport = new System.Windows.Forms.DataGridView();
            this.idRap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idVisiteurRap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomVis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomVis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateRap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motifRap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bilanRapport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonModifierMedecin = new System.Windows.Forms.Button();
            this.buttonSupprimerMedecin = new System.Windows.Forms.Button();
            this.buttonValiderModif = new System.Windows.Forms.Button();
            this.buttonAjouterMedecin = new System.Windows.Forms.Button();
            this.comboBoxListeMedecin = new System.Windows.Forms.ComboBox();
            this.comboBoxSpecialite = new System.Windows.Forms.ComboBox();
            this.txtNomMedecin = new System.Windows.Forms.TextBox();
            this.txtPrenomMedecin = new System.Windows.Forms.TextBox();
            this.txtTelMedecin = new System.Windows.Forms.TextBox();
            this.txtAdresseMedecin = new System.Windows.Forms.TextBox();
            this.txtDepartementMedecin = new System.Windows.Forms.TextBox();
            this.groupBoxNomMedecin = new System.Windows.Forms.GroupBox();
            this.groupBoxPrenomMedecin = new System.Windows.Forms.GroupBox();
            this.groupBoxTelMedecin = new System.Windows.Forms.GroupBox();
            this.groupBoxAdresseMedecin = new System.Windows.Forms.GroupBox();
            this.groupBoxDepartementMedecin = new System.Windows.Forms.GroupBox();
            this.groupBoxSpecialiteMedecin = new System.Windows.Forms.GroupBox();
            this.groupBoxListeMedecin = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMedecin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDernierRapport)).BeginInit();
            this.groupBoxNomMedecin.SuspendLayout();
            this.groupBoxPrenomMedecin.SuspendLayout();
            this.groupBoxTelMedecin.SuspendLayout();
            this.groupBoxAdresseMedecin.SuspendLayout();
            this.groupBoxDepartementMedecin.SuspendLayout();
            this.groupBoxSpecialiteMedecin.SuspendLayout();
            this.groupBoxListeMedecin.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwMedecin
            // 
            this.dgwMedecin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMedecin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomMed,
            this.prenomMed,
            this.adresseMed,
            this.telMed,
            this.nomSpecialite,
            this.departementMed});
            this.dgwMedecin.Location = new System.Drawing.Point(186, 29);
            this.dgwMedecin.Name = "dgwMedecin";
            this.dgwMedecin.Size = new System.Drawing.Size(1181, 218);
            this.dgwMedecin.TabIndex = 1;
            // 
            // nomMed
            // 
            this.nomMed.HeaderText = "nom";
            this.nomMed.Name = "nomMed";
            // 
            // prenomMed
            // 
            this.prenomMed.HeaderText = "prenom";
            this.prenomMed.Name = "prenomMed";
            // 
            // adresseMed
            // 
            this.adresseMed.HeaderText = "adresse";
            this.adresseMed.Name = "adresseMed";
            // 
            // telMed
            // 
            this.telMed.HeaderText = "telephone ";
            this.telMed.Name = "telMed";
            // 
            // nomSpecialite
            // 
            this.nomSpecialite.HeaderText = "spécialité";
            this.nomSpecialite.Name = "nomSpecialite";
            // 
            // departementMed
            // 
            this.departementMed.HeaderText = "departement ";
            this.departementMed.Name = "departementMed";
            // 
            // dgwDernierRapport
            // 
            this.dgwDernierRapport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDernierRapport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRap,
            this.idVisiteurRap,
            this.nomVis,
            this.prenomVis,
            this.dateRap,
            this.motifRap,
            this.bilanRapport});
            this.dgwDernierRapport.Location = new System.Drawing.Point(399, 550);
            this.dgwDernierRapport.Name = "dgwDernierRapport";
            this.dgwDernierRapport.Size = new System.Drawing.Size(968, 240);
            this.dgwDernierRapport.TabIndex = 2;
            // 
            // idRap
            // 
            this.idRap.HeaderText = "numéro du rapport";
            this.idRap.Name = "idRap";
            // 
            // idVisiteurRap
            // 
            this.idVisiteurRap.HeaderText = "numéro du visiteur";
            this.idVisiteurRap.Name = "idVisiteurRap";
            // 
            // nomVis
            // 
            this.nomVis.HeaderText = "nom du visiteur";
            this.nomVis.Name = "nomVis";
            // 
            // prenomVis
            // 
            this.prenomVis.HeaderText = "prénom du visiteur";
            this.prenomVis.Name = "prenomVis";
            // 
            // dateRap
            // 
            this.dateRap.HeaderText = "date du rapport";
            this.dateRap.Name = "dateRap";
            // 
            // motifRap
            // 
            this.motifRap.HeaderText = "motif du rapport";
            this.motifRap.Name = "motifRap";
            // 
            // bilanRapport
            // 
            this.bilanRapport.HeaderText = "bilan du rapport";
            this.bilanRapport.Name = "bilanRapport";
            // 
            // buttonModifierMedecin
            // 
            this.buttonModifierMedecin.Location = new System.Drawing.Point(36, 72);
            this.buttonModifierMedecin.Name = "buttonModifierMedecin";
            this.buttonModifierMedecin.Size = new System.Drawing.Size(112, 32);
            this.buttonModifierMedecin.TabIndex = 3;
            this.buttonModifierMedecin.Text = "Modifier Medecin";
            this.buttonModifierMedecin.UseVisualStyleBackColor = true;
            // 
            // buttonSupprimerMedecin
            // 
            this.buttonSupprimerMedecin.Location = new System.Drawing.Point(36, 145);
            this.buttonSupprimerMedecin.Name = "buttonSupprimerMedecin";
            this.buttonSupprimerMedecin.Size = new System.Drawing.Size(112, 32);
            this.buttonSupprimerMedecin.TabIndex = 4;
            this.buttonSupprimerMedecin.Text = "Supprimer Medecin";
            this.buttonSupprimerMedecin.UseVisualStyleBackColor = true;
            // 
            // buttonValiderModif
            // 
            this.buttonValiderModif.Location = new System.Drawing.Point(417, 480);
            this.buttonValiderModif.Name = "buttonValiderModif";
            this.buttonValiderModif.Size = new System.Drawing.Size(112, 32);
            this.buttonValiderModif.TabIndex = 5;
            this.buttonValiderModif.Text = "Valider Modifications";
            this.buttonValiderModif.UseVisualStyleBackColor = true;
            // 
            // buttonAjouterMedecin
            // 
            this.buttonAjouterMedecin.Location = new System.Drawing.Point(858, 480);
            this.buttonAjouterMedecin.Name = "buttonAjouterMedecin";
            this.buttonAjouterMedecin.Size = new System.Drawing.Size(112, 32);
            this.buttonAjouterMedecin.TabIndex = 6;
            this.buttonAjouterMedecin.Text = "Ajouter Medecin";
            this.buttonAjouterMedecin.UseVisualStyleBackColor = true;
            // 
            // comboBoxListeMedecin
            // 
            this.comboBoxListeMedecin.FormattingEnabled = true;
            this.comboBoxListeMedecin.Location = new System.Drawing.Point(37, 45);
            this.comboBoxListeMedecin.Name = "comboBoxListeMedecin";
            this.comboBoxListeMedecin.Size = new System.Drawing.Size(276, 21);
            this.comboBoxListeMedecin.TabIndex = 7;
            // 
            // comboBoxSpecialite
            // 
            this.comboBoxSpecialite.FormattingEnabled = true;
            this.comboBoxSpecialite.Location = new System.Drawing.Point(47, 31);
            this.comboBoxSpecialite.Name = "comboBoxSpecialite";
            this.comboBoxSpecialite.Size = new System.Drawing.Size(339, 21);
            this.comboBoxSpecialite.TabIndex = 8;
            // 
            // txtNomMedecin
            // 
            this.txtNomMedecin.Location = new System.Drawing.Point(51, 36);
            this.txtNomMedecin.Name = "txtNomMedecin";
            this.txtNomMedecin.Size = new System.Drawing.Size(339, 20);
            this.txtNomMedecin.TabIndex = 9;
            // 
            // txtPrenomMedecin
            // 
            this.txtPrenomMedecin.Location = new System.Drawing.Point(54, 36);
            this.txtPrenomMedecin.Name = "txtPrenomMedecin";
            this.txtPrenomMedecin.Size = new System.Drawing.Size(339, 20);
            this.txtPrenomMedecin.TabIndex = 10;
            // 
            // txtTelMedecin
            // 
            this.txtTelMedecin.Location = new System.Drawing.Point(47, 36);
            this.txtTelMedecin.Name = "txtTelMedecin";
            this.txtTelMedecin.Size = new System.Drawing.Size(339, 20);
            this.txtTelMedecin.TabIndex = 11;
            // 
            // txtAdresseMedecin
            // 
            this.txtAdresseMedecin.Location = new System.Drawing.Point(51, 31);
            this.txtAdresseMedecin.Name = "txtAdresseMedecin";
            this.txtAdresseMedecin.Size = new System.Drawing.Size(339, 20);
            this.txtAdresseMedecin.TabIndex = 12;
            // 
            // txtDepartementMedecin
            // 
            this.txtDepartementMedecin.Location = new System.Drawing.Point(54, 31);
            this.txtDepartementMedecin.Name = "txtDepartementMedecin";
            this.txtDepartementMedecin.Size = new System.Drawing.Size(339, 20);
            this.txtDepartementMedecin.TabIndex = 13;
            // 
            // groupBoxNomMedecin
            // 
            this.groupBoxNomMedecin.Controls.Add(this.txtNomMedecin);
            this.groupBoxNomMedecin.Location = new System.Drawing.Point(36, 266);
            this.groupBoxNomMedecin.Name = "groupBoxNomMedecin";
            this.groupBoxNomMedecin.Size = new System.Drawing.Size(411, 78);
            this.groupBoxNomMedecin.TabIndex = 14;
            this.groupBoxNomMedecin.TabStop = false;
            this.groupBoxNomMedecin.Text = "Nom du Médecin";
            // 
            // groupBoxPrenomMedecin
            // 
            this.groupBoxPrenomMedecin.Controls.Add(this.txtPrenomMedecin);
            this.groupBoxPrenomMedecin.Location = new System.Drawing.Point(483, 266);
            this.groupBoxPrenomMedecin.Name = "groupBoxPrenomMedecin";
            this.groupBoxPrenomMedecin.Size = new System.Drawing.Size(411, 78);
            this.groupBoxPrenomMedecin.TabIndex = 15;
            this.groupBoxPrenomMedecin.TabStop = false;
            this.groupBoxPrenomMedecin.Text = "Prénom du Médecin";
            // 
            // groupBoxTelMedecin
            // 
            this.groupBoxTelMedecin.Controls.Add(this.txtTelMedecin);
            this.groupBoxTelMedecin.Location = new System.Drawing.Point(932, 266);
            this.groupBoxTelMedecin.Name = "groupBoxTelMedecin";
            this.groupBoxTelMedecin.Size = new System.Drawing.Size(411, 78);
            this.groupBoxTelMedecin.TabIndex = 15;
            this.groupBoxTelMedecin.TabStop = false;
            this.groupBoxTelMedecin.Text = "Telephone du Médecin";
            // 
            // groupBoxAdresseMedecin
            // 
            this.groupBoxAdresseMedecin.Controls.Add(this.txtAdresseMedecin);
            this.groupBoxAdresseMedecin.Location = new System.Drawing.Point(36, 368);
            this.groupBoxAdresseMedecin.Name = "groupBoxAdresseMedecin";
            this.groupBoxAdresseMedecin.Size = new System.Drawing.Size(411, 78);
            this.groupBoxAdresseMedecin.TabIndex = 15;
            this.groupBoxAdresseMedecin.TabStop = false;
            this.groupBoxAdresseMedecin.Text = "Adresse du Médecin";
            // 
            // groupBoxDepartementMedecin
            // 
            this.groupBoxDepartementMedecin.Controls.Add(this.txtDepartementMedecin);
            this.groupBoxDepartementMedecin.Location = new System.Drawing.Point(483, 368);
            this.groupBoxDepartementMedecin.Name = "groupBoxDepartementMedecin";
            this.groupBoxDepartementMedecin.Size = new System.Drawing.Size(411, 78);
            this.groupBoxDepartementMedecin.TabIndex = 16;
            this.groupBoxDepartementMedecin.TabStop = false;
            this.groupBoxDepartementMedecin.Text = "Département du Médecin";
            // 
            // groupBoxSpecialiteMedecin
            // 
            this.groupBoxSpecialiteMedecin.Controls.Add(this.comboBoxSpecialite);
            this.groupBoxSpecialiteMedecin.Location = new System.Drawing.Point(932, 368);
            this.groupBoxSpecialiteMedecin.Name = "groupBoxSpecialiteMedecin";
            this.groupBoxSpecialiteMedecin.Size = new System.Drawing.Size(411, 78);
            this.groupBoxSpecialiteMedecin.TabIndex = 16;
            this.groupBoxSpecialiteMedecin.TabStop = false;
            this.groupBoxSpecialiteMedecin.Text = "Spécialité du Médecin";
            // 
            // groupBoxListeMedecin
            // 
            this.groupBoxListeMedecin.Controls.Add(this.comboBoxListeMedecin);
            this.groupBoxListeMedecin.Location = new System.Drawing.Point(36, 572);
            this.groupBoxListeMedecin.Name = "groupBoxListeMedecin";
            this.groupBoxListeMedecin.Size = new System.Drawing.Size(339, 101);
            this.groupBoxListeMedecin.TabIndex = 17;
            this.groupBoxListeMedecin.TabStop = false;
            this.groupBoxListeMedecin.Text = "Liste des rapports sur un Médecin";
            // 
            // Medecin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 802);
            this.Controls.Add(this.groupBoxListeMedecin);
            this.Controls.Add(this.groupBoxSpecialiteMedecin);
            this.Controls.Add(this.groupBoxDepartementMedecin);
            this.Controls.Add(this.groupBoxAdresseMedecin);
            this.Controls.Add(this.groupBoxTelMedecin);
            this.Controls.Add(this.groupBoxPrenomMedecin);
            this.Controls.Add(this.groupBoxNomMedecin);
            this.Controls.Add(this.buttonAjouterMedecin);
            this.Controls.Add(this.buttonValiderModif);
            this.Controls.Add(this.buttonSupprimerMedecin);
            this.Controls.Add(this.buttonModifierMedecin);
            this.Controls.Add(this.dgwDernierRapport);
            this.Controls.Add(this.dgwMedecin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Medecin";
            this.Text = "Medecins";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgwMedecin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDernierRapport)).EndInit();
            this.groupBoxNomMedecin.ResumeLayout(false);
            this.groupBoxNomMedecin.PerformLayout();
            this.groupBoxPrenomMedecin.ResumeLayout(false);
            this.groupBoxPrenomMedecin.PerformLayout();
            this.groupBoxTelMedecin.ResumeLayout(false);
            this.groupBoxTelMedecin.PerformLayout();
            this.groupBoxAdresseMedecin.ResumeLayout(false);
            this.groupBoxAdresseMedecin.PerformLayout();
            this.groupBoxDepartementMedecin.ResumeLayout(false);
            this.groupBoxDepartementMedecin.PerformLayout();
            this.groupBoxSpecialiteMedecin.ResumeLayout(false);
            this.groupBoxListeMedecin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgwMedecin;
        private System.Windows.Forms.DataGridView dgwDernierRapport;
        private System.Windows.Forms.Button buttonModifierMedecin;
        private System.Windows.Forms.Button buttonSupprimerMedecin;
        private System.Windows.Forms.Button buttonValiderModif;
        private System.Windows.Forms.Button buttonAjouterMedecin;
        private System.Windows.Forms.ComboBox comboBoxListeMedecin;
        private System.Windows.Forms.ComboBox comboBoxSpecialite;
        private System.Windows.Forms.TextBox txtNomMedecin;
        private System.Windows.Forms.TextBox txtPrenomMedecin;
        private System.Windows.Forms.TextBox txtTelMedecin;
        private System.Windows.Forms.TextBox txtAdresseMedecin;
        private System.Windows.Forms.TextBox txtDepartementMedecin;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomMed;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomMed;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseMed;
        private System.Windows.Forms.DataGridViewTextBoxColumn telMed;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomSpecialite;
        private System.Windows.Forms.DataGridViewTextBoxColumn departementMed;
        private System.Windows.Forms.GroupBox groupBoxNomMedecin;
        private System.Windows.Forms.GroupBox groupBoxPrenomMedecin;
        private System.Windows.Forms.GroupBox groupBoxTelMedecin;
        private System.Windows.Forms.GroupBox groupBoxAdresseMedecin;
        private System.Windows.Forms.GroupBox groupBoxDepartementMedecin;
        private System.Windows.Forms.GroupBox groupBoxSpecialiteMedecin;
        private System.Windows.Forms.GroupBox groupBoxListeMedecin;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRap;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVisiteurRap;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomVis;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomVis;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateRap;
        private System.Windows.Forms.DataGridViewTextBoxColumn motifRap;
        private System.Windows.Forms.DataGridViewTextBoxColumn bilanRapport;
    }
}