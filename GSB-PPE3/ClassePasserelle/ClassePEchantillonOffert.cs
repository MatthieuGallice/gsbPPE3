using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ClasseMétiers;

namespace ClassePasserelle
{
    public class ClassePEchantillonOffert
    {
        #region INSERT
        public static void AjoutEchantillonOffert(string idRapport, string idMedicament, string quantite)
        {
            //CONNEXION BDD
            SqlConnection connexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            //REQUETE SQL
            cmd.CommandText = "INSERT INTO offrir (`idRapportOff`, `idMedicamentOff`, `quantiteOff`) " +
                              "VALUES ('"+ idRapport + "', '" + idMedicament + "', '" + quantite + "');";
            //EXECUTION REQUETE
            SqlDataReader drr = cmd.ExecuteReader();
            drr.Close();
            connexion.Close();
        }
        #endregion

        #region UPDATE
        public static void ModifEchantillonOffert(string idRapport, string idMedicament, string quantite)
        {
            //CONNEXION BDD
            SqlConnection connexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            //REQUETE SQL
            cmd.CommandText = "UPDATE offrir " +
                              "SET idRapportOff = '"+ idRapport + "', idMedicamentOff = '" + idMedicament + "', quantiteOff = '" + quantite + "'; ";
            //EXECUTION REQUETE
            SqlDataReader drr = cmd.ExecuteReader();
            drr.Close();
            connexion.Close();
        }
        #endregion

        #region DELETE
        public static void SupprimerEchantillonOffert(string idRapport, string idMedicament)
        {
            //CONNEXION BDD
            SqlConnection connexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            //REQUETE SQL
            cmd.CommandText = "DELETE FROM offrir " +
                              "WHERE offrir.idRapportOff = '" + idRapport + "' && offrir.idMedicamentOff = '" + idMedicament + "'";
            //EXECUTE LA REQUETE
            SqlDataReader drr = cmd.ExecuteReader();
            drr.Close();
            connexion.Close();
        }
        #endregion

        #region ChargerLesEchantillonsOfferts 
        public static List<ClasseEchantillonOffert> chargerLesEchantillonOffert()
        {
            //VARIABLES
            List<ClasseEchantillonOffert> LesEchantillonsOffert = new List<ClasseEchantillonOffert>();
            string idRapport;
            string idMedicament;
            int quantite;

            //CONNEXION BDD
            SqlConnection connexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            //REQUETE SQL
            cmd.CommandText = "SELECT idRapportOff, idMedicamentOff, quantiteOff " +
                              "FROM offrir ";
            //EXECUTE LA REQUETE
            SqlDataReader drr = cmd.ExecuteReader();
            
            //LECTURE DE LA REQUETE
            while (drr.Read())
            {
                //ON RECUPERE LES VARIABLES
                idRapport = drr.GetString(0);
                idMedicament = drr.GetString(1);
                quantite = drr.GetInt16(2);
                //On récupère la liste des médicaments avec la méthode chargerLesMedicaments
                List<ClasseMedicament> lesMedicaments = ClassePMedicament.chargerLesMedicaments();


                // Instancie un échantillon 
                ClasseEchantillonOffert lEchantillon = new ClasseEchantillonOffert(quantite, lesMedicaments);

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
