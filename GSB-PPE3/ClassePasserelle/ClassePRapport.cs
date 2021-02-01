using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ClasseMétiers;

namespace ClassePasserelle
{
    public class ClassePRapport
    {
        #region UPDATE
        // procédure qui modifie un rapport 
        public static void modifRapport(int idRap, DateTime dateRap, string motifRap, string bilanRap, int idVisiteurRap, int idMedecinRAp)
        {
            //Conversion de la date
            string ladate = dateRap.ToString();
            String jour = ladate.Substring(0, 2);
            String mois = ladate.Substring(3, 2);
            String Ans = ladate.Substring(6, 4);
            string uneDate = Ans + "-" + mois + "-" + jour;

            //Connexion BDD
            MySqlConnection connexion = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();

            

            //REQUETE SQL
            cmd.CommandText = "UPDATE `rapport` SET `dateRap`='" + uneDate + "',`motifRap`='" + motifRap + "',`bilanRap`=\"" + bilanRap+ "\",`idVisiteurRap`='" + idVisiteurRap + "',`idMedecinRap`='" + idMedecinRAp + "' WHERE idRap ='" + idRap + "'";

            //EXECUTION REQUETE
            MySqlDataReader drr = cmd.ExecuteReader();
            drr.Close();
            connexion.Close();
        }
        #endregion

        #region DELETE
        // procédure qui supprime un rapport grace a l'id 
        public static void supprimerRapport(int idRap)
        {
            //CONNEXION BDD
            MySqlConnection connexion = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            //REQUETE SQL
            cmd.CommandText = "DELETE FROM `rapport` WHERE `idRap` = " + idRap + " ";

            //EXECUTION REQUETE
            MySqlDataReader drr = cmd.ExecuteReader();
            drr.Close();
            connexion.Close();
        }
        #endregion

        #region INSERT
        // procédure qui ajoute un rapport 
        public static void ajoutRapport(DateTime dateRap, string motifRap, string bilanRap, int idVisiteurRap, int idMedecinRap)
        {
            //Conversion de la date
            string ladate = dateRap.ToString();
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
            cmd.CommandText = "INSERT INTO rapport(dateRap, motifRap, bilanRap, idVisiteurRap, idMedecinRap) " +
                                "VALUES ('" + uneDate + "', '" + motifRap + "', '" + bilanRap + "', '" + idVisiteurRap + "', '" + idMedecinRap + "');";
            
            MySqlDataReader drr = cmd.ExecuteReader(); //Execution du script
            drr.Close();
            connexion.Close();
        }
        #endregion
        
        #region chargerLesRapports
        public static List<ClasseRapport> chargerLesRapports()
        {
            //Variables
            List<ClasseRapport> LesRapports = new List<ClasseRapport>();
            int idRap;
            DateTime dateRap;
            string motifRap;
            string bilanRap;
            int idVisiteurRap;
            int idMedecinRap;

            //CONNEXION BDD
            MySqlConnection connexion = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            //REQUETE SQL
            cmd.CommandText = "SELECT idRap, dateRap, motifRap, bilanRap, idVisiteurRap, idMedecinRap " +
                              "FROM rapport ORDER BY idRap ASC";

            //EXECUTION REQUETE SQL
            MySqlDataReader drr = cmd.ExecuteReader();

            //LECTURE REQUETE 
            while (drr.Read())
            {
                //ON RECUPERE LES VARIABLES
                idRap = drr.GetInt16(0);
                dateRap = drr.GetDateTime(1);
                motifRap = drr.GetString(2);
                bilanRap = drr.GetString(3);
                idVisiteurRap = int.Parse(drr.GetString(4));
                idMedecinRap = int.Parse(drr.GetString(5));

                //On récupère un objet visiteur avec la méthode chargerLeVisiteur
                ClasseVisiteur leVisiteur = ClassePVisiteur.chargerLeVisiteur(idVisiteurRap);
                //On récupère un objet Medecin avec la méthode chargerLeMedecin
                ClasseMedecin leMedecin = ClassePMedecin.chargerLeMedecin(idMedecinRap);

                // Instancie un échantillon 
                List<ClasseEchantillonOffert> lesEchantillonsOfferts = ClassePEchantillonOffert.chargerLesEchantillonOffert();


                // Instancie un rapport
                ClasseRapport unRapport = new ClasseRapport(idRap, dateRap, motifRap, bilanRap, leVisiteur, leMedecin, lesEchantillonsOfferts);
                LesRapports.Add(unRapport);
            }
            //CLOTURE LA CONNEXION
            drr.Close();
            connexion.Close();

            return LesRapports;
        }
        #endregion
        
    }
}
