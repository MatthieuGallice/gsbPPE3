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
        public void modifierMedecin(int lidMed ,string lenomMed , string leprenomMed , string ladresseMed , int letelMed , int lidSpecialisteMed , int ledepartementMed)
        {
            //Connexion à la BDD
            MySqlConnection connexion = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();
            // Mise à jour de la table Médecin dans la BDD
            cmd = connexion.CreateCommand();
            cmd.CommandText = "UPDATE `medecin` SET `nomMed` ='" + lenomMed + "',prenomMed='" + leprenomMed +"' ,adresseMed='" + ladresseMed +"',telMed= '" + letelMed + "',idSpecialiteMed= '" + lidSpecialisteMed + "'departementMed='"+ ledepartementMed ;
            MySqlDataReader drr = cmd.ExecuteReader();//execution du script
            drr.Close();
            connexion.Close();

        }
        #endregion

        #region INSERT
        public void AjouterMedecin(int lidMed, string lenomMed, string leprenomMed, string ladresseMed, int letelMed, int lidSpecialisteMed, int ledepartementMed)
        {
            //Connexion à la BDD
            MySqlConnection connexion = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();
            //Ajout d'un Medecin dans la BDD 
            cmd = connexion.CreateCommand();
            cmd.CommandText = "INSERT INTO `medecin` (`nomMed`, `prenomMed`, `adresseMed`, `telMed`, `idSpecialisteMed`, `departementMed`) " +
                                "VALUES ('" + lenomMed + "', '" + leprenomMed + "', '" + ladresseMed + "', '" + letelMed + "', '" + lidSpecialisteMed + "', '" + ledepartementMed + "');";
            MySqlDataReader drr = cmd.ExecuteReader(); //Execution du script
            drr.Close();
            connexion.Close();

        }
        #endregion

        #region DELETE
        public void SupprimerMedecin( int lidMed)
        {
            //Connexion à la BDD 
            MySqlConnection connexion = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();
            //Supprimer un Medecin dans la Table Medecin 
            cmd = connexion.CreateCommand();
            cmd.CommandText = "DELETE FROM `medecin` WHERE `medecin`.`idMed` = '" + lidMed + "'";

            MySqlDataReader drr = cmd.ExecuteReader(); //Execution du script
            drr.Close();
            connexion.Close();
        }
        #endregion

        #region ChargerLeMedecin
        public static ClasseMedecin chargerLeMedecin(string lid)
        {
            //VARIABLES
            ClasseMedecin leMedecin = new ClasseMedecin();
            string nom;
            string prenom;
            string tel;
            string adresse;
            string idspecialite;
            int departement;
            string libSpec;
            string idMed;

            //CONNEXION BDD
            MySqlConnection connexion = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            //REQUETE SQL
            cmd.CommandText = "SELECT nomMed, prenomMed, adresseMed, telMed , idSpec, departementMed, libSpec, idMed  " +
                              "FROM medecin INNER JOIN specialite ON idSpecialiteMed" +
                              "WHERE idMed = '"+ lid +"'"; 
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
                idspecialite = drr.GetString(4);
                libSpec = drr.GetString(6); 
                idMed = drr.GetString(7); 

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
            string nom;
            string prenom;
            string tel;
            string adresse;
            string idspecialite;
            int departement;
            string libSpec;
            string idMed;
            
            //CONNEXION BDD
            MySqlConnection connexion = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            //REQUETE SQL
            cmd.CommandText = "SELECT nomMed, prenomMed, adresseMed, telMed , idSpec, departementMed, libSpec, idMed  " +
                              "FROM medecin INNER JOIN specialite ON idSpecialiteMed"; 
            //EXECUTE LA REQUETE
            MySqlDataReader drr = cmd.ExecuteReader();

            while (drr.Read())
            {
                //ON RECUPERE LES VARIABLES
                nom = drr.GetString(0); // 0 correspond à nomMed
                prenom = drr.GetString(1);// 1 correspond à prenomMed
                tel = drr.GetString(3);// 3 correspond à telMed
                adresse = drr.GetString(2); // 2 correspond à adresseMed
                departement = drr.GetInt16(5);//5 correspond à departementMed
                idspecialite = drr.GetString(4);//4 correspond à idSpec
                libSpec = drr.GetString(6); //6 correspond à libSpec
                idMed = drr.GetString(7); // 7 correspond à idMed

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
