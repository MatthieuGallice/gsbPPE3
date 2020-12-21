using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ClasseMétiers;

namespace ClassePasserelle
{
    public class ClassePMedicament
    {
        #region INSERT 
        public static void AjoutMedicament(string unnomcomposition, string unecomposition, string deseffets, string unecontreindications, ClasseFamille lafamille)
        {
            //CONNEXION BDD
            MySqlConnection connexion = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            //REQUETE SQL
            cmd.CommandText = "INSERT INTO medicament (`idMedicament`, `nomCommercialMedicament`, `idFamilleMedicament`, `compositionMedicament`, `effetsMedicament`, `contreIndicationsMedicament`)" +
                              "VALUES('"+ unnomcomposition +"', '"+ unecomposition + "', '"+ lafamille +"', '" + deseffets +"', '"+ unecontreindications +"')";
            //EXECUTE LA REQUETE
            MySqlDataReader drr = cmd.ExecuteReader();
            drr.Close();
            connexion.Close();
        }
        #endregion

        #region UPDATE
        public static void ModifMedicament(string lid, string unnomcomposition, string unecomposition, string deseffets, string unecontreindications, ClasseFamille lafamille)
        {
            //CONNEXION BDD
            MySqlConnection connexion = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            //REQUETE SQL
            cmd.CommandText = "UPDATE medicament " +
                              "SET  nomCommercialMedicament  = '" + unnomcomposition + "', idFamilleMedicament  = '" + lafamille + "', compositionMedicament  = '" + unecomposition + "',  effetsMedicament  = '" + deseffets + "', contreIndicationsMedicament  = '" + unecontreindications + "'," +
                              "WHERE `medicament.idMedicament = '"+ lid +"'; ";
            //EXECUTE LA REQUETE
            MySqlDataReader drr = cmd.ExecuteReader();
            drr.Close();
            connexion.Close();
        }
        #endregion

        #region DELETE
        public static void SupprimerMedicament(string lid)
        {
            //CONNEXION BDD
            MySqlConnection connexion = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            //REQUETE SQL
            cmd.CommandText = "DELETE FROM medicament WHERE medicament.idMedicament = '"+ lid +"' ";
            //EXECUTION REQUETE
            MySqlDataReader drr = cmd.ExecuteReader();
            drr.Close();
            connexion.Close();
        }
        #endregion

        #region ChargerLeMedicament
        public static ClasseMedicament chargerLeMedicament(string idMedicament)
        {
            //VARIABLES
            ClasseMedicament LeMedicament = new ClasseMedicament();
            string id;
            string nomcomposition;
            string composition;
            string effets;
            string contreindications;
            string idfamille;
            string libFam;

            //CONNEXION BDD
            MySqlConnection connexion = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            //REQUETE SQL
            cmd.CommandText = "SELECT idMedicament, nomCommercialMedicament, idFamilleMedicament, libFamille, compositionMedicament, effetsMedicament, contreIndicationsMedicament " +
                              "FROM medicament INNER JOIN famille ON idFamilleMedicament " +
                              "WHERE medicament.idFamilleMedicament = famille.idFamille && medicament.idMedicament = "+ idMedicament +"";
            //EXECUTION REQUETE 
            MySqlDataReader drr = cmd.ExecuteReader();

            //LECTURE REQUETE
            while (drr.Read())
            {
                //ON RECUPERE LES VARIABLES
                id = drr.GetString(0);
                nomcomposition = drr.GetString(1);
                idfamille = drr.GetString(2);
                libFam = drr.GetString(3);
                composition = drr.GetString(4);
                effets = drr.GetString(5);
                contreindications = drr.GetString(6);

                //ON INSTANCIE UN OBJET CLASSEFAMILLE
                ClasseFamille laFamille = new ClasseFamille(idfamille, libFam);
                //ON INSTANCIE UN OBJET CLASSEMEDICAMENT
                ClasseMedicament leMedicament = new ClasseMedicament(id, nomcomposition, composition, effets, contreindications, laFamille);
            }

            drr.Close();
            connexion.Close();

            return LeMedicament;
        }
        #endregion

        #region ChargerLesMedicaments
        public static List<ClasseMedicament> chargerLesMedicaments()
        {
            //VARIABLES
            List<ClasseMedicament> LesMedicaments = new List<ClasseMedicament>();
            string id;
            string nomcomposition;
            string composition;
            string effets;
            string contreindications;
            string idfamille;
            string libFam;

            //CONNEXION BDD
            MySqlConnection connexion = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            //REQUETE SQL
            cmd.CommandText = "SELECT DISTINCT idMedicament, nomCommercialMedicament, idFamilleMedicament, libFamille, compositionMedicament, effetsMedicament, contreIndicationsMedicament " +
                              "FROM medicament INNER JOIN famille ON idFamilleMedicament WHERE medicament.idFamilleMedicament = famille.idFamille";
            //EXECUTION REQUETE 
            MySqlDataReader drr = cmd.ExecuteReader();

            //LECTURE REQUETE
            while (drr.Read())
            {
                //ON RECUPERE LES VARIABLES
                id = drr.GetString(0);
                nomcomposition = drr.GetString(1);
                idfamille = drr.GetString(2);
                libFam = drr.GetString(3);
                composition = drr.GetString(4);
                effets = drr.GetString(5);
                contreindications = drr.GetString(6);

                //ON INSTANCIE UN OBJET CLASSEFAMILLE
                ClasseFamille laFamille = new ClasseFamille(idfamille, libFam);
                //ON INSTANCIE UN OBJET CLASSEMEDICAMENT
                ClasseMedicament leMedicament = new ClasseMedicament(id, nomcomposition, composition, effets, contreindications, laFamille);
                //ON AJOUTE UN OBJET CLASSEMEDICAMENT DANS UNE LISTE CLASSEMEDICAMENT
                LesMedicaments.Add(leMedicament);
            }

            drr.Close();
            connexion.Close();

            return LesMedicaments;
        }
        #endregion
    }
}
