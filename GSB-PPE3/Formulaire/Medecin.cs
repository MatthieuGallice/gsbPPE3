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
    public partial class Medecin : Form
    {
        public Medecin modifier;
        string comboNonChoisi = "-----------------------------------------------------------------------------------------------";

        ClasseSpecialite instanSpe = new ClasseSpecialite();
        public Medecin()
        {
            InitializeComponent();
        }

        // FONCTION QUI REMPLIS LE DGW 
        public void dgvFormulaireMedecin()
        {
            dgwMedecin.Rows.Clear();

            List<ClasseMedecin> unMedecin = ClassePMedecin.chargerLesMedecins();
            foreach (ClasseMedecin lesMedecin in unMedecin)
            {
                string leNom = lesMedecin.Nom;
                string lePrenom = lesMedecin.Prenom;
                string ladresse = lesMedecin.Adresse;
                string leTel = lesMedecin.Tel;
                string laSpe = lesMedecin.LaSpecialite.Specialite;
                string leDepartement = lesMedecin.Departement.ToString();

                dgwMedecin.Rows.Add(leNom, lePrenom, ladresse, leTel, laSpe, leDepartement);
            }
        }

        // FONCTION QUI REMPLIS LA COMBOBOX DES MEDECINS
        public void remplirComboboxListeMedecin()
        {
            List<ClasseMedecin> lesMed = new List<ClasseMedecin>();
            lesMed = ClassePMedecin.chargerLesMedecins();

            comboBoxListeMedecin.Items.Clear();
            comboBoxListeMedecin.Items.Add(comboNonChoisi);
            comboBoxListeMedecin.SelectedItem = comboNonChoisi;

            foreach (ClasseMedecin med in lesMed)
            {
                string nom = med.Nom.ToString();
                string prenom = med.Prenom.ToString();
                string leMed = nom + " " + prenom;

                comboBoxListeMedecin.Items.Add(leMed);
            }
        }

        // AU CHARGEMENT DE LA PAGE
        private void Medecin_Load(object sender, EventArgs e)
        {
            //AFFICHAGE DATAGRIDVIEW
            dgvFormulaireMedecin();

            // AFFICHAGE SPECIALITE COMBOBOX
            List<ClasseSpecialite> lesSpe = new List<ClasseSpecialite>();
            lesSpe = ClassePSpecialite.chargerLesSpecialite();

            comboBoxSpecialite.Items.Clear();
            comboBoxSpecialite.Items.Add(comboNonChoisi);
            comboBoxSpecialite.SelectedItem = comboNonChoisi;

            foreach (ClasseSpecialite spe in lesSpe)
            {
                comboBoxSpecialite.Items.Add(spe.Specialite.ToString());
            }

            // AFFICHAGE NOM PRENOM MEDECIN POUR COMBOBOX DEUXIEME DGV
            remplirComboboxListeMedecin();
        }

        // BOUTON MODIFIER
        private void buttonModifierMedecin_Click(object sender, EventArgs e)
        {
            if (dgwMedecin.CurrentRow.Selected)
            {
                // VARIABLE POUR LA REQUETE SQL 
                string leNom = dgwMedecin.CurrentRow.Cells[0].Value.ToString();
                string lePrenom = dgwMedecin.CurrentRow.Cells[1].Value.ToString();

                //CONNEXION BDD
                MySqlConnection connexion = new MySqlConnection();
                connexion.ConnectionString = ClassePConnexion.DBConnection();

                connexion.Open();

                //REQUETE SQL
                int idMedecin = ClassePMedecin.recupererIdMedecin(leNom, lePrenom);

                // INSTANCIATION DE LA SPECIALITE
                string laSpe = dgwMedecin.CurrentRow.Cells[4].Value.ToString();
                List<ClasseSpecialite> lesSpe = ClassePSpecialite.chargerLesSpecialite();

                foreach (ClasseSpecialite specia in lesSpe)
                {
                    if (specia.Specialite.ToString() == laSpe)
                    {
                        // REQUETE QUI RECUPERE L'ID GRACE AU NOM DE LA SPECIALITE
                        int idSpe = ClassePMedecin.recupererIdSpe(laSpe);

                        instanSpe = new ClasseSpecialite(idSpe, specia.ToString());
                    }
                }

                // INSTANCIATION
                ClasseMedecin modifier = new ClasseMedecin(idMedecin, dgwMedecin.CurrentRow.Cells[0].Value.ToString(), dgwMedecin.CurrentRow.Cells[1].Value.ToString(), dgwMedecin.CurrentRow.Cells[2].Value.ToString(), dgwMedecin.CurrentRow.Cells[3].Value.ToString(), int.Parse(dgwMedecin.CurrentRow.Cells[5].Value.ToString()), instanSpe);

                // PLACEMENT DANS LES TEXTBOX ET SELECTION DANS LE COMBOBOX
                txtNomMedecin.Text = modifier.Nom;
                txtPrenomMedecin.Text = modifier.Prenom;
                txtTelMedecin.Text = modifier.Tel;
                txtAdresseMedecin.Text = modifier.Adresse;
                txtDepartementMedecin.Text = modifier.Departement.ToString();
                comboBoxSpecialite.SelectedItem = laSpe;

                connexion.Close();
            }
            else
            {
                MessageBox.Show("Sélectionner un médecin dans le tableau !");
            }

        }

        //BOUTON VALIDER MOFIFICATION
        private void buttonValiderModif_Click(object sender, EventArgs e)
        {
            //CONNEXION BDD
            MySqlConnection connexion = new MySqlConnection();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            string tel = txtTelMedecin.Text;
            bool leTelValide = ClasseMedecin.telValide(tel);

            string departement = txtDepartementMedecin.Text;
            bool ledepartementValide = ClasseMedecin.departementValide(departement);

            if (txtNomMedecin.Text == "" || txtPrenomMedecin.Text == "" || txtTelMedecin.Text == "" 
                || txtAdresseMedecin.Text == "" || txtDepartementMedecin.Text == "")
            {
                MessageBox.Show("une ou plusieurs case ne sont pas remplis ! ");
            }
            else if (leTelValide == false)
            {
                MessageBox.Show("le numéro de téléphone n'est pas un numéro valide (dix chiffre) ! ");
            }
            else if (ledepartementValide == false)
            {
                MessageBox.Show("le numéro de département n'est pas valide (deux chiffre) ! ");
            }
            else if (comboBoxSpecialite.Text == comboNonChoisi)
            {
                MessageBox.Show("il faut choisir une spécialité ! ");
            }
            else
            {
                // VARIABLE POUR LA REQUETE SQL 
                string leNom = txtNomMedecin.Text;
                string lePrenom = txtPrenomMedecin.Text;
                string laSpe = comboBoxSpecialite.Text;

                // REQUETE SQL ID MEDECIN
                int idMedecin = ClassePMedecin.recupererIdMedecin(leNom, lePrenom);

                // REQUETE SQL ID SPECIALITE
                int idSpe = ClassePMedecin.recupererIdSpe(laSpe);

                instanSpe = new ClasseSpecialite(idSpe, laSpe.ToString());

                // MISE A JOUR 
                string ladresse = txtAdresseMedecin.Text;
                string leTel = txtTelMedecin.Text;
                int leDepartement = int.Parse(txtDepartementMedecin.Text);

                ClassePMedecin.modifierMedecin(idMedecin, leNom, lePrenom, ladresse, leTel, idSpe, leDepartement);

                dgvFormulaireMedecin();
                remplirComboboxListeMedecin();

                connexion.Close();

                txtNomMedecin.Clear();
                txtPrenomMedecin.Clear();
                txtTelMedecin.Clear();
                txtAdresseMedecin.Clear();
                txtDepartementMedecin.Clear();
                comboBoxSpecialite.SelectedItem = comboNonChoisi;
            }

        }

        // BOUTON SUPPRIMER
        private void buttonSupprimerMedecin_Click(object sender, EventArgs e)
        {
            // VARIABLE POUR LA REQUETE SQL 
            string leNom = dgwMedecin.CurrentRow.Cells[0].Value.ToString();
            string lePrenom = dgwMedecin.CurrentRow.Cells[1].Value.ToString();

            //CONNEXION BDD
            MySqlConnection connexion = new MySqlConnection();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            // REQUETE SQL ID MEDECIN
            int idMedecin = ClassePMedecin.recupererIdMedecin(leNom, lePrenom);

            if (MessageBox.Show("êtes vous sur de vouloir supprimer " + leNom + " " + lePrenom + " ?", "advertissement ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ClassePMedecin.SupprimerMedecin(idMedecin);

                dgvFormulaireMedecin();
                remplirComboboxListeMedecin();
            }
            connexion.Close();
        }

        // BOUTON AJOUTER 
        private void buttonAjouterMedecin_Click(object sender, EventArgs e)
        {
            //CONNEXION BDD
            MySqlConnection connexion = new MySqlConnection();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            string tel = txtTelMedecin.Text;
            bool leTelValide = ClasseMedecin.telValide(tel);

            string departement = txtDepartementMedecin.Text;
            bool ledepartementValide = ClasseMedecin.departementValide(departement);

            if (txtNomMedecin.Text == "" || txtPrenomMedecin.Text == "" || txtTelMedecin.Text == ""
               || txtAdresseMedecin.Text == "" || txtDepartementMedecin.Text == "")
            {
                MessageBox.Show("une ou plusieurs case ne sont pas remplis ! ");
            }
            else if (leTelValide == false)
            {
                MessageBox.Show("le numéro de téléphone n'est pas un numéro valide (dix chiffre) ! ");
            }
            else if (ledepartementValide == false)
            {
                MessageBox.Show("le numéro de département n'est pas valide (deux chiffre) ! ");
            }
            else if (comboBoxSpecialite.Text == comboNonChoisi)
            {
                MessageBox.Show("il faut choisir une spécialité ! ");
            }
            else
            {
                string laSpe = comboBoxSpecialite.Text;

                // REQUETE SQL ID SPECIALITE
                int idSpe = ClassePMedecin.recupererIdSpe(laSpe);

                instanSpe = new ClasseSpecialite(idSpe, laSpe.ToString());

                // AJOUT
                string leNom = txtNomMedecin.Text;
                string lePrenom = txtPrenomMedecin.Text;
                string ladresse = txtAdresseMedecin.Text;
                string leTel = txtTelMedecin.Text;
                int leDepartement = int.Parse(txtDepartementMedecin.Text);

                ClassePMedecin.AjouterMedecin(leNom, lePrenom, ladresse, leTel, idSpe, leDepartement);

                dgvFormulaireMedecin();
                remplirComboboxListeMedecin();

                connexion.Close();

                txtNomMedecin.Clear();
                txtPrenomMedecin.Clear();
                txtTelMedecin.Clear();
                txtAdresseMedecin.Clear();
                txtDepartementMedecin.Clear();
                comboBoxSpecialite.SelectedItem = comboNonChoisi;
            }
        }

        // COMBOBOX ET DGW D'UN MEDECIN
        private void comboBoxListeMedecin_SelectedValueChanged(object sender, EventArgs e)
        {
            int idRap;
            int idVis;
            string nomVis;
            string prenomVis;
            DateTime dateRap;
            string motifRap;
            string bilanRap;

            if (comboBoxListeMedecin.ToString() == comboNonChoisi)
            {
                dgwDernierRapport.Rows.Clear();
            }
            else
            {
                dgwDernierRapport.Rows.Clear();

                string nom = comboBoxListeMedecin.ToString();
                string[] leNom = nom.Split(' ');
                string leNomMed = leNom[0];
                string lePrenomMed = leNom[1];

                //CONNEXION BDD
                MySqlConnection connexion = new MySqlConnection();
                connexion.ConnectionString = ClassePConnexion.DBConnection();

                connexion.Open();

                // REQUETE SQL ID MEDECIN
                int idMedecin = ClassePMedecin.recupererIdMedecin(leNomMed, lePrenomMed);

                List<ClasseMedecin> leMed = ClassePMedecin.ChargerLesRapportMedecin(idMedecin);
                foreach (ClasseMedecin lesRap in leMed)
                {
                    idRap = lesRap.IdRap;
                    idVis = lesRap.IdVis;
                    nomVis = lesRap.NomVis;
                    prenomVis = lesRap.PrenomVis;
                    dateRap = lesRap.DateRap;
                    motifRap = lesRap.MotifRap;
                    bilanRap = lesRap.BilanRap;

                    dgwDernierRapport.Rows.Add(idRap, idVis, nomVis, prenomMed, dateRap, motifRap, bilanRap); ;
                }
            }
        }
    }
}
