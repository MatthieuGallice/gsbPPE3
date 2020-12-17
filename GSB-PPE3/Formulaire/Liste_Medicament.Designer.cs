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
            ((System.ComponentModel.ISupportInitialize)(this.dgwListeMedicament)).BeginInit();
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
            this.dgwListeMedicament.Size = new System.Drawing.Size(1276, 636);
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
            // Liste_Medicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 722);
            this.Controls.Add(this.dgwListeMedicament);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Liste_Medicament";
            this.Text = "Liste_Medicament";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Liste_Medicament_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwListeMedicament)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgwListeMedicament;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRap;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMecidament;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomCommercialMedicament;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantiteOff;
    }
}