using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ClasseMétiers;

namespace ClassePasserelle
{
    public class ClassePMedecin
    {
        #region UPDATE
        public static void modifierMedecin(int idMed, string leNom, string lePrenom, string ladresse, string leTel, int idSpe, int leDepartement)
        {
            //Connexion à la BDD
            MySqlConnection connexion = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();
            // Mise à jour de la table Médecin dans la BDD
            cmd = connexion.CreateCommand();
            cmd.CommandText = "UPDATE medecin SET nomMed='" + leNom + "', prenomMed='" + lePrenom + "', adresseMed='" + ladresse + "', telMed= '" + leTel + "', idSpecialiteMed= '" + idSpe + "', departementMed='"+ leDepartement + "' WHERE idMed='"+ idMed + "'";

            MySqlDataReader drr = cmd.ExecuteReader(); //Execution du script
            drr.Close();
            connexion.Close();
        }
        #endregion

        #region INSERT
        public static void ajouterMedecin(string leNom, string lePrenom, string ladresse, string leTel, int laSpe, int leDepartement)
        {
            //Connexion à la BDD
            MySqlConnection connexion = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();
            //Ajout d'un Medecin dans la BDD 
            cmd = connexion.CreateCommand();
            cmd.CommandText = "INSERT INTO medecin (nomMed, prenomMed, adresseMed, telMed, idSpecialiteMed, departementMed) " +
                                "VALUES ('" + leNom + "', '" + lePrenom + "', '" + ladresse + "', '" + leTel + "', '" + laSpe + "', '" + leDepartement + "');";

            MySqlDataReader drr = cmd.ExecuteReader(); //Execution du script
            drr.Close();
            connexion.Close();

        }
        #endregion

        #region DELETE
        public static void SupprimerMedecin(int lidMed)
        {
            //Connexion à la BDD 
            MySqlConnection connexion = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();
            //Supprimer un Medecin dans la Table Medecin 
            cmd = connexion.CreateCommand();
            cmd.CommandText = "DELETE FROM `medecin` WHERE `idMed` = " + lidMed + " ";

            MySqlDataReader drr = cmd.ExecuteReader(); //Execution du script
            drr.Close();
            connexion.Close();
        }
        #endregion

        #region ChargerLeMedecin
        public static ClasseMedecin chargerLeMedecin(int lid)
        {
            //VARIABLES
            ClasseMedecin leMedecin = new ClasseMedecin();
            string nom;
            string prenom;
            string tel;
            string adresse;
            int idspecialite;
            int departement;
            string libSpec;
            int idMed;

            //CONNEXION BDD
            MySqlConnection connexion = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            //REQUETE SQL
            cmd.CommandText = "SELECT nomMed, prenomMed, adresseMed, telMed , idSpec, departementMed, libSpec, idMed  " +
                              "FROM medecin INNER JOIN specialite ON idSpecialiteMed " +
                              "WHERE idMed = '" + lid + "'";
            //EXECUTION REQUETE
            MySqlDataReader drr = cmd.ExecuteReader();

            //LECTURE REQUETE
            while (drr.Read())
            {
                //ON RECUPERE LES VARIABLES
                nom = drr.GetString(0);
                prenom = drr.GetString(1);
                tel = drr.GetString(3);
                adresse = drr.GetString(2);
                departement = drr.GetInt16(5);
                idspecialite = int.Parse(drr.GetString(4));
                libSpec = drr.GetString(6);
                idMed = int.Parse(drr.GetString(7));

                //ON INSTANCIE UN OBJET CLASSESPECIALITE
                ClasseSpecialite LaSpe = new ClasseSpecialite(idspecialite, libSpec);
                //ON INSTANCIE UN OBJET CLASSEMEDECIN
                leMedecin = new ClasseMedecin(idMed, nom, prenom, adresse, tel, departement, LaSpe);
            }

            drr.Close();
            connexion.Close();

            return leMedecin;
        }
        #endregion

