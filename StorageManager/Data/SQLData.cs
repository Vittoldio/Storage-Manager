using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace StorageManager.Data
{
    internal class SQLData
    {
        //change data source
        const string connectionString = @"Data Source=DESKTOP-A9QI9P7\MSSQLSERVER01;Initial Catalog=Storage;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
        public List<string> Get_id_login_password()
        {
            List<string> result = new List<string>();
            string expressionString = "SELECT * FROM Users";
            // Создание подключения
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(expressionString, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read()) // построчно считываем данные
                    {
                        object id = reader.GetValue(0);
                        object login = reader.GetValue(1);
                        object password = reader.GetValue(2);

                        result.Add((string)id.ToString());
                        result.Add((string)login);
                        result.Add((string)password);
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return result;
        }
        public List<string> Get_tasks()
        {
            List<string> result = new List<string>();
            string expressionString = "SELECT * FROM Tasks";
            try
            {
                connection.Open();
                Console.WriteLine("Подключение открыто");
                SqlCommand command = new SqlCommand(expressionString, connection);
                SqlDataReader reader = command.ExecuteReader();
                string param_taskType;
                if (reader.HasRows) 
                {
                    while (reader.Read()) // построчно считываем данные
                    {
                        object taskOwner = reader.GetValue(0);
                        object taskPerformer = reader.GetValue(1);
                        object taskType = reader.GetValue(2);

                        result.Add((string)taskOwner);
                        result.Add((string)taskPerformer);
                        if ( (int)taskType == 0)
                        {
                            result.Add("0");
                        } 
                        else if ((int)taskType == 1)
                        {
                            result.Add("1");
                        } 
                        else if ((int)taskType == 2)
                        {
                            result.Add("2");
                        }
                        else
                        {
                            result.Add("3");
                        }

                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // закрываем подключение
                connection.Close();
                Console.WriteLine("Подключение закрыто...");
            }
            Console.Read();
            return result;
        }
    }
}
