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
            this.dgvRapport = new System.Windows.Forms.DataGridView();
            this.idRap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomVisiteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomVisiteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateRapport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motifRapport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bilanRapport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomMedecin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomMedecin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonModifierRapport = new System.Windows.Forms.Button();
            this.buttonValiderModif = new System.Windows.Forms.Button();
            this.buttonAjouterRapport = new System.Windows.Forms.Button();
            this.buttonValiderAjout = new System.Windows.Forms.Button();
            this.buttonValiderRecherche = new System.Windows.Forms.Button();
            this.buttonReinitialiser = new System.Windows.Forms.Button();
            this.labelTitreDgv = new System.Windows.Forms.Label();
            this.buttonSupprimerRapport = new System.Windows.Forms.Button();
            this.buttonRechercher = new System.Windows.Forms.Button();
            this.groupBoxCode = new System.Windows.Forms.GroupBox();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.groupBoxVisiteur = new System.Windows.Forms.GroupBox();
            this.comboBoxVisiteur = new System.Windows.Forms.ComboBox();
            this.groupBoxMotif = new System.Windows.Forms.GroupBox();
            this.comboBoxMotif = new System.Windows.Forms.ComboBox();
            this.groupBoxDate = new System.Windows.Forms.GroupBox();
            this.dateTimePickerRapport = new System.Windows.Forms.DateTimePicker();
            this.groupBoxMedecin = new System.Windows.Forms.GroupBox();
            this.comboBoxMed = new System.Windows.Forms.ComboBox();
            this.groupBoxBilan = new System.Windows.Forms.GroupBox();
            this.textBoxBilan = new System.Windows.Forms.TextBox();
            this.dgwListeMedicament = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMecidament = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomCommercialMedicament = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantiteOff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxQuantite = new System.Windows.Forms.GroupBox();
            this.txtQuantiteOffre = new System.Windows.Forms.TextBox();
            this.groupBoxMedicamentOffert = new System.Windows.Forms.GroupBox();
            this.comboBoxMedicament = new System.Windows.Forms.ComboBox();
            this.groupBoxRapportOffert = new System.Windows.Forms.GroupBox();
            this.comboBoxIdOffreRapport = new System.Windows.Forms.ComboBox();
            this.buttonSupprimerOffre = new System.Windows.Forms.Button();
            this.buttonModifierOffre = new System.Windows.Forms.Button();
            this.buttonAjouterOffre = new System.Windows.Forms.Button();
            this.labelTitreOffert = new System.Windows.Forms.Label();
            this.buttonRechercherMedRap = new System.Windows.Forms.Button();
            this.buttonReinitialiserMedRap = new System.Windows.Forms.Button();
            this.buttonValiderModifEchantillon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapport)).BeginInit();
            this.groupBoxCode.SuspendLayout();
            this.groupBoxVisiteur.SuspendLayout();
            this.groupBoxMotif.SuspendLayout();
            this.groupBoxDate.SuspendLayout();
            this.groupBoxMedecin.SuspendLayout();
            this.groupBoxBilan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwListeMedicament)).BeginInit();
            this.groupBoxQuantite.SuspendLayout();
            this.groupBoxMedicamentOffert.SuspendLayout();
            this.groupBoxRapportOffert.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRapport
            // 
            this.dgvRapport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRapport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRap,
            this.nomVisiteur,
            this.prenomVisiteur,
            this.dateRapport,
            this.motifRapport,
            this.bilanRapport,
            this.nomMedecin,
            this.prenomMedecin});
            this.dgvRapport.Location = new System.Drawing.Point(171, 39);
            this.dgvRapport.Name = "dgvRapport";
            this.dgvRapport.Size = new System.Drawing.Size(1113, 218);
            this.dgvRapport.TabIndex = 100;
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
            // buttonModifierRapport
            // 
            this.buttonModifierRapport.Location = new System.Drawing.Point(885, 420);
            this.buttonModifierRapport.Name = "buttonModifierRapport";
            this.buttonModifierRapport.Size = new System.Drawing.Size(125, 33);
            this.buttonModifierRapport.TabIndex = 13;
            this.buttonModifierRapport.Text = "Modifier le Rapport";
            this.buttonModifierRapport.UseVisualStyleBackColor = true;
            this.buttonModifierRapport.Click += new System.EventHandler(this.buttonModifierRapport_Click);
            // 
            // buttonValiderModif
            // 
            this.buttonValiderModif.Location = new System.Drawing.Point(1031, 420);
            this.buttonValiderModif.Name = "buttonValiderModif";
            this.buttonValiderModif.Size = new System.Drawing.Size(125, 33);
            this.buttonValiderModif.TabIndex = 14;
            this.buttonValiderModif.Text = "Valider la Modification";
            this.buttonValiderModif.UseVisualStyleBackColor = true;
            this.buttonValiderModif.Click += new System.EventHandler(this.buttonValiderModif_Click);
            // 
            // buttonAjouterRapport
            // 
            this.buttonAjouterRapport.Location = new System.Drawing.Point(309, 420);
            this.buttonAjouterRapport.Name = "buttonAjouterRapport";
            this.buttonAjouterRapport.Size = new System.Drawing.Size(125, 33);
            this.buttonAjouterRapport.TabIndex = 11;
            this.buttonAjouterRapport.Text = "Ajouter un Rapport";
            this.buttonAjouterRapport.UseVisualStyleBackColor = true;
            this.buttonAjouterRapport.Click += new System.EventHandler(this.buttonAjouterRapport_Click);
            // 
            // buttonValiderAjout
            // 
            this.buttonValiderAjout.Location = new System.Drawing.Point(190, 420);
            this.buttonValiderAjout.Name = "buttonValiderAjout";
            this.buttonValiderAjout.Size = new System.Drawing.Size(102, 33);
            this.buttonValiderAjout.TabIndex = 10;
            this.buttonValiderAjout.Text = "Valider L\'Ajout";
            this.buttonValiderAjout.UseVisualStyleBackColor = true;
            this.buttonValiderAjout.Click += new System.EventHandler(this.buttonValiderAjout_Click);
            // 
            // buttonValiderRecherche
            // 
            this.buttonValiderRecherche.Location = new System.Drawing.Point(603, 420);
            this.buttonValiderRecherche.Name = "buttonValiderRecherche";
            this.buttonValiderRecherche.Size = new System.Drawing.Size(125, 33);
            this.buttonValiderRecherche.TabIndex = 12;
            this.buttonValiderRecherche.Text = "Valider la Recherche";
            this.buttonValiderRecherche.UseVisualStyleBackColor = true;
            this.buttonValiderRecherche.Click += new System.EventHandler(this.buttonValiderRecherche_Click);
            // 
            // buttonReinitialiser
            // 
            this.buttonReinitialiser.Location = new System.Drawing.Point(31, 142);
            this.buttonReinitialiser.Name = "buttonReinitialiser";
            this.buttonReinitialiser.Size = new System.Drawing.Size(118, 33);
            this.buttonReinitialiser.TabIndex = 2;
            this.buttonReinitialiser.Text = "Réinitialiser";
            this.buttonReinitialiser.UseVisualStyleBackColor = true;
            this.buttonReinitialiser.Click += new System.EventHandler(this.buttonReinitialiser_Click);
            // 
            // labelTitreDgv
            // 
            this.labelTitreDgv.AutoSize = true;
            this.labelTitreDgv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitreDgv.Location = new System.Drawing.Point(12, 39);
            this.labelTitreDgv.Name = "labelTitreDgv";
            this.labelTitreDgv.Size = new System.Drawing.Size(140, 13);
            this.labelTitreDgv.TabIndex = 0;
            this.labelTitreDgv.Text = "Tableau des Rapports :";
            // 
            // buttonSupprimerRapport
            // 
            this.buttonSupprimerRapport.Location = new System.Drawing.Point(31, 213);
            this.buttonSupprimerRapport.Name = "buttonSupprimerRapport";
            this.buttonSupprimerRapport.Size = new System.Drawing.Size(118, 33);
            this.buttonSupprimerRapport.TabIndex = 3;
            this.buttonSupprimerRapport.Text = "Supprimer le Rapport";
            this.buttonSupprimerRapport.UseVisualStyleBackColor = true;
            this.buttonSupprimerRapport.Click += new System.EventHandler(this.buttonSupprimerRapport_Click);
            // 
            // buttonRechercher
            // 
            this.buttonRechercher.Location = new System.Drawing.Point(31, 77);
            this.buttonRechercher.Name = "buttonRechercher";
            this.buttonRechercher.Size = new System.Drawing.Size(118, 33);
            this.buttonRechercher.TabIndex = 1;
            this.buttonRechercher.Text = "Faire une Recherche";
            this.buttonRechercher.UseVisualStyleBackColor = true;
            this.buttonRechercher.Click += new System.EventHandler(this.buttonRechercher_Click);
            // 
            // groupBoxCode
            // 
            this.groupBoxCode.Controls.Add(this.textBoxCode);
            this.groupBoxCode.Location = new System.Drawing.Point(31, 287);
            this.groupBoxCode.Name = "groupBoxCode";
            this.groupBoxCode.Size = new System.Drawing.Size(403, 50);
            this.groupBoxCode.TabIndex = 4;
            this.groupBoxCode.TabStop = false;
            this.groupBoxCode.Text = "Code du Rapport :";
            // 
            // textBoxCode
            // 
            this.textBoxCode.Enabled = false;
            this.textBoxCode.Location = new System.Drawing.Point(6, 19);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(391, 20);
            this.textBoxCode.TabIndex = 6;
            // 
            // groupBoxVisiteur
            // 
            this.groupBoxVisiteur.Controls.Add(this.comboBoxVisiteur);
            this.groupBoxVisiteur.Location = new System.Drawing.Point(31, 343);
            this.groupBoxVisiteur.Name = "groupBoxVisiteur";
            this.groupBoxVisiteur.Size = new System.Drawing.Size(403, 50);
            this.groupBoxVisiteur.TabIndex = 7;
            this.groupBoxVisiteur.TabStop = false;
            this.groupBoxVisiteur.Text = "Nom Prenom des visiteur";
            // 
            // comboBoxVisiteur
            // 
            this.comboBoxVisiteur.FormattingEnabled = true;
            this.comboBoxVisiteur.Location = new System.Drawing.Point(6, 19);
            this.comboBoxVisiteur.Name = "comboBoxVisiteur";
            this.comboBoxVisiteur.Size = new System.Drawing.Size(391, 21);
            this.comboBoxVisiteur.TabIndex = 9;
            // 
            // groupBoxMotif
            // 
            this.groupBoxMotif.Controls.Add(this.comboBoxMotif);
            this.groupBoxMotif.Location = new System.Drawing.Point(462, 343);
            this.groupBoxMotif.Name = "groupBoxMotif";
            this.groupBoxMotif.Size = new System.Drawing.Size(403, 50);
            this.groupBoxMotif.TabIndex = 8;
            this.groupBoxMotif.TabStop = false;
            this.groupBoxMotif.Text = "Motif du Rapport :";
            // 
            // comboBoxMotif
            // 
            this.comboBoxMotif.FormattingEnabled = true;
            this.comboBoxMotif.Location = new System.Drawing.Point(6, 19);
            this.comboBoxMotif.Name = "comboBoxMotif";
            this.comboBoxMotif.Size = new System.Drawing.Size(391, 21);
            this.comboBoxMotif.TabIndex = 10;
            // 
            // groupBoxDate
            // 
            this.groupBoxDate.Controls.Add(this.dateTimePickerRapport);
            this.groupBoxDate.Location = new System.Drawing.Point(462, 287);
            this.groupBoxDate.Name = "groupBoxDate";
            this.groupBoxDate.Size = new System.Drawing.Size(403, 50);
            this.groupBoxDate.TabIndex = 5;
            this.groupBoxDate.TabStop = false;
            this.groupBoxDate.Text = "Date du Rapport :";
            // 
            // dateTimePickerRapport
            // 
            this.dateTimePickerRapport.Location = new System.Drawing.Point(6, 16);
            this.dateTimePickerRapport.Name = "dateTimePickerRapport";
            this.dateTimePickerRapport.Size = new System.Drawing.Size(391, 20);
            this.dateTimePickerRapport.TabIndex = 7;
            // 
            // groupBoxMedecin
            // 
            this.groupBoxMedecin.Controls.Add(this.comboBoxMed);
            this.groupBoxMedecin.Location = new System.Drawing.Point(885, 287);
            this.groupBoxMedecin.Name = "groupBoxMedecin";
            this.groupBoxMedecin.Size = new System.Drawing.Size(403, 50);
            this.groupBoxMedecin.TabIndex = 6;
            this.groupBoxMedecin.TabStop = false;
            this.groupBoxMedecin.Text = "Nom Prenom des Médecin :";
            // 
            // comboBoxMed
            // 
            this.comboBoxMed.FormattingEnabled = true;
            this.comboBoxMed.Location = new System.Drawing.Point(6, 18);
            this.comboBoxMed.Name = "comboBoxMed";
            this.comboBoxMed.Size = new System.Drawing.Size(391, 21);
            this.comboBoxMed.TabIndex = 8;
            // 
            // groupBoxBilan
            // 
            this.groupBoxBilan.Controls.Add(this.textBoxBilan);
            this.groupBoxBilan.Location = new System.Drawing.Point(885, 343);
            this.groupBoxBilan.Name = "groupBoxBilan";
            this.groupBoxBilan.Size = new System.Drawing.Size(403, 50);
            this.groupBoxBilan.TabIndex = 9;
            this.groupBoxBilan.TabStop = false;
            this.groupBoxBilan.Text = "Bilan du Rapport :";
            // 
            // textBoxBilan
            // 
            this.textBoxBilan.Location = new System.Drawing.Point(6, 19);
            this.textBoxBilan.Name = "textBoxBilan";
            this.textBoxBilan.Size = new System.Drawing.Size(391, 20);
            this.textBoxBilan.TabIndex = 11;
            // 
            // dgwListeMedicament
            // 
            this.dgwListeMedicament.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwListeMedicament.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.idMecidament,
            this.nomCommercialMedicament,
            this.quantiteOff});
            this.dgwListeMedicament.Location = new System.Drawing.Point(643, 511);
            this.dgwListeMedicament.Name = "dgwListeMedicament";
            this.dgwListeMedicament.Size = new System.Drawing.Size(648, 199);
            this.dgwListeMedicament.TabIndex = 101;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "numéro du rapport";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
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
            this.groupBoxQuantite.Location = new System.Drawing.Point(31, 638);
            this.groupBoxQuantite.Name = "groupBoxQuantite";
            this.groupBoxQuantite.Size = new System.Drawing.Size(325, 50);
            this.groupBoxQuantite.TabIndex = 17;
            this.groupBoxQuantite.TabStop = false;
            this.groupBoxQuantite.Text = "Quantité offertes";
            // 
            // txtQuantiteOffre
            // 
            this.txtQuantiteOffre.Location = new System.Drawing.Point(6, 19);
            this.txtQuantiteOffre.Name = "txtQuantiteOffre";
            this.txtQuantiteOffre.Size = new System.Drawing.Size(313, 20);
            this.txtQuantiteOffre.TabIndex = 19;
            // 
            // groupBoxMedicamentOffert
            // 
            this.groupBoxMedicamentOffert.Controls.Add(this.comboBoxMedicament);
            this.groupBoxMedicamentOffert.Location = new System.Drawing.Point(31, 582);
            this.groupBoxMedicamentOffert.Name = "groupBoxMedicamentOffert";
            this.groupBoxMedicamentOffert.Size = new System.Drawing.Size(325, 50);
            this.groupBoxMedicamentOffert.TabIndex = 16;
            this.groupBoxMedicamentOffert.TabStop = false;
            this.groupBoxMedicamentOffert.Text = "médicament offert";
            // 
            // comboBoxMedicament
            // 
            this.comboBoxMedicament.FormattingEnabled = true;
            this.comboBoxMedicament.Location = new System.Drawing.Point(6, 19);
            this.comboBoxMedicament.Name = "comboBoxMedicament";
            this.comboBoxMedicament.Size = new System.Drawing.Size(313, 21);
            this.comboBoxMedicament.TabIndex = 18;
            // 
            // groupBoxRapportOffert
            // 
            this.groupBoxRapportOffert.Controls.Add(this.comboBoxIdOffreRapport);
            this.groupBoxRapportOffert.Location = new System.Drawing.Point(31, 529);
            this.groupBoxRapportOffert.Name = "groupBoxRapportOffert";
            this.groupBoxRapportOffert.Size = new System.Drawing.Size(325, 50);
            this.groupBoxRapportOffert.TabIndex = 15;
            this.groupBoxRapportOffert.TabStop = false;
            this.groupBoxRapportOffert.Text = "Rapport associé";
            // 
            // comboBoxIdOffreRapport
            // 
            this.comboBoxIdOffreRapport.FormattingEnabled = true;
            this.comboBoxIdOffreRapport.Location = new System.Drawing.Point(6, 18);
            this.comboBoxIdOffreRapport.Name = "comboBoxIdOffreRapport";
            this.comboBoxIdOffreRapport.Size = new System.Drawing.Size(313, 21);
            this.comboBoxIdOffreRapport.TabIndex = 17;
            // 
            // buttonSupprimerOffre
            // 
            this.buttonSupprimerOffre.Location = new System.Drawing.Point(507, 592);
            this.buttonSupprimerOffre.Name = "buttonSupprimerOffre";
            this.buttonSupprimerOffre.Size = new System.Drawing.Size(102, 30);
            this.buttonSupprimerOffre.TabIndex = 21;
            this.buttonSupprimerOffre.Text = "Supprimer Offre";
            this.buttonSupprimerOffre.UseVisualStyleBackColor = true;
            this.buttonSupprimerOffre.Click += new System.EventHandler(this.buttonSupprimerOffre_Click);
            // 
            // buttonModifierOffre
            // 
            this.buttonModifierOffre.Location = new System.Drawing.Point(379, 651);
            this.buttonModifierOffre.Name = "buttonModifierOffre";
            this.buttonModifierOffre.Size = new System.Drawing.Size(102, 30);
            this.buttonModifierOffre.TabIndex = 22;
            this.buttonModifierOffre.Text = "Modifier Offre";
            this.buttonModifierOffre.UseVisualStyleBackColor = true;
            this.buttonModifierOffre.Click += new System.EventHandler(this.buttonModifierOffre_Click);
            // 
            // buttonAjouterOffre
            // 
            this.buttonAjouterOffre.Location = new System.Drawing.Point(379, 592);
            this.buttonAjouterOffre.Name = "buttonAjouterOffre";
            this.buttonAjouterOffre.Size = new System.Drawing.Size(102, 30);
            this.buttonAjouterOffre.TabIndex = 20;
            this.buttonAjouterOffre.Text = "Ajouter Offre";
            this.buttonAjouterOffre.UseVisualStyleBackColor = true;
            this.buttonAjouterOffre.Click += new System.EventHandler(this.buttonAjouterOffre_Click);
            // 
            // labelTitreOffert
            // 
            this.labelTitreOffert.AutoSize = true;
            this.labelTitreOffert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitreOffert.Location = new System.Drawing.Point(34, 502);
            this.labelTitreOffert.Name = "labelTitreOffert";
            this.labelTitreOffert.Size = new System.Drawing.Size(191, 13);
            this.labelTitreOffert.TabIndex = 0;
            this.labelTitreOffert.Text = "Tableau des Medicament offert :";
            // 
            // buttonRechercherMedRap
            // 
            this.buttonRechercherMedRap.Location = new System.Drawing.Point(379, 538);
            this.buttonRechercherMedRap.Name = "buttonRechercherMedRap";
            this.buttonRechercherMedRap.Size = new System.Drawing.Size(102, 30);
            this.buttonRechercherMedRap.TabIndex = 18;
            this.buttonRechercherMedRap.Text = "Rechercher Offre";
            this.buttonRechercherMedRap.UseVisualStyleBackColor = true;
            this.buttonRechercherMedRap.Click += new System.EventHandler(this.buttonRechercherMedRap_Click);
            // 
            // buttonReinitialiserMedRap
            // 
            this.buttonReinitialiserMedRap.Location = new System.Drawing.Point(507, 538);
            this.buttonReinitialiserMedRap.Name = "buttonReinitialiserMedRap";
            this.buttonReinitialiserMedRap.Size = new System.Drawing.Size(102, 30);
            this.buttonReinitialiserMedRap.TabIndex = 19;
            this.buttonReinitialiserMedRap.Text = "Réinitialiser";
            this.buttonReinitialiserMedRap.UseVisualStyleBackColor = true;
            this.buttonReinitialiserMedRap.Click += new System.EventHandler(this.buttonReinitialiserMedRap_Click);
            // 
            // buttonValiderModifEchantillon
            // 
            this.buttonValiderModifEchantillon.Location = new System.Drawing.Point(507, 651);
            this.buttonValiderModifEchantillon.Name = "buttonValiderModifEchantillon";
            this.buttonValiderModifEchantillon.Size = new System.Drawing.Size(102, 30);
            this.buttonValiderModifEchantillon.TabIndex = 23;
            this.buttonValiderModifEchantillon.Text = "Valider Modif ";
            this.buttonValiderModifEchantillon.UseVisualStyleBackColor = true;
            this.buttonValiderModifEchantillon.Click += new System.EventHandler(this.buttonValiderModifEchantillon_Click);
            // 
            // Rapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 722);
            this.Controls.Add(this.buttonValiderModifEchantillon);
            this.Controls.Add(this.buttonReinitialiserMedRap);
            this.Controls.Add(this.buttonRechercherMedRap);
            this.Controls.Add(this.labelTitreOffert);
            this.Controls.Add(this.groupBoxQuantite);
            this.Controls.Add(this.groupBoxMedicamentOffert);
            this.Controls.Add(this.groupBoxRapportOffert);
            this.Controls.Add(this.buttonSupprimerOffre);
            this.Controls.Add(this.buttonModifierOffre);
            this.Controls.Add(this.buttonAjouterOffre);
            this.Controls.Add(this.dgwListeMedicament);
            this.Controls.Add(this.groupBoxBilan);
            this.Controls.Add(this.groupBoxMedecin);
            this.Controls.Add(this.groupBoxDate);
            this.Controls.Add(this.groupBoxMotif);
            this.Controls.Add(this.groupBoxVisiteur);
            this.Controls.Add(this.groupBoxCode);
            this.Controls.Add(this.buttonRechercher);
            this.Controls.Add(this.buttonSupprimerRapport);
            this.Controls.Add(this.labelTitreDgv);
            this.Controls.Add(this.buttonReinitialiser);
            this.Controls.Add(this.buttonValiderRecherche);
            this.Controls.Add(this.buttonValiderAjout);
            this.Controls.Add(this.buttonAjouterRapport);
            this.Controls.Add(this.buttonValiderModif);
            this.Controls.Add(this.buttonModifierRapport);
            this.Controls.Add(this.dgvRapport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rapport";
            this.Text = "Gestion des Rapports";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Rapport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapport)).EndInit();
            this.groupBoxCode.ResumeLayout(false);
            this.groupBoxCode.PerformLayout();
            this.groupBoxVisiteur.ResumeLayout(false);
            this.groupBoxMotif.ResumeLayout(false);
            this.groupBoxDate.ResumeLayout(false);
            this.groupBoxMedecin.ResumeLayout(false);
            this.groupBoxBilan.ResumeLayout(false);
            this.groupBoxBilan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwListeMedicament)).EndInit();
            this.groupBoxQuantite.ResumeLayout(false);
            this.groupBoxQuantite.PerformLayout();
            this.groupBoxMedicamentOffert.ResumeLayout(false);
            this.groupBoxRapportOffert.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvRapport;
        private System.Windows.Forms.Button buttonModifierRapport;
        private System.Windows.Forms.Button buttonValiderModif;
        private System.Windows.Forms.Button buttonAjouterRapport;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRap;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomVisiteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomVisiteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateRapport;
        private System.Windows.Forms.DataGridViewTextBoxColumn motifRapport;
        private System.Windows.Forms.DataGridViewTextBoxColumn bilanRapport;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomMedecin;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomMedecin;
        private System.Windows.Forms.Button buttonValiderAjout;
        private System.Windows.Forms.Button buttonValiderRecherche;
        private System.Windows.Forms.Button buttonReinitialiser;
        private System.Windows.Forms.Label labelTitreDgv;
        private System.Windows.Forms.Button buttonSupprimerRapport;
        private System.Windows.Forms.Button buttonRechercher;
        private System.Windows.Forms.GroupBox groupBoxCode;
        private System.Windows.Forms.GroupBox groupBoxVisiteur;
        private System.Windows.Forms.ComboBox comboBoxVisiteur;
        private System.Windows.Forms.GroupBox groupBoxMotif;
        private System.Windows.Forms.ComboBox comboBoxMotif;
        private System.Windows.Forms.GroupBox groupBoxDate;
        private System.Windows.Forms.GroupBox groupBoxMedecin;
        private System.Windows.Forms.ComboBox comboBoxMed;
        private System.Windows.Forms.GroupBox groupBoxBilan;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.DateTimePicker dateTimePickerRapport;
        private System.Windows.Forms.TextBox textBoxBilan;
        private System.Windows.Forms.DataGridView dgwListeMedicament;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMecidament;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomCommercialMedicament;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantiteOff;
        private System.Windows.Forms.GroupBox groupBoxQuantite;
        private System.Windows.Forms.TextBox txtQuantiteOffre;
        private System.Windows.Forms.GroupBox groupBoxMedicamentOffert;
        private System.Windows.Forms.ComboBox comboBoxMedicament;
        private System.Windows.Forms.GroupBox groupBoxRapportOffert;
        private System.Windows.Forms.ComboBox comboBoxIdOffreRapport;
        private System.Windows.Forms.Button buttonSupprimerOffre;
        private System.Windows.Forms.Button buttonModifierOffre;
        private System.Windows.Forms.Button buttonAjouterOffre;
        private System.Windows.Forms.Label labelTitreOffert;
        private System.Windows.Forms.Button buttonRechercherMedRap;
        private System.Windows.Forms.Button buttonReinitialiserMedRap;
        private System.Windows.Forms.Button buttonValiderModifEchantillon;
    }
}