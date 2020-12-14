using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ClasseMétiers;
using Formulaire;

namespace ClassePasserelle
{
    public class ClassePRapport
    {
        // procédure qui modifie un rapport 
        public static void modifRapport(int idRap, DateTime dateRap, string motifRap, string bilanRap, int idVisiteurRap, int idMedecinRAp)
        {
            SqlConnection connexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            cmd.CommandText = "UPDATE rapport SET dateRap = '"+ dateRap + "', motifRap = '" + motifRap + "', bilanRap = '" + bilanRap + "', idVisiteurRap = '" + idVisiteurRap + "', idMedecinRap = '" + idMedecinRAp + "' WHERE idRap = '" + idRap + "' ";
            SqlDataReader drr = cmd.ExecuteReader();
            drr.Close();
            connexion.Close();
        }

        // procédure qui supprime un rapport grace a l'id 
        public static void supprimerRapport(int idRap)
        {
            SqlConnection connexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            cmd.CommandText = "DELETE FROM 'rapport' WHERE idRap = '" + idRap + "' ";
            SqlDataReader drr = cmd.ExecuteReader();
            drr.Close();
            connexion.Close();
        }

        // procédure qui ajoute un rapport 
        public static void ajoutRapport(int idRap, DateTime dateRap, string motifRap, string bilanRap, int idVisiteurRap, int idMedecinRAp)
        {
            SqlConnection connexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            cmd.CommandText = "DELETE FROM 'rapport' WHERE idRap = '" + idRap + "' ";
            SqlDataReader drr = cmd.ExecuteReader();
            drr.Close();
            connexion.Close();
        }

        public static ClasseRapport ChargerLesRapport()
        {
            List<ClasseRapport> lesRapport = new List<ClasseRapport>();
            int unId;
            DateTime uneDate;
            string unMotif;
            string unBilan;
            ClasseVisiteur leVisiteur;
            ClasseMedecin leMedecin;
            List<ClasseEchantillonOffert> lesEchantillonsOfferts;

            SqlConnection connexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();

            cmd.CommandText = "SELECT idRap, nomVis, prenomVis, dateRap, motifRap, bilanRap, nomMed, prenomMed FROM `rapport` inner join visiteur on idVisiteurRap = idVisiteurRap inner join medecin on idMedecinRap = idMedecinRap WHERE idVis = idVisiteurRap AND idMed = idMedecinRap";

            SqlDataReader drr = cmd.ExecuteReader();

            while (drr.Read())
            {
                unId = drr.GetInt32(0);
                uneDate = drr.GetDateTime(3);
                unMotif = drr.GetString(4);
                unBilan = drr.GetString(5);

                lesRapport.Add(new ClasseRapport(unId, uneDate, unMotif, unBilan, leVisiteur, leMedecin, lesEchantillonsOfferts));
            }
            drr.Close();
            connexion.Close();

            return lesRapport;
        }
    }
}
