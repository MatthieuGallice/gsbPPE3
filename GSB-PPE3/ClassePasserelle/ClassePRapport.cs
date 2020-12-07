using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ClasseMétiers;

namespace ClassePasserelle
{
    public class ClassePRapport
    {
        public static void modifRapport(int idRap, DateTime dateRap, string motifRap, string bilanRap, int idVisiteurRap, int idMedecinRAp)
        {
            SqlConnection connexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            cmd.CommandText = "UPDATE rapport SET dateRap = '"+ dateRap + "', motifRap = '" + motifRap + "', bilanRap = '" + bilanRap + "', idVisiteurRap = '" + idVisiteurRap + "', idMedecinRap = '" + idMedecinRAp + "' WHERE idRap = '" + idRap + "' ";
            SqlDataReader drr = cmd.ExecuteReader();
            drr.Close();
            connexion.Close();
        }

        public static void supprimerRapport(int idRap)
        {
            SqlConnection connexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            cmd.CommandText = "DELETE FROM 'rapport' WHERE idRap = '" + idRap + "' ";
            SqlDataReader drr = cmd.ExecuteReader();
            drr.Close();
            connexion.Close();
        }

        public static void ajoutRapport(int idRap, DateTime dateRap, string motifRap, string bilanRap, int idVisiteurRap, int idMedecinRAp)
        {
            SqlConnection connexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            connexion.ConnectionString = ClassePConnexion.DBConnection();

            connexion.Open();

            cmd = connexion.CreateCommand();
            cmd.CommandText = "DELETE FROM 'rapport' WHERE idRap = '" + idRap + "' ";
            SqlDataReader drr = cmd.ExecuteReader();
            drr.Close();
            connexion.Close();
        }

    }
}
