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
        public static void SupprimerVisiteur(string lid)
        {
            SqlConnection connexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            cmd.CommandText = "DELETE FROM `visiteur` WHERE `visiteur`.`idVis` = '"+ lid+"'";
            SqlDataReader drr = cmd.ExecuteReader();
            drr.Close();
            connexion.Close();
        }
        public static List<ClasseVisiteur> chargerLesVisiteurs()
        {
            List<ClasseVisiteur> LesVisiteurs = new List<ClasseVisiteur>();
            string id;
            string nom;
            string prenom;
            string adresse;
            string login;
            string mdp;
            string cp;
            string ville;
            DateTime dateEmbauche;

            SqlConnection connexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            cmd.CommandText = "SELECT nomVis, prenomVis, loginVis, mdpVis, adresseVis, cpVis, villeVis, dateEmbaucheVis, idVis " +
                              "FROM visiteur ";
            SqlDataReader drr = cmd.ExecuteReader();

            while (drr.Read())
            {
                nom = drr.GetString(0);
                prenom = drr.GetString(1);
                login = drr.GetString(2);
                mdp = drr.GetString(3);
                adresse = drr.GetString(4);
                cp = drr.GetString(5);
                ville = drr.GetString(6);
                dateEmbauche = drr.GetDateTime(7);
                id = drr.GetString(8);
                ClasseVisiteur leVisiteur = new ClasseVisiteur(id, nom, prenom, adresse, login, mdp, cp, ville, dateEmbauche);
                LesVisiteurs.Add(leVisiteur);
            }

            drr.Close();
            connexion.Close();

            return LesVisiteurs;
        }
    }
}
