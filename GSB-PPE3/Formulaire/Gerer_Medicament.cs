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
    public partial class Gerer_Medicament : Form
    {
        public Gerer_Medicament()
        {
            InitializeComponent();
        }

        private void Gerer_Medicament_Load(object sender, EventArgs e)
        {
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
    }
}
