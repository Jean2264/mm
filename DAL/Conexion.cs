using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_9.DAL
{
    public static class Conexion
    {
       public static void Conectar()
        {
            Decla.ConnectionString = @"Data Source=localhost;Initial Catalog=Escuela;Trusted_Connection=True;TrustServerCertificate=True;";
            Decla.cnn = new SqlConnection(Decla.ConnectionString);
        }
    }
}
