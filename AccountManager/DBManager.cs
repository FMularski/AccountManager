using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace AccountManager
{
    class DBManager
    {
        private static SQLiteConnection Connection = new SQLiteConnection("Data Source=accman.db");

        public static void AddUser(params string[] values)
        {
            Connection.Open();

            using (SQLiteCommand command = Connection.CreateCommand())
            {
                string login = values[0];
                string email = values[1];
                string password = values[2];
                string pin = values[3];

                command.CommandText = "INSERT INTO USERS ('Login', 'Email', 'Password', 'Pin')" + 
                    "VALUES (@login, @email, @password, @pin)";
                command.Parameters.Add(new SQLiteParameter("@login") { Value = login });
                command.Parameters.Add(new SQLiteParameter("@email") { Value = email });
                command.Parameters.Add(new SQLiteParameter("@password") { Value = password });
                command.Parameters.Add(new SQLiteParameter("@pin") { Value = pin });
                command.ExecuteNonQuery();
            }

            Connection.Close();
        }

        public static List<string> GetUsers(TextBox t)
        {
            Connection.Open();
            List<string> users = new List<string>();

            using (SQLiteCommand command = Connection.CreateCommand())
            {
                command.CommandText = "SELECT Login FROM Users";
                command.CommandType = System.Data.CommandType.Text;
                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                    users.Add(reader["Login"].ToString());
            }

            Connection.Close();
            return users;
        }
    }
}
