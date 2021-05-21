using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ClasseMétiers;

namespace ClassePasserelle
{
    public class ClassePEchantillonOffert
    {
        #region INSERT
        public static void AjoutEchantillonOffert(int idRapport, int idMedicament, int quantite)
        {
            //CONNEXION BDD
            MySqlConnection connexion = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            //REQUETE SQL
            cmd.CommandText = "INSERT INTO offrir (`idRapportOff`, `idMedicamentOff`, `quantiteOff`) " +
                              "VALUES ('"+ idRapport + "', '" + idMedicament + "', '" + quantite + "');";
            //EXECUTION REQUETE
            MySqlDataReader drr = cmd.ExecuteReader();
            drr.Close();
            connexion.Close();
        }
        #endregion

        #region UPDATE
        public static void ModifEchantillonOffert(int idRapport, int idMedicament, int quantite)
        {
            //CONNEXION BDD
            MySqlConnection connexion = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            //REQUETE SQL
            cmd.CommandText = "UPDATE offrir " +
                              "SET idRapportOff = "+ idRapport + ", idMedicamentOff = " + idMedicament + ", quantiteOff = " + quantite + " " +
                              "WHERE  idRapportOff = " + idRapport + " AND idMedicamentOff = " + idMedicament + "";
            //EXECUTION REQUETE
            MySqlDataReader drr = cmd.ExecuteReader();
            drr.Close();
            connexion.Close();
        }
        #endregion

        #region DELETE
        public static void SupprimerEchantillonOffert(int idRapport, int idMedicament)
        {
            //CONNEXION BDD
            MySqlConnection connexion = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            //REQUETE SQL
            cmd.CommandText = "DELETE FROM offrir " +
                              "WHERE offrir.idRapportOff = '" + idRapport + "' && offrir.idMedicamentOff = '" + idMedicament + "'";
            //EXECUTE LA REQUETE
            MySqlDataReader drr = cmd.ExecuteReader();
            drr.Close();
            connexion.Close();
        }
        #endregion

        #region ChargerLeEchantillonsOffert selon rapport
        public static List<ClasseEchantillonOffert> chargerLEchantillonOffert(int idRapport)
        {
            //VARIABLES
            List<ClasseEchantillonOffert> LEchantillons = new List<ClasseEchantillonOffert>();
            int idMedicament;
            int quantite;

            //CONNEXION BDD
            MySqlConnection connexion = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            //REQUETE SQL
            cmd.CommandText = "SELECT idMedicamentOff, quantiteOff " +
                              "FROM offrir " +
                              "WHERE idRapportOff = '"+ idRapport + "'";
            //EXECUTE LA REQUETE
            MySqlDataReader drr = cmd.ExecuteReader();

            //LECTURE DE LA REQUETE
            while (drr.Read())
            {
                //ON RECUPERE LES VARIABLES
                idMedicament = drr.GetInt16(0);
                quantite = drr.GetInt16(1);
                //On récupère le médicaments avec la méthode chargerLeMedicament
                ClasseMedicament leMedicament = ClassePMedicament.chargerLeMedicament(idMedicament);


                // Instancie un échantillon 
                ClasseEchantillonOffert lEchantillon = new ClasseEchantillonOffert(quantite, leMedicament);
                // Ajoute un échantillon dans la liste
                LEchantillons.Add(lEchantillon);

            }

            drr.Close();
            connexion.Close();

            return LEchantillons;
        }
        #endregion

        #region ChargerLesEchantillonsOfferts 
        public static List<ClasseEchantillonOffert> chargerLesEchantillonOffert()
        {
            // VARIABLES
            List<ClasseEchantillonOffert> LesEchantillonsOffert = new List<ClasseEchantillonOffert>();
            int idRapport;
            int idMedicament;
            int quantite;

            // CONNEXION BDD
            MySqlConnection connexion = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            // REQUETE SQL
            cmd.CommandText = "SELECT idRapportOff, idMedicamentOff, quantiteOff " +
                            "FROM offrir inner join medicament order by idRapportOff ASC";
            // EXECUTE LA REQUETE
            MySqlDataReader drr = cmd.ExecuteReader();
            
            // LECTURE DE LA REQUETE
            while (drr.Read())
            {
                // ON RECUPERE LES VARIABLES
                idRapport = int.Parse(drr.GetString(0));
                idMedicament = int.Parse(drr.GetString(1));
                quantite = drr.GetInt16(2);

                
                // On récupère la liste des médicaments avec la méthode chargerLeMedicaments
                ClasseMedicament leMedicament = ClassePMedicament.chargerLeMedicament(idMedicament);
                
                // On récupére le rapport avec l'id et la méthode chargerLeRapports
                ClasseRapport leRapport = ClassePRapport.chargerLeRapports(idRapport);

                // Instancie un échantillon 
                ClasseEchantillonOffert lEchantillon = new ClasseEchantillonOffert(quantite, leMedicament, leRapport);

                // Instancie un rapport
                LesEchantillonsOffert.Add(lEchantillon);
            }

            drr.Close();
            connexion.Close();

            return LesEchantillonsOffert;
        }
        #endregion

