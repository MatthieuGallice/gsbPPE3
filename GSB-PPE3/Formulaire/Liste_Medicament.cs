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
            List<ClasseRapport> lesRapports = ClassePRapport.chargerLesRapports();
            foreach (ClasseRapport leRapport in lesRapports)
            {
                int numrapport = leRapport.Id;
                List<ClasseEchantillonOffert> lEchantillonOffert = ClassePEchantillonOffert.chargerLEchantillonOffert(numrapport);
                foreach (ClasseEchantillonOffert unEchantillon in lEchantillonOffert)
                {
                    int quantiteOff = unEchantillon.Quantite;
                    string numMedic = unEchantillon.LeMedicament.Id;
                    string nomCommercial = unEchantillon.LeMedicament.NomCommercial;
                    dgwListeMedicament.Rows.Add(numrapport, numMedic, nomCommercial, quantiteOff);
                }
            }
        }
    }
}