        #region ChargerLesMedecins
        public static List<ClasseMedecin> chargerLesMedecins()
        {
            //VARIABLES
            List<ClasseMedecin> LesMedecins = new List<ClasseMedecin>();
            int idMed;
            string nom;
            string prenom;
            string tel;
            string adresse;
            int idspecialite;
            int departement;
            string libSpec;

            //CONNEXION BDD
            MySqlConnection connexion = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            //REQUETE SQL
            cmd.CommandText = "SELECT idMed, nomMed, prenomMed, adresseMed, telMed , idSpec, departementMed, libSpec " +
                            "FROM medecin INNER JOIN specialite ON specialite.idSpec = medecin.idSpecialiteMed ORDER BY nomMed ASC";
            //EXECUTE LA REQUETE
            MySqlDataReader drr = cmd.ExecuteReader();

            while (drr.Read())
            {
                //ON RECUPERE LES VARIABLES
                idMed = int.Parse(drr.GetString(0)); // 7 correspond à idMed
                nom = drr.GetString(1); // 0 correspond à nomMed
                prenom = drr.GetString(2);// 1 correspond à prenomMed
                tel = drr.GetString(4);// 3 correspond à telMed
                adresse = drr.GetString(3); // 2 correspond à adresseMed
                departement = drr.GetInt16(6);//5 correspond à departementMed
                idspecialite = int.Parse(drr.GetString(5));//4 correspond à idSpec
                libSpec = drr.GetString(7); //6 correspond à libSpec
                

                //ON INSTANCIE UN OBJET CLASSESPECIALITE
                ClasseSpecialite LaSpe = new ClasseSpecialite(idspecialite, libSpec);
                // ON INSTANCIE UN OBJET CLASSEMEDECIN
                ClasseMedecin leMedecin = new ClasseMedecin(idMed, nom, prenom, adresse, tel, departement, LaSpe);
                // ON AJOUTE UN OBJET CLASSEMEDECIN DANS UNE LISTE CLASSEMEDECIN
                LesMedecins.Add(leMedecin);
            }

            drr.Close();
            connexion.Close();

            return LesMedecins; //retoune la liste des Medecins 
        }
        #endregion

        #region ChargerLesRapportMedecin
        public static List<ClasseMedecin> ChargerLesRapportMedecin(int lid)
        {
            //VARIABLES
            List<ClasseMedecin> leMedecin = new List<ClasseMedecin>();
            int idMed;
            string nomMed;
            string prenomMed;
            string adresseMed;
            int idRap;
            int idVis;
            string nomVis;
            string prenomVis;
            DateTime dateRap;
            string motifRap;
            string bilanRap;

            //CONNEXION BDD
            MySqlConnection connexion = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            //REQUETE SQL
            cmd.CommandText = "SELECT nomMed, prenomMed, adresseMed, idRap, idVis, nomVis, prenomVis, dateRap, motifRap, bilanRap " +
                            "FROM visiteur INNER JOIN rapport ON rapport.idVisiteurRap = visiteur.idVis " +
                            "INNER JOIN medecin ON rapport.idMedecinRap = medecin.idMed " +
                            "WHERE medecin.idMed = '" + lid + "'"; 
            //EXECUTION REQUETE
            MySqlDataReader drr = cmd.ExecuteReader();

            //LECTURE REQUETE
            while (drr.Read())
            {
                //ON RECUPERE LES VARIABLES
                idMed = lid;
                nomMed = drr.GetString(0); 
                prenomMed = drr.GetString(1); 
                adresseMed = drr.GetString(2); 
                idRap = drr.GetInt16(3);
                idVis = drr.GetInt16(4);
                nomVis = drr.GetString(5); 
                prenomVis = drr.GetString(6);
                dateRap = drr.GetDateTime(7);
                motifRap = drr.GetString(8); 
                bilanRap = drr.GetString(9);

                //ON INSTANCIE UN TABLEAU 
                ClasseMedecin lesRap = new ClasseMedecin(idMed, nomMed, prenomMed, adresseMed, idRap, idVis, nomVis, prenomVis, dateRap, motifRap, bilanRap);
                // ON AJOUTE UN OBJET CLASSEMEDECIN DANS UNE LISTE CLASSEMEDECIN
                leMedecin.Add(lesRap);

            }

            drr.Close();
            connexion.Close();

            return leMedecin;
        }
        #endregion

