using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ClasseMétiers;

namespace ClassePasserelle
{
    public class ClassePVisiteur
    {
        #region INSERT
        public static void AjoutVisiteur(string lenom, string leprenom, string ladresse, string lelogin, string lemdp, string lecp, string laville, DateTime ladateEmbauche)
        {
            // CONNEXION BDD
            MySqlConnection connexion = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            //REQUETE SQL
            cmd.CommandText = "INSERT INTO `visiteur` (`nomVis`, `prenomVis`, `loginVis`, `mdpVis`, `adresseVis`, `cpVis`, `villeVis`, `dateEmbaucheVis`) " +
                                "VALUES ('"+ lenom + "', '" + leprenom + "', '" + lelogin + "', '" + lemdp + "', '" + ladresse + "', '" + lecp + "', '" + laville + "', '" + ladateEmbauche + "');";
            //EXECUTION REQUETE
            MySqlDataReader drr = cmd.ExecuteReader();
            drr.Close();
            connexion.Close();
        }
        #endregion

        #region UPDATE
        public static void ModifVisiteur(string lid, string lenom, string leprenom, string ladresse, string lelogin, string lemdp, string lecp, string laville, DateTime ladateEmbauche)
        {
            //CONNEXION BDD
            MySqlConnection connexion = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            //REQUETE SQL
            cmd.CommandText = "UPDATE `visiteur` SET `nomVis` = '" + lenom + "', `prenomVis` = '" + lelogin + "', `loginVis` = '" + lelogin + "', `mdpVis` = '" + lemdp + "', `adresseVis` = '" + ladresse + "', `cpVis` = '" + lecp + "', `villeVis` = '" + laville + "', `dateEmbaucheVis` = '" + ladateEmbauche + "' WHERE `visiteur`.`idVis` = '" + lid + "'; ";
            //EXECUTION REQUETE SQL
            MySqlDataReader drr = cmd.ExecuteReader();
            drr.Close();
            connexion.Close();
        }
        #endregion

        #region DELETE
        public static void SupprimerVisiteur(string lid)
        {
            //CONNEXION BDD
            MySqlConnection connexion = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();
            
            cmd = connexion.CreateCommand();
            //REQUETE SQL
            cmd.CommandText = "DELETE FROM `visiteur` WHERE `visiteur`.`idVis` = '"+ lid +"'";
            //EXECUTION REQUETE SQL
            MySqlDataReader drr = cmd.ExecuteReader();
            drr.Close();
            connexion.Close();
        }
        #endregion

        #region ChargerLeVisiteur
        public static ClasseVisiteur chargerLeVisiteur(string lid)
        {
            // variables
            string id;
            string nom;
            string prenom;
            string adresse;
            string login;
            string mdp;
            string cp;
            string ville;
            DateTime dateEmbauche;
            ClasseVisiteur leVisiteur = new ClasseVisiteur();

            //Connexion BDD
            MySqlConnection connexion = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            //REQUETE SQL
            cmd.CommandText = "SELECT nomVis, prenomVis, loginVis, mdpVis, adresseVis, cpVis, villeVis, dateEmbaucheVis, idVis " +
                              "FROM visiteur " +
                              "WHERE idVis = '"+ lid +"'";
            //EXECUTION REQUETE SQL
            MySqlDataReader drr = cmd.ExecuteReader();

            //LECTURE REQUETE
            while (drr.Read())
            {
                //ON RECUPERE LES VARIABLES
                nom = drr.GetString(0);
                prenom = drr.GetString(1);
                login = drr.GetString(2);
                mdp = drr.GetString(3);
                adresse = drr.GetString(4);
                cp = drr.GetString(5);
                ville = drr.GetString(6);
                dateEmbauche = drr.GetDateTime(7);
                id = drr.GetString(8);

                //On instancie un objet ClasseVisiteur
                leVisiteur = new ClasseVisiteur(id, nom, prenom, adresse, login, mdp, cp, ville, dateEmbauche);
            }

            drr.Close();
            connexion.Close();

            return leVisiteur;
        }
        #endregion

        #region chargerLesVisiteurs
        public static List<ClasseVisiteur> chargerLesVisiteurs()
        {
            //VARIABLES
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

            //CONNEXION BDD
            MySqlConnection connexion = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            connexion.ConnectionString = "SERVER=localhost;Initial Catalog=gsbppe3; UID = root; PASSWORD =''";

            connexion.Open();

            cmd = connexion.CreateCommand();
            //REQUETE SQL
            cmd.CommandText = "SELECT nomVis, prenomVis, loginVis, mdpVis, adresseVis, cpVis, villeVis, dateEmbaucheVis, idVis " +
                              "FROM visiteur ";
            //EXECUTION REQUETE
            MySqlDataReader drr = cmd.ExecuteReader();

            //LECTURE REQUETE
            while (drr.Read())
            {
                //ON RECUPERE LES VARIABLES
                nom = drr.GetString(0);
                prenom = drr.GetString(1);
                login = drr.GetString(2);
                mdp = drr.GetString(3);
                adresse = drr.GetString(4);
                cp = drr.GetString(5);
                ville = drr.GetString(6);
                dateEmbauche = drr.GetDateTime(7);
                id = drr.GetString(8);

                //ON INSTANCIE UN OBJET CLASSEVISITEUR
                ClasseVisiteur leVisiteur = new ClasseVisiteur(id, nom, prenom, adresse, login, mdp, cp, ville, dateEmbauche);
                //ON L'AJOUTE A UNE LISTE DE VISITEURS
                LesVisiteurs.Add(leVisiteur);
            }

            drr.Close();
            connexion.Close();

            return LesVisiteurs;
        }
        #endregion
    }
}
