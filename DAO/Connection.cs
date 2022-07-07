using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Orders.API.DAO
{
    public class Connection
    {
        string configurationBuilder = new ConfigurationBuilder()
            .AddJsonFile(Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json"), false)
            .Build().GetSection("ConnectionStrings:Production").Value;
        public SqlConnection AbrirConection()
        {
            SqlConnection conection = new SqlConnection(configurationBuilder);
            if (conection.State == ConnectionState.Closed)
                conection.Open();
            return conection;
        }
        public SqlConnection CerrarConection()
        {
            SqlConnection conection = new SqlConnection(configurationBuilder);
            if (conection.State == ConnectionState.Open)
                conection.Close();
            return conection;
        }
    }
}