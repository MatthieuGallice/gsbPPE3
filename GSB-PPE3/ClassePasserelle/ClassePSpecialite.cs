using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasseMétiers;
using System.Data.SqlClient;

namespace ClassePasserelle
{
    public class ClassePSpecialite
    {
        public static List<ClasseSpecialite> chargerLesSpecialite()
        {
            List<ClasseSpecialite> lesSpecialite = new List<ClasseSpecialite>();
            string id;
            string specialite;

            SqlConnection connexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            cmd.CommandText = "SELECT * FROM specialite";
            SqlDataReader drr = cmd.ExecuteReader();

            while (drr.Read())
            {
                id = drr.GetString(0);
                specialite = drr.GetString(1);
                ClasseSpecialite laSpecialite = new ClasseSpecialite(id, specialite);
                lesSpecialite.Add(laSpecialite);
            }

            drr.Close();
            connexion.Close();

            return lesSpecialite;
        }
    }
}
