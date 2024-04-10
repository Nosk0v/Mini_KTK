using Mini_KTK.Model;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Mini_KTK.Repository
{
    public static class DbCommandSender
    {
        public static User SignIn(string username, string password)
        {
            NpgsqlCommand command = ApplicationDbContext.GetCommand("Select * FROM \"User\" WHERE username=@username AND password=@password");
            command.Parameters.AddWithValue("@username", NpgsqlDbType.Varchar, username);
            command.Parameters.AddWithValue("@password", NpgsqlDbType.Varchar, password);
            using (NpgsqlDataReader result = command.ExecuteReader())
            {
                try
                {
                    if (result.HasRows)
                    {
                        result.Read();

                        User user = new User
                        {
                            Id = result.GetInt32(result.GetOrdinal("Id")),
                            Surname = result.GetString(result.GetOrdinal("Surname")),
                            Name = result.GetString(result.GetOrdinal("Name")),
                            Patronymic = result.GetString(result.GetOrdinal("Patronymic")),
                            UserName = result.GetString(result.GetOrdinal("UserName")),
                            Password = result.GetString(result.GetOrdinal("Password")),
                            RoleId = result.GetInt32(result.GetOrdinal("RoleId"))
                        };

                        return user;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return null;
                }
            }
        }
    }
}
