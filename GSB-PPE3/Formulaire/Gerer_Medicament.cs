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
using MySql.Data.MySqlClient;

namespace Formulaire
{
    public partial class Gerer_Medicament : Form
    {
        public Gerer_Medicament modifier;
        string comboNonChoisi = "-----------------------------------------------------------------------------------------------";

        public Gerer_Medicament()
        {
            InitializeComponent();
        }

        // FONCTION QUI REMPLIS LE DGW 
        public void dgvFormulaireGererMedicament()
        {
            dgwGererMedicament.Rows.Clear();

            List<ClasseMedicament> lesMedicaments = ClassePMedicament.chargerLesMedicaments();
            foreach (ClasseMedicament unMedicament in lesMedicaments)
            {
                int leNb = unMedicament.Id;
                string leNom = unMedicament.NomCommercial;
                string laFamille = unMedicament.Famille.Libelle;
                string laComposition = unMedicament.Composition;
                string leffet = unMedicament.Effets;
                string lesIndications = unMedicament.Contreindictions;

                dgwGererMedicament.Rows.Add(leNb, leNom, laFamille, laComposition, leffet, lesIndications);
            }
        }

        // AU CHARGEMENT DE LA PAGE
        private void Gerer_Medicament_Load(object sender, EventArgs e)
        {
            dgvFormulaireGererMedicament();

            // AFFICHAGE FAMILLE COMBOBOX
            List<ClasseFamille> lesFamille = new List<ClasseFamille>();
            lesFamille = ClassePFamille.chargerLesFamilles();

            comboBoxFamilleMedicament.Items.Clear();
            comboBoxFamilleMedicament.Items.Add(comboNonChoisi);
            comboBoxFamilleMedicament.SelectedItem = comboNonChoisi;

            foreach (ClasseFamille famille in lesFamille)
            {
                comboBoxFamilleMedicament.Items.Add(famille.Libelle.ToString());
            }
        }

        // BOUTON MODIFIER
        private void buttonModifierMedicament_Click(object sender, EventArgs e)
        {
            if (dgwGererMedicament.CurrentRow.Selected)
            {
                // VARIABLE POUR LA REQUETE SQL 
                string laFamille = dgwGererMedicament.CurrentRow.Cells[2].Value.ToString(); ;

                //CONNEXION BDD
                MySqlConnection connexion = new MySqlConnection();
                connexion.ConnectionString = ClassePConnexion.DBConnection();

                connexion.Open();

                //REQUETE SQL
                int idFamille = ClassePMedicament.recupererIdFamille(laFamille);

                // INSTANCIATION DE LA FAMILLE
                ClasseFamille instanFam = new ClasseFamille(idFamille, laFamille.ToString());
                 
                // INSTANCIATION
                ClasseMedicament modifier = new ClasseMedicament(int.Parse(dgwGererMedicament.CurrentRow.Cells[0].Value.ToString()), dgwGererMedicament.CurrentRow.Cells[1].Value.ToString(), dgwGererMedicament.CurrentRow.Cells[3].Value.ToString(), dgwGererMedicament.CurrentRow.Cells[4].Value.ToString(), dgwGererMedicament.CurrentRow.Cells[5].Value.ToString(), instanFam);

                // PLACEMENT DANS LES TEXTBOX ET SELECTION DANS LE COMBOBOX
                txtNomMedicament.Text = modifier.NomCommercial;
                txtCompositionMedicament.Text = modifier.Composition;
                txtEffetMedicament.Text = modifier.Effets;
                txtContreIndicationMedicament.Text = modifier.Contreindictions;
                comboBoxFamilleMedicament.SelectedItem = laFamille;

                connexion.Close();
            }
            else
            {
                MessageBox.Show("Sélectionner un médicament dans le tableau !");
            }

        }

        //BOUTON VALIDER MOFIFICATION
        private void buttonValiderModification_Click(object sender, EventArgs e)
        {
            //CONNEXION BDD
            MySqlConnection connexion = new MySqlConnection();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            if (txtNomMedicament.Text == "" || txtCompositionMedicament.Text == "" || txtEffetMedicament.Text == ""
                || txtContreIndicationMedicament.Text == "")
            {
                MessageBox.Show("une ou plusieurs case ne sont pas remplis ! ");
            }
            else if (comboBoxFamilleMedicament.Text == comboNonChoisi)
            {
                MessageBox.Show("il faut choisir une famille de médicament ! ");
            }
            else
            {
                // VARIABLE POUR LA REQUETE SQL 
                string leNom = txtNomMedicament.Text;
                string laFamille = comboBoxFamilleMedicament.Text;

                // REQUETE SQL
                int idMedi = ClassePMedicament.recupererIdMedicament(leNom);
                int idFamille = ClassePMedicament.recupererIdFamille(laFamille);

                // MISE A JOUR 
                string laComposition = txtCompositionMedicament.Text;
                string leffet = txtEffetMedicament.Text;
                string contreIndication = txtContreIndicationMedicament.Text;

                ClassePMedicament.ModifMedicament(idMedi, leNom, laComposition, leffet, contreIndication, idFamille);

                dgvFormulaireGererMedicament();

                connexion.Close();

                txtNomMedicament.Clear();
                txtCompositionMedicament.Clear();
                txtEffetMedicament.Clear();
                txtContreIndicationMedicament.Clear();
                comboBoxFamilleMedicament.SelectedItem = comboNonChoisi;
            }
        }

        // BOUTON SUPPRIMER
        private void buttonSupprimerMedicament_Click(object sender, EventArgs e)
        {
            // VARIABLE
            int lid = int.Parse(dgwGererMedicament.CurrentRow.Cells[0].Value.ToString());
            string leNom = dgwGererMedicament.CurrentRow.Cells[1].Value.ToString();

            if (MessageBox.Show("êtes vous sur de vouloir supprimer le médicament : " + leNom + " ?", "advertissement ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ClassePMedicament.SupprimerMedicament(lid);

                dgvFormulaireGererMedicament();
            }
            
        }

        // BOUTON AJOUTER 
        private void buttonAjouterMedicament_Click(object sender, EventArgs e)
        {
            //CONNEXION BDD
            MySqlConnection connexion = new MySqlConnection();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            if (txtNomMedicament.Text == "" || txtCompositionMedicament.Text == "" || txtEffetMedicament.Text == ""
                || txtContreIndicationMedicament.Text == "")
            {
                MessageBox.Show("une ou plusieurs case ne sont pas remplis ! ");
            }
            else if (comboBoxFamilleMedicament.Text == comboNonChoisi)
            {
                MessageBox.Show("il faut choisir une famille de médicament ! ");
            }
            else
            {
                string laFamille = comboBoxFamilleMedicament.Text;

                // REQUETE QUI RECUPERE L'ID GRACE AU NOM DE LA FAMILLE
                int idFamille = ClassePMedicament.recupererIdFamille(laFamille);

                // AJOUT
                string leNom = txtNomMedicament.Text;
                string laComposition = txtCompositionMedicament.Text;
                string leffet = txtEffetMedicament.Text;
                string contreIndication = txtContreIndicationMedicament.Text;

                ClassePMedicament.AjoutMedicament(leNom, laComposition, leffet, contreIndication, idFamille);

                dgvFormulaireGererMedicament();

                connexion.Close();

                txtNomMedicament.Clear();
                txtCompositionMedicament.Clear();
                txtEffetMedicament.Clear();
                txtContreIndicationMedicament.Clear();
                comboBoxFamilleMedicament.SelectedItem = comboNonChoisi;
            }
        }
    }
}
