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

        // FONCTION QUI REMPLIS LE DGW 
        public void dgvFormulaireVisiteur()
        {
            dgwVisiteur.Rows.Clear();

            List<ClasseVisiteur> unVisiteur = ClassePVisiteur.chargerLesVisiteurs();
            foreach (ClasseVisiteur lesVisiteurs in unVisiteur)
            {
                int leNb = lesVisiteurs.Id;
                string leNom = lesVisiteurs.Nom;
                string lePrenom = lesVisiteurs.Prenom;
                string ladresse = lesVisiteurs.Adresse;
                string leCodePostal = lesVisiteurs.Cp;
                string laVille = lesVisiteurs.Ville;
                DateTime laDate = lesVisiteurs.DateEmbauche;

                dgwVisiteur.Rows.Add(leNb, leNom, lePrenom, ladresse, leCodePostal, laVille, laDate);
            }
        }

        // AU CHARGEMENT DE LA PAGE
        private void Visiteur_Load(object sender, EventArgs e)
        {
            dgvFormulaireVisiteur();
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
                CalendrierDateEmbauche.SelectionRange.Start = modifier.DateEmbauche;
                txtCodePostalVisiteur.Text = modifier.Cp;
                txtVilleVisiteur.Text = modifier.Ville;
                txtAdresseVisiteur.Text = modifier.Adresse;
            }
            else
            {
                MessageBox.Show("Sélectionner un visiteur dans le tableau !");
            }
        }

        private void buttonValiderModificationVisiteur_Click(object sender, EventArgs e)
        {

        }

        private void buttonSupprimerVisiteur_Click(object sender, EventArgs e)
        {

        }

        private void buttonAjouterVisiteur_Click(object sender, EventArgs e)
        {

        }
    }
}
