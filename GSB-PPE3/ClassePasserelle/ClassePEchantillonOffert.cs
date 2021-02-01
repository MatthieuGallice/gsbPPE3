using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ClasseMétiers;

namespace ClassePasserelle
{
    public class ClassePEchantillonOffert
    {
        #region INSERT
        public static void AjoutEchantillonOffert(int idRapport, int idMedicament, int quantite)
        {
            //CONNEXION BDD
            MySqlConnection connexion = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            //REQUETE SQL
            cmd.CommandText = "INSERT INTO offrir (`idRapportOff`, `idMedicamentOff`, `quantiteOff`) " +
                              "VALUES ('"+ idRapport + "', '" + idMedicament + "', '" + quantite + "');";
            //EXECUTION REQUETE
            MySqlDataReader drr = cmd.ExecuteReader();
            drr.Close();
            connexion.Close();
        }
        #endregion

        #region UPDATE
        public static void ModifEchantillonOffert(int idRapport, int idMedicament, int quantite)
        {
            //CONNEXION BDD
            MySqlConnection connexion = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            //REQUETE SQL
            cmd.CommandText = "UPDATE offrir " +
                              "SET idRapportOff = "+ idRapport + ", idMedicamentOff = " + idMedicament + ", quantiteOff = " + quantite + " " +
                              "WHERE  idRapportOff = " + idRapport + " AND idMedicamentOff = " + idMedicament + "";
            //EXECUTION REQUETE
            MySqlDataReader drr = cmd.ExecuteReader();
            drr.Close();
            connexion.Close();
        }
        #endregion

        #region DELETE
        public static void SupprimerEchantillonOffert(int idRapport, int idMedicament)
        {
            //CONNEXION BDD
            MySqlConnection connexion = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            //REQUETE SQL
            cmd.CommandText = "DELETE FROM offrir " +
                              "WHERE offrir.idRapportOff = '" + idRapport + "' && offrir.idMedicamentOff = '" + idMedicament + "'";
            //EXECUTE LA REQUETE
            MySqlDataReader drr = cmd.ExecuteReader();
            drr.Close();
            connexion.Close();
        }
        #endregion

        #region ChargerLeEchantillonsOffert selon rapport
        public static List<ClasseEchantillonOffert> chargerLEchantillonOffert(int idRapport)
        {
            //VARIABLES
            List<ClasseEchantillonOffert> LEchantillons = new List<ClasseEchantillonOffert>();
            int idMedicament;
            int quantite;

            //CONNEXION BDD
            MySqlConnection connexion = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            //REQUETE SQL
            cmd.CommandText = "SELECT idMedicamentOff, quantiteOff " +
                              "FROM offrir " +
                              "WHERE idRapportOff = '"+ idRapport + "'";
            //EXECUTE LA REQUETE
            MySqlDataReader drr = cmd.ExecuteReader();

            //LECTURE DE LA REQUETE
            while (drr.Read())
            {
                //ON RECUPERE LES VARIABLES
                idMedicament = drr.GetInt16(0);
                quantite = drr.GetInt16(1);
                //On récupère le médicaments avec la méthode chargerLeMedicament
                ClasseMedicament leMedicament = ClassePMedicament.chargerLeMedicament(idMedicament);


                // Instancie un échantillon 
                ClasseEchantillonOffert lEchantillon = new ClasseEchantillonOffert(quantite, leMedicament);
                // Ajoute un échantillon dans la liste
                LEchantillons.Add(lEchantillon);

            }

            drr.Close();
            connexion.Close();

            return LEchantillons;
        }
        #endregion

        #region ChargerLesEchantillonsOfferts 
        public static List<ClasseEchantillonOffert> chargerLesEchantillonOffert()
        {
            //VARIABLES
            List<ClasseEchantillonOffert> LesEchantillonsOffert = new List<ClasseEchantillonOffert>();
            int idRapport;
            int idMedicament;
            int quantite;

            //CONNEXION BDD
            MySqlConnection connexion = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            //REQUETE SQL
            cmd.CommandText = "SELECT idRapportOff, idMedicamentOff, quantiteOff " +
                              "FROM offrir ";
            //EXECUTE LA REQUETE
            MySqlDataReader drr = cmd.ExecuteReader();
            
            //LECTURE DE LA REQUETE
            while (drr.Read())
            {
                //ON RECUPERE LES VARIABLES
                idRapport = int.Parse(drr.GetString(0));
                idMedicament = int.Parse(drr.GetString(1));
                quantite = drr.GetInt16(2);
                //On récupère la liste des médicaments avec la méthode chargerLesMedicaments
                ClasseMedicament leMedicament = ClassePMedicament.chargerLeMedicament(idMedicament);


                // Instancie un échantillon 
                ClasseEchantillonOffert lEchantillon = new ClasseEchantillonOffert(quantite, leMedicament);

                // Instancie un rapport
                LesEchantillonsOffert.Add(lEchantillon);
            }

            drr.Close();
            connexion.Close();

            return LesEchantillonsOffert;
        }
        #endregion

    }
}
