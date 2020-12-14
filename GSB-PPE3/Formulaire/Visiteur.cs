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
    public partial class Visiteur : Form
    {
        public Visiteur()
        {
            InitializeComponent();
        }

        private void Visiteur_Load(object sender, EventArgs e)
        {
            List<ClasseVisiteur> unVisiteur = ClassePVisiteur.chargerLesVisiteurs();
            foreach(ClasseVisiteur lesVisiteurs in unVisiteur)
            {
                string leNb = lesVisiteurs.Id;
                string leNom = lesVisiteurs.Nom;
                string lePrenom = lesVisiteurs.Prenom;
                string ladresse = lesVisiteurs.Adresse;
                string leCodePostal = lesVisiteurs.Cp;
                string laVille = lesVisiteurs.Ville;
                DateTime laDate = lesVisiteurs.DateEmbauche;

                dgwVisiteur.Rows.Add(leNb, leNom, lePrenom, ladresse, leCodePostal, laVille, laDate);
            }

        }
    }
}
