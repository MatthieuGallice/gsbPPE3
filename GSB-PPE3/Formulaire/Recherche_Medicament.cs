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
    public partial class Recherche_Medicament : Form
    {
        string comboNonChoisi = "----------------";
        public Recherche_Medicament()
        {
            InitializeComponent();
        }

        private void Recherche_Mecicament_Load(object sender, EventArgs e)
        {
            //Affichage Combobox Nom Medicament 
            List<ClasseMedicament>lesmedicaments  = new List<ClasseMedicament>();
            lesmedicaments = ClassePMedicament.chargerLesMedicaments();

            comboBoxRechercheNom_Medicament.Items.Clear();
            comboBoxRechercheNom_Medicament.Items.Add(comboNonChoisi);
            comboBoxRechercheNom_Medicament.SelectedIndex = 0;

            foreach (ClasseMedicament medic in lesmedicaments)
            {
                comboBoxRechercheNom_Medicament.Items.Add(medic.NomCommercial.ToString());
            }


            // AFFICHAGE FAMILLE COMBOBOX
            List<ClasseFamille> lesFamille = new List<ClasseFamille>();
            lesFamille = ClassePFamille.chargerLesFamilles();

            comboBoxRecherchefam_Medicament.Items.Clear();
            comboBoxRecherchefam_Medicament.Items.Add(comboNonChoisi);
            comboBoxRecherchefam_Medicament.SelectedIndex=0;

            foreach (ClasseFamille famille in lesFamille)
            {
                comboBoxRecherchefam_Medicament.Items.Add(famille.Libelle.ToString());
            }

        }

        private void dgwRechercheMedicament_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           //Mettre dans le datagred la liste de la famille ou des noms des Médicaments .
           //et les afficher par la suite .
        }
    }
}