        #region rechercherRapportMedicament
        public static List<ClasseEchantillonOffert> rechercherRapportMedicament(string codeRapport, bool rapportValide, string nomMedicament, bool medicamentValide, string quantite)
        {
            //VARIABLES
            List<ClasseEchantillonOffert> lesEchantillons = new List<ClasseEchantillonOffert>();
            int idRapport;
            int idMedicament;
            int quantiteOffert;

            //CONNEXION BDD
            MySqlConnection connexion = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();

            // les différentes condition pour la recherche
            // condition à 1 élément

            // condition si seulement le rapport est sélectionné
            if (rapportValide == true && medicamentValide == false && quantite == "")
            {
                //REQUETE SQL
                cmd.CommandText = "SELECT idRapportOff, idMedicamentOff, quantiteOff FROM offrir " +
                                "INNER JOIN medicament ON medicament.idMedicament = offrir.idMedicamentOff WHERE idRapportOff = '" + codeRapport + "' ";
            }
            // condition si seulement le médicament est sélectionné
            else if (rapportValide == false && medicamentValide == true && quantite == "")
            {
                //REQUETE SQL
                cmd.CommandText = "SELECT idRapportOff, idMedicamentOff, quantiteOff FROM offrir " +
                                "INNER JOIN medicament ON medicament.idMedicament = offrir.idMedicamentOff WHERE nomCommercialMedicament = '" + nomMedicament + "' ";
            }
            // condition si seulement la quantite est sélectionné
            else if (rapportValide == false && medicamentValide == false && quantite != "")
            {
                //REQUETE SQL
                cmd.CommandText = "SELECT idRapportOff, idMedicamentOff, quantiteOff FROM offrir " +
                                "INNER JOIN medicament ON medicament.idMedicament = offrir.idMedicamentOff WHERE quantiteOff = '" + quantite + "' ";
            }

            // condition à 2 éléments
            // condition si seulement le rapport et le medicament sont sélectionné
            else if (rapportValide == true && medicamentValide == true && quantite == "")
            {
                //REQUETE SQL
                cmd.CommandText = "SELECT idRapportOff, idMedicamentOff, quantiteOff FROM offrir " +
                                "INNER JOIN medicament ON medicament.idMedicament = offrir.idMedicamentOff WHERE idRapportOff = '" + codeRapport + "' AND nomCommercialMedicament = '" + nomMedicament + "' ";
            }
            // condition si seulement le rapport et la quantite sont sélectionné
            else if (rapportValide == true && medicamentValide == false && quantite != "")
            {
                //REQUETE SQL
                cmd.CommandText = "SELECT idRapportOff, idMedicamentOff, quantiteOff FROM offrir " +
                                "INNER JOIN medicament ON medicament.idMedicament = offrir.idMedicamentOff WHERE idRapportOff = '" + codeRapport + "' AND quantiteOff = '" + quantite + "' ";
            }
            // condition si seulement le medicament et la quantite sont sélectionné 
            else if (rapportValide == false && medicamentValide == true && quantite != "")
            {
                //REQUETE SQL
                cmd.CommandText = "SELECT idRapportOff, idMedicamentOff, quantiteOff FROM offrir " +
                                "INNER JOIN medicament ON medicament.idMedicament = offrir.idMedicamentOff WHERE nomCommercialMedicament = '" + nomMedicament + "' AND quantiteOff = '" + quantite + "' ";
            }

            // condition à 3 éléments
            // condition si tout les éléments sont sélectionné 
            else if (rapportValide == true && medicamentValide == true && quantite != "")
            {
                //REQUETE SQL
                cmd.CommandText = "SELECT idRapportOff, idMedicamentOff, quantiteOff FROM offrir " +
                                "INNER JOIN medicament ON medicament.idMedicament = offrir.idMedicamentOff " +
                                "WHERE idRapportOff = '" + codeRapport + "' AND nomCommercialMedicament = '" + nomMedicament + "' AND quantiteOff = '" + quantite + "' ";
            }

            //EXECUTE LA REQUETE
            MySqlDataReader drr = cmd.ExecuteReader();

            while (drr.Read())
            {
                //ON RECUPERE LES VARIABLES
                idRapport = int.Parse(drr.GetString(0));// 0 correspond à idRapportOff
                idMedicament = int.Parse(drr.GetString(1)); // 1 correspond à dateRap
                quantiteOffert = int.Parse(drr.GetString(2)); // 2 correspond à motifRap

                // On récupère la liste des médicaments avec la méthode chargerLeMedicaments
                ClasseMedicament leMedicament = ClassePMedicament.chargerLeMedicament(idMedicament);

                // On récupére le rapport avec l'id
                //ClasseRapport leRapport = ClassePRapport.chargerLeRapports(idRapport);

                // Instancie un échantillon 
                ClasseEchantillonOffert lEchantillons = new ClasseEchantillonOffert(quantiteOffert, leMedicament, idRapport);

                // On ajoute à la liste
                lesEchantillons.Add(lEchantillons);
            }

            drr.Close();
            connexion.Close();

            return lesEchantillons; //retoune la liste des echantillons 
        }

        #endregion

    }
}
