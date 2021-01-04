namespace Formulaire
{
    partial class Recherche_Medicament
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
            this.dgwRechercheMedicament = new System.Windows.Forms.DataGridView();
            this.idMedicament = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomCommercialMedicament = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFamilleMedicament = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compositionMedicament = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.effetsMedicament = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contreIndicationsMedicament = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxRechercheNom_Medicament = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxRecherchefam_Medicament = new System.Windows.Forms.ComboBox();
            this.label_ou = new System.Windows.Forms.Label();
            this.boutton_verif = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRechercheMedicament)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwRechercheMedicament
            // 
            this.dgwRechercheMedicament.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRechercheMedicament.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMedicament,
            this.nomCommercialMedicament,
            this.idFamilleMedicament,
            this.compositionMedicament,
            this.effetsMedicament,
            this.contreIndicationsMedicament});
            this.dgwRechercheMedicament.Location = new System.Drawing.Point(61, 210);
            this.dgwRechercheMedicament.Name = "dgwRechercheMedicament";
            this.dgwRechercheMedicament.Size = new System.Drawing.Size(730, 151);
            this.dgwRechercheMedicament.TabIndex = 2;
            this.dgwRechercheMedicament.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwRechercheMedicament_CellContentClick);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxRechercheNom_Medicament);
            this.groupBox1.Location = new System.Drawing.Point(322, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 53);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choisir Nom";
            // 
            // comboBoxRechercheNom_Medicament
            // 
            this.comboBoxRechercheNom_Medicament.FormattingEnabled = true;
            this.comboBoxRechercheNom_Medicament.Location = new System.Drawing.Point(6, 19);
            this.comboBoxRechercheNom_Medicament.Name = "comboBoxRechercheNom_Medicament";
            this.comboBoxRechercheNom_Medicament.Size = new System.Drawing.Size(181, 21);
            this.comboBoxRechercheNom_Medicament.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxRecherchefam_Medicament);
            this.groupBox2.Location = new System.Drawing.Point(61, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 53);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choisir Famille";
            // 
            // comboBoxRecherchefam_Medicament
            // 
            this.comboBoxRecherchefam_Medicament.FormattingEnabled = true;
            this.comboBoxRecherchefam_Medicament.Location = new System.Drawing.Point(6, 19);
            this.comboBoxRecherchefam_Medicament.Name = "comboBoxRecherchefam_Medicament";
            this.comboBoxRecherchefam_Medicament.Size = new System.Drawing.Size(179, 21);
            this.comboBoxRecherchefam_Medicament.TabIndex = 0;
            // 
            // label_ou
            // 
            this.label_ou.AutoSize = true;
            this.label_ou.Location = new System.Drawing.Point(288, 99);
            this.label_ou.Name = "label_ou";
            this.label_ou.Size = new System.Drawing.Size(19, 13);
            this.label_ou.TabIndex = 5;
            this.label_ou.Text = "ou";
            // 
            // boutton_verif
            // 
            this.boutton_verif.Location = new System.Drawing.Point(104, 162);
            this.boutton_verif.Name = "boutton_verif";
            this.boutton_verif.Size = new System.Drawing.Size(75, 23);
            this.boutton_verif.TabIndex = 6;
            this.boutton_verif.Text = "Vérifier";
            this.boutton_verif.UseVisualStyleBackColor = true;
            // 
            // Recherche_Medicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 486);
            this.Controls.Add(this.boutton_verif);
            this.Controls.Add(this.label_ou);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgwRechercheMedicament);
            this.Name = "Recherche_Medicament";
            this.Text = "Recherche_Mecicament";
            this.Load += new System.EventHandler(this.Recherche_Mecicament_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwRechercheMedicament)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwRechercheMedicament;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMedicament;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomCommercialMedicament;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFamilleMedicament;
        private System.Windows.Forms.DataGridViewTextBoxColumn compositionMedicament;
        private System.Windows.Forms.DataGridViewTextBoxColumn effetsMedicament;
        private System.Windows.Forms.DataGridViewTextBoxColumn contreIndicationsMedicament;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxRechercheNom_Medicament;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxRecherchefam_Medicament;
        private System.Windows.Forms.Label label_ou;
        private System.Windows.Forms.Button boutton_verif;
    }
}