using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasseMétiers;
using MySql.Data.MySqlClient;

namespace ClassePasserelle
{
    public class ClassePFamille
    {
        public static List<ClasseFamille> chargerLesFamilles()
        {
            List<ClasseFamille> lesFamille = new List<ClasseFamille>();
            int id_famille;
            string libelle;

            MySqlConnection connexion = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            cmd.CommandText = "SELECT * FROM famille";
            MySqlDataReader drr = cmd.ExecuteReader();

            while (drr.Read())
            {
                id_famille = int.Parse(drr.GetString(0));
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
