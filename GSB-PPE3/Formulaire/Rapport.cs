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
        string comboNonChoisi = "----------------------------------------------------------------------------------------------------------------------------------------------------";

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

        // fonction qui remplis les combobox partie rapport
        public void remplirCombobox()
        {
            // initialisation d'une liste puis ajout grâce a la fonction chargerLesVisteur de classePVisiteur
            List<ClasseVisiteur> lesVisi = new List<ClasseVisiteur>();
            lesVisi = ClassePVisiteur.chargerLesVisiteurs();

            // initialisation d'une liste puis ajout grâce a la fonction chargerLesMedecin de classePMedecin
            List<ClasseMedecin> lesMed = new List<ClasseMedecin>();
            lesMed = ClassePMedecin.chargerLesMedecins();

            // initialisation d'une liste puis ajout grâce a la fonction chargerLesMotif de classePRapport
            string[] lesMotif = { "périodicité", "nouveautés ou actualisations", "Problèmes occasionnel" };

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

        // fonction qui remplis les combobox partie med offert
        private void remplirComboboxMedOffert()
        {
            List<ClasseRapport> lesRapp = new List<ClasseRapport>();
            lesRapp = ClassePRapport.chargerLesRapports();

            comboBoxIdOffreRapport.Items.Clear();
            comboBoxIdOffreRapport.Items.Add(comboNonChoisi);
            comboBoxIdOffreRapport.SelectedItem = comboNonChoisi;

            // foreach qui ajoute dans le combobox visiteur 
            foreach (ClasseRapport rapportOffert in lesRapp)
            {
                string numRap = rapportOffert.Id.ToString();

                comboBoxIdOffreRapport.Items.Add(numRap);
            }

            List<ClasseMedicament> lesMedi = new List<ClasseMedicament>();
            lesMedi = ClassePMedicament.chargerLesMedicaments();

            comboBoxMedicament.Items.Clear();
            comboBoxMedicament.Items.Add(comboNonChoisi);
            comboBoxMedicament.SelectedItem = comboNonChoisi;

            // foreach qui ajoute dans le combobox visiteur 
            foreach (ClasseMedicament medOffert in lesMedi)
            {
                string nomMed = medOffert.NomCommercial;

                comboBoxMedicament.Items.Add(nomMed);
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

            // rend le textbox code et bilan inaccessible
            textBoxCode.Enabled = false;
            textBoxBilan.Enabled = false;


            // met la date du jour au dateTimePicker
            dateTimePickerRapport.Value = DateTime.Now;
        }

        // fonction qui nettoye le textbox quantite et sélectionne les combobox
        private void clearMed()
        {
            remplirComboboxMedOffert();
            txtQuantiteOffre.Clear();

            buttonValiderModifEchantillon.Visible = false;

            comboBoxIdOffreRapport.Enabled = true;
            comboBoxMedicament.Enabled = true;
        }

        // fonction qui enleve la case a cocher et met la date a jour sur le date time picker
        private void dateTimeAJour()
        {
            dateTimePickerRapport.ShowCheckBox = false;
            dateTimePickerRapport.Value = DateTime.Today;
        }

        // fonction qui ajoute une case a cocher au date time picker
        private void dateTimeCocher()
        {
            dateTimePickerRapport.ShowCheckBox = true;
        }


        // fonction au chargement du formulaire
        private void Rapport_Load(object sender, EventArgs e)
        {
            // partie rapport
            chargerDgv();
            remplirCombobox();
            nettoyer();
            cacherText();
            dateTimeAJour();

            // partie med offert
            remplirComboboxMedOffert();
            clearMed();
        }

        // fonction au clique du button ajouter qui affiche les groupbox et le button valider ajout
        private void buttonAjouterRapport_Click(object sender, EventArgs e)
        {
            remplirCombobox();
            nettoyer();
            cacherText();
            dateTimeAJour();

            // affiche les groupebox 
            groupBoxCode.Visible = true;
            groupBoxDate.Visible = true;
            
            groupBoxVisiteur.Visible = true;
            groupBoxMedecin.Visible = true;
            
            groupBoxMotif.Visible = true;
            groupBoxBilan.Visible = true;

            // rend accessible le textbox bilan
            textBoxBilan.Enabled = true;

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
                int leVisi = ClassePVisiteur.chargerUnVisiteur(nomVisi, prenomVisi);

                // récupére et sépare le nom et prénom du médecin 
                string[] separeMed = leMedecin.Split(' ');
                string nomMed = separeMed[0];
                string prenomMed = separeMed[1];

                // fonction qui récupére l'id grace au nom et prenom du medecin
                int leMede = ClassePMedecin.recupererIdMedecin(nomMed, prenomMed);

                // ajoute le rapport avec la fonction ajouterRapport
                ClassePRapport.ajoutRapport(laDate, leMotif, leBilan, leVisi, leMede);

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
                // variable qui récupére les données dans les cellules du dgv 
                int idRapport = int.Parse(dgvRapport.CurrentRow.Cells[0].Value.ToString());

                // condition qui active un messageBox et si valider alors suppression du rapport
                if (MessageBox.Show("êtes vous sur de vouloir supprimer le rapport numéro : " + idRapport + " ?", "advertissement ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    // fonction qui supprime le rapport
                    ClassePRapport.supprimerRapport(idRapport);

                    // appelle de la fonction qui remplis le dgv et qui remplis les combobox
                    chargerDgv();
                    remplirCombobox();

                    // appelle de la fonction qui nettoye les textbox et combobox puis les cache 
                    nettoyer();
                    cacherText();
                    dateTimeAJour();
                }
            }
            else
            {
                MessageBox.Show("il n'y pas d'élément dans le tableau");
            }
        }

        // fonction au clique du button modifier qui affiche les groupbox et le button valider modif
        private void buttonModifierRapport_Click(object sender, EventArgs e)
        {
            // condition qui vérifie qu'il y et un élément dans le dgv
            if (dgvRapport.RowCount != 1)
            {
                // condition qui pour être remplis dois sélectionné une ligne dans le dgv
                if (dgvRapport.CurrentRow.Selected)
                {
                    remplirCombobox();
                    nettoyer();
                    cacherText();
                    dateTimeAJour();

                    // affiche les groupebox 
                    groupBoxCode.Visible = true;
                    groupBoxDate.Visible = true;

                    groupBoxVisiteur.Visible = true;
                    groupBoxMedecin.Visible = true;

                    groupBoxMotif.Visible = true;
                    groupBoxBilan.Visible = true;

                    // rend accessible le textbox bilan
                    textBoxBilan.Enabled = true;

                    // affiche le button valider ajout
                    buttonValiderModif.Visible = true;

                    // récupération des valeur 
                    string leCode = dgvRapport.CurrentRow.Cells[0].Value.ToString();
                    
                    string leNomVisi= dgvRapport.CurrentRow.Cells[1].Value.ToString();
                    string lePrenomVisi= dgvRapport.CurrentRow.Cells[2].Value.ToString();
                    string leVisi = leNomVisi.Trim() + " " + lePrenomVisi.Trim();

                    string laDate = dgvRapport.CurrentRow.Cells[3].Value.ToString();

                    string leMotif = dgvRapport.CurrentRow.Cells[4].Value.ToString();

                    string leBilan = dgvRapport.CurrentRow.Cells[5].Value.ToString();

                    string leNomMed = dgvRapport.CurrentRow.Cells[6].Value.ToString();
                    string lePrenomMed = dgvRapport.CurrentRow.Cells[7].Value.ToString();
                    string leMed = leNomMed.Trim() + " " + lePrenomMed.Trim();

                    // placement dans les textbox et sélection dans le combobox
                    textBoxCode.Text = leCode;
                    dateTimePickerRapport.Text = laDate;

                    comboBoxVisiteur.SelectedItem = leVisi;
                    comboBoxMed.SelectedItem = leMed;

                    comboBoxMotif.SelectedItem = leMotif.Trim();
                    textBoxBilan.Text = leBilan;

                }
                // condition si pas de ligne sélectionner
                else
                {
                    MessageBox.Show("Sélectionner un rapport dans le tableau !");
                }
            }
        }

        // fonction au clique du button valider modif qui modifie le rapport 
        private void buttonValiderModif_Click(object sender, EventArgs e)
        {
            
            // condition qui vérifie que le combobox visiteur soit sélectionner
            if (comboBoxVisiteur.Text == comboNonChoisi)
            {
                MessageBox.Show("il faut sélectionner un visiteur ! ");
            }
            // condition qui vérifie que le combobox médecin soit sélectionner
            else if (comboBoxMed.Text == comboNonChoisi)
            {
                MessageBox.Show("il faut sélectionner un médecin ! ");
            }
            // condition qui vérifie que le combobox motif soit sélectionner
            else if (comboBoxMotif.Text == comboNonChoisi)
            {
                MessageBox.Show("il faut sélectionner un motif ! ");
            }
            // condition qui vérifie si un le textbox bilan est vide
            else if (textBoxBilan.Text == "")
            {
                MessageBox.Show("le bilan n'est pas remplis ! ");
            }
            // condition qui réalise la modification 
            else
            {
                // variable qui récupére les info dans les combobox pour les fonction
                string leVis = comboBoxVisiteur.Text;
                string[] visiteur = leVis.Split();
                string leNomVis = visiteur[0];
                string lePrenomVis = visiteur[1];

                string leMed = comboBoxMed.Text;
                string[] medecin = leMed.Split();
                string leNomMed = medecin[0];
                string lePrenomMed = medecin[1];

                // fonction qui récupére l'id du visiteur
                int idVis = ClassePVisiteur.chargerUnVisiteur(leNomVis, lePrenomVis);

                // fonction qui récupére l'id du medecin
                int idMed = ClassePMedecin.recupererIdMedecin(leNomMed, lePrenomMed);

                // variable qui récupére les données pour la modification 
                int lid = int.Parse(textBoxCode.Text);
                DateTime laDate = DateTime.Parse(dateTimePickerRapport.Text);
                string leMotif = comboBoxMotif.Text;
                string leBilan = textBoxBilan.Text;


                // met à jour le rapport avec la fonction modifierRapport
                ClassePRapport.modifRapport(lid, laDate, leMotif,leBilan, idVis, idMed);

                // appelle de la fonction qui remplis le dgv et qui remplis les combobox
                chargerDgv();
                remplirCombobox();

                // appelle de la fonction qui nettoye les textbox et combobox puis les cache 
                nettoyer();
                cacherText();
            }
        }

        // fonction au clique du button rechercher qui affiche les groupbox et le button valider recherche
        private void buttonRechercher_Click(object sender, EventArgs e)
        {
            // appelle de la fonction qui remplis le dgv et qui remplis les combobox
            chargerDgv();
            remplirCombobox();

            // appelle de la fonction qui nettoye les textbox et combobox puis les cache 
            nettoyer();
            cacherText();

            // affiche les groupebox 
            groupBoxCode.Visible = true;
            groupBoxDate.Visible = true;

            dateTimeCocher();

            groupBoxVisiteur.Visible = true;
            groupBoxMedecin.Visible = true;

            groupBoxMotif.Visible = true;
            groupBoxBilan.Visible = true;

            // affiche le button valider ajout
            buttonValiderRecherche.Visible = true;

            // rend le textbox code accessible
            textBoxCode.Enabled = true;
        }

        // fonction au clique du button valider recherche qui affiche dans le dgv en focntion des recherche rentrée
        private void buttonValiderRecherche_Click(object sender, EventArgs e)
        {
            // nettoye le dgv
            dgvRapport.Rows.Clear();

            // variable qui récupére le contenu des combobox et du textbox de recherche  
            string leCode = textBoxCode.Text;
            bool laDateActive = dateTimePickerRapport.Checked;

            string leVisiteur = comboBoxVisiteur.Text;
            string leMedecin = comboBoxMed.Text;

            string leMotif = comboBoxMotif.Text;

            string leNomVis;
            string lePrenomVis;

            // récupération du nom et du prénom du visiteur avec un split qui prend la séparation sur l'espace
            if (leVisiteur == comboNonChoisi)
            {
                leNomVis = "";
                lePrenomVis = "";
            }
            else
            {
                string[] leVisi = leVisiteur.Split(' ');
                leNomVis = leVisi[0];
                lePrenomVis = leVisi[1];
            }

            // fonction qui récupére l'id du visiteur
            int idVis = ClassePVisiteur.chargerUnVisiteur(leNomVis, lePrenomVis);

            string leNomMed;
            string lePrenomMed;

            // récupération du nom et du prénom du médecin avec un split qui prend la séparation sur l'espace
            if (leMedecin == comboNonChoisi)
            {
                leNomMed = "";
                lePrenomMed = "";
            }
            else
            {
                string[] leMed = leMedecin.Split(' ');
                leNomMed = leMed[0];
                lePrenomMed = leMed[1];
            }
            
            // fonction qui récupére l'id du medecin
            int idMed = ClassePMedecin.recupererIdMedecin(leNomMed, lePrenomMed);

            // vérifie si la case a cocher est activer si oui alors on récupére la date et on passe la variable laDateActive a true sinon false est on prend la date du jour
            DateTime laDate;
            bool dateActive;
            if (laDateActive == true)
            {
                laDate = DateTime.Parse(dateTimePickerRapport.Text);
                dateActive = true;
            }
            else
            {
                laDate = DateTime.Parse(DateTime.Today.ToString());
                dateActive = false;
            }

            // condition qui vérifie qu'au moins un des élément et sélectionné
            if (leCode != "" || laDateActive == true || leVisiteur != comboNonChoisi || leMedecin != comboNonChoisi || leMotif != comboNonChoisi)
            {
                // initialisation d'une liste avec la fonction rechercherRapport de classePRapport
                List<ClasseRapport> leRap = ClassePRapport.rechercherRapport(leCode, laDate, dateActive, idMed, idVis, leMotif);
                // foreach qui remplis le dgv avec la liste leRap
                foreach (ClasseRapport lesRap in leRap)
                {
                    string lid = lesRap.Id.ToString();
                    string leNomVisiteur = lesRap.LeVisiteur.Nom;
                    string lePrenomVisiteur = lesRap.LeVisiteur.Prenom;
                    DateTime DateRap = lesRap.Date;
                    string MotifRap = lesRap.Motif;
                    string leBilan = lesRap.Bilan;
                    string leNomMedecin = lesRap.LeMedecin.Nom;
                    string lePrenomMedecin = lesRap.LeMedecin.Prenom;

                    dgvRapport.Rows.Add(lid, leNomVisiteur, lePrenomVisiteur, DateRap, MotifRap, leBilan, leNomMedecin, lePrenomMedecin);
                }
            }
            // condition qui s'active si aucun des groupbox et le textbox ne sont sélectionné 
            else
            {
                chargerDgv();
                MessageBox.Show("il faut choisir au moins un élément de recherche !");
            }
        }

        // fonction qui nettoie le dgv est cache les groupbox et les button au clique de reinitialiser
        private void buttonReinitialiser_Click(object sender, EventArgs e)
        {
            remplirCombobox();
            nettoyer();
            cacherText();

            chargerDgv();
        }
        
        // fonction qui affiche les groupbox et le bouton valider ajout 
        private void buttonAjouterOffre_Click(object sender, EventArgs e)
        {
            // variable récupérent les information
            string leRapport = comboBoxIdOffreRapport.Text;
            string leMedicament = comboBoxMedicament.Text;
            string laQuantite = txtQuantiteOffre.Text;
            bool laQuantiteValide;

            // vérifie si une quantité est indiquer qu'il s'agisse bien d'un chiffre
            if (laQuantite != "")
            {
                laQuantiteValide = ClasseRapport.quantiteValide(laQuantite);
            }
            else
            {
                laQuantiteValide = false;
            }
            
            // vérifie que le rapport et le médicament est sélection et que la quantité soit valide
            if (leRapport != comboNonChoisi && leMedicament != comboNonChoisi && laQuantiteValide == true)
            {
                int idMedicament = ClassePMedicament.recupererIdMedicament(leMedicament);

                // ajoute l'échantillon avec la fonction 
                ClassePEchantillonOffert.AjoutEchantillonOffert(int.Parse(leRapport), idMedicament, int.Parse(laQuantite));

                // appelle de la fonction qui remplis le dgv et qui remplis les combobox
                remplirComboboxMedOffert();
                clearMed();
            }
            // sinon affiche un messagebox pour indiquer un problème
            else
            {
                MessageBox.Show("attention l'ajout n'est pas valide, l'un des élément n'est pas valide, non sélection d'un rapport ou d'un médicament ou la quantité n'est pas valide (il ne s'agit pas d'un chiffre ou il n'a pas était remplis) !", "advertissement ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // fonction qui remplie les groupebox et le textbox puis le bouton valider modif 
        private void buttonModifierOffre_Click(object sender, EventArgs e)
        {
            // condition qui vérifie qu'il y et un élément dans le dgv
            if (dgwListeMedicament.RowCount != 1)
            {
                // condition qui pour être remplis dois sélectionné une ligne dans le dgv
                if (dgwListeMedicament.CurrentRow.Selected)
                {
                    // appelle des fonction qui clear les groupebox et le textbox
                    remplirComboboxMedOffert();
                    clearMed();

                    // affiche le button valider modif
                    buttonValiderModifEchantillon.Visible = true;

                    // récupération des valeur 
                    string codeRapport = dgwListeMedicament.CurrentRow.Cells[0].Value.ToString();
                    string nomMedicament = dgwListeMedicament.CurrentRow.Cells[2].Value.ToString();
                    string laQuantite = dgwListeMedicament.CurrentRow.Cells[3].Value.ToString();

                    // placement dans les textbox et sélection dans le combobox
                    comboBoxIdOffreRapport.SelectedItem = codeRapport;
                    comboBoxMedicament.SelectedItem = nomMedicament;
                    txtQuantiteOffre.Text = laQuantite;

                    comboBoxIdOffreRapport.Enabled = false;
                    comboBoxMedicament.Enabled = false;

                }
                // condition si pas de ligne sélectionner
                else
                {
                    MessageBox.Show("Sélectionner un rapport dans le tableau !");
                }
            }
            else
            {
                MessageBox.Show("il n'y pas d'élément dans le tableau");
            }
        }

        // fonction qui vérifie que les modificationsoit correct puis réalise la modification 
        private void buttonValiderModifEchantillon_Click(object sender, EventArgs e)
        {
            // variable récupérent les information
            string leRapport = comboBoxIdOffreRapport.Text;
            string leMedicament = comboBoxMedicament.Text;
            string laQuantite = txtQuantiteOffre.Text;
            bool laQuantiteValide;

            // vérifie que la quantité soit remplie
            if (laQuantite != "")
            {
                // vérifie que la quantité soit valide
                laQuantiteValide = ClasseRapport.quantiteValide(laQuantite);
                if (laQuantiteValide == true)
                {
                    int idMedicament = ClassePMedicament.recupererIdMedicament(leMedicament);

                    // modifie l'échantillon avec la fonction ModifEchantillonOffert
                    ClassePEchantillonOffert.ModifEchantillonOffert(int.Parse(leRapport), idMedicament, int.Parse(laQuantite));

                    // appelle de la fonction qui remplis le dgv et qui remplis les combobox
                    dgwListeMedicament.Rows.Clear();
                    remplirComboboxMedOffert();
                    clearMed();
                }
                // sinon affiche un messagebox pour indiquer que la quantité n'est pas valide
                else
                {
                    MessageBox.Show("attention la modification n'est pas valide, la quantité n'a pas était remplis !", "advertissement ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            // sinon affiche un messagebox pour indiquer que la quantité n'est pas remplie
            else
            {
                MessageBox.Show("attention la modification n'est pas valide, la quantité n'a pas était remplis !", "advertissement ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // fonction qui affiche un messagebox puis qui supprime le medicament offert
        private void buttonSupprimerOffre_Click(object sender, EventArgs e)
        {
            if (dgwListeMedicament.RowCount != 1)
            {
                // variable qui récupére les données dans les cellules du dgv 
                int idRapport = int.Parse(dgwListeMedicament.CurrentRow.Cells[0].Value.ToString());
                int idMedicament = int.Parse(dgwListeMedicament.CurrentRow.Cells[1].Value.ToString());
                string nomMedicament = dgwListeMedicament.CurrentRow.Cells[2].Value.ToString();

                // condition qui active un messageBox et si valider alors suppression de l'échantillon
                if (MessageBox.Show("êtes vous sur de vouloir supprimer l'échantillon lier au rapport numéro : " + idRapport + " comprenant le médicament intituler : " + nomMedicament + " ?", "advertissement ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    // fonction qui supprime l'échantillon
                    ClassePEchantillonOffert.SupprimerEchantillonOffert(idRapport, idMedicament);

                    // appelle de la fonction qui remplis le dgv et qui remplis les combobox
                    dgwListeMedicament.Rows.Clear();
                    remplirComboboxMedOffert();
                    clearMed();
                } 
            }
            else
            {
                MessageBox.Show("il n'y pas d'élément dans le tableau");
            }
        }

        // fonction qui recherche et affiche dans le datagridview
        private void buttonRechercherMedRap_Click(object sender, EventArgs e)
        {
            string leRapport = comboBoxIdOffreRapport.Text;
            string leMedicament = comboBoxMedicament.Text;
            string laQuantite = txtQuantiteOffre.Text;

            bool leRapportValide = false;
            bool leMedicamentValide = false;
            bool laQuantiteValide = ClasseRapport.quantiteValide(laQuantite);

            // condition qui vérifie qu'au moins un élément est sélectionné pour la recherche 
            if (leRapport == comboNonChoisi && leMedicament == comboNonChoisi && laQuantite == "")
            {
                // active un messageBox pour indiquer que la recherche n'est pas valide
                MessageBox.Show("attention la recherche n'est pas valide vous n'avait pas choisi de rapport ou de médicament ou la quantité n'est pas valide !", "advertissement ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            // vérifie si la quantité est bien un chiffre
            else if (laQuantiteValide == false && laQuantite != "")
            {
                // active un messageBox pour indiquer que la recherche n'est pas valide a cause de la quantite
                MessageBox.Show("attention la recherche n'est pas valide, la quantité n'est pas un chiffre !", "advertissement ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // condition qui active un messageBox et si valider alors recherche
                if (MessageBox.Show("êtes vous sur de vouloir réaliser la recherche avec les élèments sélectionné ?", "advertissement ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    // condition qui vérifie si un rapport est sélectionner
                    if (leRapport == comboNonChoisi)
                    {
                        leRapportValide = false;
                    }
                    else
                    {
                        leRapportValide = true;
                    }

                    // condition qui vérifie si un médicament est sélectionner
                    if (leMedicament == comboNonChoisi)
                    {
                        leMedicamentValide = false;
                    }
                    else
                    {
                        leMedicamentValide = true;
                    }

                    // initialisation d'une liste avec la fonction rechercherRapport de classePRapport
                    List<ClasseEchantillonOffert> lEchant = ClassePEchantillonOffert.rechercherRapportMedicament(leRapport, leRapportValide, leMedicament, leMedicamentValide, laQuantite);
                    // on vide le dgw pour le remplir 
                    dgwListeMedicament.Rows.Clear();
                    // foreach qui remplis le dgv avec la liste leRap
                    foreach (ClasseEchantillonOffert lesEchant in lEchant)
                    {
                        string idRap = lesEchant.IdRapport.ToString();
                        string idMed = lesEchant.LeMedicament.Id.ToString();
                        string nomMed = lesEchant.LeMedicament.NomCommercial;
                        string quantiteOfferte = lesEchant.Quantite.ToString();

                        dgwListeMedicament.Rows.Add(idRap, idMed, nomMed, quantiteOfferte);

                    }
                }
            }
        }

        // fonction qui réinitialise le dgw des medicament offert
        private void buttonReinitialiserMedRap_Click(object sender, EventArgs e)
        {
            dgwListeMedicament.Rows.Clear();
            remplirComboboxMedOffert();
            clearMed();
        }
    }
}
