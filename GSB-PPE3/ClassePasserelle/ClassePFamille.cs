using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasseMétiers;

namespace ClassePasserelle
{
    public class ClassePFamille
    {
        public static List<ClasseFamille> chargerLesFamilles()
        {
            List<ClasseFamille> lesFamille = new List<ClasseFamille>();
            string id_famille;
            string libelle;

            SqlConnection connexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            cmd.CommandText = "SELECT * FROM famille";
            SqlDataReader drr = cmd.ExecuteReader();

            while (drr.Read())
            {
                id_famille = drr.GetString(0);
                libelle = drr.GetString(1);
                ClasseFamille laFamille = new ClasseFamille(id_famille, libelle);
                lesFamille.Add(laFamille);
            }

            drr.Close();
            connexion.Close();

            return lesFamille;
        }
    }
}
