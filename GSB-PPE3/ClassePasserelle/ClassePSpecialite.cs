using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasseMétiers;
using MySql.Data.MySqlClient;

namespace ClassePasserelle
{
    public class ClassePSpecialite
    {
        public static List<ClasseSpecialite> chargerLesSpecialite()
        {
            List<ClasseSpecialite> lesSpecialite = new List<ClasseSpecialite>();
            int id;
            string specialite;

            MySqlConnection connexion = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            cmd.CommandText = "SELECT * FROM specialite";
            MySqlDataReader drr = cmd.ExecuteReader();

            while (drr.Read())
            {
                id = drr.GetInt16(0);
                specialite = drr.GetString(1);
                ClasseSpecialite laSpecialite = new ClasseSpecialite(id, specialite);
                lesSpecialite.Add(laSpecialite);
            }

            drr.Close();
            connexion.Close();

            return lesSpecialite;
        }

        public static int recupererIdSpe(string libelle)
        {
            int id = 0;

            MySqlConnection connexion = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            cmd.CommandText = "SELECT idSpec FROM specialite WHERE libSpec = '"+ libelle +"' ";
            MySqlDataReader drr = cmd.ExecuteReader();

            while (drr.Read())
            {
                id = drr.GetInt16(0);
            }

            drr.Close();
            connexion.Close();

            return id;
        }
    }
}
