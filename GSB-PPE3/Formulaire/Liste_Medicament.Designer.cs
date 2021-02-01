namespace Formulaire
{
    partial class Liste_Medicament
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
            this.dgwListeMedicament = new System.Windows.Forms.DataGridView();
            this.idRap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMecidament = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomCommercialMedicament = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantiteOff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxQuantite = new System.Windows.Forms.GroupBox();
            this.txtQuantiteOffre = new System.Windows.Forms.TextBox();
            this.groupBoxMedicamentOffert = new System.Windows.Forms.GroupBox();
            this.comboBoxIdMedicament = new System.Windows.Forms.ComboBox();
            this.groupBoxRapportOffert = new System.Windows.Forms.GroupBox();
            this.comboBoxIdOffreRapport = new System.Windows.Forms.ComboBox();
            this.buttonSupprimerOffre = new System.Windows.Forms.Button();
            this.buttonModifierOffre = new System.Windows.Forms.Button();
            this.buttonAjouterOffre = new System.Windows.Forms.Button();
            this.txtboxNomCommercial = new System.Windows.Forms.TextBox();
            this.grpboxNomCommercial = new System.Windows.Forms.GroupBox();
            this.btnValiderAjout = new System.Windows.Forms.Button();
            this.btnValiderModif = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwListeMedicament)).BeginInit();
            this.groupBoxQuantite.SuspendLayout();
            this.groupBoxMedicamentOffert.SuspendLayout();
            this.groupBoxRapportOffert.SuspendLayout();
            this.grpboxNomCommercial.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwListeMedicament
            // 
            this.dgwListeMedicament.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwListeMedicament.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRap,
            this.idMecidament,
            this.nomCommercialMedicament,
            this.quantiteOff});
            this.dgwListeMedicament.Location = new System.Drawing.Point(12, 46);
            this.dgwListeMedicament.Name = "dgwListeMedicament";
            this.dgwListeMedicament.Size = new System.Drawing.Size(1276, 176);
            this.dgwListeMedicament.TabIndex = 1;
            // 
            // idRap
            // 
            this.idRap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idRap.HeaderText = "numéro du rapport";
            this.idRap.Name = "idRap";
            // 
            // idMecidament
            // 
            this.idMecidament.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idMecidament.HeaderText = "numéro du médicament";
            this.idMecidament.Name = "idMecidament";
            // 
            // nomCommercialMedicament
            // 
            this.nomCommercialMedicament.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomCommercialMedicament.HeaderText = "nom commercial";
            this.nomCommercialMedicament.Name = "nomCommercialMedicament";
            // 
            // quantiteOff
            // 
            this.quantiteOff.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantiteOff.HeaderText = "quantité offerte";
            this.quantiteOff.Name = "quantiteOff";
            // 
            // groupBoxQuantite
            // 
            this.groupBoxQuantite.Controls.Add(this.txtQuantiteOffre);
            this.groupBoxQuantite.Location = new System.Drawing.Point(511, 493);
            this.groupBoxQuantite.Name = "groupBoxQuantite";
            this.groupBoxQuantite.Size = new System.Drawing.Size(292, 60);
            this.groupBoxQuantite.TabIndex = 28;
            this.groupBoxQuantite.TabStop = false;
            this.groupBoxQuantite.Text = "Quantité offertes";
            this.groupBoxQuantite.Visible = false;
            // 
            // txtQuantiteOffre
            // 
            this.txtQuantiteOffre.Location = new System.Drawing.Point(25, 19);
            this.txtQuantiteOffre.Name = "txtQuantiteOffre";
            this.txtQuantiteOffre.Size = new System.Drawing.Size(243, 20);
            this.txtQuantiteOffre.TabIndex = 13;
            // 
            // groupBoxMedicamentOffert
            // 
            this.groupBoxMedicamentOffert.Controls.Add(this.comboBoxIdMedicament);
            this.groupBoxMedicamentOffert.Location = new System.Drawing.Point(511, 373);
            this.groupBoxMedicamentOffert.Name = "groupBoxMedicamentOffert";
            this.groupBoxMedicamentOffert.Size = new System.Drawing.Size(292, 60);
            this.groupBoxMedicamentOffert.TabIndex = 27;
            this.groupBoxMedicamentOffert.TabStop = false;
            this.groupBoxMedicamentOffert.Text = "médicament offert";
            this.groupBoxMedicamentOffert.Visible = false;
            // 
            // comboBoxIdMedicament
            // 
            this.comboBoxIdMedicament.FormattingEnabled = true;
            this.comboBoxIdMedicament.Location = new System.Drawing.Point(25, 19);
            this.comboBoxIdMedicament.Name = "comboBoxIdMedicament";
            this.comboBoxIdMedicament.Size = new System.Drawing.Size(243, 21);
            this.comboBoxIdMedicament.TabIndex = 23;
            // 
            // groupBoxRapportOffert
            // 
            this.groupBoxRapportOffert.Controls.Add(this.comboBoxIdOffreRapport);
            this.groupBoxRapportOffert.Location = new System.Drawing.Point(59, 373);
            this.groupBoxRapportOffert.Name = "groupBoxRapportOffert";
            this.groupBoxRapportOffert.Size = new System.Drawing.Size(292, 60);
            this.groupBoxRapportOffert.TabIndex = 26;
            this.groupBoxRapportOffert.TabStop = false;
            this.groupBoxRapportOffert.Text = "Rapport associé";
            this.groupBoxRapportOffert.Visible = false;
            // 
            // comboBoxIdOffreRapport
            // 
            this.comboBoxIdOffreRapport.FormattingEnabled = true;
            this.comboBoxIdOffreRapport.Location = new System.Drawing.Point(25, 19);
            this.comboBoxIdOffreRapport.Name = "comboBoxIdOffreRapport";
            this.comboBoxIdOffreRapport.Size = new System.Drawing.Size(243, 21);
            this.comboBoxIdOffreRapport.TabIndex = 23;
            // 
            // buttonSupprimerOffre
            // 
            this.buttonSupprimerOffre.Location = new System.Drawing.Point(802, 252);
            this.buttonSupprimerOffre.Name = "buttonSupprimerOffre";
            this.buttonSupprimerOffre.Size = new System.Drawing.Size(95, 38);
            this.buttonSupprimerOffre.TabIndex = 25;
            this.buttonSupprimerOffre.Text = "Supprimer ";
            this.buttonSupprimerOffre.UseVisualStyleBackColor = true;
            this.buttonSupprimerOffre.Click += new System.EventHandler(this.buttonSupprimerOffre_Click);
            // 
            // buttonModifierOffre
            // 
            this.buttonModifierOffre.Location = new System.Drawing.Point(600, 252);
            this.buttonModifierOffre.Name = "buttonModifierOffre";
            this.buttonModifierOffre.Size = new System.Drawing.Size(95, 38);
            this.buttonModifierOffre.TabIndex = 24;
            this.buttonModifierOffre.Text = "Modifier ";
            this.buttonModifierOffre.UseVisualStyleBackColor = true;
            this.buttonModifierOffre.Click += new System.EventHandler(this.buttonModifierOffre_Click);
            // 
            // buttonAjouterOffre
            // 
            this.buttonAjouterOffre.Location = new System.Drawing.Point(398, 252);
            this.buttonAjouterOffre.Name = "buttonAjouterOffre";
            this.buttonAjouterOffre.Size = new System.Drawing.Size(95, 38);
            this.buttonAjouterOffre.TabIndex = 23;
            this.buttonAjouterOffre.Text = "Ajouter ";
            this.buttonAjouterOffre.UseVisualStyleBackColor = true;
            this.buttonAjouterOffre.Click += new System.EventHandler(this.buttonAjouterOffre_Click);
            // 
            // txtboxNomCommercial
            // 
            this.txtboxNomCommercial.Location = new System.Drawing.Point(16, 20);
            this.txtboxNomCommercial.Name = "txtboxNomCommercial";
            this.txtboxNomCommercial.Size = new System.Drawing.Size(251, 20);
            this.txtboxNomCommercial.TabIndex = 29;
            // 
            // grpboxNomCommercial
            // 
            this.grpboxNomCommercial.Controls.Add(this.txtboxNomCommercial);
            this.grpboxNomCommercial.Location = new System.Drawing.Point(889, 373);
            this.grpboxNomCommercial.Name = "grpboxNomCommercial";
            this.grpboxNomCommercial.Size = new System.Drawing.Size(292, 60);
            this.grpboxNomCommercial.TabIndex = 30;
            this.grpboxNomCommercial.TabStop = false;
            this.grpboxNomCommercial.Text = "Nom Commercial";
            this.grpboxNomCommercial.Visible = false;
            // 
            // btnValiderAjout
            // 
            this.btnValiderAjout.Location = new System.Drawing.Point(398, 598);
            this.btnValiderAjout.Name = "btnValiderAjout";
            this.btnValiderAjout.Size = new System.Drawing.Size(95, 38);
            this.btnValiderAjout.TabIndex = 31;
            this.btnValiderAjout.Text = "Valider ";
            this.btnValiderAjout.UseVisualStyleBackColor = true;
            this.btnValiderAjout.Visible = false;
            this.btnValiderAjout.Click += new System.EventHandler(this.btnValiderAjout_Click);
            // 
            // btnValiderModif
            // 
            this.btnValiderModif.Location = new System.Drawing.Point(600, 598);
            this.btnValiderModif.Name = "btnValiderModif";
            this.btnValiderModif.Size = new System.Drawing.Size(95, 38);
            this.btnValiderModif.TabIndex = 32;
            this.btnValiderModif.Text = "Valider";
            this.btnValiderModif.UseVisualStyleBackColor = true;
            this.btnValiderModif.Visible = false;
            this.btnValiderModif.Click += new System.EventHandler(this.btnValiderModif_Click);
            // 
            // Liste_Medicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 722);
            this.Controls.Add(this.btnValiderModif);
            this.Controls.Add(this.btnValiderAjout);
            this.Controls.Add(this.grpboxNomCommercial);
            this.Controls.Add(this.groupBoxQuantite);
            this.Controls.Add(this.groupBoxMedicamentOffert);
            this.Controls.Add(this.groupBoxRapportOffert);
            this.Controls.Add(this.buttonSupprimerOffre);
            this.Controls.Add(this.buttonModifierOffre);
            this.Controls.Add(this.buttonAjouterOffre);
            this.Controls.Add(this.dgwListeMedicament);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Liste_Medicament";
            this.Text = "Liste_Medicament";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Liste_Medicament_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwListeMedicament)).EndInit();
            this.groupBoxQuantite.ResumeLayout(false);
            this.groupBoxQuantite.PerformLayout();
            this.groupBoxMedicamentOffert.ResumeLayout(false);
            this.groupBoxRapportOffert.ResumeLayout(false);
            this.grpboxNomCommercial.ResumeLayout(false);
            this.grpboxNomCommercial.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgwListeMedicament;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRap;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMecidament;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomCommercialMedicament;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantiteOff;
        private System.Windows.Forms.GroupBox groupBoxQuantite;
        private System.Windows.Forms.TextBox txtQuantiteOffre;
        private System.Windows.Forms.GroupBox groupBoxMedicamentOffert;
        private System.Windows.Forms.ComboBox comboBoxIdMedicament;
        private System.Windows.Forms.GroupBox groupBoxRapportOffert;
        private System.Windows.Forms.ComboBox comboBoxIdOffreRapport;
        private System.Windows.Forms.Button buttonSupprimerOffre;
        private System.Windows.Forms.Button buttonModifierOffre;
        private System.Windows.Forms.Button buttonAjouterOffre;
        private System.Windows.Forms.TextBox txtboxNomCommercial;
        private System.Windows.Forms.GroupBox grpboxNomCommercial;
        private System.Windows.Forms.Button btnValiderAjout;
        private System.Windows.Forms.Button btnValiderModif;
    }
}