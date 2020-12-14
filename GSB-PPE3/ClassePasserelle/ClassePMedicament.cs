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
        public static void AjoutMedicament()
        {
        }
        public static void ModifMedicament(string lid, string lenom, string leprenom, string ladresse, string lelogin, string lemdp, string lecp, string laville, DateTime ladateEmbauche)
        {
        }
        public static void SupprimerMedicament(string lid)
        {
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
