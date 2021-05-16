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
        public static void AjoutMedicament(string unnomcomposition, string unecomposition, string deseffets, string unecontreindications, int lafamille)
        {
            //CONNEXION BDD
            MySqlConnection connexion = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            //REQUETE SQL
            cmd.CommandText = "INSERT INTO medicament (nomCommercialMedicament, idFamilleMedicament, compositionMedicament, effetsMedicament, contreIndicationsMedicament)" +
                              "VALUES('" + unnomcomposition + "', '" + lafamille + "', '" + unecomposition + "', '" + deseffets + "', '" + unecontreindications + "')";

            //EXECUTE LA REQUETE
            MySqlDataReader drr = cmd.ExecuteReader();
            drr.Close();
            connexion.Close();
        }
        #endregion

        #region UPDATE
        public static void ModifMedicament(int lid, string unnomcomposition, string unecomposition, string deseffets, string unecontreindications, int lafamille)
        {
            //CONNEXION BDD
            MySqlConnection connexion = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            //REQUETE SQL
            cmd.CommandText = "UPDATE medicament " +
                            "SET nomCommercialMedicament='" + unnomcomposition + "', idFamilleMedicament='" + lafamille + "', compositionMedicament='" + unecomposition + "', effetsMedicament='" + deseffets + "', contreIndicationsMedicament='" + unecontreindications + "' " +
                            "WHERE idMedicament= '" + lid + "'";

            //EXECUTE LA REQUETE
            MySqlDataReader drr = cmd.ExecuteReader();
            drr.Close();
            connexion.Close();
        }
        #endregion

        #region DELETE
        public static void SupprimerMedicament(int lid)
        {
            //CONNEXION BDD
            MySqlConnection connexion = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            //REQUETE SQL
            cmd.CommandText = "DELETE FROM medicament WHERE idMedicament = '"+ lid +"' ";
            //EXECUTION REQUETE
            MySqlDataReader drr = cmd.ExecuteReader();
            drr.Close();
            connexion.Close();
        }
        #endregion

        #region ChargerLeMedicament
        public static ClasseMedicament chargerLeMedicament(int idMedicament)
        {
            //VARIABLES
            ClasseMedicament LeMedicament = new ClasseMedicament();
            int id;
            string nomcomposition;
            string composition;
            string effets;
            string contreindications;
            int idfamille;
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
                id = drr.GetInt16(0);
                nomcomposition = drr.GetString(1);
                idfamille = drr.GetInt16(2);
                libFam = drr.GetString(3);
                composition = drr.GetString(4);
                effets = drr.GetString(5);
                contreindications = drr.GetString(6);

                //ON INSTANCIE UN OBJET CLASSEFAMILLE
                ClasseFamille laFamille = new ClasseFamille(idfamille, libFam);
                //ON INSTANCIE UN OBJET CLASSEMEDICAMENT
                LeMedicament = new ClasseMedicament(id, nomcomposition, composition, effets, contreindications, laFamille);
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
            int id;
            string nomcomposition;
            string composition;
            string effets;
            string contreindications;
            int idfamille;
            string libFam;

            //CONNEXION BDD
            MySqlConnection connexion = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            //REQUETE SQL
            cmd.CommandText = "SELECT DISTINCT idMedicament, nomCommercialMedicament, idFamilleMedicament, libFamille, compositionMedicament, effetsMedicament, contreIndicationsMedicament " +
                              "FROM medicament INNER JOIN famille ON famille.idFamille = medicament.idFamilleMedicament WHERE medicament.idFamilleMedicament = famille.idFamille";
            //EXECUTION REQUETE 
            MySqlDataReader drr = cmd.ExecuteReader();

            //LECTURE REQUETE
            while (drr.Read())
            {
                //ON RECUPERE LES VARIABLES
                id = int.Parse(drr.GetString(0));
                nomcomposition = drr.GetString(1);
                idfamille = int.Parse(drr.GetString(2));
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

        #region recuperer id medicament
        public static int recupererIdMedicament(string nomMedicament)
        {
            int idMedicament = 0;

            //CONNEXION BDD
            MySqlConnection connexion = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            //REQUETE SQL
            cmd.CommandText = "SELECT idMedicament " +
                            "FROM medicament " +
                            "WHERE nomCommercialMedicament = '" + nomMedicament + "' ";

            //EXECUTE LA REQUETE
            MySqlDataReader drr = cmd.ExecuteReader();

            if (drr.Read())
            {
                //ON RECUPERE LES VARIABLES
                idMedicament = drr.GetInt16(0);
            }
            drr.Close();
            connexion.Close();

            return idMedicament;
        }
        #endregion

        #region recuperer id famille
        public static int recupererIdFamille(string libelleFamille)
        {
            int idFamille = 0;
            //CONNEXION BDD
            MySqlConnection connexion = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            //REQUETE SQL
            cmd.CommandText = "SELECT idFamille " +
                            "FROM famille " +
                            "WHERE libFamille = '" + libelleFamille + "'";

            //EXECUTE LA REQUETE
            MySqlDataReader drr = cmd.ExecuteReader();

            if (drr.Read())
            {
                //ON RECUPERE LES VARIABLES
                idFamille = drr.GetInt16(0);
            }

            drr.Close();           
            connexion.Close();

            return idFamille;
        }
        #endregion

        #region ChargerLeNom
        public static List<ClasseMedicament> chargerLeNom(string Nom)
        {
            //VARIABLES
            List<ClasseMedicament> LesMedicaments = new List<ClasseMedicament>();
            int id;
            string nom;
            string composition;
            string effets;
            string contreindications;
            int idfamille;
            string libFam;


            //CONNEXION BDD
            MySqlConnection connexion = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            //REQUETE SQL
            cmd.CommandText = "SELECT idMedicament, nomCommercialMedicament, idFamilleMedicament, libFamille, compositionMedicament, effetsMedicament, contreIndicationsMedicament " +
                              "FROM medicament INNER JOIN famille " +
                              "ON famille.idFamille = medicament.idFamilleMedicament " +
                              "WHERE nomCommercialMedicament = '" + Nom + "'";
            //EXECUTION REQUETE
            MySqlDataReader drr = cmd.ExecuteReader();

            //LECTURE REQUETE
            while (drr.Read())
            {
                //ON RECUPERE LES VARIABLES
                id = int.Parse(drr.GetString(0));
                nom = drr.GetString(1);
                idfamille = int.Parse(drr.GetString(2));
                libFam = drr.GetString(3);
                composition = drr.GetString(4);
                effets = drr.GetString(5);
                contreindications = drr.GetString(6);

                //ON INSTANCIE UN OBJET CLASSEFAMILLE
                ClasseFamille laFamille = new ClasseFamille(idfamille, libFam);
                //ON INSTANCIE UN OBJET CLASSEMEDICAMENT
                ClasseMedicament leMedicament = new ClasseMedicament(id, nom, composition, effets, contreindications, laFamille);
                //ON AJOUTE UN OBJET CLASSEMEDICAMENT DANS UNE LISTE CLASSEMEDICAMENT
                LesMedicaments.Add(leMedicament);
            }

            drr.Close();
            connexion.Close();

            return LesMedicaments;
        }
        #endregion

        #region ChargerLaFamille
        public static List<ClasseMedicament> chargerLaFamille(string Famille)
        {
            //VARIABLES
            List<ClasseMedicament> LesMedicaments = new List<ClasseMedicament>();
            int id;
            string Nom;
            string composition;
            string effets;
            string contreindications;
            int idfamille;
            string libFam;


            //CONNEXION BDD
            MySqlConnection connexion = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            //REQUETE SQL
            cmd.CommandText = "SELECT idMedicament, nomCommercialMedicament, idFamilleMedicament, libFamille, compositionMedicament, effetsMedicament, contreIndicationsMedicament " +
                              "FROM medicament INNER JOIN famille " +
                              "ON famille.idFamille = medicament.idFamilleMedicament " +
                              "WHERE libFamille = '" + Famille + "'";
            //EXECUTION REQUETE
            MySqlDataReader drr = cmd.ExecuteReader();

            //LECTURE REQUETE
            while (drr.Read())
            {
                //ON RECUPERE LES VARIABLES
                id = int.Parse(drr.GetString(0));
                Nom = drr.GetString(1);
                idfamille = int.Parse(drr.GetString(2));
                libFam = drr.GetString(3);
                composition = drr.GetString(4);
                effets = drr.GetString(5);
                contreindications = drr.GetString(6);

                //ON INSTANCIE UN OBJET CLASSEFAMILLE
                ClasseFamille laFamille = new ClasseFamille(idfamille, libFam);
                //ON INSTANCIE UN OBJET CLASSEMEDICAMENT
                ClasseMedicament leMedicament = new ClasseMedicament(id, Nom, composition, effets, contreindications, laFamille);
                //ON AJOUTE UN OBJET CLASSEMEDICAMENT DANS UNE LISTE CLASSEMEDICAMENT
                LesMedicaments.Add(leMedicament);


            }

            drr.Close();
            connexion.Close();

            return LesMedicaments;
        }
        #endregion

        #region ChargerLaComposition
        public static List<ClasseMedicament> chargerLaComposition(string Compo)
        {
            //VARIABLES
            List<ClasseMedicament> LesMedicaments = new List<ClasseMedicament>();
            int id;
            string Nom;
            string composition;
            string effets;
            string contreindications;
            int idfamille;
            string libFam;


            //CONNEXION BDD
            MySqlConnection connexion = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            //REQUETE SQL
            cmd.CommandText = "SELECT idMedicament, nomCommercialMedicament, idFamilleMedicament, libFamille, compositionMedicament, effetsMedicament, contreIndicationsMedicament " +
                              "FROM medicament INNER JOIN famille " +
                              "ON famille.idFamille = medicament.idFamilleMedicament " +
                              "WHERE compositionMedicament = '" + Compo + "'";
            //EXECUTION REQUETE
            MySqlDataReader drr = cmd.ExecuteReader();

            //LECTURE REQUETE
            while (drr.Read())
            {
                //ON RECUPERE LES VARIABLES
                id = int.Parse(drr.GetString(0));
                Nom = drr.GetString(1);
                idfamille = int.Parse(drr.GetString(2));
                libFam = drr.GetString(3);
                composition = drr.GetString(4);
                effets = drr.GetString(5);
                contreindications = drr.GetString(6);

                //ON INSTANCIE UN OBJET CLASSEFAMILLE
                ClasseFamille laFamille = new ClasseFamille(idfamille, libFam);
                //ON INSTANCIE UN OBJET CLASSEMEDICAMENT
                ClasseMedicament leMedicament = new ClasseMedicament(id, Nom, composition, effets, contreindications, laFamille);
                //ON AJOUTE UN OBJET CLASSEMEDICAMENT DANS UNE LISTE CLASSEMEDICAMENT
                LesMedicaments.Add(leMedicament);


            }

            drr.Close();
            connexion.Close();

            return LesMedicaments;
        }
        #endregion
        
        #region ChargerLEffet
        public static List<ClasseMedicament> chargerLEffet(string Effet)
        {
            //VARIABLES
            List<ClasseMedicament> LesMedicaments = new List<ClasseMedicament>();
            int id;
            string Nom;
            string composition;
            string effets;
            string contreindications;
            int idfamille;
            string libFam;


            //CONNEXION BDD
            MySqlConnection connexion = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            //REQUETE SQL
            cmd.CommandText = "SELECT idMedicament, nomCommercialMedicament, idFamilleMedicament, libFamille, compositionMedicament, effetsMedicament, contreIndicationsMedicament " +
                              "FROM medicament INNER JOIN famille " +
                              "ON famille.idFamille = medicament.idFamilleMedicament " +
                              "WHERE effetsMedicament = '" + Effet + "'";
            //EXECUTION REQUETE
            MySqlDataReader drr = cmd.ExecuteReader();

            //LECTURE REQUETE
            while (drr.Read())
            {
                //ON RECUPERE LES VARIABLES
                id = int.Parse(drr.GetString(0));
                Nom = drr.GetString(1);
                idfamille = int.Parse(drr.GetString(2));
                libFam = drr.GetString(3);
                composition = drr.GetString(4);
                effets = drr.GetString(5);
                contreindications = drr.GetString(6);

                //ON INSTANCIE UN OBJET CLASSEFAMILLE
                ClasseFamille laFamille = new ClasseFamille(idfamille, libFam);
                //ON INSTANCIE UN OBJET CLASSEMEDICAMENT
                ClasseMedicament leMedicament = new ClasseMedicament(id, Nom, composition, effets, contreindications, laFamille);
                //ON AJOUTE UN OBJET CLASSEMEDICAMENT DANS UNE LISTE CLASSEMEDICAMENT
                LesMedicaments.Add(leMedicament);


            }

            drr.Close();
            connexion.Close();

            return LesMedicaments;
        }
        #endregion

        #region ChargerLaCI
        public static List<ClasseMedicament> chargerLaCI(string CI)
        {
            //VARIABLES
            List<ClasseMedicament> LesMedicaments = new List<ClasseMedicament>();
            int id;
            string Nom;
            string composition;
            string effets;
            string contreindications;
            int idfamille;
            string libFam;


            //CONNEXION BDD
            MySqlConnection connexion = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            //REQUETE SQL
            cmd.CommandText = "SELECT idMedicament, nomCommercialMedicament, idFamilleMedicament, libFamille, compositionMedicament, effetsMedicament, contreIndicationsMedicament " +
                              "FROM medicament INNER JOIN famille " +
                              "ON famille.idFamille = medicament.idFamilleMedicament " +
                              "WHERE contreIndicationsMedicament = '" + CI + "'";
            //EXECUTION REQUETE
            MySqlDataReader drr = cmd.ExecuteReader();

            //LECTURE REQUETE
            while (drr.Read())
            {
                //ON RECUPERE LES VARIABLES
                id = int.Parse(drr.GetString(0));
                Nom = drr.GetString(1);
                idfamille = int.Parse(drr.GetString(2));
                libFam = drr.GetString(3);
                composition = drr.GetString(4);
                effets = drr.GetString(5);
                contreindications = drr.GetString(6);

                //ON INSTANCIE UN OBJET CLASSEFAMILLE
                ClasseFamille laFamille = new ClasseFamille(idfamille, libFam);
                //ON INSTANCIE UN OBJET CLASSEMEDICAMENT
                ClasseMedicament leMedicament = new ClasseMedicament(id, Nom, composition, effets, contreindications, laFamille);
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
