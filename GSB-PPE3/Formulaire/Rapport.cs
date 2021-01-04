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
        public Rapport()
        {
            InitializeComponent();
        }

        private void Rapport_Load(object sender, EventArgs e)
        {
            List<ClasseRapport> unRapport = ClassePRapport.chargerLesRapports();
            foreach (ClasseRapport lesRapports in unRapport)
            {
                int leNb = lesRapports.Id;
                string nomVisiteur = lesRapports.LeVisiteur.Nom;
                string prenomVisiteur = lesRapports.LeVisiteur.Prenom;
                string laDate = lesRapports.Date.ToString();
                string leMotif = lesRapports.Motif;
                string leBilan = lesRapports.Bilan;
                string nomMedecin = lesRapports.LeMedecin.Nom;
                string prenomMedecin = lesRapports.LeMedecin.Prenom;

                dgwRapport.Rows.Add(leNb, nomVisiteur, prenomVisiteur, laDate, leMotif, leBilan, nomMedecin, prenomMedecin);
            }
        }
    }
}
