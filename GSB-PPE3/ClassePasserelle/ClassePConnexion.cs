﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ClassePasserelle
{
    class ClassePConnexion
    {
        public static string DBConnection()
        {
<<<<<<< HEAD
            string connectionString = "SERVER=localhost; DATABASE=gsbppe3;UID = root; PASSWORD = root";
=======
            string connectionString = "datasource=localhost; DATABASE=gsbppe3;UID = root; PASSWORD = ";
>>>>>>> Math
            
            return (connectionString);
        }

    }
}
