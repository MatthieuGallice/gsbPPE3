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
            ((System.ComponentModel.ISupportInitialize)(this.dgwListeMedicament)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwListeMedicament
            // 
            this.dgwListeMedicament.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwListeMedicament.Location = new System.Drawing.Point(72, 41);
            this.dgwListeMedicament.Name = "dgwListeMedicament";
            this.dgwListeMedicament.Size = new System.Drawing.Size(1197, 613);
            this.dgwListeMedicament.TabIndex = 1;
            // 
            // Liste_Medicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 790);
            this.Controls.Add(this.dgwListeMedicament);
            this.Name = "Liste_Medicament";
            this.Text = "Liste_Medicament";
            ((System.ComponentModel.ISupportInitialize)(this.dgwListeMedicament)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgwListeMedicament;
    }
}