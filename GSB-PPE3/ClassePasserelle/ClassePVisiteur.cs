using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ClasseMétiers;

namespace ClassePasserelle
{
    public class ClassePVisiteur
    {
        public static void AjoutVisiteur(string lenom, string leprenom, string ladresse, string lelogin, string lemdp, string lecp, string laville, DateTime ladateEmbauche)
        {
            SqlConnection connexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            cmd.CommandText = "INSERT INTO `visiteur` (`nomVis`, `prenomVis`, `loginVis`, `mdpVis`, `adresseVis`, `cpVis`, `villeVis`, `dateEmbaucheVis`) " +
                                "VALUES ('"+ lenom + "', '" + leprenom + "', '" + lelogin + "', '" + lemdp + "', '" + ladresse + "', '" + lecp + "', '" + laville + "', '" + ladateEmbauche + "');";
            SqlDataReader drr = cmd.ExecuteReader();
            drr.Close();
            connexion.Close();
        }
        public static void ModifVisiteur(string lid, string lenom, string leprenom, string ladresse, string lelogin, string lemdp, string lecp, string laville, DateTime ladateEmbauche)
        {
            SqlConnection connexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            cmd.CommandText = "UPDATE `visiteur` SET `nomVis` = '" + lenom + "', `prenomVis` = '" + lelogin + "', `loginVis` = '" + lelogin + "', `mdpVis` = '" + lemdp + "', `adresseVis` = '" + ladresse + "', `cpVis` = '" + lecp + "', `villeVis` = '" + laville + "', `dateEmbaucheVis` = '" + ladateEmbauche + "' WHERE `visiteur`.`idVis` = '" + lid + "'; ";
            SqlDataReader drr = cmd.ExecuteReader();
            drr.Close();
            connexion.Close();
        }
        public static void SupprimerVisiteur()
        {

        }
        public static ClasseVisiteur chargerLesVisiteurs()
        {
            return ();
        }
    }
}
