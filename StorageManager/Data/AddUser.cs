using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageManager.Data
{
    class AddUser
    {
        const string connectionString = @"Data Source=DESKTOP-A9QI9P7\MSSQLSERVER01;Initial Catalog=Storage;Integrated Security=True";
        public void Add_login_password(string login, string password)
        {
            //List<string> result = new List<string>();
            Encryption encrypt = new Encryption();
            string expressionString =
                //String.Format($"INSERT INTO Users (Login, Password) VALUES('{login}','{encrypt.EncryptText(password)}')");
                String.Format($"INSERT INTO Users (Login, Password) VALUES('{login}','{password}')");
            // Создание подключения
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                // Открываем подключение
                connection.Open();
                SqlCommand command = new SqlCommand(expressionString, connection);
                int number = command.ExecuteNonQuery();  
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // закрываем подключение
                connection.Close();
            }
        }
    }
}
