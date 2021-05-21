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
                List<ClasseEchantillonOffert> lesEchantillonsOfferts = ClassePEchantillonOffert.chargerLEchantillonOffert(idRap);

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

        #region chargerLeRapports
        public static ClasseRapport chargerLeRapports(int idRapport)
        {
            //Variables
            ClasseRapport unRapport = new ClasseRapport();
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
                              "FROM rapport WHERE idRap = '" + idRapport + "' ";

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
                unRapport = new ClasseRapport(idRap, dateRap, motifRap, bilanRap, leVisiteur, leMedecin, lesEchantillonsOfferts);
            }
            //CLOTURE LA CONNEXION
            drr.Close();
            connexion.Close();

            return unRapport;
        }
        #endregion

        #region rechercherRapport
        public static List<ClasseRapport> rechercherRapport(string codeRapport, DateTime dateRapport, bool dateActive, int idMedecinRapport, int idVisiteurRapport, string motifRapport)
        {
            //VARIABLES
            List<ClasseRapport> lesRapprorts = new List<ClasseRapport>();
            int idRap;
            DateTime dateRap;
            string motifRap;
            string bilanRap;
            int idVis;
            int idMed;

            string comboNonChoisi = "----------------------------------------------------------------------------------------------------------------------------------------------------";

            //CONNEXION BDD
            MySqlConnection connexion = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();

            // les différentes condition pour la recherche

            // recherche à 1 argument
            // argument = code 
            if (codeRapport != "" && dateActive == false && idMedecinRapport == 0 && idVisiteurRapport == 0 && motifRapport == comboNonChoisi)
            {
                //REQUETE SQL
                cmd.CommandText = "SELECT idRap, dateRap, motifRap, bilanRap, idVisiteurRap, idMedecinRap FROM rapport " +
                                "WHERE idRap = " + codeRapport + " ";
            }
            // argument = date 
            else if (codeRapport == "" && dateActive == true && idMedecinRapport == 0 && idVisiteurRapport == 0 && motifRapport == comboNonChoisi)
            {
                //REQUETE SQL
                cmd.CommandText = "SELECT idRap, dateRap, motifRap, bilanRap, idVisiteurRap, idMedecinRap FROM rapport " +
                                "WHERE dateRap = '" + dateRapport + "' ";
            }
            // argument = medecin
            else if (codeRapport == "" && dateActive == false && idMedecinRapport != 0 && idVisiteurRapport == 0 && motifRapport == comboNonChoisi)
            {
                //REQUETE SQL
                cmd.CommandText = "SELECT idRap, dateRap, motifRap, bilanRap, idVisiteurRap, idMedecinRap FROM rapport " +
                                "WHERE idMedecinRap = " + idMedecinRapport + " ";
            }
            // argument = visiteur
            else if (codeRapport == "" && dateActive == false && idMedecinRapport == 0 && idVisiteurRapport != 0 && motifRapport == comboNonChoisi)
            {
                //REQUETE SQL
                cmd.CommandText = "SELECT idRap, dateRap, motifRap, bilanRap, idVisiteurRap, idMedecinRap FROM rapport " +
                                "WHERE idVisiteurRap = " + idVisiteurRapport + " ";
            }
            // argument = motif
            else if (codeRapport == "" && dateActive == false && idMedecinRapport == 0 && idVisiteurRapport == 0 && motifRapport != comboNonChoisi)
            {
                //REQUETE SQL
                cmd.CommandText = "SELECT idRap, dateRap, motifRap, bilanRap, idVisiteurRap, idMedecinRap FROM rapport " +
                                "WHERE motifRap = '" + motifRapport + "' ";
            }


            // recherche à 2 argument
            // argument = code + date 
            else if (codeRapport != "" && dateActive == true && idMedecinRapport == 0 && idVisiteurRapport == 0 && motifRapport == comboNonChoisi)
            {
                //REQUETE SQL
                cmd.CommandText = "SELECT idRap, dateRap, motifRap, bilanRap, idVisiteurRap, idMedecinRap FROM rapport " +
                                "WHERE idRap = " + codeRapport + " AND dateRap = '" + dateRapport + "' ";
            }
            // argument = code + medecin 
            else if (codeRapport != "" && dateActive == false && idMedecinRapport != 0 && idVisiteurRapport == 0 && motifRapport == comboNonChoisi)
            {
                //REQUETE SQL
                cmd.CommandText = "SELECT idRap, dateRap, motifRap, bilanRap, idVisiteurRap, idMedecinRap FROM rapport " +
                                "WHERE idRap = " + codeRapport + " AND idMedecinRap = " + idMedecinRapport + " ";
            }
            // argument = code + visiteur  
            else if (codeRapport != "" && dateActive == false && idMedecinRapport == 0 && idVisiteurRapport != 0 && motifRapport == comboNonChoisi)
            {
                //REQUETE SQL
                cmd.CommandText = "SELECT idRap, dateRap, motifRap, bilanRap, idVisiteurRap, idMedecinRap FROM rapport " +
                                "WHERE idRap = " + codeRapport + " AND idVisiteurRap = " + idVisiteurRapport + " ";
            }
            // argument = code + motif  
            else if (codeRapport != "" && dateActive == false && idMedecinRapport == 0 && idVisiteurRapport == 0 && motifRapport != comboNonChoisi)
            {
                //REQUETE SQL
                cmd.CommandText = "SELECT idRap, dateRap, motifRap, bilanRap, idVisiteurRap, idMedecinRap FROM rapport " +
                                "WHERE idRap = " + codeRapport + " AND motifRap = '" + motifRapport + "' ";
            }
            // argument = date + medecin  
            else if (codeRapport == "" && dateActive == true && idMedecinRapport != 0 && idVisiteurRapport == 0 && motifRapport == comboNonChoisi)
            {
                //REQUETE SQL
                cmd.CommandText = "SELECT idRap, dateRap, motifRap, bilanRap, idVisiteurRap, idMedecinRap FROM rapport " +
                                "WHERE dateRap = '" + dateRapport + "' AND idMedecinRap = " + idMedecinRapport + " ";
            }
            // argument = date + visiteur  
            else if (codeRapport == "" && dateActive == true && idMedecinRapport == 0 && idVisiteurRapport != 0 && motifRapport == comboNonChoisi)
            {
                //REQUETE SQL
                cmd.CommandText = "SELECT idRap, dateRap, motifRap, bilanRap, idVisiteurRap, idMedecinRap FROM rapport " +
                                "WHERE dateRap = '" + dateRapport + "' AND idVisiteurRap = " + idVisiteurRapport + " ";
            }
            // argument = date + motif  
            else if (codeRapport == "" && dateActive == true && idMedecinRapport == 0 && idVisiteurRapport == 0 && motifRapport != comboNonChoisi)
            {
                //REQUETE SQL
                cmd.CommandText = "SELECT idRap, dateRap, motifRap, bilanRap, idVisiteurRap, idMedecinRap FROM rapport " +
                                "WHERE dateRap = '" + dateRapport + "' AND motifRap = '" + motifRapport + "' ";
            }
            // argument = medecin + visiteur  
            else if (codeRapport == "" && dateActive == false && idMedecinRapport != 0 && idVisiteurRapport != 0 && motifRapport == comboNonChoisi)
            {
                //REQUETE SQL
                cmd.CommandText = "SELECT idRap, dateRap, motifRap, bilanRap, idVisiteurRap, idMedecinRap FROM rapport " +
                                "WHERE idMedecinRap = " + idMedecinRapport + " AND idVisiteurRap = " + idVisiteurRapport + " ";
            }
            // argument = medecin + motif  
            else if (codeRapport == "" && dateActive == false && idMedecinRapport != 0 && idVisiteurRapport == 0 && motifRapport != comboNonChoisi)
            {
                //REQUETE SQL
                cmd.CommandText = "SELECT idRap, dateRap, motifRap, bilanRap, idVisiteurRap, idMedecinRap FROM rapport " +
                                "WHERE idMedecinRap = " + idMedecinRapport + " AND motifRap = '" + motifRapport + "' ";
            }
            // argument = visiteur + motif  
            else if (codeRapport == "" && dateActive == false && idMedecinRapport == 0 && idVisiteurRapport != 0 && motifRapport != comboNonChoisi)
            {
                //REQUETE SQL
                cmd.CommandText = "SELECT idRap, dateRap, motifRap, bilanRap, idVisiteurRap, idMedecinRap FROM rapport " +
                                "WHERE idVisiteurRap = " + idVisiteurRapport + " AND motifRap = '" + motifRapport + "' ";
            }

            // recherche à 3 argument
            // argument = code + date + medecin  
            else if (codeRapport != "" && dateActive == true && idMedecinRapport != 0 && idVisiteurRapport == 0 && motifRapport == comboNonChoisi)
            {
                //REQUETE SQL
                cmd.CommandText = "SELECT idRap, dateRap, motifRap, bilanRap, idVisiteurRap, idMedecinRap FROM rapport " +
                                "WHERE idRap = " + codeRapport + " AND dateRap = '" + dateRapport + "' AND idMedecinRap = " + idMedecinRapport + " ";
            }
            // argument = code + date + visiteur  
            else if (codeRapport != "" && dateActive == true && idMedecinRapport == 0 && idVisiteurRapport != 0 && motifRapport == comboNonChoisi)
            {
                //REQUETE SQL
                cmd.CommandText = "SELECT idRap, dateRap, motifRap, bilanRap, idVisiteurRap, idMedecinRap FROM rapport " +
                                "WHERE  idRap = " + codeRapport + " AND dateRap = '" + dateRapport + "' AND idVisiteurRap = " + idVisiteurRapport + " ";
            }
            // argument = code + date + motif  
            else if (codeRapport != "" && dateActive == true && idMedecinRapport == 0 && idVisiteurRapport == 0 && motifRapport != comboNonChoisi)
            {
                //REQUETE SQL
                cmd.CommandText = "SELECT idRap, dateRap, motifRap, bilanRap, idVisiteurRap, idMedecinRap FROM rapport " +
                                "WHERE idRap = " + codeRapport + " AND dateRap = '" + dateRapport + "' AND motifRap = '" + motifRapport + "' ";
            }
            // argument = code + medecin + visiteur  
            else if (codeRapport != "" && dateActive == false && idMedecinRapport != 0 && idVisiteurRapport != 0 && motifRapport == comboNonChoisi)
            {
                //REQUETE SQL
                cmd.CommandText = "SELECT idRap, dateRap, motifRap, bilanRap, idVisiteurRap, idMedecinRap FROM rapport " +
                                "WHERE idRap = " + codeRapport + " AND idMedecinRap = " + idMedecinRapport + " AND idVisiteurRap = " + idVisiteurRapport + " ";
            }
            // argument = code + medecin + motif  
            else if (codeRapport != "" && dateActive == false && idMedecinRapport != 0 && idVisiteurRapport == 0 && motifRapport != comboNonChoisi)
            {
                //REQUETE SQL
                cmd.CommandText = "SELECT idRap, dateRap, motifRap, bilanRap, idVisiteurRap, idMedecinRap FROM rapport " +
                                "WHERE idRap = " + codeRapport + " AND idMedecinRap = " + idMedecinRapport + " AND motifRap = '" + motifRapport + "' ";
            }
            // argument = code + visiteur + motif  
            else if (codeRapport != "" && dateActive == false && idMedecinRapport == 0 && idVisiteurRapport != 0 && motifRapport != comboNonChoisi)
            {
                //REQUETE SQL
                cmd.CommandText = "SELECT idRap, dateRap, motifRap, bilanRap, idVisiteurRap, idMedecinRap FROM rapport " +
                                "WHERE idRap = " + codeRapport + " AND idVisiteurRap = " + idVisiteurRapport + " AND motifRap = '" + motifRapport + "' ";
            }
            // argument = date + medecin + visiteur  
            else if (codeRapport == "" && dateActive == true && idMedecinRapport != 0 && idVisiteurRapport != 0 && motifRapport == comboNonChoisi)
            {
                //REQUETE SQL
                cmd.CommandText = "SELECT idRap, dateRap, motifRap, bilanRap, idVisiteurRap, idMedecinRap FROM rapport " +
                                "WHERE dateRap = '" + dateRapport + "' AND idMedecinRap = " + idMedecinRapport + " AND idVisiteurRap = " + idVisiteurRapport + " ";
            }
            // argument = date + medecin + motif  
            else if (codeRapport == "" && dateActive == true && idMedecinRapport != 0 && idVisiteurRapport == 0 && motifRapport != comboNonChoisi)
            {
                //REQUETE SQL
                cmd.CommandText = "SELECT idRap, dateRap, motifRap, bilanRap, idVisiteurRap, idMedecinRap FROM rapport " +
                                "WHERE dateRap = '" + dateRapport + "' AND idMedecinRap = " + idMedecinRapport + " AND motifRap = '" + motifRapport + "' ";
            }
            // argument = date + visiteur + motif  
            else if (codeRapport == "" && dateActive == true && idMedecinRapport == 0 && idVisiteurRapport != 0 && motifRapport != comboNonChoisi)
            {
                //REQUETE SQL
                cmd.CommandText = "SELECT idRap, dateRap, motifRap, bilanRap, idVisiteurRap, idMedecinRap FROM rapport " +
                                "WHERE dateRap = '" + dateRapport + "' AND idVisiteurRap = " + idVisiteurRapport + " AND motifRap = '" + motifRapport + "' ";
            }
            // argument = medecin + visiteur + motif  
            else if (codeRapport == "" && dateActive == false && idMedecinRapport != 0 && idVisiteurRapport != 0 && motifRapport != comboNonChoisi)
            {
                //REQUETE SQL
                cmd.CommandText = "SELECT idRap, dateRap, motifRap, bilanRap, idVisiteurRap, idMedecinRap FROM rapport " +
                                "WHERE idMedecinRap = " + idMedecinRapport + " AND idVisiteurRap = " + idVisiteurRapport + " AND motifRap = '" + motifRapport + "' ";
            }

            // recherche à 4 argument
            // argument = code + date + medecin + visiteur
            else if (codeRapport != "" && dateActive == true && idMedecinRapport != 0 && idVisiteurRapport != 0 && motifRapport == comboNonChoisi)
            {
                //REQUETE SQL
                cmd.CommandText = "SELECT idRap, dateRap, motifRap, bilanRap, idVisiteurRap, idMedecinRap FROM rapport " +
                                "WHERE idRap = " + codeRapport + " AND dateRap = '" + dateRapport + "' AND idMedecinRap = " + idMedecinRapport + " AND idVisiteurRap = " + idVisiteurRapport + " ";
            }
            // argument = code + date + medecin + motif
            else if (codeRapport != "" && dateActive == true && idMedecinRapport != 0 && idVisiteurRapport == 0 && motifRapport != comboNonChoisi)
            {
                //REQUETE SQL
                cmd.CommandText = "SELECT idRap, dateRap, motifRap, bilanRap, idVisiteurRap, idMedecinRap FROM rapport " +
                                "WHERE idRap = " + codeRapport + " AND dateRap = '" + dateRapport + "' AND idMedecinRap = " + idMedecinRapport + " AND motifRap = '" + motifRapport + "' ";
            }
            // argument = code + medecin + visiteur + motif
            else if (codeRapport != "" && dateActive == false && idMedecinRapport != 0 && idVisiteurRapport != 0 && motifRapport != comboNonChoisi)
            {
                //REQUETE SQL
                cmd.CommandText = "SELECT idRap, dateRap, motifRap, bilanRap, idVisiteurRap, idMedecinRap FROM rapport " +
                                "WHERE idRap = " + codeRapport + " AND idMedecinRap = " + idMedecinRapport + " AND idVisiteurRap = " + idVisiteurRapport + " AND motifRap = '" + motifRapport + "' ";
            }
            // argument = code + visiteur + date + motif
            else if (codeRapport != "" && dateActive == true && idMedecinRapport == 0 && idVisiteurRapport != 0 && motifRapport != comboNonChoisi)
            {
                //REQUETE SQL
                cmd.CommandText = "SELECT idRap, dateRap, motifRap, bilanRap, idVisiteurRap, idMedecinRap FROM rapport " +
                                "WHERE idRap = " + codeRapport + " AND dateRap = '" + dateRapport + "' AND idVisiteurRap = " + idVisiteurRapport + " AND motifRap = '" + motifRapport + "' ";
            }
            // argument = date + medecin + visiteur + motif
            else if (codeRapport == "" && dateActive == true && idMedecinRapport != 0 && idVisiteurRapport != 0 && motifRapport != comboNonChoisi)
            {
                //REQUETE SQL
                cmd.CommandText = "SELECT idRap, dateRap, motifRap, bilanRap, idVisiteurRap, idMedecinRap FROM rapport " +
                                "WHERE dateRap = '" + dateRapport + "' AND idMedecinRap = " + idMedecinRapport + " AND idVisiteurRap = " + idVisiteurRapport + " AND motifRap = '" + motifRapport + "' ";
            }

            // recherche à 5 argument
            // argument = code + date + medecin + visiteur + motif
            else if (codeRapport != "" && dateActive == true && idMedecinRapport != 0 && idVisiteurRapport != 0 && motifRapport != comboNonChoisi)
            {
                //REQUETE SQL
                cmd.CommandText = "SELECT idRap, dateRap, motifRap, bilanRap, idVisiteurRap, idMedecinRap FROM rapport " +
                                "WHERE idRap = " + codeRapport + " AND dateRap = '" + dateRapport + "' AND idMedecinRap = " + idMedecinRapport + " AND idVisiteurRap = " + idVisiteurRapport + " AND motifRap = '" + motifRapport + "' ";
            }
            
            //EXECUTE LA REQUETE
            MySqlDataReader drr = cmd.ExecuteReader();

            while (drr.Read())
            {
                //ON RECUPERE LES VARIABLES
                idRap = int.Parse(drr.GetString(0)); // 0 correspond à idRap
                dateRap = DateTime.Parse(drr.GetString(1)); // 1 correspond à dateRap
                motifRap = drr.GetString(2);// 2 correspond à motifRap
                bilanRap = drr.GetString(3);// 3 correspond à bilanRap
                idVis = int.Parse(drr.GetString(4));// 5 correspond à idVisiteurRap
                idMed = int.Parse(drr.GetString(5));// 5 correspond à idMedecinRap

                // ON INSTANCIE UN OBJET VISITEUR 
                ClasseVisiteur lesVisi = new ClasseVisiteur();
                lesVisi = ClassePVisiteur.chargerLeVisiteur(idVis);

                // ON INSTANCIE UN OBJET MEDECIN
                ClasseMedecin lesMed = new ClasseMedecin();
                lesMed = ClassePMedecin.chargerLeMedecin(idMed);

                // ON INSTANCIE UNE LISTE ECHANTILLON
                List<ClasseEchantillonOffert> lesEchantillons = new List<ClasseEchantillonOffert>();
                lesEchantillons = ClassePEchantillonOffert.chargerLEchantillonOffert(idRap);

                // ON INSTANCIE UN OBJET RAPPORT
                ClasseRapport lesRaps = new ClasseRapport(idRap, dateRap, motifRap, bilanRap, lesVisi, lesMed, lesEchantillons);
                // ON AJOUTE L'OBJET RAPPORT DANS LA LISTE LesRapports
                lesRapprorts.Add(lesRaps);
            }

            drr.Close();
            connexion.Close();

            return lesRapprorts; //retoune la liste des rapports 
        }

        #endregion
    }
}
