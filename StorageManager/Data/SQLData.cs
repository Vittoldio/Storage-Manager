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
        const string connectionString = @"Data Source=HOME-PC;Initial Catalog=Storage;Integrated Security=True";
        public List<string> Get_id_login_password()
        {
            List<string> result = new List<string>();
            string expressionString = "SELECT * FROM Users";
            // Создание подключения
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                // Открываем подключение
                connection.Open();
                Console.WriteLine("Подключение открыто");
                SqlCommand command = new SqlCommand(expressionString, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) // если есть данные
                {
                    // выводим названия столбцов
                    while (reader.Read()) // построчно считываем данные
                    {
                        object id = reader.GetValue(0);
                        object login = reader.GetValue(1);
                        object password = reader.GetValue(2);
                        /*
                         * ЗДЕСЬ надо решить проблему со стрингами,
                         * потому что в таблице базы пользователей нужен ещё и ID
                         * а добавляется в столбец login пароль почемута
                        */
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
                // закрываем подключение
                connection.Close();
                Console.WriteLine("Подключение закрыто...");
            }
            Console.Read();
            return result;
        }
        public List<string> Get_tasks()
        {
            List<string> result = new List<string>();
            string expressionString = "SELECT * FROM Tasks";
            // Создание подключения
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                // Открываем подключение
                connection.Open();
                Console.WriteLine("Подключение открыто");
                SqlCommand command = new SqlCommand(expressionString, connection);
                SqlDataReader reader = command.ExecuteReader();

                string param_taskType;
                if (reader.HasRows) // если есть данные
                {
                    // выводим названия столбцов
                    while (reader.Read()) // построчно считываем данные
                    {
                        object taskOwner = reader.GetValue(0);
                        object taskPerformer = reader.GetValue(1);
                        object taskType = reader.GetValue(2);

                        result.Add((string)taskOwner);
                        result.Add((string)taskPerformer);
                        if ((int)taskType == 1 || (int)taskType == 0)
                        {
                            result.Add("1");
                        } 
                        else if ((int)taskType == 2)
                        {
                            result.Add("2");
                        } 
                        else if ((int)taskType == 3)
                        {
                            result.Add("3");
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
