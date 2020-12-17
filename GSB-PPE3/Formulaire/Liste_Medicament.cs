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
            List<ClasseMedicament> lesMedicaments = ClassePMedicament.chargerLesMedicaments();
            foreach (ClasseMedicament leMedicament in lesMedicaments)
            {
                dgwListeMedicament.Rows.Add(leMedicament.Famille);
            }
        }
    }
}
