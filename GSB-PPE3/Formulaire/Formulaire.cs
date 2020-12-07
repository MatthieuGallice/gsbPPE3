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
            accueilForm.Show();
        }

        // affichage rapport
        private void rapportMenuStrip_Click(object sender, EventArgs e)
        {
            Rapport rapportForm = new Rapport();
            rapportForm.MdiParent = this;
            rapportForm.Show();
        }

        private void visiteurMenuStrip_Click(object sender, EventArgs e)
        {
            Visiteur visiteurForm = new Visiteur();
            visiteurForm.MdiParent = this;
            visiteurForm.Show();
        }

        private void medecinMenuStrip_Click(object sender, EventArgs e)
        {
            Medecin medecinForm = new Medecin();
            medecinForm.MdiParent = this;
            medecinForm.Show();
        }

        private void gérerMédicamentMenuStrip_Click(object sender, EventArgs e)
        {
            Gerer_Medicament gerer_medecinForm = new Gerer_Medicament();
            gerer_medecinForm.MdiParent = this;
            gerer_medecinForm.Show();
        }

        private void listeMédicamentMenuStrip_Click(object sender, EventArgs e)
        {
            Liste_Medicament liste_medecinForm = new Liste_Medicament();
            liste_medecinForm.MdiParent = this;
            liste_medecinForm.Show();
        }

        private void aProposMenuStrip_Click(object sender, EventArgs e)
        {
            A_Propos AProposForm = new A_Propos();
            AProposForm.MdiParent = this;
            AProposForm.Show();
        }
    }
}
