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
        string comboNonChoisi = "";

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
            comboBoxFamilleMedicament.Items.Add("");

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
                buttonValiderModification.Visible = true;
                AfficherBox();
                btnRetour.Visible = true;
            }
            else
            {
                MessageBox.Show("Il faut sélectionner un médicament dans le tableau !");
            }
        }

        //BOUTON VALIDER MOFIFICATION
        private void buttonValiderModification_Click(object sender, EventArgs e)
        {

            if (txtNomMedicament.Text == "" || txtCompositionMedicament.Text == "" || txtEffetMedicament.Text == ""
                || txtContreIndicationMedicament.Text == "")
            {
                MessageBox.Show("Une ou plusieurs cases ne sont pas remplis ! ");
            }
            else if (comboBoxFamilleMedicament.Text == "")
            {
                MessageBox.Show("Il faut choisir une famille de médicament ! ");
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


                txtNomMedicament.Clear();
                txtCompositionMedicament.Clear();
                txtEffetMedicament.Clear();
                txtContreIndicationMedicament.Clear();
                comboBoxFamilleMedicament.SelectedItem = "";
                CacherBox();
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
            AfficherBox();
            btnValiderAjout.Visible = true;
            btnRetour.Visible = true;
        }
        #region fonctions
        private void CacherBox()
        {
            groupBoxCompositionMedicament.Visible = false;
            groupBoxContreIndication.Visible = false;
            groupBoxEffetMedicament.Visible = false;
            groupBoxFamilleMedicament.Visible = false;
            groupBoxNomMedicament.Visible = false;
            buttonSupprimerMedicament.Visible = true;
            buttonModifierMedicament.Visible = true;
            buttonAjouterMedicament.Visible = true;
            buttonValiderModification.Visible = false;
            btnRechercher.Visible = true;
        }

        private void AfficherBox()
        {
            groupBoxCompositionMedicament.Visible = true;
            groupBoxContreIndication.Visible = true;
            groupBoxEffetMedicament.Visible = true;
            groupBoxFamilleMedicament.Visible = true;
            groupBoxNomMedicament.Visible = true;
            buttonSupprimerMedicament.Visible = false;
            buttonModifierMedicament.Visible = false;
            buttonAjouterMedicament.Visible = false;
            btnRechercher.Visible = false;
        }

        private void FermerComboBox()
        {
            cboxRechercherNom.Enabled = false;
            cboxRechercherCompo.Enabled = false;
            cboxRechercheEffet.Enabled = false;
            cboxRechercheCI.Enabled = false;
            cboxRechercheFamille.Enabled = false;
            // vide le dgv
            dgwGererMedicament.Rows.Clear();
        }
        private void OuvrirComboBox()
        {
            cboxRechercherNom.Enabled = true;
            cboxRechercherCompo.Enabled = true;
            cboxRechercheEffet.Enabled = true;
            cboxRechercheCI.Enabled = true;
            cboxRechercheFamille.Enabled = true;

            dgwGererMedicament.Rows.Clear();
        }
        #endregion
        private void btnValiderAjout_Click(object sender, EventArgs e)
        {
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

                txtNomMedicament.Clear();
                txtCompositionMedicament.Clear();
                txtEffetMedicament.Clear();
                txtContreIndicationMedicament.Clear();
                comboBoxFamilleMedicament.SelectedItem = "";
                CacherBox();
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            // Nettoie toutes les zones de textes
            txtNomMedicament.Clear();
            txtCompositionMedicament.Clear();
            txtEffetMedicament.Clear();
            txtContreIndicationMedicament.Clear();

            // Réinitialise la selection des combobox
            comboBoxFamilleMedicament.SelectedItem = "";
            cboxRechercheCI.SelectedItem = "";
            cboxRechercheEffet.SelectedItem = "";
            cboxRechercheFamille.SelectedItem = "";
            cboxRechercherCompo.SelectedItem = "";
            cboxRechercherNom.SelectedItem = "";


            //Gère la visibilité des boutons 
            btnRetour.Visible = false;
            btnValiderAjout.Visible = false;
            buttonValiderModification.Visible = false;

            //Gère la visibilité des éléments
            grpboxRechercheCI.Visible = false;
            grpboxRechercheEffet.Visible = false;
            grpboxRechercherCompo.Visible = false;
            grpboxRechercherNom.Visible = false;
            grpboxRechercheFamille.Visible = false;
            CacherBox();

            //Charge les données dans le DGV
            dgvFormulaireGererMedicament();

        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            //Gère affichage des boutons
            buttonSupprimerMedicament.Visible = false;
            buttonModifierMedicament.Visible = false;
            buttonAjouterMedicament.Visible = false;
            btnRechercher.Visible = false;

            //  Vide les combo box
            cboxRechercheFamille.Items.Clear();
            cboxRechercheCI.Items.Clear();
            cboxRechercheEffet.Items.Clear();
            cboxRechercherCompo.Items.Clear();
            cboxRechercherNom.Items.Clear();

            // vide le dgv
            dgwGererMedicament.Rows.Clear();

            // Ajoute un éléments aux combobox
            cboxRechercheCI.Items.Add("");
            cboxRechercheEffet.Items.Add("");
            cboxRechercheFamille.Items.Add("");
            cboxRechercherCompo.Items.Add("");
            cboxRechercherNom.Items.Add("");

            // Gére la visiblité des group box
            grpboxRechercheCI.Visible = true;
            grpboxRechercheEffet.Visible = true;
            grpboxRechercherCompo.Visible = true;
            grpboxRechercherNom.Visible = true;
            grpboxRechercheFamille.Visible = true;

            // Instancie la liste de tout les médicaments
            List<ClasseMedicament> lesMedicaments = ClassePMedicament.chargerLesMedicaments();
            //Balaye la liste des médicaments
            foreach (ClasseMedicament unMedicament in lesMedicaments)
            {
                // Récupère les données de cet éléments 
                string leNom = unMedicament.NomCommercial;
                string laFamille = unMedicament.Famille.Libelle;
                string laComposition = unMedicament.Composition;
                string leffet = unMedicament.Effets;
                string lesIndications = unMedicament.Contreindictions;


                // Gère si les indications sont écrites plusieurs fois
                if (!cboxRechercheCI.Items.Contains(lesIndications))
                {
                    // Les insèrent dans la combobox
                    cboxRechercheCI.Items.Add(lesIndications);
                }

                // Gère si les effets sont écrites plusieurs fois
                if (!cboxRechercheEffet.Items.Contains(leffet))
                {
                    // Les insèrent dans la combobox
                    cboxRechercheEffet.Items.Add(leffet);
                }

                // Gère si la composition est écrite plusieurs fois
                if (!cboxRechercherCompo.Items.Contains(laComposition))
                {
                    // Les insèrent dans la combobox
                    cboxRechercherCompo.Items.Add(laComposition);
                }

                // Gère si le nom est écrit plusieurs fois
                if (!cboxRechercherNom.Items.Contains(leNom))
                {
                    // Les insèrent dans la combobox
                    cboxRechercherNom.Items.Add(leNom);
                }

                // Gère si la famille est écrite plusieurs fois
                if (!cboxRechercheFamille.Items.Contains(laFamille))
                {
                    // Les insèrent dans la combobox
                    cboxRechercheFamille.Items.Add(laFamille);
                }
            }
            // Gère la visibilité du bouton retour
            btnRetour.Visible = true;
        }

        private void cboxRechercherNom_TextChanged(object sender, EventArgs e)
        {
            // Vérifie si une information est saisie dans la combobox
            if(cboxRechercherNom.Text == "")
            {
                // Laisse accessible toutes les combobox
                OuvrirComboBox();
            }
            else
            {
                // Empêche la saisie dans les autres combobox
                FermerComboBox();
                cboxRechercherNom.Enabled = true;

                // Cherche les médicaments qui disposent du nom choisis dans la combobox
                List<ClasseMedicament> LesNomsMedicaments = ClassePMedicament.chargerLeNom(cboxRechercherNom.Text);
                // Balaye les noms de médicaments
                foreach(ClasseMedicament leNomMedicament in LesNomsMedicaments)
                {
                    // Récupère les informations 
                    int leNb = leNomMedicament.Id;
                    string leNom = leNomMedicament.NomCommercial;
                    string laFamille = leNomMedicament.Famille.Libelle;
                    string laComposition = leNomMedicament.Composition;
                    string leffet = leNomMedicament.Effets;
                    string lesIndications = leNomMedicament.Contreindictions;
                    // Ajoute les médicaments dans le DGV
                    dgwGererMedicament.Rows.Add(leNb, leNom, laFamille, laComposition, leffet, lesIndications);
                }
            }
        }

        private void cboxRechercheFamille_TextChanged(object sender, EventArgs e)
        {
            // Vérifie si une information est saisie dans la combobox
            if (cboxRechercheFamille.Text == "")
            {
                // Laisse accessible toutes les combobox
                OuvrirComboBox();
            }
            else
            {
                // Empêche la saisie dans les autres combobox
                FermerComboBox();
                cboxRechercheFamille.Enabled = true;

                // Cherche les médicaments qui disposent de la famille choisis dans la combobox
                List<ClasseMedicament> LesFamilles = ClassePMedicament.chargerLaFamille(cboxRechercheFamille.Text);
                // Balaye les familles de médicaments
                foreach (ClasseMedicament laFamille in LesFamilles)
                {
                    // Récupère les informations 
                    int leNb = laFamille.Id;
                    string leNom = laFamille.NomCommercial;
                    string uneFamille = laFamille.Famille.Libelle;
                    string laComposition = laFamille.Composition;
                    string leffet = laFamille.Effets;
                    string lesIndications = laFamille.Contreindictions;
                    // Ajoute les médicaments dans le DGV
                    dgwGererMedicament.Rows.Add(leNb, leNom, uneFamille, laComposition, leffet, lesIndications);
                }
            }
        }

        private void cboxRechercherCompo_TextChanged(object sender, EventArgs e)
        {
            // Vérifie si une information est saisie dans la combobox
            if (cboxRechercherCompo.Text == "")
            {
                // Laisse accessible toutes les combobox
                OuvrirComboBox();
            }
            else
            {
                // Empêche la saisie dans les autres combobox
                FermerComboBox();
                cboxRechercherCompo.Enabled = true;

                // Cherche les médicaments qui disposent de la composition choisis dans la combobox
                List<ClasseMedicament> LesCompos = ClassePMedicament.chargerLaComposition(cboxRechercherCompo.Text);
                // Balaye les compositions de médicaments
                foreach (ClasseMedicament laCompo in LesCompos)
                {
                    // Récupère les informations 
                    int leNb = laCompo.Id;
                    string leNom = laCompo.NomCommercial;
                    string uneFamille = laCompo.Famille.Libelle;
                    string laComposition = laCompo.Composition;
                    string leffet = laCompo.Effets;
                    string lesIndications = laCompo.Contreindictions;
                    // Ajoute les médicaments dans le DGV
                    dgwGererMedicament.Rows.Add(leNb, leNom, uneFamille, laComposition, leffet, lesIndications);
                }
            }
        }

        private void cboxRechercheEffet_TextChanged(object sender, EventArgs e)
        {
            // Vérifie si une information est saisie dans la combobox
            if (cboxRechercheEffet.Text == "")
            {
                // Laisse accessible toutes les combobox
                OuvrirComboBox();
            }
            else
            {
                // Empêche la saisie dans les autres combobox
                FermerComboBox();
                cboxRechercheEffet.Enabled = true;

                // Cherche les médicaments qui disposent des effets choisis dans la combobox
                List<ClasseMedicament> LesEffets = ClassePMedicament.chargerLEffet(cboxRechercheEffet.Text);
                // Balaye les effets de médicaments
                foreach (ClasseMedicament lEffet in LesEffets)
                {
                    // Récupère les informations 
                    int leNb = lEffet.Id;
                    string leNom = lEffet.NomCommercial;
                    string uneFamille = lEffet.Famille.Libelle;
                    string laComposition = lEffet.Composition;
                    string leffet = lEffet.Effets;
                    string lesIndications = lEffet.Contreindictions;
                    // Ajoute les médicaments dans le DGV
                    dgwGererMedicament.Rows.Add(leNb, leNom, uneFamille, laComposition, leffet, lesIndications);
                }
            }
        }

        private void cboxRechercheCI_TextChanged(object sender, EventArgs e)
        {
            // Vérifie si une information est saisie dans la combobox
            if (cboxRechercheCI.Text == "")
            {
                // Laisse accessible toutes les combobox
                OuvrirComboBox();
            }
            else
            {
                // Empêche la saisie dans les autres combobox
                FermerComboBox();
                cboxRechercheCI.Enabled = true;

                // Cherche les médicaments qui disposent des Contre Indications choisis dans la combobox
                List<ClasseMedicament> LesCI = ClassePMedicament.chargerLaCI(cboxRechercheCI.Text);
                // Balaye les Contre indications de médicaments
                foreach (ClasseMedicament laCI in LesCI)
                {
                    // Récupère les informations 
                    int leNb = laCI.Id;
                    string leNom = laCI.NomCommercial;
                    string uneFamille = laCI.Famille.Libelle;
                    string laComposition = laCI.Composition;
                    string leffet = laCI.Effets;
                    string lesIndications = laCI.Contreindictions;
                    // Ajoute les médicaments dans le DGV
                    dgwGererMedicament.Rows.Add(leNb, leNom, uneFamille, laComposition, leffet, lesIndications);
                }
            }
        }
    }
}
