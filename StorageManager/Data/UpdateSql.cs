using Microsoft.SqlServer.Server;
using Microsoft.VisualBasic.Logging;
using StorageManager.Enumirations;
using StorageManager.TaskManager;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageManager.Data
{
    class UpdateSql
    {
        const string connectionString = @"Data Source=DESKTOP-A9QI9P7\MSSQLSERVER01;Initial Catalog=Storage;Integrated Security=True";
        public void Add_login_password(string login, string password)
        {
            //List<string> result = new List<string>();
            string expressionString =
                String.Format($"INSERT INTO Users (Login, Password) VALUES('{login}','{password}')");
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
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
                connection.Close();
            }
        }

        public bool DoesExist_Login(string login)
        {
            DB_plug_user doesExist = new DB_plug_user();

            for (int i = 0; i < doesExist.login.Count; i++)
            {
                if (doesExist.login[i] == login)
                {
                    return true;
                }
            }
            return false;
        }

        public void Remove_login_password(string login)
        {
            //List<string> result = new List<string>();
            string expressionString =
                //String.Format($"INSERT INTO Users (Login, Password) VALUES('{login}','{encrypt.EncryptText(password)}')");
                String.Format($"DELETE FROM Users WHERE login = '{login}'");
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

        public void AddTask(Task_ inputData)
        {
            int taskType;
            if (inputData.TaskType == TaskType.relocation) taskType = 0;
            if (inputData.TaskType == TaskType.remove) taskType = 2;
            if (inputData.TaskType == TaskType.sell) taskType = 1;
            string expressionString =
                String.
                Format($"INSERT INTO Tasks (TaskOwner, TaskPerformer, TaskType) VALUES('{inputData.TaskOwner}','{inputData.TaskPerformer}','{(int)inputData.TaskType}')");
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

        public void RemoveTask(Task_ inputData)
        {
            string expressionString =
                String.Format($"DELETE FROM Tasks WHERE taskOwner = '{inputData.TaskOwner}' AND taskPerformer = '{inputData.TaskPerformer}'");
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
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
                connection.Close();
            }
        }
        public void RemoveTask_ByPerformer(string taskPerformer)
        {
            string expressionString =
                String.Format($"DELETE FROM Tasks WHERE taskPerformer = '{taskPerformer}'");
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
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
                connection.Close();
            }
        }
        public void RemoveTask_ByPerformer(Task_ taskPerformer)
        {

        }

        public void RemoveTask_ByTaskType(TaskType taskType)
        {

        }
        public void RemoveTask_ByOwner(string taskOwner)
        {
            string expressionString =
                String.Format($"DELETE FROM Tasks WHERE taskOwner = '{taskOwner}'");
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
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
                connection.Close();
            }
        }
        public void RemoveTask_ByOwner(Task_ taskOwner)
        {

        }
    }
}
