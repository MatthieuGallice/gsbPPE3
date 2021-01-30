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
    public partial class Visiteur : Form
    {
        public Visiteur()
        {
            InitializeComponent();
        }

        

        // AU CHARGEMENT DE LA PAGE
        private void Visiteur_Load(object sender, EventArgs e)
        {
            dgvFormulaireVisiteur();
            CacherBox();

        }

        // BOUTON MODIFIER
        private void buttonModifierVisiteur_Click(object sender, EventArgs e)
        {
            if (dgwVisiteur.CurrentRow.Selected)
            {
                DateTime dateEmbauche = DateTime.Parse(dgwVisiteur.CurrentRow.Cells[6].Value.ToString());
                // INSTANCIATION
                ClasseVisiteur modifier = new ClasseVisiteur(int.Parse(dgwVisiteur.CurrentRow.Cells[0].Value.ToString()), dgwVisiteur.CurrentRow.Cells[1].Value.ToString(), dgwVisiteur.CurrentRow.Cells[2].Value.ToString(), dgwVisiteur.CurrentRow.Cells[3].Value.ToString(), dgwVisiteur.CurrentRow.Cells[4].Value.ToString(), dgwVisiteur.CurrentRow.Cells[5].Value.ToString(), dateEmbauche);
                
                // PLACEMENT DANS LES TEXTBOX ET SELECTION DANS LE COMBOBOX
                txtNomVisiteur.Text = modifier.Nom;
                txtPrenomVisiteur.Text = modifier.Prenom;
                //Code Postal
                txtCodePostalVisiteur.Text = modifier.Cp;
                //Ville
                txtVilleVisiteur.Text = modifier.Ville;
                //Adresse
                txtAdresseVisiteur.Text = modifier.Adresse;

                //Gestion de la date
                CalendrierDateEmbauche.SetDate(modifier.DateEmbauche);

                AfficherBox();
                buttonValiderModificationVisiteur.Visible = true;
            }
            else
            {
                MessageBox.Show("Sélectionner un visiteur dans le tableau !");
            }
        }

        private void buttonValiderModificationVisiteur_Click(object sender, EventArgs e)
        {
            // PLACEMENT DANS LES TEXTBOX ET SELECTION DANS LE COMBOBOX
            int id = int.Parse(dgwVisiteur.CurrentRow.Cells[0].Value.ToString());
            string nomVis = txtNomVisiteur.Text;
            string prenomVis = txtPrenomVisiteur.Text;
            //Code Postal
            string CP = txtCodePostalVisiteur.Text;
            //Ville
            string Ville = txtVilleVisiteur.Text;
            //Adresse
            string Adresse = txtAdresseVisiteur.Text;
            //gère la date
            DateTime laDate = CalendrierDateEmbauche.SelectionStart;



            ClassePVisiteur.ModifVisiteur(id, nomVis, prenomVis, Adresse, "", "", CP, Ville, laDate);
            CacherBox();
            buttonModifierVisiteur.Visible = true;
            MessageBox.Show("Le visiteur " + nomVis + " " + prenomVis + " a été modifié !");
            dgvFormulaireVisiteur();
            clearBox();
        }

        private void buttonSupprimerVisiteur_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgwVisiteur.CurrentRow.Cells[0].Value.ToString());
            string nomVis = dgwVisiteur.CurrentRow.Cells[1].Value.ToString();
            string prenomVis = dgwVisiteur.CurrentRow.Cells[2].Value.ToString();

            //Supprime le visiteur
            ClassePVisiteur.SupprimerVisiteur(id);

            MessageBox.Show("Le visiteur " + nomVis + " " + prenomVis + " a bien été supprimé !");
            dgvFormulaireVisiteur();
        }

        private void buttonAjouterVisiteur_Click(object sender, EventArgs e)
        {
            //Affiche toutes les textBox et le bouton réinitialiser et Enleve les boutons ajouter, supprimer et modifier
            AfficherBox();
            //Affiche le bonton ajouter
            btnAjoutVisiteur.Visible = true;
        }

        private void btn_Reinitialiser_Click(object sender, EventArgs e)
        {
            // remplis le dgv
            dgvFormulaireVisiteur();

            //Cache toutes les textBox, le bouton réinitialiser, valider modification et ajouter visiteur et Affiche les boutons supprimer et ajouter 
            CacherBox();
            //Nettoie toutes les textBox et remet le calendrier à la date du jour
            clearBox();
            //Affiche le bonton modifier
            buttonModifierVisiteur.Visible = true;

        }

        private void btnAjoutVisiteur_Click(object sender, EventArgs e)
        {
            // Gestion des erreurs
            if (txtAdresseVisiteur.Text == "" || txtCodePostalVisiteur.Text == "" || txtNomVisiteur.Text == ""
                || txtPrenomVisiteur.Text == "" || txtVilleVisiteur.Text == "")
            {
                MessageBox.Show("Certaines cases sont mals remplis ! ");
            }
            else
            {
                //Nom
                string nomVis = txtNomVisiteur.Text;
                //Prenom
                string prenomVis = txtPrenomVisiteur.Text;
                //Code Postal
                string CP = txtCodePostalVisiteur.Text;
                //Ville
                string Ville = txtVilleVisiteur.Text;
                //Adresse
                string Adresse = txtAdresseVisiteur.Text;
                //gère la date
                DateTime laDate = CalendrierDateEmbauche.SelectionStart;

                //On ajoute le visiteur
                ClassePVisiteur.AjoutVisiteur(nomVis, prenomVis, Adresse, "", "", CP, Ville, laDate);

                //Affiche le bonton modifier
                buttonModifierVisiteur.Visible = true;
                //Met a jour le DGV
                dgvFormulaireVisiteur();
                //Cache toutes les textBox, le bouton réinitialiser, valider modification et ajouter visiteur et Affiche les boutons supprimer et ajouter 
                CacherBox();
                //Nettoie toutes les textBox et remet le calendrier à la date du jour
                clearBox();
            }
        }

        /// <summary>
        /// Cache toutes les textBox, le bouton réinitialiser, valider modification et ajouter visiteur
        /// Affiche les boutons supprimer et ajouter 
        /// </summary>
        private void CacherBox()
        {
            //Cacher
            groupBoxAdresse.Visible = false;
            groupBoxCodePostal.Visible = false;
            groupBoxDateEmbauche.Visible = false;
            groupBoxNomVisiteur.Visible = false;
            groupBoxPrenomVisiteur.Visible = false;
            groupBoxVille.Visible = false;
            btn_Reinitialiser.Visible = false;
            buttonValiderModificationVisiteur.Visible = false;
            btnAjoutVisiteur.Visible = false;
            grpboxCPRechercher.Visible = false;
            grpboxNPVisiteurRecherche.Visible = false;
            grpboxVilleRecherche.Visible = false;

            //Afficher
            buttonAjouterVisiteur.Visible = true;
            buttonSupprimerVisiteur.Visible = true;
            btnRechercheVis.Visible = true;
        }

        /// <summary>
        /// Affiche toutes les textBox et le bouton réinitialiser
        /// Enleve les boutons ajouter, supprimer et modifier
        /// </summary>
        private void AfficherBox()
        {
            //Afficher
            groupBoxAdresse.Visible = true;
            groupBoxCodePostal.Visible = true;
            groupBoxDateEmbauche.Visible = true;
            groupBoxNomVisiteur.Visible = true;
            groupBoxPrenomVisiteur.Visible = true;
            groupBoxVille.Visible = true;
            btn_Reinitialiser.Visible = true;

            //Cacher
            buttonAjouterVisiteur.Visible = false;
            buttonSupprimerVisiteur.Visible = false;
            buttonModifierVisiteur.Visible = false;
            btnRechercheVis.Visible = false;
        }

        /// <summary>
        /// Nettoie toutes les textBox et remet le calendrier à la date du jour
        /// </summary>
        private void clearBox()
        {
            txtAdresseVisiteur.Clear();
            txtCodePostalVisiteur.Clear();
            txtNomVisiteur.Clear();
            txtPrenomVisiteur.Clear();
            txtVilleVisiteur.Clear();
            CalendrierDateEmbauche.SetDate(DateTime.Now);
            cboxCPRechercher.Enabled = true;
            cboxNPVisiteurRechercher.Enabled = true;
            cboxVilleRechercher.Enabled = true;
        }

        /// <summary>
        /// Remplis le dgv
        /// </summary>
        public void dgvFormulaireVisiteur()
        {
            //Nettoie les lignes du dgv
            dgwVisiteur.Rows.Clear();

            // On va chercher la liste des visiteurs
            List<ClasseVisiteur> unVisiteur = ClassePVisiteur.chargerLesVisiteurs();
            //On analyse chaque objet de la liste
            foreach (ClasseVisiteur lesVisiteurs in unVisiteur)
            {
                int leNb = lesVisiteurs.Id;
                string leNom = lesVisiteurs.Nom;
                string lePrenom = lesVisiteurs.Prenom;
                string ladresse = lesVisiteurs.Adresse;
                string leCodePostal = lesVisiteurs.Cp;
                string laVille = lesVisiteurs.Ville;
                DateTime laDate = lesVisiteurs.DateEmbauche;

                //Ajoute une ligne au dgv
                dgwVisiteur.Rows.Add(leNb, leNom, lePrenom, ladresse, leCodePostal, laVille, laDate);
            }
        }

        private void btnRechercheVis_Click(object sender, EventArgs e)
        {
            // Clear les boxs
            dgwVisiteur.Rows.Clear();
            cboxNPVisiteurRechercher.Items.Clear();
            cboxCPRechercher.Items.Clear();
            cboxVilleRechercher.Items.Clear();
            cboxVilleRechercher.Text = "";
            cboxNPVisiteurRechercher.Text = "";
            cboxCPRechercher.Text = "";
            //Afficher
            grpboxCPRechercher.Visible = true;
            grpboxNPVisiteurRecherche.Visible = true;
            grpboxVilleRecherche.Visible = true;
            btn_Reinitialiser.Visible = true;

            //Cacher
            buttonAjouterVisiteur.Visible = false;
            buttonSupprimerVisiteur.Visible = false;
            buttonModifierVisiteur.Visible = false;
            btnRechercheVis.Visible = false;

            cboxNPVisiteurRechercher.Items.Add("");
            cboxCPRechercher.Items.Add("");
            cboxVilleRechercher.Items.Add("");

            // Cherche les visiteurs
            List<ClasseVisiteur> ChargerNomsVisiteurs = ClassePVisiteur.chargerLesVisiteurs();
            // Boucle qui scrute les visiteurs
            foreach (ClasseVisiteur leNomPrenom in ChargerNomsVisiteurs)
            {
                // Assigne les variables 
                string id = leNomPrenom.Id.ToString();
                string NomVisiteur = leNomPrenom.Nom;
                string PrenomVisiteur = leNomPrenom.Prenom;
                // Regroupe les variables en une
                string LesVisiteurs = (id + "   " + NomVisiteur + " - " + PrenomVisiteur);
                // Les insèrent dans la combobox
                cboxNPVisiteurRechercher.Items.Add(LesVisiteurs);
                
                // Récupère la ville
                string ville = leNomPrenom.Ville;
                // Gère si les villes sont écrites plusieurs fois
                if (!cboxVilleRechercher.Items.Contains(ville))
                {
                    // Les insèrent dans la combobox
                    cboxVilleRechercher.Items.Add(ville);
                }

                // Récupère le CP
                int cp = int.Parse(leNomPrenom.Cp);
                // Gère si les CP sont écrits plusieurs fois
                if (!cboxCPRechercher.Items.Contains(cp))
                {
                    // Les insèrent dans la combobox
                    cboxCPRechercher.Items.Add(cp);
                }
            }
        }

        private void cboxNPVisiteurRechercher_TextChanged(object sender, EventArgs e)
        {
            // Clear le DGV
            dgwVisiteur.Rows.Clear();
            // Vérifie que la combobox soit vide
            if (cboxNPVisiteurRechercher.Text == "")
            {
                // Permet la saisie dans les autres combobox
                cboxVilleRechercher.Enabled = true;
                cboxCPRechercher.Enabled = true;
            }
            else
            {
                // Empêche la saisie dans les autres combobox
                cboxVilleRechercher.Enabled = false;
                cboxCPRechercher.Enabled = false;
                // Récupère l'id 
                int id = int.Parse(cboxNPVisiteurRechercher.Text.Substring(0, 3));
                // Cherche le visiteur avec l'id "id"
                ClasseVisiteur LeVisiteur = ClassePVisiteur.chargerLeVisiteur(id);
                // récupère les variables 
                int leNb = LeVisiteur.Id;
                string leNom = LeVisiteur.Nom;
                string lePrenom = LeVisiteur.Prenom;
                string ladresse = LeVisiteur.Adresse;
                string leCodePostal = LeVisiteur.Cp;
                string laVille = LeVisiteur.Ville;
                DateTime laDate = LeVisiteur.DateEmbauche;
                // Insère les variables dans le DGV
                dgwVisiteur.Rows.Add(leNb, leNom, lePrenom, ladresse, leCodePostal, laVille, laDate);
            }
        }

        private void cboxVilleRechercher_TextChanged(object sender, EventArgs e)
        {
            // Clear le DGV
            dgwVisiteur.Rows.Clear();
            // Vérifie que la combobox soit vide
            if (cboxVilleRechercher.Text == "")
            {
                // Permet la saisie dans les autres combobox
                cboxNPVisiteurRechercher.Enabled = true;
                cboxCPRechercher.Enabled = true;
            }
            else
            {
                // Empêche la saisie dans les autres combobox
                cboxNPVisiteurRechercher.Enabled = false;
                cboxCPRechercher.Enabled = false;
                // Cherche le visiteur avec la ville correspondante
                List<ClasseVisiteur> LesVisiteurs = ClassePVisiteur.chargerLeVille(cboxVilleRechercher.Text);
                foreach (ClasseVisiteur leVisiteur in LesVisiteurs)
                {
                    // Récupère les variables 
                    int leNb = leVisiteur.Id;
                    string leNom = leVisiteur.Nom;
                    string lePrenom = leVisiteur.Prenom;
                    string ladresse = leVisiteur.Adresse;
                    string leCodePostal = leVisiteur.Cp;
                    string laVille = leVisiteur.Ville;
                    DateTime laDate = leVisiteur.DateEmbauche;
                    // Ajoute dans le DGV
                    dgwVisiteur.Rows.Add(leNb, leNom, lePrenom, ladresse, leCodePostal, laVille, laDate);
                }
            }
        }

        private void cboxCPRechercher_TextChanged(object sender, EventArgs e)
        {
            // Clear le DGV
            dgwVisiteur.Rows.Clear();
            // Vérifie que la combobox soit vide
            if (cboxCPRechercher.Text == "")
            {
                // Permet la saisie dans les autres combobox
                cboxVilleRechercher.Enabled = true;
                cboxNPVisiteurRechercher.Enabled = true;
            }
            else
            {
                // Cherche le visiteur avec la ville correspondante
                List<ClasseVisiteur> LesVisiteurs = ClassePVisiteur.chargerLeCp(cboxCPRechercher.Text);
                foreach (ClasseVisiteur leVisiteur in LesVisiteurs)
                {
                    // Récupère les variables 
                    int leNb = leVisiteur.Id;
                    string leNom = leVisiteur.Nom;
                    string lePrenom = leVisiteur.Prenom;
                    string ladresse = leVisiteur.Adresse;
                    string leCodePostal = leVisiteur.Cp;
                    string laVille = leVisiteur.Ville;
                    DateTime laDate = leVisiteur.DateEmbauche;
                    // Ajoute dans le DGV
                    dgwVisiteur.Rows.Add(leNb, leNom, lePrenom, ladresse, leCodePostal, laVille, laDate);
                }
                // Empêche la saisie dans les autres combobox
                cboxVilleRechercher.Enabled = false;
                cboxNPVisiteurRechercher.Enabled = false;
            }
            

        }
    }
}
