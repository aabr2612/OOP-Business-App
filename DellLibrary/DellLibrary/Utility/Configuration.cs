﻿using System.Data.SqlClient;
namespace DellLibrary.Utility
{
    class Configuration
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection("Server=(local);Database=Dell;Trusted_Connection=True");
        }
    }
}