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

        // AU CHARGEMENT DE LA PAGE
        private void Medecin_Load(object sender, EventArgs e)
        {
            //AFFICHAGE DATAGRIDVIEW
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

            // AFFICHAGE SPECIALITE COMBOBOX
            List<ClasseSpecialite> lesSpe = new List<ClasseSpecialite>();
            lesSpe = ClassePSpecialite.chargerLesSpecialite();

            comboBoxSpecialite.Items.Clear();
            comboBoxSpecialite.Items.Add("-----------------------------------------------------------------------------------------------");
            comboBoxSpecialite.SelectedItem = "-----------------------------------------------------------------------------------------------";

            foreach (ClasseSpecialite spe in lesSpe)
            {
                comboBoxSpecialite.Items.Add(spe.Specialite.ToString());
            }

        }

        // BOUTON MODIFIER
        private void buttonModifierMedecin_Click(object sender, EventArgs e)
        {
            if (dgwMedecin.CurrentRow.Selected)
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

                // INSTANCIATION DE LA SPECIALITE
                string laSpe = dgwMedecin.CurrentRow.Cells[4].Value.ToString();
                ClasseSpecialite instanSpe = new ClasseSpecialite();



                if (laSpe == "Généraliste")
                {
                    instanSpe = new ClasseSpecialite("1", "Généraliste");
                }
                else if (laSpe == "Spécialiste")
                {
                    instanSpe = new ClasseSpecialite("2", "Spécialiste");
                }
                else if (laSpe == "Service Hospitalier")
                {
                    instanSpe = new ClasseSpecialite("3", "Service Hospitalier");
                }
                else if (laSpe == "Infirmier")
                {
                    instanSpe = new ClasseSpecialite("4", "Infirmier");
                }
                else if (laSpe == "Pharmacien")
                {
                    instanSpe = new ClasseSpecialite("5", "Pharmacien");
                }

                // INSTANCIATION
                ClasseMedecin modifier = new ClasseMedecin(getId.ToString(), dgwMedecin.CurrentRow.Cells[0].Value.ToString(), dgwMedecin.CurrentRow.Cells[1].Value.ToString(), dgwMedecin.CurrentRow.Cells[2].Value.ToString(), dgwMedecin.CurrentRow.Cells[3].Value.ToString(), int.Parse(dgwMedecin.CurrentRow.Cells[5].Value.ToString()), instanSpe);

                // PLACEMENT DANS LES TEXTBOX ET SELECTION DANS LE COMBOBOX
                txtNomMedecin.Text = modifier.Nom;
                txtPrenomMedecin.Text = modifier.Prenom;
                txtTelMedecin.Text = modifier.Tel;
                txtAdresseMedecin.Text = modifier.Adresse;
                txtDepartementMedecin.Text = modifier.Departement.ToString();
                comboBoxSpecialite.SelectedItem = laSpe;

                connexion.Close();
            }
            else
            {
                MessageBox.Show("Sélectionner un médecin dans le tableau !");
            }

        }

        // BOUTON SUPPRIMER
        private void buttonSupprimerMedecin_Click(object sender, EventArgs e)
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

            if (MessageBox.Show("êtes vous sur de vouloir supprimer " + leNom + " " + lePrenom + " ?", "advertissement ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ClassePMedecin.SupprimerMedecin(getId.ToString());

                ClassePMedecin.chargerLesMedecins();
            }
        }
    }
}
