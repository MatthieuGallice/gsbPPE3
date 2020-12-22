using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ClassePasserelle
{
    public class ClassePConnexion
    {
        public static string DBConnection()
        {
            string connectionString = " SERVER ='localhost' ; DATABASE ='gsbppe3' ; UID ='root' ; PASSWORD ='root' ;";
            return (connectionString);
        }

    }
}
