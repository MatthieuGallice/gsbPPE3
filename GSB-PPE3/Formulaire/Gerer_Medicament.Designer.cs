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
            ((System.ComponentModel.ISupportInitialize)(this.dgwGererMedicament)).BeginInit();
            this.groupBoxNomMedicament.SuspendLayout();
            this.groupBoxCompositionMedicament.SuspendLayout();
            this.groupBoxEffetMedicament.SuspendLayout();
            this.groupBoxFamilleMedicament.SuspendLayout();
            this.groupBoxContreIndication.SuspendLayout();
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
            this.dgwGererMedicament.Location = new System.Drawing.Point(196, 12);
            this.dgwGererMedicament.Name = "dgwGererMedicament";
            this.dgwGererMedicament.Size = new System.Drawing.Size(1166, 314);
            this.dgwGererMedicament.TabIndex = 1;
            // 
            // idMedicament
            // 
            this.idMedicament.HeaderText = "numéro du médicament";
            this.idMedicament.Name = "idMedicament";
            // 
            // nomCommercialMedicament
            // 
            this.nomCommercialMedicament.HeaderText = "nom commercial";
            this.nomCommercialMedicament.Name = "nomCommercialMedicament";
            // 
            // idFamilleMedicament
            // 
            this.idFamilleMedicament.HeaderText = "libelle de la famille ";
            this.idFamilleMedicament.Name = "idFamilleMedicament";
            // 
            // compositionMedicament
            // 
            this.compositionMedicament.HeaderText = "composition";
            this.compositionMedicament.Name = "compositionMedicament";
            // 
            // effetsMedicament
            // 
            this.effetsMedicament.HeaderText = "effets";
            this.effetsMedicament.Name = "effetsMedicament";
            // 
            // contreIndicationsMedicament
            // 
            this.contreIndicationsMedicament.HeaderText = "contre indications";
            this.contreIndicationsMedicament.Name = "contreIndicationsMedicament";
            // 
            // buttonModifierMedicament
            // 
            this.buttonModifierMedicament.Location = new System.Drawing.Point(36, 72);
            this.buttonModifierMedicament.Name = "buttonModifierMedicament";
            this.buttonModifierMedicament.Size = new System.Drawing.Size(127, 47);
            this.buttonModifierMedicament.TabIndex = 2;
            this.buttonModifierMedicament.Text = "Modifier Medicament";
            this.buttonModifierMedicament.UseVisualStyleBackColor = true;
            // 
            // buttonSupprimerMedicament
            // 
            this.buttonSupprimerMedicament.Location = new System.Drawing.Point(36, 195);
            this.buttonSupprimerMedicament.Name = "buttonSupprimerMedicament";
            this.buttonSupprimerMedicament.Size = new System.Drawing.Size(127, 47);
            this.buttonSupprimerMedicament.TabIndex = 3;
            this.buttonSupprimerMedicament.Text = "Supprimer Medicament";
            this.buttonSupprimerMedicament.UseVisualStyleBackColor = true;
            // 
            // buttonValiderModification
            // 
            this.buttonValiderModification.Location = new System.Drawing.Point(442, 711);
            this.buttonValiderModification.Name = "buttonValiderModification";
            this.buttonValiderModification.Size = new System.Drawing.Size(127, 47);
            this.buttonValiderModification.TabIndex = 4;
            this.buttonValiderModification.Text = "Valider Modification";
            this.buttonValiderModification.UseVisualStyleBackColor = true;
            // 
            // buttonAjouterMedicament
            // 
            this.buttonAjouterMedicament.Location = new System.Drawing.Point(739, 711);
            this.buttonAjouterMedicament.Name = "buttonAjouterMedicament";
            this.buttonAjouterMedicament.Size = new System.Drawing.Size(127, 47);
            this.buttonAjouterMedicament.TabIndex = 5;
            this.buttonAjouterMedicament.Text = "Ajouter Medicament";
            this.buttonAjouterMedicament.UseVisualStyleBackColor = true;
            // 
            // txtNomMedicament
            // 
            this.txtNomMedicament.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtNomMedicament.Location = new System.Drawing.Point(30, 47);
            this.txtNomMedicament.Name = "txtNomMedicament";
            this.txtNomMedicament.Size = new System.Drawing.Size(305, 20);
            this.txtNomMedicament.TabIndex = 6;
            // 
            // txtCompositionMedicament
            // 
            this.txtCompositionMedicament.Location = new System.Drawing.Point(53, 38);
            this.txtCompositionMedicament.Name = "txtCompositionMedicament";
            this.txtCompositionMedicament.Size = new System.Drawing.Size(305, 20);
            this.txtCompositionMedicament.TabIndex = 7;
            // 
            // txtEffetMedicament
            // 
            this.txtEffetMedicament.Location = new System.Drawing.Point(37, 47);
            this.txtEffetMedicament.Name = "txtEffetMedicament";
            this.txtEffetMedicament.Size = new System.Drawing.Size(305, 20);
            this.txtEffetMedicament.TabIndex = 8;
            // 
            // txtContreIndicationMedicament
            // 
            this.txtContreIndicationMedicament.Location = new System.Drawing.Point(55, 42);
            this.txtContreIndicationMedicament.Name = "txtContreIndicationMedicament";
            this.txtContreIndicationMedicament.Size = new System.Drawing.Size(305, 20);
            this.txtContreIndicationMedicament.TabIndex = 10;
            // 
            // comboBoxFamilleMedicament
            // 
            this.comboBoxFamilleMedicament.FormattingEnabled = true;
            this.comboBoxFamilleMedicament.Location = new System.Drawing.Point(45, 48);
            this.comboBoxFamilleMedicament.Name = "comboBoxFamilleMedicament";
            this.comboBoxFamilleMedicament.Size = new System.Drawing.Size(305, 21);
            this.comboBoxFamilleMedicament.TabIndex = 11;
            // 
            // groupBoxNomMedicament
            // 
            this.groupBoxNomMedicament.Controls.Add(this.txtNomMedicament);
            this.groupBoxNomMedicament.Location = new System.Drawing.Point(36, 396);
            this.groupBoxNomMedicament.Name = "groupBoxNomMedicament";
            this.groupBoxNomMedicament.Size = new System.Drawing.Size(398, 102);
            this.groupBoxNomMedicament.TabIndex = 12;
            this.groupBoxNomMedicament.TabStop = false;
            this.groupBoxNomMedicament.Text = "Nom du Médicament";
            // 
            // groupBoxCompositionMedicament
            // 
            this.groupBoxCompositionMedicament.Controls.Add(this.txtCompositionMedicament);
            this.groupBoxCompositionMedicament.Location = new System.Drawing.Point(936, 396);
            this.groupBoxCompositionMedicament.Name = "groupBoxCompositionMedicament";
            this.groupBoxCompositionMedicament.Size = new System.Drawing.Size(398, 102);
            this.groupBoxCompositionMedicament.TabIndex = 13;
            this.groupBoxCompositionMedicament.TabStop = false;
            this.groupBoxCompositionMedicament.Text = "Composition du Médicament";
            // 
            // groupBoxEffetMedicament
            // 
            this.groupBoxEffetMedicament.Controls.Add(this.txtEffetMedicament);
            this.groupBoxEffetMedicament.Location = new System.Drawing.Point(258, 541);
            this.groupBoxEffetMedicament.Name = "groupBoxEffetMedicament";
            this.groupBoxEffetMedicament.Size = new System.Drawing.Size(398, 102);
            this.groupBoxEffetMedicament.TabIndex = 13;
            this.groupBoxEffetMedicament.TabStop = false;
            this.groupBoxEffetMedicament.Text = "Effet du Médicament";
            // 
            // groupBoxFamilleMedicament
            // 
            this.groupBoxFamilleMedicament.Controls.Add(this.comboBoxFamilleMedicament);
            this.groupBoxFamilleMedicament.Location = new System.Drawing.Point(491, 396);
            this.groupBoxFamilleMedicament.Name = "groupBoxFamilleMedicament";
            this.groupBoxFamilleMedicament.Size = new System.Drawing.Size(398, 102);
            this.groupBoxFamilleMedicament.TabIndex = 14;
            this.groupBoxFamilleMedicament.TabStop = false;
            this.groupBoxFamilleMedicament.Text = "Libelle de la Famille du Médicament";
            // 
            // groupBoxContreIndication
            // 
            this.groupBoxContreIndication.Controls.Add(this.txtContreIndicationMedicament);
            this.groupBoxContreIndication.Location = new System.Drawing.Point(753, 541);
            this.groupBoxContreIndication.Name = "groupBoxContreIndication";
            this.groupBoxContreIndication.Size = new System.Drawing.Size(398, 102);
            this.groupBoxContreIndication.TabIndex = 15;
            this.groupBoxContreIndication.TabStop = false;
            this.groupBoxContreIndication.Text = "Contre Indications ";
            // 
            // Gerer_Medicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 806);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idMedicament;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomCommercialMedicament;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFamilleMedicament;
        private System.Windows.Forms.DataGridViewTextBoxColumn compositionMedicament;
        private System.Windows.Forms.DataGridViewTextBoxColumn effetsMedicament;
        private System.Windows.Forms.DataGridViewTextBoxColumn contreIndicationsMedicament;
        private System.Windows.Forms.GroupBox groupBoxNomMedicament;
        private System.Windows.Forms.GroupBox groupBoxCompositionMedicament;
        private System.Windows.Forms.GroupBox groupBoxEffetMedicament;
        private System.Windows.Forms.GroupBox groupBoxFamilleMedicament;
        private System.Windows.Forms.GroupBox groupBoxContreIndication;
    }
}