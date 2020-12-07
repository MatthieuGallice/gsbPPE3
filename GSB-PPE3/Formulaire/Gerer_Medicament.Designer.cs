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
            this.buttonModifierMedicament = new System.Windows.Forms.Button();
            this.buttonSupprimerMedicament = new System.Windows.Forms.Button();
            this.buttonValiderModification = new System.Windows.Forms.Button();
            this.buttonAjouterMedicament = new System.Windows.Forms.Button();
            this.txtNomMedicament = new System.Windows.Forms.TextBox();
            this.txtCompositionMedicament = new System.Windows.Forms.TextBox();
            this.txtEffetMedicament = new System.Windows.Forms.TextBox();
            this.txtFamilleMedicament = new System.Windows.Forms.TextBox();
            this.txtContreIndicationMedicament = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwGererMedicament)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwGererMedicament
            // 
            this.dgwGererMedicament.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwGererMedicament.Location = new System.Drawing.Point(196, 12);
            this.dgwGererMedicament.Name = "dgwGererMedicament";
            this.dgwGererMedicament.Size = new System.Drawing.Size(1166, 306);
            this.dgwGererMedicament.TabIndex = 1;
            // 
            // buttonModifierMedicament
            // 
            this.buttonModifierMedicament.Location = new System.Drawing.Point(36, 72);
            this.buttonModifierMedicament.Name = "buttonModifierMedicament";
            this.buttonModifierMedicament.Size = new System.Drawing.Size(127, 23);
            this.buttonModifierMedicament.TabIndex = 2;
            this.buttonModifierMedicament.Text = "Modifier Medicament";
            this.buttonModifierMedicament.UseVisualStyleBackColor = true;
            // 
            // buttonSupprimerMedicament
            // 
            this.buttonSupprimerMedicament.Location = new System.Drawing.Point(36, 194);
            this.buttonSupprimerMedicament.Name = "buttonSupprimerMedicament";
            this.buttonSupprimerMedicament.Size = new System.Drawing.Size(127, 23);
            this.buttonSupprimerMedicament.TabIndex = 3;
            this.buttonSupprimerMedicament.Text = "Supprimer Medicament";
            this.buttonSupprimerMedicament.UseVisualStyleBackColor = true;
            // 
            // buttonValiderModification
            // 
            this.buttonValiderModification.Location = new System.Drawing.Point(407, 711);
            this.buttonValiderModification.Name = "buttonValiderModification";
            this.buttonValiderModification.Size = new System.Drawing.Size(123, 23);
            this.buttonValiderModification.TabIndex = 4;
            this.buttonValiderModification.Text = "Valider Modification";
            this.buttonValiderModification.UseVisualStyleBackColor = true;
            // 
            // buttonAjouterMedicament
            // 
            this.buttonAjouterMedicament.Location = new System.Drawing.Point(822, 711);
            this.buttonAjouterMedicament.Name = "buttonAjouterMedicament";
            this.buttonAjouterMedicament.Size = new System.Drawing.Size(125, 23);
            this.buttonAjouterMedicament.TabIndex = 5;
            this.buttonAjouterMedicament.Text = "Ajouter Medicament";
            this.buttonAjouterMedicament.UseVisualStyleBackColor = true;
            // 
            // txtNomMedicament
            // 
            this.txtNomMedicament.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtNomMedicament.Location = new System.Drawing.Point(92, 417);
            this.txtNomMedicament.Name = "txtNomMedicament";
            this.txtNomMedicament.Size = new System.Drawing.Size(305, 20);
            this.txtNomMedicament.TabIndex = 6;
            // 
            // txtCompositionMedicament
            // 
            this.txtCompositionMedicament.Location = new System.Drawing.Point(540, 417);
            this.txtCompositionMedicament.Name = "txtCompositionMedicament";
            this.txtCompositionMedicament.Size = new System.Drawing.Size(305, 20);
            this.txtCompositionMedicament.TabIndex = 7;
            // 
            // txtEffetMedicament
            // 
            this.txtEffetMedicament.Location = new System.Drawing.Point(965, 417);
            this.txtEffetMedicament.Name = "txtEffetMedicament";
            this.txtEffetMedicament.Size = new System.Drawing.Size(305, 20);
            this.txtEffetMedicament.TabIndex = 8;
            // 
            // txtFamilleMedicament
            // 
            this.txtFamilleMedicament.Location = new System.Drawing.Point(298, 559);
            this.txtFamilleMedicament.Name = "txtFamilleMedicament";
            this.txtFamilleMedicament.Size = new System.Drawing.Size(305, 20);
            this.txtFamilleMedicament.TabIndex = 9;
            // 
            // txtContreIndicationMedicament
            // 
            this.txtContreIndicationMedicament.Location = new System.Drawing.Point(766, 559);
            this.txtContreIndicationMedicament.Name = "txtContreIndicationMedicament";
            this.txtContreIndicationMedicament.Size = new System.Drawing.Size(305, 20);
            this.txtContreIndicationMedicament.TabIndex = 10;
            // 
            // Gerer_Medicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 806);
            this.Controls.Add(this.txtContreIndicationMedicament);
            this.Controls.Add(this.txtFamilleMedicament);
            this.Controls.Add(this.txtEffetMedicament);
            this.Controls.Add(this.txtCompositionMedicament);
            this.Controls.Add(this.txtNomMedicament);
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
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox txtFamilleMedicament;
        private System.Windows.Forms.TextBox txtContreIndicationMedicament;
    }
}