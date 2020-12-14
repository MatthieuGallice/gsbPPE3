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
        public static void AjoutEchantillonOffert(string idRapport, string idMedicament, string quantite)
        {
            SqlConnection connexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            cmd.CommandText = "INSERT INTO offrir (`idRapportOff`, `idMedicamentOff`, `quantiteOff`) " +
                              "VALUES ('"+ idRapport + "', '" + idMedicament + "', '" + quantite + "');";
            SqlDataReader drr = cmd.ExecuteReader();
            drr.Close();
            connexion.Close();
        }
        public static void ModifEchantillonOffert(string idRapport, string idMedicament, string quantite)
        {
            SqlConnection connexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            cmd.CommandText = "UPDATE offrir " +
                              "SET idRapportOff = '"+ idRapport + "', idMedicamentOff = '" + idMedicament + "', quantiteOff = '" + quantite + "'; ";
            SqlDataReader drr = cmd.ExecuteReader();
            drr.Close();
            connexion.Close();
        }
        public static void SupprimerEchantillonOffert(string idRapport, string idMedicament)
        {
            SqlConnection connexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            cmd.CommandText = "DELETE FROM offrir " +
                              "WHERE offrir.idRapportOff = '" + idRapport + "' && offrir.idMedicamentOff = '" + idMedicament + "'";
            SqlDataReader drr = cmd.ExecuteReader();
            drr.Close();
            connexion.Close();
        }
        public static List<ClasseEchantillonOffert> chargerLesEchantillonOffert()
        {
            List<ClasseEchantillonOffert> LesEchantillonsOffert = new List<ClasseEchantillonOffert>();
            string idRapport;
            string idMedicament;
            int quantite;

            SqlConnection connexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            cmd.CommandText = "SELECT idRapportOff, idMedicamentOff, quantiteOff " +
                              "FROM offrir ";
            SqlDataReader drr = cmd.ExecuteReader();

            while (drr.Read())
            {
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

        public static List<ClasseVisiteur> chargerLesEchantillonOffertRapports()
        {
            List<ClasseEchantillonOffert> LesEchantillonsOffert = new List<ClasseEchantillonOffert>();
            string idRapport;
            string idMedicament;
            int quantite;

            SqlConnection connexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            cmd.CommandText = "SELECT idRapportOff, idMedicamentOff, quantiteOff " +
                              "FROM offrir ";
            SqlDataReader drr = cmd.ExecuteReader();

            while (drr.Read())
            {
                idRapport = drr.GetString(0);
                idMedicament = drr.GetString(1);
                quantite = drr.GetInt16(2);
                //On récupère la liste des médicaments avec la méthode chargerLesMedicaments
                List<ClasseMedicament> lesMedicaments = ClassePMedicament.chargerLesMedicaments();
                //On récupère la liste des visiteurs avec la méthode chargerLesVisiteurs
                List<ClasseVisiteur> lesVisiteurs = ClassePVisiteur.chargerLesVisiteurs();
                //On récupère la liste des visiteurs avec la méthode chargerLesVisiteurs
                List<ClasseMedecin> lesMedecins = ClassePMedecin.chargerLesMedecins();

            
                // Instancie un échantillon 
                ClasseEchantillonOffert lEchantillon = new ClasseEchantillonOffert(quantite, lesMedicaments);

                // Instancie un rapport
                LesVisiteurs.Add(leVisiteur);
            }

            drr.Close();
            connexion.Close();

            return LesVisiteurs;
        }
    }
}
