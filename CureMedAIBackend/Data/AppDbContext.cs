using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace CureMedAI.CureMedAIBackend.Data
{
    internal class AppDbContext
    {
        private static string connectionString = @"Data Source=C:\Users\k\Desktop\CureMedAI_DB\CureMedAI_Database.db;";

        public static SqliteConnection getConnection()
        {
            var connection = new SqliteConnection(connectionString);

            try
            {
                connection.Open();
                Console.WriteLine("SQLite connection opened successfully");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Connection error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Attempt to open SQLite connection done.");
            }

            return connection;
        }
    }
}
