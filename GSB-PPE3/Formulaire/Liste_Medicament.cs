using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassePasserelle;
using ClasseMétiers;

namespace Formulaire
{
    public partial class Liste_Medicament : Form
    {
        public Liste_Medicament()
        {
            InitializeComponent();
        }

        private void Liste_Medicament_Load(object sender, EventArgs e)
        {
            List<ClasseRapport> lesRapports = ClassePRapport.chargerLesRapports();
            foreach (ClasseRapport leRapport in lesRapports)
            {
                //Récupère l'id du rapport
                int numrapport = leRapport.Id;
                comboBoxIdOffreRapport.Items.Add(numrapport);
            }

            List<ClasseMedicament> lesMedicaments = ClassePMedicament.chargerLesMedicaments();
            foreach (ClasseMedicament leMedicament in lesMedicaments)
            {
                //Récupère l'id du rapport
                int idMedicament = leMedicament.Id;
                comboBoxIdMedicament.Items.Add(idMecidament);
            }
            ChargerLeDGV();

        }

        private void ChargerLeDGV()
        {
            dgwListeMedicament.Rows.Clear();
            //Charge tout les rapports
            List<ClasseRapport> lesRapports = ClassePRapport.chargerLesRapports();
            foreach (ClasseRapport leRapport in lesRapports)
            {
                //Récupère l'id du rapport
                int numrapport = leRapport.Id;
                //Charge les échantillons du rapport
                List<ClasseEchantillonOffert> lEchantillonOffert = ClassePEchantillonOffert.chargerLEchantillonOffert(numrapport);
                foreach (ClasseEchantillonOffert unEchantillon in lEchantillonOffert)
                {
                    //Récupère les données 
                    int quantiteOff = unEchantillon.Quantite;
                    int numMedic = unEchantillon.LeMedicament.Id;
                    string nomCommercial = unEchantillon.LeMedicament.NomCommercial;
                    // Insère les données dans le DGV
                    dgwListeMedicament.Rows.Add(numrapport, numMedic, nomCommercial, quantiteOff);
                }
            }
        }

        private void buttonModifierOffre_Click(object sender, EventArgs e)
        {
            if (dgwListeMedicament.CurrentRow.Selected)
            {

                comboBoxIdOffreRapport.Text = dgwListeMedicament.CurrentRow.Cells[0].Value.ToString();
                comboBoxIdMedicament.Text = dgwListeMedicament.CurrentRow.Cells[1].Value.ToString();
                txtboxNomCommercial.Text = dgwListeMedicament.CurrentRow.Cells[2].Value.ToString();
                txtQuantiteOffre.Text = dgwListeMedicament.CurrentRow.Cells[3].Value.ToString();
                comboBoxIdMedicament.Enabled = false;
                comboBoxIdOffreRapport.Enabled = false;

                btnValiderModif.Visible = true;
                AfficherBox();
            }
            else
            {
                MessageBox.Show("Sélectionner un visiteur dans le tableau !");
            }
        }

        private void buttonSupprimerOffre_Click(object sender, EventArgs e)
        {
            int idRapport = int.Parse(dgwListeMedicament.CurrentRow.Cells[0].Value.ToString());
            int idMedicament = int.Parse(dgwListeMedicament.CurrentRow.Cells[1].Value.ToString());

            ClassePEchantillonOffert.SupprimerEchantillonOffert(idRapport, idMedicament);
            MessageBox.Show("L'offre du rapport " + idRapport + " qui avait le medicament " + idMedicament + " a bien été supprimé !");
            ChargerLeDGV();
        }

        private void btnValiderModif_Click(object sender, EventArgs e)
        {
            int idRapport = int.Parse(comboBoxIdOffreRapport.Text);
            int idMedicament = int.Parse(comboBoxIdMedicament.Text);
            int quantite = int.Parse(txtQuantiteOffre.Text);

            ClassePEchantillonOffert.ModifEchantillonOffert(idRapport, idMedicament, quantite);

            MessageBox.Show("L'offre du rapport " + idRapport + " qui avait le medicament " + idMedicament + " a bien été modifié !");
            btnValiderModif.Visible = false;
            comboBoxIdMedicament.Enabled = true;
            comboBoxIdOffreRapport.Enabled = true;

            ChargerLeDGV();
            Clear();
            CacherBox();
        }

        private void CacherBox()
        {
            grpboxNomCommercial.Visible = false;
            groupBoxMedicamentOffert.Visible = false;
            groupBoxQuantite.Visible = false;
            groupBoxRapportOffert.Visible = false;

            buttonAjouterOffre.Visible = true;
            buttonModifierOffre.Visible = true;
            buttonSupprimerOffre.Visible = true;
        }

        private void AfficherBox()
        {
            grpboxNomCommercial.Visible = true;
            groupBoxMedicamentOffert.Visible = true;
            groupBoxQuantite.Visible = true;
            groupBoxRapportOffert.Visible = true;

            buttonAjouterOffre.Visible = false;
            buttonModifierOffre.Visible = false;
            buttonSupprimerOffre.Visible = false;
        }

        private void Clear()
        {
            comboBoxIdMedicament.Text = "";
            comboBoxIdOffreRapport.Text = "";
            txtboxNomCommercial.Text = "";
            txtQuantiteOffre.Text = "";
        }

        private void buttonAjouterOffre_Click(object sender, EventArgs e)
        {
            AfficherBox();
            btnValiderAjout.Visible = true;
        }

        private void btnValiderAjout_Click(object sender, EventArgs e)
        {
            int idRapport = int.Parse(comboBoxIdOffreRapport.Text);
            int idMedicament = int.Parse(comboBoxIdMedicament.Text);
            int quantite = int.Parse(txtQuantiteOffre.Text);

            ClassePEchantillonOffert.AjoutEchantillonOffert(idRapport, idMedicament, quantite);
            MessageBox.Show("L'offre du rapport " + idRapport + " qui avait le medicament " + idMedicament + " a bien été ajouté !");
            btnValiderAjout.Visible = false;
            comboBoxIdMedicament.Enabled = true;
            comboBoxIdOffreRapport.Enabled = true;

            ChargerLeDGV();
            Clear();
            CacherBox();
        }
    }
}
