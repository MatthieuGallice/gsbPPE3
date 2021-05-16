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
        // variable global
        public Medecin modifier;
        string comboNonChoisi = "-----------------------------------------------------------------------------------------------";

        ClasseSpecialite instanSpe = new ClasseSpecialite();
        public Medecin()
        {
            InitializeComponent();
        }

        // fonction qui remplis le dgv medecin  
        public void dgvFormulaireMedecin()
        {
            // nettoye le dgv
            dgwMedecin.Rows.Clear();

            // initialise une liste avec la fonction chargerLesMedecin de classePMedecin
            List<ClasseMedecin> unMedecin = ClassePMedecin.chargerLesMedecins();
            // foreach qui remplis le dgv grâce à la liste 
            foreach (ClasseMedecin lesMedecin in unMedecin)
            {
                // variable 
                string lid = lesMedecin.Id.ToString();
                string leNom = lesMedecin.Nom;
                string lePrenom = lesMedecin.Prenom;
                string ladresse = lesMedecin.Adresse;
                string leTel = lesMedecin.Tel;
                string laSpe = lesMedecin.LaSpecialite.Specialite;
                string leDepartement = lesMedecin.Departement.ToString();

                // ajoute les éléments dans le dgv par ligne
                dgwMedecin.Rows.Add(lid, leNom, lePrenom, ladresse, leTel, laSpe, leDepartement);
            }
        }

        // fonction qui remplis le combobox des medecins
        public void remplirComboboxListeMedecin()
        {
            // initialisation d'une liste puis ajout grâce a la fonction chargerLesMedecin de classePMedecin
            List<ClasseMedecin> lesMed = new List<ClasseMedecin>();
            lesMed = ClassePMedecin.chargerLesMedecins();

            // nettoye les combobox puis ajout la variable global comboNonChoisi et la selectionne
            comboBoxListeMedecin.Items.Clear();
            comboBoxListeMedecin.Items.Add(comboNonChoisi);
            comboBoxListeMedecin.SelectedItem = comboNonChoisi;
            
            // foreach qui ajoute dans les combobox 
            foreach (ClasseMedecin med in lesMed)
            {
                string nom = med.Nom.ToString();
                string prenom = med.Prenom.ToString();
                string leMed = nom + " " + prenom;

                comboBoxListeMedecin.Items.Add(leMed);
                comboBoxRechercherNom.Items.Add(leMed);
            }
        }

        // fonction qui cache les groupebox et les button
        private void cacherText()
        {
            // cache la première ligne de groupebox 
            groupBoxNomMedecin.Visible = false;
            groupBoxPrenomMedecin.Visible = false;
            groupBoxTelMedecin.Visible = false;

            // cache la deuxième ligne de groupebox 
            groupBoxRechercherNom.Visible = false;
            groupBoxRechercherSpe.Visible = false;
            groupBoxRechercherDepartement.Visible = false;

            // cache la troisième ligne de groupebox 
            groupBoxAdresseMedecin.Visible = false;
            groupBoxDepartementMedecin.Visible = false;
            groupBoxSpecialiteMedecin.Visible = false;

            // cache la ligne de button pour valider
            buttonValiderRecherche.Visible = false;
            buttonValiderModif.Visible = false;
            buttonValiderAjouterMedecin.Visible = false;
        }

        // fonction qui nettoye les textbox et sélectionne la variable comboNonChoisi pour la combobox spécialité
        private void nettoyer()
        {
            txtNomMedecin.Clear();
            txtPrenomMedecin.Clear();
            txtTelMedecin.Clear();
            txtAdresseMedecin.Clear();
            txtDepartementMedecin.Clear();
            comboBoxSpecialite.SelectedItem = comboNonChoisi;
        }

        // fonction qui nettoye, ajouter et selectionne la variable comboNonChoisi dans les combobox
        private void comboboxNull()
        {
            comboBoxRechercherNom.Items.Clear();
            comboBoxRechercherNom.Items.Add(comboNonChoisi);
            comboBoxRechercherNom.SelectedItem = comboNonChoisi;

            comboBoxRechercherSpe.Items.Clear();
            comboBoxRechercherSpe.Items.Add(comboNonChoisi);
            comboBoxRechercherSpe.SelectedItem = comboNonChoisi;
        }

        // fonction qui s'execute au chargement de la page
        private void Medecin_Load(object sender, EventArgs e)
        {
            // appelle de la fonction qui remplis les formulaire
            dgvFormulaireMedecin();

            // appelle de la fonction qui nettoye les combobox
            comboboxNull();

            // mise en place de la combobox des spécialité
            // initialisation d'une liste est la remplir avec les spécialité
            List<ClasseSpecialite> lesSpe = new List<ClasseSpecialite>();
            lesSpe = ClassePSpecialite.chargerLesSpecialite();

            // nettoye, ajoute et sélectionne la variable comboNonChoisi dans le combobox spécialité 
            comboBoxSpecialite.Items.Clear();
            comboBoxSpecialite.Items.Add(comboNonChoisi);
            comboBoxSpecialite.SelectedItem = comboNonChoisi;

            // foreach qui remplis le combobox spécialité 
            foreach (ClasseSpecialite spe in lesSpe)
            {
                comboBoxSpecialite.Items.Add(spe.Specialite.ToString());
                comboBoxRechercherSpe.Items.Add(spe.Specialite.ToString());
            }

            // appelle la fonction qui cache les groupebox et button
            cacherText();

            // appelle la fonction qui rtemplis le combobox des medecin pour le deuxièem dgv
            remplirComboboxListeMedecin();
        }

        // fonction qui s'active au clique du button modifier 
        private void buttonModifierMedecin_Click(object sender, EventArgs e)
        {
            if (dgwMedecin.RowCount != 1)
            {
                // condition qui pour être remplis dans sélectionné une ligne dans le dgv
                if (dgwMedecin.CurrentRow.Selected)
                {
                    // nettoye et cache les textbox et combobox
                    nettoyer();
                    cacherText();

                    // rend les groupbox et le button validerModif visible
                    groupBoxNomMedecin.Visible = true;
                    groupBoxPrenomMedecin.Visible = true;
                    groupBoxTelMedecin.Visible = true;
                    groupBoxAdresseMedecin.Visible = true;
                    groupBoxDepartementMedecin.Visible = true;
                    groupBoxSpecialiteMedecin.Visible = true;

                    buttonValiderModif.Visible = true;

                    // instanciation de la spécialité
                    string laSpe = dgwMedecin.CurrentRow.Cells[5].Value.ToString();
                    List<ClasseSpecialite> lesSpe = ClassePSpecialite.chargerLesSpecialite();

                    foreach (ClasseSpecialite specia in lesSpe)
                    {
                        if (specia.Specialite.ToString() == laSpe)
                        {
                            // fonction qui récupérer l'id de spécialité grâce au nom de la spécialité
                            int idSpe = ClassePMedecin.recupererIdSpe(laSpe);

                            instanSpe = new ClasseSpecialite(idSpe, specia.ToString());
                        }
                    }

                    // instanciation du medecin 
                    ClasseMedecin modifier = new ClasseMedecin(int.Parse(dgwMedecin.CurrentRow.Cells[0].Value.ToString()), dgwMedecin.CurrentRow.Cells[1].Value.ToString(), dgwMedecin.CurrentRow.Cells[2].Value.ToString(), dgwMedecin.CurrentRow.Cells[3].Value.ToString(), dgwMedecin.CurrentRow.Cells[4].Value.ToString(), int.Parse(dgwMedecin.CurrentRow.Cells[6].Value.ToString()), instanSpe);

                    // placement dans les textbox et sélection dans le combobox
                    txtId.Text = modifier.Id.ToString();
                    txtNomMedecin.Text = modifier.Nom;
                    txtPrenomMedecin.Text = modifier.Prenom;
                    txtTelMedecin.Text = modifier.Tel;
                    txtAdresseMedecin.Text = modifier.Adresse;
                    txtDepartementMedecin.Text = modifier.Departement.ToString();
                    comboBoxSpecialite.SelectedItem = laSpe;

                }
                // condition si pas de ligne sélectionner
                else
                {
                    MessageBox.Show("Sélectionner un médecin dans le tableau !");
                }
            }
        }

        // fonction qui s'active au clique du button validerModifier 
        private void buttonValiderModif_Click(object sender, EventArgs e)
        {
            // variable qui récupére le numéro de téléphone dans le textbox puis qui vérifie sa validité
            string tel = txtTelMedecin.Text;
            bool leTelValide = ClasseMedecin.telValide(tel);

            // variable qui récupére le département dans le textbox puis qui vérifie sa validité
            string departement = txtDepartementMedecin.Text;
            bool ledepartementValide = ClasseMedecin.departementValide(departement);


            // condition qui vérifie si un des textbox est vide
            if (txtNomMedecin.Text == "" || txtPrenomMedecin.Text == "" || txtTelMedecin.Text == "" 
                || txtAdresseMedecin.Text == "" || txtDepartementMedecin.Text == "")
            {
                MessageBox.Show("une ou plusieurs case ne sont pas remplis ! ");
            }
            // condition qui vérifie la validité du numéro de téléphone
            else if (leTelValide == false)
            {
                MessageBox.Show("le numéro de téléphone n'est pas un numéro valide (dix chiffre) ! ");
            }
            // condition qui vérifie la validité du département
            else if (ledepartementValide == false)
            {
                MessageBox.Show("le numéro de département n'est pas valide (deux chiffre) ! ");
            }
            // condition qui vérifie le combobox spécialité
            else if (comboBoxSpecialite.Text == comboNonChoisi)
            {
                MessageBox.Show("il faut choisir une spécialité ! ");
            }
            // condition qui réalise la modification 
            else
            {
                // variable qui récupére la spécialité dans la combobox 
                string laSpe = comboBoxSpecialite.Text;

                // fonction qui récupére l'id de la spécialité
                int idSpe = ClassePMedecin.recupererIdSpe(laSpe);

                // initialisation de la spécialité
                instanSpe = new ClasseSpecialite(idSpe, laSpe.ToString());

                // variable qui récupére les données pour la modification 
                int lid = int.Parse(txtId.Text);
                string leNom = txtNomMedecin.Text;
                string lePrenom = txtPrenomMedecin.Text;
                string ladresse = txtAdresseMedecin.Text;
                string leTel = txtTelMedecin.Text;
                int leDepartement = int.Parse(txtDepartementMedecin.Text);

                // met à jour le medecin avec la fonction modifierMedecin
                ClassePMedecin.modifierMedecin(lid, leNom, lePrenom, ladresse, leTel, idSpe, leDepartement);

                // appelle de la fonction qui remplis le dgv et qui remplis les combobox
                dgvFormulaireMedecin();
                remplirComboboxListeMedecin();

                // appelle de la fonction qui nettoye les textbox et combobox puis les cache
                nettoyer();
                cacherText();
            }
        }

        // fonction qui s'active au clique du button supprimer 
        private void buttonSupprimerMedecin_Click(object sender, EventArgs e)
        {
            if (dgwMedecin.RowCount != 1)
            {
                // variable qui récupére les données dans les cellules du dgv 
                string leNom = dgwMedecin.CurrentRow.Cells[1].Value.ToString();
                string lePrenom = dgwMedecin.CurrentRow.Cells[2].Value.ToString();
                int idMedecin = int.Parse(dgwMedecin.CurrentRow.Cells[0].Value.ToString());

                // condition qui active un messageBox et si valider alors suppression du médecin
                if (MessageBox.Show("êtes vous sur de vouloir supprimer " + leNom + " " + lePrenom + " ?", "advertissement ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    // fonction qui supprime le medecin
                    ClassePMedecin.SupprimerMedecin(idMedecin);

                    dgvFormulaireMedecin();
                    remplirComboboxListeMedecin();
                    cacherText();
                    nettoyer();
                }
            }    
        }

        // fonction qui s'active au clique du button ajouter  
        private void buttonAjouterMedecin_Click(object sender, EventArgs e)
        {
            // nettoye et cache les textbox et combobox
            nettoyer();
            cacherText();

            // rend visible les groupbox et le button validerAjouter
            groupBoxNomMedecin.Visible = true;
            groupBoxPrenomMedecin.Visible = true;
            groupBoxTelMedecin.Visible = true;
            groupBoxAdresseMedecin.Visible = true;
            groupBoxDepartementMedecin.Visible = true;
            groupBoxSpecialiteMedecin.Visible = true;

            buttonValiderAjouterMedecin.Visible = true;
        }
        
        // fonction qui s'active au clique du button validerAjout 
        private void buttonValiderAjouterMedecin_Click(object sender, EventArgs e)
        {
            // variable qui récupére le numéro de téléphone dans le textbox puis qui vérifie sa validité
            string tel = txtTelMedecin.Text;
            bool leTelValide = ClasseMedecin.telValide(tel);

            // variable qui récupére le département dans le textbox puis qui vérifie sa validité
            string departement = txtDepartementMedecin.Text;
            bool ledepartementValide = ClasseMedecin.departementValide(departement);

            // condition qui vérifie si un des textbox est vide
            if (txtNomMedecin.Text == "" || txtPrenomMedecin.Text == "" || txtTelMedecin.Text == ""
               || txtAdresseMedecin.Text == "" || txtDepartementMedecin.Text == "")
            {
                MessageBox.Show("une ou plusieurs case ne sont pas remplis ! ");
            }
            // condition qui vérifie la validité du numéro de téléphone
            else if (leTelValide == false)
            {
                MessageBox.Show("le numéro de téléphone n'est pas un numéro valide (dix chiffre) ! ");
            }
            // condition qui vérifie la validité du département
            else if (ledepartementValide == false)
            {
                MessageBox.Show("le numéro de département n'est pas valide (deux chiffre) ! ");
            }
            // condition qui vérifie le combobox spécialité
            else if (comboBoxSpecialite.Text == comboNonChoisi)
            {
                MessageBox.Show("il faut choisir une spécialité ! ");
            }
            // condition qui ajoute le medecin
            else
            {
                // variable qui récupére la spécialité
                string laSpe = comboBoxSpecialite.Text;

                // fonction qui récupére l'id de la spécialité
                int idSpe = ClassePMedecin.recupererIdSpe(laSpe);

                // initialisation de la spécialité
                instanSpe = new ClasseSpecialite(idSpe, laSpe.ToString());

                // variable qui récupére les données pour l'ajout
                string leNom = txtNomMedecin.Text;
                string lePrenom = txtPrenomMedecin.Text;
                string ladresse = txtAdresseMedecin.Text;
                string leTel = txtTelMedecin.Text;
                int leDepartement = int.Parse(txtDepartementMedecin.Text);

                // ajoute le medecin avec la fonction ajouterMedecin
                ClassePMedecin.ajouterMedecin(leNom, lePrenom, ladresse, leTel, idSpe, leDepartement);
               
                // appelle de la fonction qui remplis le dgv et qui remplis les combobox
                dgvFormulaireMedecin();
                remplirComboboxListeMedecin();

                // appelle de la fonction qui nettoye les textbox et combobox puis les cache 
                nettoyer();
                cacherText();
            }
        }

        // fonction qui remplis le deuxième dgv en fonction du combobox des medecin
        private void comboBoxListeMedecin_TextChanged(object sender, EventArgs e)
        {
            int idRap;
            int idVis;
            string nomVis;
            string prenomVis;
            DateTime dateRap;
            string motifRap;
            string bilanRap;

            // condition qui nettoye le dgv si comboNonChoisi sélectionné dans combobox 
            if (comboBoxListeMedecin.Text == comboNonChoisi)
            {
                dgwDernierRapport.Rows.Clear();
            }
            // condition qui ajoute le medecin choisi dans le dgv
            else
            {
                dgwDernierRapport.Rows.Clear();

                // récupération du nom et du prénom du médecin avec un split qui prend la séparation sur l'espace
                string nom = comboBoxListeMedecin.Text;
                string[] leNom = nom.Split(' ');
                string leNomMed = leNom[0];
                string lePrenomMed = leNom[1];

                // fonction qui récupére l'id du médecin en fonction de sont nom et prénom
                int idMedecin = ClassePMedecin.recupererIdMedecin(leNomMed, lePrenomMed);

                // initialisation d'une liste avec la fonction qui récupére le médecin en fonction de l'id
                List<ClasseMedecin> leMed = ClassePMedecin.ChargerLesRapportMedecin(idMedecin);
                // foreach qui remplis le dgv
                foreach (ClasseMedecin lesRap in leMed)
                {
                    idRap = lesRap.IdRap;
                    idVis = lesRap.IdVis;
                    nomVis = lesRap.NomVis;
                    prenomVis = lesRap.PrenomVis;
                    dateRap = lesRap.DateRap;
                    motifRap = lesRap.MotifRap;
                    bilanRap = lesRap.BilanRap;

                    dgwDernierRapport.Rows.Add(idRap, idVis, nomVis, prenomVis, dateRap, motifRap, bilanRap); 
                }
            }
        }

        // fonction qui affiche les groupbox de recherche et le button validerRecherche au clique du button rechercher
        private void buttonRechercherMedecin_Click(object sender, EventArgs e)
        {
            dgvFormulaireMedecin();
            cacherText();
            nettoyer();
            groupBoxRechercherNom.Visible = true;
            groupBoxRechercherSpe.Visible = true;
            groupBoxRechercherDepartement.Visible = true;


            comboBoxRechercherNom.SelectedItem = comboNonChoisi;
            comboBoxRechercherSpe.SelectedItem = comboNonChoisi;

            buttonValiderRecherche.Visible = true;

        }

        // fonction qui vérifie les groupbox et le textbox de recherche au clique de validerRecherche
        private void buttonValiderRecherche_Click(object sender, EventArgs e)
        {
            // nettoye le dgv
            dgwMedecin.Rows.Clear();

            // variable qui récupére le contenu des combobox et du textbox de recherche  
            string leNomMedecin = comboBoxRechercherNom.Text;
            string laSpeMedecin = comboBoxRechercherSpe.Text;
            string leDepartementMedecin = textBoxRechercherDepartement.Text;

            string leNomMed;
            string lePrenomMed;

            // récupération du nom et du prénom du médecin avec un split qui prend la séparation sur l'espace
            if (leNomMedecin == comboNonChoisi)
            {
                leNomMed = "";
                lePrenomMed = "";
            }
            else
            {
                string[] leNom = leNomMedecin.Split(' ');
                leNomMed = leNom[0];
                lePrenomMed = leNom[1];
            }

            if (leDepartementMedecin != "")
            {
                // variable qui vérifie la validité du département
                bool ledepartementValide = ClasseMedecin.departementValide(leDepartementMedecin);

                // condition qui vérifie la validité du département
                if (ledepartementValide == false)
                {
                    MessageBox.Show("le numéro de département n'est pas valide (deux chiffre) ! ");
                }
            }

            // condition qui vérifie qu'au moins un des élément et sélectionné
            if (leNomMedecin != comboNonChoisi || laSpeMedecin != comboNonChoisi || leDepartementMedecin != "")
            {
                // initialisation d'une liste avec la fonction rechercherNomMedecin de classePMedecin 
                List<ClasseMedecin> leMed = ClassePMedecin.rechercherMedecin(leNomMed, lePrenomMed, laSpeMedecin, leDepartementMedecin);
                // foreach qui remplis le dgv avec la liste leMed
                foreach (ClasseMedecin lesMed in leMed)
                {
                    string lid = lesMed.Id.ToString();
                    string leNomMede = lesMed.Nom;
                    string lePrenomMede = lesMed.Prenom;
                    string ladresse = lesMed.Adresse;
                    string leTel = lesMed.Tel;
                    string laSpe = lesMed.LaSpecialite.Specialite;
                    string leDepartement = lesMed.Departement.ToString();

                    dgwMedecin.Rows.Add(lid, leNomMede, lePrenomMede, ladresse, leTel, laSpe, leDepartement);
                }
            }
            // condition qui s'active si aucun des groupbox et le textbox ne sont sélectionné 
            else
            {
                dgvFormulaireMedecin();
                MessageBox.Show("il faut choisir au moins un élément de recherche !");
            }
        }

        // fonction qui nettoie le dgv est cache les groupbox et les button au clique de reinitialiser
        private void buttonReinitialisermedecin_Click(object sender, EventArgs e)
        {
            nettoyer();
            cacherText();

            dgvFormulaireMedecin();
        }
    }
}
