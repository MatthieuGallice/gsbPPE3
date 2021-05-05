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
            //Conversion de la date
            string ladate = ladateEmbauche.ToString();
            String jour = ladate.Substring(0, 2);
            String mois = ladate.Substring(3, 2);
            String Ans = ladate.Substring(6, 4);
            string uneDate = Ans + "-" + mois + "-" + jour;


            // CONNEXION BDD
            MySqlConnection connexion = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            //REQUETE SQL
            cmd.CommandText = "INSERT INTO `visiteur` (`nomVis`, `prenomVis`, `loginVis`, `mdpVis`, `adresseVis`, `cpVis`, `villeVis`, `dateEmbaucheVis`) " +
                                "VALUES ('"+ lenom + "', '" + leprenom + "', '" + lelogin + "', '" + lemdp + "', '" + ladresse + "', '" + lecp + "', '" + laville + "', '" + uneDate + "');";
            //EXECUTION REQUETE
            MySqlDataReader drr = cmd.ExecuteReader();
            drr.Close();
            connexion.Close();
        }
        #endregion

        #region UPDATE
        public static void ModifVisiteur(int lid, string lenom, string leprenom, string ladresse, string lelogin, string lemdp, string lecp, string laville, DateTime ladateEmbauche)
        {
            //Conversion de la date
            string ladate = ladateEmbauche.ToString();
            String jour = ladate.Substring(0, 2);
            String mois = ladate.Substring(3, 2);
            String Ans = ladate.Substring(6, 4);
            string uneDate = Ans + "-" + mois + "-" + jour;
            

            //CONNEXION BDD
            MySqlConnection connexion = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            //REQUETE SQL
            cmd.CommandText = "UPDATE visiteur " +
                              "SET nomVis = '" + lenom + "', prenomVis = '" + leprenom + "', loginVis = '" + lelogin + "', mdpVis = '" + lemdp + "', adresseVis = '" + ladresse + "', cpVis = '" + lecp + "', villeVis = '" + laville + "', dateEmbaucheVis = '" + uneDate + "' " +
                              "WHERE visiteur.idVis = '" + lid + "'; ";
            //EXECUTION REQUETE SQL
            MySqlDataReader drr = cmd.ExecuteReader();
            drr.Close();
            connexion.Close();
        }
        #endregion

        #region DELETE
        public static void SupprimerVisiteur(int lid)
        {
            //CONNEXION BDD
            MySqlConnection connexion = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            MySqlCommand cmd2 = new MySqlCommand();
            MySqlCommand cmd3 = new MySqlCommand();
            MySqlCommand cmd4 = new MySqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            List<int> lesRapports = new List<int>();

            connexion.Open();
            
            cmd4 = connexion.CreateCommand();
            //REQUETE SQL
            cmd4.CommandText = "SELECT `idRap` FROM `rapport` WHERE idVisiteurRap = '"+ lid +"'";
            //EXECUTION REQUETE SQL
            MySqlDataReader drr4 = cmd4.ExecuteReader();

            while (drr4.Read())
            {
                //ON RECUPERE LES VARIABLES
                int idRapport = drr4.GetInt32(0);
                lesRapports.Add(idRapport);
            }
            drr4.Close();


            cmd3 = connexion.CreateCommand();
            foreach (int idRapport in lesRapports)
            {
                //REQUETE SQL
                cmd3.CommandText = "DELETE FROM offrir WHERE offrir.idRapportOff = '" + idRapport + "'";
                //EXECUTION REQUETE SQL
                MySqlDataReader drr3 = cmd3.ExecuteReader();

                drr3.Close();
            }
            

            cmd2 = connexion.CreateCommand();
            //REQUETE SQL
            cmd2.CommandText = "DELETE FROM rapport WHERE rapport.idVisiteurRap = '" + lid + "'";
            //EXECUTION REQUETE SQL
            MySqlDataReader drr1 = cmd2.ExecuteReader();

            drr1.Close();

            cmd = connexion.CreateCommand();
            //REQUETE SQL
            cmd.CommandText = "DELETE FROM visiteur WHERE visiteur.idVis = '"+ lid +"'";
            //EXECUTION REQUETE SQL
            MySqlDataReader drr2 = cmd.ExecuteReader();

            drr2.Close();
            connexion.Close();
        }
        #endregion

        #region ChargerLeVisiteur
        public static ClasseVisiteur chargerLeVisiteur(int lid)
        {
            // variables
            int id;
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
                id = drr.GetInt16(8);

                //On instancie un objet ClasseVisiteur
                leVisiteur = new ClasseVisiteur(id, nom, prenom, adresse, cp, ville, login, mdp, dateEmbauche);
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
            int id;
            string nom;
            string prenom;
            string adresse;
            string cp;
            string ville;
            string mdp;
            string login;
            DateTime dateEmbauche;

            //CONNEXION BDD
            MySqlConnection connexion = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            //REQUETE SQL
            cmd.CommandText = "SELECT nomVis, prenomVis, adresseVis, cpVis, villeVis, dateEmbaucheVis, idVis, loginVis, mdpVis " +
                              "FROM visiteur ";
            //EXECUTION REQUETE
            MySqlDataReader drr = cmd.ExecuteReader();

            //LECTURE REQUETE
            while (drr.Read())
            {
                //ON RECUPERE LES VARIABLES
                nom = drr.GetString(0);
                prenom = drr.GetString(1);
                adresse = drr.GetString(2);
                cp = drr.GetString(3);
                ville = drr.GetString(4);
                dateEmbauche = drr.GetDateTime(5);
                id = int.Parse(drr.GetString(6));
                login = drr.GetString(7);
                mdp = drr.GetString(8);

                //ON INSTANCIE UN OBJET CLASSEVISITEUR
                ClasseVisiteur leVisiteur = new ClasseVisiteur(id, nom, prenom, adresse, cp, ville, login, mdp, dateEmbauche);
                //ON L'AJOUTE A UNE LISTE DE VISITEURS
                LesVisiteurs.Add(leVisiteur);
            }

            drr.Close();
            connexion.Close();

            return LesVisiteurs;
        }
        #endregion

        #region ChargerLeCp
        public static List<ClasseVisiteur> chargerLeCp(string CP)
        {
            //VARIABLES
            List<ClasseVisiteur> LesVisiteurs = new List<ClasseVisiteur>();
            int id;
            string nom;
            string prenom;
            string adresse;
            string ville;
            DateTime dateEmbauche;

            //CONNEXION BDD
            MySqlConnection connexion = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            //REQUETE SQL
            cmd.CommandText = "SELECT nomVis, prenomVis, adresseVis, villeVis, dateEmbaucheVis, idVis " +
                              "FROM visiteur " +
                              "WHERE cpVis = " + CP + "" ;
            //EXECUTION REQUETE
            MySqlDataReader drr = cmd.ExecuteReader();

            //LECTURE REQUETE
            while (drr.Read())
            {
                //ON RECUPERE LES VARIABLES
                nom = drr.GetString(0);
                prenom = drr.GetString(1);
                adresse = drr.GetString(2);
                ville = drr.GetString(3);
                dateEmbauche = drr.GetDateTime(4);
                id = int.Parse(drr.GetString(5));

                //ON INSTANCIE UN OBJET CLASSEVISITEUR
                ClasseVisiteur leVisiteur = new ClasseVisiteur(id, nom, prenom, adresse, CP, ville, dateEmbauche);
                //ON L'AJOUTE A UNE LISTE DE VISITEURS
                LesVisiteurs.Add(leVisiteur);


            }

            drr.Close();
            connexion.Close();

            return LesVisiteurs;
        }
        #endregion

        #region ChargerLeVille
        public static List<ClasseVisiteur> chargerLeVille(string Ville)
        {
            //VARIABLES
            List<ClasseVisiteur> LesVisiteurs = new List<ClasseVisiteur>();
            int id;
            string nom;
            string prenom;
            string adresse;
            string cpVis;
            DateTime dateEmbauche;

            //CONNEXION BDD
            MySqlConnection connexion = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            //REQUETE SQL
            cmd.CommandText = "SELECT nomVis, prenomVis, adresseVis, cpVis, dateEmbaucheVis, idVis " +
                              "FROM visiteur " +
                              "WHERE villeVis = '" + Ville + "'";
            //EXECUTION REQUETE
            MySqlDataReader drr = cmd.ExecuteReader();

            //LECTURE REQUETE
            while (drr.Read())
            {
                //ON RECUPERE LES VARIABLES
                nom = drr.GetString(0);
                prenom = drr.GetString(1);
                adresse = drr.GetString(2);
                cpVis = drr.GetString(3);
                dateEmbauche = drr.GetDateTime(4);
                id = int.Parse(drr.GetString(5));

                //ON INSTANCIE UN OBJET CLASSEVISITEUR
                ClasseVisiteur leVisiteur = new ClasseVisiteur(id, nom, prenom, adresse, cpVis, Ville, dateEmbauche);
                //ON L'AJOUTE A UNE LISTE DE VISITEURS
                LesVisiteurs.Add(leVisiteur);


            }

            drr.Close();
            connexion.Close();

            return LesVisiteurs;
        }
        #endregion

        #region ChargerUnVisiteur
        public static int chargerUnVisiteur(string nom, string prenom)
        {
            // variables
            int id = 0;

            //Connexion BDD
            MySqlConnection connexion = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            //REQUETE SQL
            cmd.CommandText = "SELECT idVis " +
                              "FROM visiteur " +
                              "WHERE nomVis = '" + nom + "' && prenomVis = '" + prenom + "'";
            //EXECUTION REQUETE SQL
            MySqlDataReader drr = cmd.ExecuteReader();

            //LECTURE REQUETE
            while (drr.Read())
            {
                //ON RECUPERE LES VARIABLES
                id = drr.GetInt16(0);
                
            }

            drr.Close();
            connexion.Close();

            return id;
        }
        #endregion
    }
}