        #region recuperer id medecin
        public static int recupererIdMedecin(string nomMedecin, string prenomMedecin)
        {
            int idMedecin = 0;

            //CONNEXION BDD
            MySqlConnection connexion = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            //REQUETE SQL
            cmd.CommandText = "SELECT idMed " +
                              "FROM medecin " +
                              "WHERE nomMed = '" + nomMedecin + "' " +
                              "AND prenomMed = '" + prenomMedecin + "'";

            //EXECUTE LA REQUETE
            MySqlDataReader drr = cmd.ExecuteReader();

            if (drr.Read())
            {
                //ON RECUPERE LES VARIABLES
                idMedecin = drr.GetInt16(0);
            }
            drr.Close();
            connexion.Close();

            return idMedecin;
        }
        #endregion

        #region recuperer id spécialité
        public static int recupererIdSpe(string laSpe)
        {
            int idSpe = 0;

            //CONNEXION BDD
            MySqlConnection connexion = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            //REQUETE SQL
            cmd.CommandText = "SELECT `idSpec` " +
                              "FROM `specialite` WHERE `libSpec` = '" + laSpe + "'";

            //EXECUTE LA REQUETE
            MySqlDataReader drr = cmd.ExecuteReader();

            if (drr.Read())
            {
                //ON RECUPERE LES VARIABLES
                idSpe = drr.GetInt16(0);
            }
            drr.Close();
            connexion.Close();

            return idSpe;
        }
        #endregion

