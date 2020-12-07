using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ClasseMétiers;

namespace ClassePasserelle
{
    public class ClassePMedecin
    {
        public void modifierMedecin(int idMed ,string nomMed , string prenomMed , string adresseMed , int telMed , int idSpecialisteMed , int departementMed)
        {
            SqlConnection connexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            connexion.Open();

            cmd = connexion.CreateCommand();
            cmd.CommandText = "UPDATE medecin SET nomMed ='" + nomMed + "',prenomMed ";
        }
    }
}
