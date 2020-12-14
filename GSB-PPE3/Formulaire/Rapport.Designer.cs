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
            this.txtBoxMotifRapport = new System.Windows.Forms.TextBox();
            this.txtBoxBilanRapport = new System.Windows.Forms.TextBox();
            this.comboBoxVisiteurRapport = new System.Windows.Forms.ComboBox();
            this.comboBoxMedecinRapport = new System.Windows.Forms.ComboBox();
            this.buttonValiderModifRapport = new System.Windows.Forms.Button();
            this.buttonAjouterRapport = new System.Windows.Forms.Button();
            this.txtIdOffre = new System.Windows.Forms.TextBox();
            this.txtIdMedicament = new System.Windows.Forms.TextBox();
            this.txtQuantiteOffre = new System.Windows.Forms.TextBox();
            this.buttonAjouterOffre = new System.Windows.Forms.Button();
            this.buttonModifierOffre = new System.Windows.Forms.Button();
            this.buttonSupprimerOffre = new System.Windows.Forms.Button();
            this.dgwOffre = new System.Windows.Forms.DataGridView();
            this.idRapport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomVisiteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomVisiteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateRapport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motifRapport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bilanRapport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomMedecin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomMedecin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRapport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOffre)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwRapport
            // 
            this.dgwRapport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRapport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRapport,
            this.nomVisiteur,
            this.prenomVisiteur,
            this.dateRapport,
            this.motifRapport,
            this.bilanRapport,
            this.nomMedecin,
            this.prenomMedecin});
            this.dgwRapport.Location = new System.Drawing.Point(301, 12);
            this.dgwRapport.Name = "dgwRapport";
            this.dgwRapport.Size = new System.Drawing.Size(1060, 226);
            this.dgwRapport.TabIndex = 1;
            // 
            // buttonModifierRapport
            // 
            this.buttonModifierRapport.Location = new System.Drawing.Point(89, 70);
            this.buttonModifierRapport.Name = "buttonModifierRapport";
            this.buttonModifierRapport.Size = new System.Drawing.Size(102, 23);
            this.buttonModifierRapport.TabIndex = 2;
            this.buttonModifierRapport.Text = "Modifier";
            this.buttonModifierRapport.UseVisualStyleBackColor = true;
            // 
            // buttonSupprimerRapport
            // 
            this.buttonSupprimerRapport.Location = new System.Drawing.Point(89, 147);
            this.buttonSupprimerRapport.Name = "buttonSupprimerRapport";
            this.buttonSupprimerRapport.Size = new System.Drawing.Size(102, 23);
            this.buttonSupprimerRapport.TabIndex = 3;
            this.buttonSupprimerRapport.Text = "Supprimer";
            this.buttonSupprimerRapport.UseVisualStyleBackColor = true;
            // 
            // txtBoxDateRapport
            // 
            this.txtBoxDateRapport.Location = new System.Drawing.Point(63, 302);
            this.txtBoxDateRapport.Name = "txtBoxDateRapport";
            this.txtBoxDateRapport.Size = new System.Drawing.Size(206, 20);
            this.txtBoxDateRapport.TabIndex = 4;
            // 
            // txtBoxMotifRapport
            // 
            this.txtBoxMotifRapport.Location = new System.Drawing.Point(561, 302);
            this.txtBoxMotifRapport.Name = "txtBoxMotifRapport";
            this.txtBoxMotifRapport.Size = new System.Drawing.Size(221, 20);
            this.txtBoxMotifRapport.TabIndex = 5;
            // 
            // txtBoxBilanRapport
            // 
            this.txtBoxBilanRapport.Location = new System.Drawing.Point(1045, 302);
            this.txtBoxBilanRapport.Name = "txtBoxBilanRapport";
            this.txtBoxBilanRapport.Size = new System.Drawing.Size(231, 20);
            this.txtBoxBilanRapport.TabIndex = 6;
            // 
            // comboBoxVisiteurRapport
            // 
            this.comboBoxVisiteurRapport.FormattingEnabled = true;
            this.comboBoxVisiteurRapport.Location = new System.Drawing.Point(211, 375);
            this.comboBoxVisiteurRapport.Name = "comboBoxVisiteurRapport";
            this.comboBoxVisiteurRapport.Size = new System.Drawing.Size(226, 21);
            this.comboBoxVisiteurRapport.TabIndex = 7;
            // 
            // comboBoxMedecinRapport
            // 
            this.comboBoxMedecinRapport.FormattingEnabled = true;
            this.comboBoxMedecinRapport.Location = new System.Drawing.Point(962, 375);
            this.comboBoxMedecinRapport.Name = "comboBoxMedecinRapport";
            this.comboBoxMedecinRapport.Size = new System.Drawing.Size(215, 21);
            this.comboBoxMedecinRapport.TabIndex = 8;
            // 
            // buttonValiderModifRapport
            // 
            this.buttonValiderModifRapport.Location = new System.Drawing.Point(496, 436);
            this.buttonValiderModifRapport.Name = "buttonValiderModifRapport";
            this.buttonValiderModifRapport.Size = new System.Drawing.Size(115, 23);
            this.buttonValiderModifRapport.TabIndex = 9;
            this.buttonValiderModifRapport.Text = "Valider Modification";
            this.buttonValiderModifRapport.UseVisualStyleBackColor = true;
            // 
            // buttonAjouterRapport
            // 
            this.buttonAjouterRapport.Location = new System.Drawing.Point(777, 436);
            this.buttonAjouterRapport.Name = "buttonAjouterRapport";
            this.buttonAjouterRapport.Size = new System.Drawing.Size(99, 23);
            this.buttonAjouterRapport.TabIndex = 10;
            this.buttonAjouterRapport.Text = "Ajouter Rapport";
            this.buttonAjouterRapport.UseVisualStyleBackColor = true;
            // 
            // txtIdOffre
            // 
            this.txtIdOffre.Location = new System.Drawing.Point(43, 535);
            this.txtIdOffre.Name = "txtIdOffre";
            this.txtIdOffre.Size = new System.Drawing.Size(226, 20);
            this.txtIdOffre.TabIndex = 11;
            // 
            // txtIdMedicament
            // 
            this.txtIdMedicament.Location = new System.Drawing.Point(43, 622);
            this.txtIdMedicament.Name = "txtIdMedicament";
            this.txtIdMedicament.Size = new System.Drawing.Size(226, 20);
            this.txtIdMedicament.TabIndex = 12;
            // 
            // txtQuantiteOffre
            // 
            this.txtQuantiteOffre.Location = new System.Drawing.Point(43, 719);
            this.txtQuantiteOffre.Name = "txtQuantiteOffre";
            this.txtQuantiteOffre.Size = new System.Drawing.Size(226, 20);
            this.txtQuantiteOffre.TabIndex = 13;
            // 
            // buttonAjouterOffre
            // 
            this.buttonAjouterOffre.Location = new System.Drawing.Point(322, 533);
            this.buttonAjouterOffre.Name = "buttonAjouterOffre";
            this.buttonAjouterOffre.Size = new System.Drawing.Size(89, 23);
            this.buttonAjouterOffre.TabIndex = 14;
            this.buttonAjouterOffre.Text = "Ajouter Offre";
            this.buttonAjouterOffre.UseVisualStyleBackColor = true;
            // 
            // buttonModifierOffre
            // 
            this.buttonModifierOffre.Location = new System.Drawing.Point(322, 619);
            this.buttonModifierOffre.Name = "buttonModifierOffre";
            this.buttonModifierOffre.Size = new System.Drawing.Size(89, 23);
            this.buttonModifierOffre.TabIndex = 15;
            this.buttonModifierOffre.Text = "Modifier Offre";
            this.buttonModifierOffre.UseVisualStyleBackColor = true;
            // 
            // buttonSupprimerOffre
            // 
            this.buttonSupprimerOffre.Location = new System.Drawing.Point(322, 716);
            this.buttonSupprimerOffre.Name = "buttonSupprimerOffre";
            this.buttonSupprimerOffre.Size = new System.Drawing.Size(89, 23);
            this.buttonSupprimerOffre.TabIndex = 16;
            this.buttonSupprimerOffre.Text = "Supprimer Offre";
            this.buttonSupprimerOffre.UseVisualStyleBackColor = true;
            // 
            // dgwOffre
            // 
            this.dgwOffre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOffre.Location = new System.Drawing.Point(465, 501);
            this.dgwOffre.Name = "dgwOffre";
            this.dgwOffre.Size = new System.Drawing.Size(896, 279);
            this.dgwOffre.TabIndex = 17;
            // 
            // idRapport
            // 
            this.idRapport.HeaderText = "nbRapport";
            this.idRapport.Name = "idRapport";
            // 
            // nomVisiteur
            // 
            this.nomVisiteur.HeaderText = "nomVisiteur";
            this.nomVisiteur.Name = "nomVisiteur";
            // 
            // prenomVisiteur
            // 
            this.prenomVisiteur.HeaderText = "prenomVisiteur";
            this.prenomVisiteur.Name = "prenomVisiteur";
            // 
            // dateRapport
            // 
            this.dateRapport.HeaderText = "dateRapport";
            this.dateRapport.Name = "dateRapport";
            // 
            // motifRapport
            // 
            this.motifRapport.HeaderText = "motifRapport";
            this.motifRapport.Name = "motifRapport";
            // 
            // bilanRapport
            // 
            this.bilanRapport.HeaderText = "bilanRapport";
            this.bilanRapport.Name = "bilanRapport";
            // 
            // nomMedecin
            // 
            this.nomMedecin.HeaderText = "nomMedecin";
            this.nomMedecin.Name = "nomMedecin";
            // 
            // prenomMedecin
            // 
            this.prenomMedecin.HeaderText = "prenomMedecin";
            this.prenomMedecin.Name = "prenomMedecin";
            // 
            // Rapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 792);
            this.Controls.Add(this.dgwOffre);
            this.Controls.Add(this.buttonSupprimerOffre);
            this.Controls.Add(this.buttonModifierOffre);
            this.Controls.Add(this.buttonAjouterOffre);
            this.Controls.Add(this.txtQuantiteOffre);
            this.Controls.Add(this.txtIdMedicament);
            this.Controls.Add(this.txtIdOffre);
            this.Controls.Add(this.buttonAjouterRapport);
            this.Controls.Add(this.buttonValiderModifRapport);
            this.Controls.Add(this.comboBoxMedecinRapport);
            this.Controls.Add(this.comboBoxVisiteurRapport);
            this.Controls.Add(this.txtBoxBilanRapport);
            this.Controls.Add(this.txtBoxMotifRapport);
            this.Controls.Add(this.txtBoxDateRapport);
            this.Controls.Add(this.buttonSupprimerRapport);
            this.Controls.Add(this.buttonModifierRapport);
            this.Controls.Add(this.dgwRapport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rapport";
            this.Text = "Rappors";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgwRapport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOffre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgwRapport;
        private System.Windows.Forms.Button buttonModifierRapport;
        private System.Windows.Forms.Button buttonSupprimerRapport;
        private System.Windows.Forms.TextBox txtBoxDateRapport;
        private System.Windows.Forms.TextBox txtBoxMotifRapport;
        private System.Windows.Forms.TextBox txtBoxBilanRapport;
        private System.Windows.Forms.ComboBox comboBoxVisiteurRapport;
        private System.Windows.Forms.ComboBox comboBoxMedecinRapport;
        private System.Windows.Forms.Button buttonValiderModifRapport;
        private System.Windows.Forms.Button buttonAjouterRapport;
        private System.Windows.Forms.TextBox txtIdOffre;
        private System.Windows.Forms.TextBox txtIdMedicament;
        private System.Windows.Forms.TextBox txtQuantiteOffre;
        private System.Windows.Forms.Button buttonAjouterOffre;
        private System.Windows.Forms.Button buttonModifierOffre;
        private System.Windows.Forms.Button buttonSupprimerOffre;
        private System.Windows.Forms.DataGridView dgwOffre;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRapport;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomVisiteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomVisiteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateRapport;
        private System.Windows.Forms.DataGridViewTextBoxColumn motifRapport;
        private System.Windows.Forms.DataGridViewTextBoxColumn bilanRapport;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomMedecin;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomMedecin;
    }
}