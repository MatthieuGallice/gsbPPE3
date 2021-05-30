using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulaire
{
    public partial class Formulaire : Form
    {
        public Formulaire()
        {
            InitializeComponent();
        }
        
        // affichage accueil 
        private void accueilMenuStrip_Click(object sender, EventArgs e)
        {
            Accueil accueilForm = new Accueil();
            accueilForm.MdiParent = this;
            fermeForme();
            accueilForm.Show();
        }

        // affichage rapport
        private void rapportMenuStrip_Click(object sender, EventArgs e)
        {
            Rapport rapportForm = new Rapport();
            rapportForm.MdiParent = this;
            fermeForme();
            rapportForm.Show();
        }

        // affichage visiteurs
        private void visiteurMenuStrip_Click(object sender, EventArgs e)
        {
            Visiteur visiteurForm = new Visiteur();
            visiteurForm.MdiParent = this;
            fermeForme();
            visiteurForm.Show();
        }

        // affichage medecin
        private void medecinMenuStrip_Click(object sender, EventArgs e)
        {
            Medecin medecinForm = new Medecin();
            medecinForm.MdiParent = this;
            fermeForme();
            medecinForm.Show();
        }


        // affichage de à propos
        private void aProposMenuStrip_Click(object sender, EventArgs e)
        {
            A_Propos AProposForm = new A_Propos();
            AProposForm.MdiParent = this;
            fermeForme();
            AProposForm.Show();
        }

        // méthode qui récupére la collection de formulaire et qui regarde si au moins un et ouvert et les ferme
        public void fermeForme()
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
        }

        private void listeMedecinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Medecin medecinForm = new Medecin();
            medecinForm.MdiParent = this;
            fermeForme();
            medecinForm.Show();
        }


        // affichage gérer les médicaments
        private void medicamentMenuStrip_Click(object sender, EventArgs e)
        {
            Gerer_Medicament gerer_medecinForm = new Gerer_Medicament();
            gerer_medecinForm.MdiParent = this;
            fermeForme();
            gerer_medecinForm.Show();
        }

    }
}
