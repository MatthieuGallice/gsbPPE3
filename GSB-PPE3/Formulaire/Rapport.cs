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
    public partial class Rapport : Form
    {
        // variable global
        string comboNonChoisi = "-----------------------------------------------------------------------------------------------";

        public Rapport()
        {
            InitializeComponent();
        }

        // fonction qui remplis le dgv 
        private void chargerDgv()
        {
            // nettoye le dgv
            dgvRapport.Rows.Clear();

            // initialise une liste avec la fonction chargerLesMedecin de classePMedecin
            List<ClasseRapport> unRapport = ClassePRapport.chargerLesRapports();
            // foreach qui remplis le dgv grâce à la liste 
            foreach (ClasseRapport lesRapports in unRapport)
            {
                // variable 
                int leNb = lesRapports.Id;
                string nomVisiteur = lesRapports.LeVisiteur.Nom;
                string prenomVisiteur = lesRapports.LeVisiteur.Prenom;
                string laDate = lesRapports.Date.ToString();
                string leMotif = lesRapports.Motif;
                string leBilan = lesRapports.Bilan;
                string nomMedecin = lesRapports.LeMedecin.Nom;
                string prenomMedecin = lesRapports.LeMedecin.Prenom;

                // ajoute les éléments dans le dgv par ligne
                dgvRapport.Rows.Add(leNb, nomVisiteur, prenomVisiteur, laDate, leMotif, leBilan, nomMedecin, prenomMedecin);
            }
        }

        // fonction qui remplis les combobox
        public void remplirCombobox()
        {
            // initialisation d'une liste puis ajout grâce a la fonction chargerLesVisteur de classePVisiteur
            List<ClasseVisiteur> lesVisi = new List<ClasseVisiteur>();
            lesVisi = ClassePVisiteur.chargerLesVisiteurs();

            // initialisation d'une liste puis ajout grâce a la fonction chargerLesMedecin de classePMedecin
            List<ClasseMedecin> lesMed = new List<ClasseMedecin>();
            lesMed = ClassePMedecin.chargerLesMedecins();

            // initialisation d'une liste puis ajout grâce a la fonction chargerLesMotif de classePRapport
            string[] lesMotif = { "périodicité", "nouveautés ou actualisations", "Problèmes occasionnel" };

            // nettoye le combobox visiteur puis ajout la variable global comboNonChoisi et la selectionne
            comboBoxVisiteur.Items.Clear();
            comboBoxVisiteur.Items.Add(comboNonChoisi);
            comboBoxVisiteur.SelectedItem = comboNonChoisi;

            // nettoye le combobox medecin puis ajout la variable global comboNonChoisi et la selectionne
            comboBoxMed.Items.Clear();
            comboBoxMed.Items.Add(comboNonChoisi);
            comboBoxMed.SelectedItem = comboNonChoisi;

            // nettoye le combobox motif puis ajout la variable global comboNonChoisi et la selectionne
            comboBoxMotif.Items.Clear();
            comboBoxMotif.Items.Add(comboNonChoisi);
            comboBoxMotif.SelectedItem = comboNonChoisi;

            // foreach qui ajoute dans le combobox visiteur 
            foreach (ClasseVisiteur visiteur in lesVisi)
            {
                string nom = visiteur.Nom.ToString();
                string prenom = visiteur.Prenom.ToString();
                string leVis = nom + " " + prenom;

                comboBoxVisiteur.Items.Add(leVis);
            }

            // foreach qui ajoute dans le combobox medecin 
            foreach (ClasseMedecin medecin in lesMed)
            {
                string nom = medecin.Nom.ToString();
                string prenom = medecin.Prenom.ToString();
                string leVis = nom + " " + prenom;

                comboBoxMed.Items.Add(leVis);
            }

            // foreach qui ajoute dans le combobox motif 
            foreach (string motif in lesMotif)
            {
                comboBoxMotif.Items.Add(motif);
            }
        }
        
        // fonction qui cache les groupebox et les button
        private void cacherText()
        {
            // cache la première ligne de groupebox 
            groupBoxCode.Visible = false;
            groupBoxDate.Visible = false;

            // cache la deuxième ligne de groupebox 
            groupBoxVisiteur.Visible = false;
            groupBoxMedecin.Visible = false;

            // cache la troisième ligne de groupebox 
            groupBoxMotif.Visible = false;
            groupBoxBilan.Visible = false;

            // cache la ligne de button pour valider
            buttonValiderAjout.Visible = false;
            buttonValiderRecherche.Visible = false;
            buttonValiderModif.Visible = false;
        }

        // fonction qui clear les textbox et sélectionne la date du jour
        private void nettoyer()
        {
            // nettoye les textbox
            textBoxCode.Clear();
            textBoxBilan.Clear();

            // rend le textbox code inaccessible
            textBoxCode.Enabled = false;

            // met la date du jour au dateTimePicker
            dateTimePickerRapport.Value = DateTime.Now;
        }

        // fonction au chargement du formulaire
        private void Rapport_Load(object sender, EventArgs e)
        {
            chargerDgv();
            remplirCombobox();
            nettoyer();
            cacherText();
        }

        // fonction au clique du button ajouter qui affiche les groupbox et le button valider ajout
        private void buttonAjouterRapport_Click(object sender, EventArgs e)
        {
            remplirCombobox();
            nettoyer();
            cacherText();

            // affiche les groupebox 
            groupBoxCode.Visible = true;
            groupBoxDate.Visible = true;
            
            groupBoxVisiteur.Visible = true;
            groupBoxMedecin.Visible = true;
            
            groupBoxMotif.Visible = true;
            groupBoxBilan.Visible = true;

            // affiche le button valider ajout
            buttonValiderAjout.Visible = true;
        }

        // fonction au clique du button valider ajouter qui ajoute le rapport 
        private void buttonValiderAjout_Click(object sender, EventArgs e)
        {
            // variable qui récupére le contenu des éléments
            DateTime laDate = DateTime.Parse(dateTimePickerRapport.Text);
            string leVisiteur = comboBoxVisiteur.Text;
            string leMedecin = comboBoxMed.Text;
            string leMotif = comboBoxMotif.Text;
            string leBilan = textBoxBilan.Text;

            // condition qui vérifie si un des textbox est vide
            if (leBilan == "")
            {
                MessageBox.Show("une ou plusieurs case ne sont pas remplis ! ");
            }
            // condition qui vérifie qu'un visiteur soit sélectionner
            else if (leVisiteur == comboNonChoisi)
            {
                MessageBox.Show("il faut choisir un visiteur ! ");
            }
            // condition qui vérifie qu'un médecin soit sélectionner
            else if (leMedecin == comboNonChoisi)
            {
                MessageBox.Show("il faut choisir un médecin ! ");
            }
            // condition qui vérifie qu'un motif soit sélectionner
            else if (leMotif == comboNonChoisi)
            {
                MessageBox.Show("il faut choisir un motif ! ");
            }
            // condition qui ajoute le rapport
            else
            {
                // récupére et sépare le nom et prénom du visiteur 
                string[] separeVis = leVisiteur.Split(' ');
                string nomVisi = separeVis[0];
                string prenomVisi = separeVis[1];
                // fonction qui récupére l'id grace au nom et prenom du visiteur
                /* int leVisi = ClassePVisiteur.chargerUnVisiteur(nomVisi, prenomVisi);*/

                // récupére et sépare le nom et prénom du médecin 
                string[] separeMed = leMedecin.Split(' ');
                string nomMed = separeMed[0];
                string prenomMed = separeMed[1];
                // fonction qui récupére l'id grace au nom et prenom du visiteur
                int leMede = ClassePMedecin.recupererIdMedecin(nomMed, prenomMed);

                // ajoute le rapport avec la fonction ajouterRapport
                //ClassePRapport.ajouterRapport(dateRapport, motifRapport, bilanRapport, leVisi, leMede);

                // appelle de la fonction qui remplis le dgv et qui remplis les combobox
                chargerDgv();
                remplirCombobox();

                // appelle de la fonction qui nettoye les textbox et combobox puis les cache 
                nettoyer();
                cacherText();
            }
        }

        // fonction au clique du button supprimer qui affiche un messagebox pour valider la suppression du rapport sélectionner
        private void buttonSupprimerRapport_Click(object sender, EventArgs e)
        {
            if (dgvRapport.RowCount != 1)
            {

            }

        }

        // fonction au clique du button modifier qui affiche les groupbox et le button valider modif
        private void buttonModifierRapport_Click(object sender, EventArgs e)
        {
            if (dgvRapport.RowCount != 1)
            {

            }

            remplirCombobox();
            nettoyer();
            cacherText();

            // affiche les groupebox 
            groupBoxCode.Visible = true;
            groupBoxDate.Visible = true;

            groupBoxVisiteur.Visible = true;
            groupBoxMedecin.Visible = true;

            groupBoxMotif.Visible = true;
            groupBoxBilan.Visible = true;

            // affiche le button valider ajout
            buttonValiderModif.Visible = true;
        }

        // fonction au clique du button valider modif qui modifie le rapport 
        private void buttonValiderModif_Click(object sender, EventArgs e)
        {

        }

        // fonction au clique du button rechercher qui affiche les groupbox et le button valider recherche
        private void buttonRechercher_Click(object sender, EventArgs e)
        {

        }

        // fonction au clique du button valider recherche qui affiche dans le dgv en focntion des recherche rentrée
        private void buttonValiderRecherche_Click(object sender, EventArgs e)
        {

        }

        // fonction qui nettoie le dgv est cache les groupbox et les button au clique de reinitialiser
        private void buttonReinitialiser_Click(object sender, EventArgs e)
        {
            remplirCombobox();
            nettoyer();
            cacherText();

            chargerDgv();
        }
    }
}
