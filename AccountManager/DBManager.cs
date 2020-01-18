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

        public static List<string> GetColumnValues(string table, string column)
        {
            List<string> values = new List<string>();

            Connection.Open();
            
            using (SQLiteCommand command = Connection.CreateCommand())
            {
                command.CommandText = "SELECT " + column + " FROM " + table;
                command.CommandType = System.Data.CommandType.Text;
                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                    values.Add(reader[column].ToString());
            }

            Connection.Close();
            
            return values;
        }

        public static string GetSingleValueWhere(string table, string column, string whereColumn, string value)
        {
            Connection.Open();

            SQLiteDataReader reader = null;
            List<string> val = new List<string>();

            using(SQLiteCommand command = Connection.CreateCommand())
            {
                command.CommandText = "SELECT " + column + " FROM " + table + " WHERE " + whereColumn + " = @value";
                command.Parameters.Add(new SQLiteParameter("@value") { Value = value });
                command.CommandType = System.Data.CommandType.Text;
                reader = command.ExecuteReader();

                while (reader.Read())
                    val.Add(reader[column].ToString());
            }

            Connection.Close();
            return val.First();
        }

        public static void UpdateValueWhere(string table, string column, string newValue, string whereColumn, string whereValue)
        {
            Connection.Open();

            using (SQLiteCommand command = Connection.CreateCommand())
            {
                command.CommandText = "UPDATE " + table + " SET " + column + " = @newvalue WHERE " + whereColumn + " = @value";
                command.Parameters.Add(new SQLiteParameter("@newvalue") { Value = newValue });
                command.Parameters.Add(new SQLiteParameter("@value") { Value = whereValue });
                command.ExecuteNonQuery();
            }

            Connection.Close();
            
        }


    }
}
