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
    public partial class Medecin : Form
    {
        public Medecin modifier;
        public Medecin()
        {
            InitializeComponent();
        }

        private void Medecin_Load(object sender, EventArgs e)
        {
            List<ClasseMedecin> unMedecin = ClassePMedecin.chargerLesMedecins();
            foreach (ClasseMedecin lesMedecin in unMedecin)
            {
                string leNom = lesMedecin.Nom;
                string lePrenom = lesMedecin.Prenom;
                string ladresse = lesMedecin.Adresse;
                string leTel = lesMedecin.Tel;
                string laSpe = lesMedecin.LaSpecialite.Specialite;
                string leDepartement = lesMedecin.Departement.ToString();

                dgwMedecin.Rows.Add(leNom, lePrenom, ladresse, leTel, laSpe, leDepartement);
            }
        }

        private void buttonModifierMedecin_Click(object sender, EventArgs e)
        {
            /*if (dgwMedecin.CurrentRow.Selected)
            {
                // VARIABLE POUR LA REQUETE SQL 
                string leNom = dgwMedecin.CurrentRow.Cells[0].Value.ToString();
                string lePrenom = dgwMedecin.CurrentRow.Cells[1].Value.ToString();

                //CONNEXION BDD
                MySqlConnection connexion = new MySqlConnection();
                MySqlCommand getId = new MySqlCommand();
                connexion.ConnectionString = ClassePConnexion.DBConnection();

                connexion.Open();

                getId = connexion.CreateCommand();

                //REQUETE SQL
                getId.CommandText = "SELECT idMed " +
                                  "FROM medecin " +
                                  "WHERE nomMed = '" + leNom + "' " +
                                  "AND prenomMed = '" + lePrenom + "'";

                modifier = new ClasseMedecin(getId.ToString(), dgwMedecin.CurrentRow.Cells[0].Value.ToString(), dgwMedecin.CurrentRow.Cells[1].Value.ToString(), dgwMedecin.CurrentRow.Cells[2].Value.ToString(), dgwMedecin.CurrentRow.Cells[3].Value.ToString(), int.Parse(dgwMedecin.CurrentRow.Cells[4].Value.ToString()), dgwMedecin.CurrentRow.Cells[5].Value.ToString());

                txtNomMedecin.Text = modifier.Nom;
                txtPrenomMedecin.Text = modifier.Prenom;
                txtTelMedecin.Text = modifier.Tel;
                txtAdresseMedecin.Text = modifier.Adresse;
                txtDepartementMedecin.Text = modifier.Departement;
                comboBoxSpecialite.SelectedItem = modifier.ClasseSpecialite;
            }
            else
            {
                MessageBox.Show("Sélectionner un médecin dans le tableau !");
            }*/
        }
    }
}
