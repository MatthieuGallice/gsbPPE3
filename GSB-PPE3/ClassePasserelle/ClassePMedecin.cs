using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ClasseMétiers;

namespace ClassePasserelle
{
    public class ClassePMedecin
    {
        public void modifierMedecin(int lidMed ,string lenomMed , string leprenomMed , string ladresseMed , int letelMed , int lidSpecialisteMed , int ledepartementMed)
        {
            //Connexion à la BDD
            SqlConnection connexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();
            // Mise à jour de la table Médecin dans la BDD
            cmd = connexion.CreateCommand();
            cmd.CommandText = "UPDATE `medecin` SET `nomMed` ='" + lenomMed + "',prenomMed='" + leprenomMed +"' ,adresseMed='" + ladresseMed +"',telMed= '" + letelMed + "',idSpecialiteMed= '" + lidSpecialisteMed + "'departementMed='"+ ledepartementMed ;
            SqlDataReader drr = cmd.ExecuteReader();//execution du script
            drr.Close();
            connexion.Close();

        }

        public void AjouterMedecin(int lidMed, string lenomMed, string leprenomMed, string ladresseMed, int letelMed, int lidSpecialisteMed, int ledepartementMed)
        {
            //Connexion à la BDD
            SqlConnection connexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();
            //Ajout d'un Medecin dans la BDD 
            cmd = connexion.CreateCommand();
            cmd.CommandText = "INSERT INTO `medecin` (`nomMed`, `prenomMed`, `adresseMed`, `telMed`, `idSpecialisteMed`, `departementMed`) " +
                                "VALUES ('" + lenomMed + "', '" + leprenomMed + "', '" + ladresseMed + "', '" + letelMed + "', '" + lidSpecialisteMed + "', '" + ledepartementMed + "');";
            SqlDataReader drr = cmd.ExecuteReader(); //Execution du script
            drr.Close();
            connexion.Close();

        }


        public void SupprimerMedecin( int lidMed)
        {
            //Connexion à la BDD 
            SqlConnection connexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();
            //Supprimer un Medecin dans la Table Medecin 
            cmd = connexion.CreateCommand();
            cmd.CommandText = "DELETE FROM `medecin` WHERE `medecin`.`idMed` = '" + lidMed + "'";

            SqlDataReader drr = cmd.ExecuteReader(); //Execution du script
            drr.Close();
            connexion.Close();
        }

        public static List<ClasseMedecin> chargerLesMedecins()
        {
            List<ClasseMedecin> LesMedecins = new List<ClasseMedecin>();
            
            string nom;
            string prenom;
            string tel;
            string adresse;
            string idspecialite;
            int departement;
            string libSpec;
            string idMed;
            

            SqlConnection connexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            cmd.CommandText = "SELECT nomMed, prenomMed, adresseMed, telMed , idSpec, departementMed, libSpec, idMed  " +
                              "FROM medecin INNER JOIN specialite "; //Inner join pour faire le lien avec la table specialite pour afficher libelle d'une Spéciallité 
            SqlDataReader drr = cmd.ExecuteReader();

            while (drr.Read())
            {
                nom = drr.GetString(0); // 0 correspond à nomMed
                prenom = drr.GetString(1);// 1 correspond à prenomMed
                tel = drr.GetString(3);// 3 correspond à telMed
                adresse = drr.GetString(2); // 2 correspond à adresseMed
                departement = drr.GetInt16(5);//5 correspond à departementMed
                idspecialite = drr.GetString(4);//4 correspond à idSpec
                libSpec = drr.GetString(6); //6 correspond à libSpec
                idMed = drr.GetString(7); // 7 correspond à idMed


                ClasseSpecialite LaSpe = new ClasseSpecialite(idspecialite, libSpec); //Declaration de la specialite medecin pour le ComboBox l'id correspond à un libelle Spécialité
                ClasseMedecin leMedecin = new ClasseMedecin(idMed, nom, prenom, adresse, tel, departement, LaSpe);
                LesMedecins.Add(leMedecin);
            }

            drr.Close();
            connexion.Close();

            return LesMedecins; //retoune la liste des Medecins 
        }
    }
}
