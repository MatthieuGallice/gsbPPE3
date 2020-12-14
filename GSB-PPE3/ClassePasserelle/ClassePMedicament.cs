using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ClasseMétiers;

namespace ClassePasserelle
{
    public class ClassePMedicament
    {
        public static void AjoutMedicament(string unnomcomposition, string unecomposition, string deseffets, string unecontreindications, ClasseFamille lafamille)
        {
            SqlConnection connexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            cmd.CommandText = "INSERT INTO medicament (`idMedicament`, `nomCommercialMedicament`, `idFamilleMedicament`, `compositionMedicament`, `effetsMedicament`, `contreIndicationsMedicament`)" +
                              "VALUES('"+ unnomcomposition +"', '"+ unecomposition + "', '"+ lafamille +"', '" + deseffets +"', '"+ unecontreindications +"')";
            SqlDataReader drr = cmd.ExecuteReader();
            drr.Close();
            connexion.Close();
        }
        public static void ModifMedicament(string lid, string unnomcomposition, string unecomposition, string deseffets, string unecontreindications, ClasseFamille lafamille)
        {
            SqlConnection connexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            cmd.CommandText = "UPDATE medicament " +
                              "SET  nomCommercialMedicament  = '" + unnomcomposition + "', idFamilleMedicament  = '" + lafamille + "', compositionMedicament  = '" + unecomposition + "',  effetsMedicament  = '" + deseffets + "', contreIndicationsMedicament  = '" + unecontreindications + "'," +
                              "WHERE `medicament.idMedicament = '"+ lid +"'; ";
            SqlDataReader drr = cmd.ExecuteReader();
            drr.Close();
            connexion.Close();
        }
        public static void SupprimerMedicament(string lid)
        {
            SqlConnection connexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            cmd.CommandText = "DELETE FROM medicament WHERE medicament.idMedicament = '"+ lid +"' ";
            SqlDataReader drr = cmd.ExecuteReader();
            drr.Close();
            connexion.Close();
        }
        public static List<ClasseMedicament> chargerLesMedicaments()
        {
            List<ClasseMedicament> LesMedicaments = new List<ClasseMedicament>();
            string id;
            string nomcomposition;
            string composition;
            string effets;
            string contreindications;
            string idfamille;
            string libFam;

            SqlConnection connexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            cmd.CommandText = "SELECT idMedicament, nomCommercialMedicament, idFamilleMedicament, libFamille, compositionMedicament, effetsMedicament, contreIndicationsMedicament " +
                              "FROM medicament INNER JOIN famille ON idFamilleMedicament";
            SqlDataReader drr = cmd.ExecuteReader();

            while (drr.Read())
            {
                id = drr.GetString(0);
                nomcomposition = drr.GetString(1);
                idfamille = drr.GetString(2);
                libFam = drr.GetString(3);
                composition = drr.GetString(4);
                effets = drr.GetString(5);
                contreindications = drr.GetString(6);
                ClasseFamille laFamille = new ClasseFamille(idfamille, libFam);
                ClasseMedicament leMedicament = new ClasseMedicament(id, nomcomposition, composition, effets, contreindications, laFamille);
                LesMedicaments.Add(leMedicament);
            }

            drr.Close();
            connexion.Close();

            return LesMedicaments;
        }
    }
}
