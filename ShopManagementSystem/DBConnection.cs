using System;
using Microsoft.Data.SqlClient;

namespace ShopManagementSystem
{
    internal static class DBConnection
    {
        // Centralized connection string
        public static readonly string ConnectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=ShopManagementSystem;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        /// <summary>
        /// Returns a new instance of SqlConnection using the centralized connection string.
        /// </summary>
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
