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
    public partial class Liste_Medicament : Form
    {
        public Liste_Medicament()
        {
            InitializeComponent();
        }

        private void Liste_Medicament_Load(object sender, EventArgs e)
        {
            ChargerLeDGV();

        }

        private void ChargerLeDGV()
        {
            //Charge tout les rapports
            List<ClasseRapport> lesRapports = ClassePRapport.chargerLesRapports();
            foreach (ClasseRapport leRapport in lesRapports)
            {
                //Récupère l'id du rapport
                int numrapport = leRapport.Id;
                //Charge les échantillons du rapport
                List<ClasseEchantillonOffert> lEchantillonOffert = ClassePEchantillonOffert.chargerLEchantillonOffert(numrapport);
                foreach (ClasseEchantillonOffert unEchantillon in lEchantillonOffert)
                {
                    //Récupère les données 
                    int quantiteOff = unEchantillon.Quantite;
                    int numMedic = unEchantillon.LeMedicament.Id;
                    string nomCommercial = unEchantillon.LeMedicament.NomCommercial;
                    // Insère les données dans le DGV
                    dgwListeMedicament.Rows.Add(numrapport, numMedic, nomCommercial, quantiteOff);
                }
            }
        }
    }
}