        #region rechercherMedecin
        public static List<ClasseMedecin> rechercherMedecin(string nomMedecin, string prenomMedecin, string laSpe, string departementMed)
        {
            //VARIABLES
            List<ClasseMedecin> LesMedecins = new List<ClasseMedecin>();
            int idMed;
            string nom;
            string prenom;
            string tel;
            string adresse;
            int idspecialite;
            int departement;
            string libSpec;

            string comboNonChoisi = "-----------------------------------------------------------------------------------------------";

            //CONNEXION BDD
            MySqlConnection connexion = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();

            // condition si seulement le nom et prenom sont remplis 
            if(nomMedecin != "" && prenomMedecin != "" && laSpe == comboNonChoisi && departementMed == "")
            {
                //REQUETE SQL
                cmd.CommandText = "SELECT idMed, nomMed, prenomMed, adresseMed, telMed , idSpec, departementMed, libSpec " +
                            "FROM medecin INNER JOIN specialite ON specialite.idSpec = medecin.idSpecialiteMed " +
                            "WHERE nomMed = '" + nomMedecin + "' AND prenomMed = '" + prenomMedecin + "' ORDER BY nomMed ASC";
            }
            // condition si seulement la spécialité et remplis 
            else if (nomMedecin == "" && prenomMedecin == "" && laSpe != comboNonChoisi && departementMed == "")
            {
                int id = ClassePSpecialite.recupererIdSpe(laSpe);
                
                //REQUETE SQL
                cmd.CommandText = "SELECT idMed, nomMed, prenomMed, adresseMed, telMed , idSpec, departementMed, libSpec " +
                                "FROM medecin INNER JOIN specialite ON specialite.idSpec = medecin.idSpecialiteMed " +
                                "WHERE idSpec = '" + id + "' ORDER BY nomMed ASC";
            }
            // condition si seulement le département et remplis 
            else if (nomMedecin == "" && prenomMedecin == "" && laSpe == comboNonChoisi && departementMed != "")
            {
                //REQUETE SQL
                cmd.CommandText = "SELECT idMed, nomMed, prenomMed, adresseMed, telMed , idSpec, departementMed, libSpec " +
                                "FROM medecin INNER JOIN specialite ON specialite.idSpec = medecin.idSpecialiteMed " +
                                "WHERE departementMed = '" + departementMed + "' ORDER BY nomMed ASC";
            }
            // condition si le medecin et la spécialité sont remplis 
            else if (nomMedecin != "" && prenomMedecin != "" && laSpe != comboNonChoisi && departementMed == "")
            {
                int id = ClassePSpecialite.recupererIdSpe(laSpe);
                
                //REQUETE SQL
                cmd.CommandText = "SELECT idMed, nomMed, prenomMed, adresseMed, telMed , idSpec, departementMed, libSpec " +
                                "FROM medecin INNER JOIN specialite ON specialite.idSpec = medecin.idSpecialiteMed " +
                                "WHERE nomMed = '" + nomMedecin + "' AND prenomMed = '" + prenomMedecin + "' AND idSpec = '" + id + "' ORDER BY nomMed ASC";
            }
            // condition si le medecin et le département sont remplis 
            else if (nomMedecin != "" && prenomMedecin != "" && laSpe == comboNonChoisi && departementMed != "")
            {
                //REQUETE SQL
                cmd.CommandText = "SELECT idMed, nomMed, prenomMed, adresseMed, telMed , idSpec, departementMed, libSpec " +
                                "FROM medecin INNER JOIN specialite ON specialite.idSpec = medecin.idSpecialiteMed " +
                                "WHERE nomMed = '" + nomMedecin + "' AND prenomMed = '" + prenomMedecin + "' AND departementMed = '" + departementMed + "' ORDER BY nomMed ASC";
            }
            // condition si la spécialité et le département sont remplis 
            else if (nomMedecin == "" && prenomMedecin == "" && laSpe != comboNonChoisi && departementMed != "")
            {
                int id = ClassePSpecialite.recupererIdSpe(laSpe);
                
                //REQUETE SQL
                cmd.CommandText = "SELECT idMed, nomMed, prenomMed, adresseMed, telMed , idSpec, departementMed, libSpec " +
                                "FROM medecin INNER JOIN specialite ON specialite.idSpec = medecin.idSpecialiteMed " +
                                "WHERE idSpec = '" + id + "' AND departementMed = '" + departementMed + "' ORDER BY nomMed ASC";
            }
            // condition si tout les champs sont remplis
            else if (nomMedecin != "" && prenomMedecin != "" && laSpe != comboNonChoisi && departementMed != "")
            {
                int id = ClassePSpecialite.recupererIdSpe(laSpe);
                
                //REQUETE SQL
                cmd.CommandText = "SELECT idMed, nomMed, prenomMed, adresseMed, telMed , idSpec, departementMed, libSpec " +
                                "FROM medecin INNER JOIN specialite ON specialite.idSpec = medecin.idSpecialiteMed " +
                                "WHERE nomMed = '" + nomMedecin + "' AND prenomMed = '" + prenomMedecin + "' AND idSpec = '" + id + "' AND departementMed = '" + departementMed + "' ORDER BY nomMed ASC";
            }
 
            //EXECUTE LA REQUETE
            MySqlDataReader drr = cmd.ExecuteReader();

            while (drr.Read())
            {
                //ON RECUPERE LES VARIABLES
                idMed = int.Parse(drr.GetString(0)); // 7 correspond à idMed
                nom = drr.GetString(1); // 0 correspond à nomMed
                prenom = drr.GetString(2);// 1 correspond à prenomMed
                tel = drr.GetString(4);// 3 correspond à telMed
                adresse = drr.GetString(3); // 2 correspond à adresseMed
                departement = drr.GetInt16(6);//5 correspond à departementMed
                idspecialite = int.Parse(drr.GetString(5));//4 correspond à idSpec
                libSpec = drr.GetString(7); //6 correspond à libSpec


                //ON INSTANCIE UN OBJET CLASSESPECIALITE
                ClasseSpecialite LaSpe = new ClasseSpecialite(idspecialite, libSpec);
                // ON INSTANCIE UN OBJET CLASSEMEDECIN
                ClasseMedecin leMedecin = new ClasseMedecin(idMed, nom, prenom, adresse, tel, departement, LaSpe);
                // ON AJOUTE UN OBJET CLASSEMEDECIN DANS UNE LISTE CLASSEMEDECIN
                LesMedecins.Add(leMedecin);
            }

            drr.Close();
            connexion.Close();

            return LesMedecins; //retoune la liste des Medecins 
        }

        #endregion
        
    }
}
