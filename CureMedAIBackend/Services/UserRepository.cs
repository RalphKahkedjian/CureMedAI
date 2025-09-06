using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CureMedAI.CureMedAIBackend.Data;
using Microsoft.Data.Sqlite;

namespace CureMedAI.CureMedAIBackend.Services
{
    internal class UserRepository
    {
        public void addUser(string name, string email, string password, int age, string role )
        {
            using var conn = AppDbContext.getConnection();

            string insertUser = @"INSERT INTO Users (Name, email, password, age, role)
                                VALUES(@Name, @Email, @Password, @Age, @Role)";

            using var cmd = new SqliteCommand(insertUser, conn);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.Parameters.AddWithValue("@Age", age);
            cmd.Parameters.AddWithValue("@Role", role);

            cmd.ExecuteNonQuery();
        }
    }
}
