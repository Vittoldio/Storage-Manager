using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageManager
{
    /*
     *  Заглушка от которой в теорий мы получаем данные.
     * реализовать подгон данных из дб
     * 
     */
    class DB_plug_user
    {
        private string? login;
        string Login { get; set; }
        private string? password;
        string Password { get; set; }
        public DB_plug_user(string login, string password) { 
            this.Login = login;
            this.Password = password;
        }

        public string GetPassword()
        {
            return this.Password;
        }
        public string GetLogin()
        {
            return this.Login;
        }
    }
}
